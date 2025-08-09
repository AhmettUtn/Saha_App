using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;
using System.Text;
using Web_Api.Models;

public class AuthAttribute : ActionFilterAttribute
{ 

    

    public override void OnActionExecuting(ActionExecutingContext context)
    {
        var authKey = context.HttpContext.Request.Headers["auth_key"].FirstOrDefault();

        if (string.IsNullOrEmpty(authKey) || !IsValidAuthKey(authKey))
        {
            context.Result = new UnauthorizedResult();
        }

        base.OnActionExecuting(context);
    }

    private bool IsValidAuthKey(string authKey)
    { 
        var decodedKey = Encoding.UTF8.GetString(Convert.FromBase64String(authKey));
        var userData = decodedKey.Split('_');

        var _erpdbContext = new reina_erpdbContext();
        var user = _erpdbContext.Users.FirstOrDefault(x => x.Id == Convert.ToUInt64(userData[0]) && x.Email == userData[1]);

        return user != null;
    }
}
