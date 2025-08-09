using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;
using Web_Api.Models;
using Web_Api.ViewModels;

namespace Web_Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : ControllerBase
    {

        private readonly reina_erpdbContext _erpdbContext;
        private readonly ILogger<UserController> _logger;
        public UserController(ILogger<UserController> logger, reina_erpdbContext erpdbContext)
        {
            _logger = logger;
            _erpdbContext = erpdbContext;
        }


        [HttpGet]
        [Auth]
        public IEnumerable<User> list()
        {
            return _erpdbContext.Users.ToArray();
        }

        [HttpPost]
        public ActionResult<LoginResponse> Login(string email, string password)
        {
            var user = _erpdbContext.Users.SingleOrDefault(u => u.Email == email);

            if (user == null || !VerifyPassword(password, user.Password))
            {
                return Unauthorized("Invalid login credentials");
            }

            var authKey = GenerateAuthKey(user); // Auth Key oluşturuluyor
            var response = new LoginResponse
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                AuthKey = authKey
            };

            return Ok(response);
        }


        private string GenerateAuthKey(User user)
        {
            var keyData = $"{user.Id}_{user.Email}";
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(keyData));
        }

        private bool VerifyPassword(string enteredPassword, string storedHashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(enteredPassword, storedHashedPassword);
        }
    }
}
