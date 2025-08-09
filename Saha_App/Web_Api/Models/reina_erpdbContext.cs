using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Web_Api.Models
{
    public partial class reina_erpdbContext : DbContext
    {
        public reina_erpdbContext()
        {
        }

        public reina_erpdbContext(DbContextOptions<reina_erpdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActivityLog> ActivityLogs { get; set; } = null!;
        public virtual DbSet<AdminPaymentSetting> AdminPaymentSettings { get; set; } = null!;
        public virtual DbSet<Allowance> Allowances { get; set; } = null!;
        public virtual DbSet<AllowanceOption> AllowanceOptions { get; set; } = null!;
        public virtual DbSet<Announcement> Announcements { get; set; } = null!;
        public virtual DbSet<AnnouncementEmployee> AnnouncementEmployees { get; set; } = null!;
        public virtual DbSet<Appraisal> Appraisals { get; set; } = null!;
        public virtual DbSet<Asset> Assets { get; set; } = null!;
        public virtual DbSet<AttendanceEmployee> AttendanceEmployees { get; set; } = null!;
        public virtual DbSet<Award> Awards { get; set; } = null!;
        public virtual DbSet<AwardType> AwardTypes { get; set; } = null!;
        public virtual DbSet<BankAccount> BankAccounts { get; set; } = null!;
        public virtual DbSet<BankTransfer> BankTransfers { get; set; } = null!;
        public virtual DbSet<Bill> Bills { get; set; } = null!;
        public virtual DbSet<BillPayment> BillPayments { get; set; } = null!;
        public virtual DbSet<BillProduct> BillProducts { get; set; } = null!;
        public virtual DbSet<Branch> Branches { get; set; } = null!;
        public virtual DbSet<Budget> Budgets { get; set; } = null!;
        public virtual DbSet<Bug> Bugs { get; set; } = null!;
        public virtual DbSet<BugComment> BugComments { get; set; } = null!;
        public virtual DbSet<BugFile> BugFiles { get; set; } = null!;
        public virtual DbSet<BugStatus> BugStatuses { get; set; } = null!;
        public virtual DbSet<ChFavorite> ChFavorites { get; set; } = null!;
        public virtual DbSet<ChMessage> ChMessages { get; set; } = null!;
        public virtual DbSet<ChartOfAccount> ChartOfAccounts { get; set; } = null!;
        public virtual DbSet<ChartOfAccountSubType> ChartOfAccountSubTypes { get; set; } = null!;
        public virtual DbSet<ChartOfAccountType> ChartOfAccountTypes { get; set; } = null!;
        public virtual DbSet<ClientDeal> ClientDeals { get; set; } = null!;
        public virtual DbSet<Commission> Commissions { get; set; } = null!;
        public virtual DbSet<CompanyPaymentSetting> CompanyPaymentSettings { get; set; } = null!;
        public virtual DbSet<CompanyPolicy> CompanyPolicies { get; set; } = null!;
        public virtual DbSet<Competency> Competencies { get; set; } = null!;
        public virtual DbSet<Complaint> Complaints { get; set; } = null!;
        public virtual DbSet<Contract> Contracts { get; set; } = null!;
        public virtual DbSet<ContractAttachment> ContractAttachments { get; set; } = null!;
        public virtual DbSet<ContractComment> ContractComments { get; set; } = null!;
        public virtual DbSet<ContractNote> ContractNotes { get; set; } = null!;
        public virtual DbSet<ContractType> ContractTypes { get; set; } = null!;
        public virtual DbSet<Coupon> Coupons { get; set; } = null!;
        public virtual DbSet<CreditNote> CreditNotes { get; set; } = null!;
        public virtual DbSet<CustomField> CustomFields { get; set; } = null!;
        public virtual DbSet<CustomFieldValue> CustomFieldValues { get; set; } = null!;
        public virtual DbSet<CustomQuestion> CustomQuestions { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Deal> Deals { get; set; } = null!;
        public virtual DbSet<DealCall> DealCalls { get; set; } = null!;
        public virtual DbSet<DealDiscussion> DealDiscussions { get; set; } = null!;
        public virtual DbSet<DealEmail> DealEmails { get; set; } = null!;
        public virtual DbSet<DealFile> DealFiles { get; set; } = null!;
        public virtual DbSet<DealTask> DealTasks { get; set; } = null!;
        public virtual DbSet<DebitNote> DebitNotes { get; set; } = null!;
        public virtual DbSet<DeductionOption> DeductionOptions { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Designation> Designations { get; set; } = null!;
        public virtual DbSet<Document> Documents { get; set; } = null!;
        public virtual DbSet<DucumentUpload> DucumentUploads { get; set; } = null!;
        public virtual DbSet<EmailTemplate> EmailTemplates { get; set; } = null!;
        public virtual DbSet<EmailTemplateLang> EmailTemplateLangs { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<EmployeeDocument> EmployeeDocuments { get; set; } = null!;
        public virtual DbSet<Estimation> Estimations { get; set; } = null!;
        public virtual DbSet<Event> Events { get; set; } = null!;
        public virtual DbSet<EventEmployee> EventEmployees { get; set; } = null!;
        public virtual DbSet<Expense> Expenses { get; set; } = null!;
        public virtual DbSet<ExperienceCertificate> ExperienceCertificates { get; set; } = null!;
        public virtual DbSet<FailedJob> FailedJobs { get; set; } = null!;
        public virtual DbSet<FormBuilder> FormBuilders { get; set; } = null!;
        public virtual DbSet<FormField> FormFields { get; set; } = null!;
        public virtual DbSet<FormFieldResponse> FormFieldResponses { get; set; } = null!;
        public virtual DbSet<FormResponse> FormResponses { get; set; } = null!;
        public virtual DbSet<GenerateOfferLetter> GenerateOfferLetters { get; set; } = null!;
        public virtual DbSet<GenratePayslipOption> GenratePayslipOptions { get; set; } = null!;
        public virtual DbSet<Goal> Goals { get; set; } = null!;
        public virtual DbSet<GoalTracking> GoalTrackings { get; set; } = null!;
        public virtual DbSet<GoalType> GoalTypes { get; set; } = null!;
        public virtual DbSet<Holiday> Holidays { get; set; } = null!;
        public virtual DbSet<Indicator> Indicators { get; set; } = null!;
        public virtual DbSet<InterviewSchedule> InterviewSchedules { get; set; } = null!;
        public virtual DbSet<Invoice> Invoices { get; set; } = null!;
        public virtual DbSet<InvoicePayment> InvoicePayments { get; set; } = null!;
        public virtual DbSet<InvoiceProduct> InvoiceProducts { get; set; } = null!;
        public virtual DbSet<IpRestrict> IpRestricts { get; set; } = null!;
        public virtual DbSet<Job> Jobs { get; set; } = null!;
        public virtual DbSet<JobApplication> JobApplications { get; set; } = null!;
        public virtual DbSet<JobApplicationNote> JobApplicationNotes { get; set; } = null!;
        public virtual DbSet<JobCategory> JobCategories { get; set; } = null!;
        public virtual DbSet<JobOnBoard> JobOnBoards { get; set; } = null!;
        public virtual DbSet<JobStage> JobStages { get; set; } = null!;
        public virtual DbSet<JoiningLetter> JoiningLetters { get; set; } = null!;
        public virtual DbSet<JournalEntry> JournalEntries { get; set; } = null!;
        public virtual DbSet<JournalItem> JournalItems { get; set; } = null!;
        public virtual DbSet<Label> Labels { get; set; } = null!;
        public virtual DbSet<LandingPageSection> LandingPageSections { get; set; } = null!;
        public virtual DbSet<Lead> Leads { get; set; } = null!;
        public virtual DbSet<LeadActivityLog> LeadActivityLogs { get; set; } = null!;
        public virtual DbSet<LeadCall> LeadCalls { get; set; } = null!;
        public virtual DbSet<LeadDiscussion> LeadDiscussions { get; set; } = null!;
        public virtual DbSet<LeadEmail> LeadEmails { get; set; } = null!;
        public virtual DbSet<LeadFile> LeadFiles { get; set; } = null!;
        public virtual DbSet<LeadStage> LeadStages { get; set; } = null!;
        public virtual DbSet<Leaf> Leaves { get; set; } = null!;
        public virtual DbSet<LeaveType> LeaveTypes { get; set; } = null!;
        public virtual DbSet<Loan> Loans { get; set; } = null!;
        public virtual DbSet<LoanOption> LoanOptions { get; set; } = null!;
        public virtual DbSet<LogActivity> LogActivities { get; set; } = null!;
        public virtual DbSet<Meeting> Meetings { get; set; } = null!;
        public virtual DbSet<MeetingEmployee> MeetingEmployees { get; set; } = null!;
        public virtual DbSet<Migration> Migrations { get; set; } = null!;
        public virtual DbSet<Milestone> Milestones { get; set; } = null!;
        public virtual DbSet<ModelHasPermission> ModelHasPermissions { get; set; } = null!;
        public virtual DbSet<ModelHasRole> ModelHasRoles { get; set; } = null!;
        public virtual DbSet<NocCertificate> NocCertificates { get; set; } = null!;
        public virtual DbSet<Notification> Notifications { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OtherPayment> OtherPayments { get; set; } = null!;
        public virtual DbSet<Overtime> Overtimes { get; set; } = null!;
        public virtual DbSet<PasswordReset> PasswordResets { get; set; } = null!;
        public virtual DbSet<PaySlip> PaySlips { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<PayslipType> PayslipTypes { get; set; } = null!;
        public virtual DbSet<PerformanceType> PerformanceTypes { get; set; } = null!;
        public virtual DbSet<Permission> Permissions { get; set; } = null!;
        public virtual DbSet<PersonalAccessToken> PersonalAccessTokens { get; set; } = null!;
        public virtual DbSet<Pipeline> Pipelines { get; set; } = null!;
        public virtual DbSet<Plan> Plans { get; set; } = null!;
        public virtual DbSet<PlanRequest> PlanRequests { get; set; } = null!;
        public virtual DbSet<Po> Pos { get; set; } = null!;
        public virtual DbSet<PosPayment> PosPayments { get; set; } = null!;
        public virtual DbSet<PosProduct> PosProducts { get; set; } = null!;
        public virtual DbSet<ProductService> ProductServices { get; set; } = null!;
        public virtual DbSet<ProductServiceCategory> ProductServiceCategories { get; set; } = null!;
        public virtual DbSet<ProductServiceUnit> ProductServiceUnits { get; set; } = null!;
        public virtual DbSet<Project> Projects { get; set; } = null!;
        public virtual DbSet<ProjectEmailTemplate> ProjectEmailTemplates { get; set; } = null!;
        public virtual DbSet<ProjectInvoice> ProjectInvoices { get; set; } = null!;
        public virtual DbSet<ProjectTask> ProjectTasks { get; set; } = null!;
        public virtual DbSet<ProjectUser> ProjectUsers { get; set; } = null!;
        public virtual DbSet<Projectstage> Projectstages { get; set; } = null!;
        public virtual DbSet<Promotion> Promotions { get; set; } = null!;
        public virtual DbSet<Proposal> Proposals { get; set; } = null!;
        public virtual DbSet<ProposalProduct> ProposalProducts { get; set; } = null!;
        public virtual DbSet<Purchase> Purchases { get; set; } = null!;
        public virtual DbSet<PurchasePayment> PurchasePayments { get; set; } = null!;
        public virtual DbSet<PurchaseProduct> PurchaseProducts { get; set; } = null!;
        public virtual DbSet<Resignation> Resignations { get; set; } = null!;
        public virtual DbSet<Revenue> Revenues { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<SaturationDeduction> SaturationDeductions { get; set; } = null!;
        public virtual DbSet<SetSalary> SetSalaries { get; set; } = null!;
        public virtual DbSet<Setting> Settings { get; set; } = null!;
        public virtual DbSet<Source> Sources { get; set; } = null!;
        public virtual DbSet<Stage> Stages { get; set; } = null!;
        public virtual DbSet<StockReport> StockReports { get; set; } = null!;
        public virtual DbSet<Support> Supports { get; set; } = null!;
        public virtual DbSet<SupportReply> SupportReplies { get; set; } = null!;
        public virtual DbSet<TaskChecklist> TaskChecklists { get; set; } = null!;
        public virtual DbSet<TaskComment> TaskComments { get; set; } = null!;
        public virtual DbSet<TaskFile> TaskFiles { get; set; } = null!;
        public virtual DbSet<TaskStage> TaskStages { get; set; } = null!;
        public virtual DbSet<Taxis> Taxes { get; set; } = null!;
        public virtual DbSet<Termination> Terminations { get; set; } = null!;
        public virtual DbSet<TerminationType> TerminationTypes { get; set; } = null!;
        public virtual DbSet<TimeTracker> TimeTrackers { get; set; } = null!;
        public virtual DbSet<Timesheet> Timesheets { get; set; } = null!;
        public virtual DbSet<TrackPhoto> TrackPhotos { get; set; } = null!;
        public virtual DbSet<Trainer> Trainers { get; set; } = null!;
        public virtual DbSet<Training> Trainings { get; set; } = null!;
        public virtual DbSet<TrainingType> TrainingTypes { get; set; } = null!;
        public virtual DbSet<Transaction> Transactions { get; set; } = null!;
        public virtual DbSet<Transfer> Transfers { get; set; } = null!;
        public virtual DbSet<Travel> Travels { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserContact> UserContacts { get; set; } = null!;
        public virtual DbSet<UserCoupon> UserCoupons { get; set; } = null!;
        public virtual DbSet<UserDeal> UserDeals { get; set; } = null!;
        public virtual DbSet<UserEmailTemplate> UserEmailTemplates { get; set; } = null!;
        public virtual DbSet<UserLead> UserLeads { get; set; } = null!;
        public virtual DbSet<UserToDo> UserToDos { get; set; } = null!;
        public virtual DbSet<Vender> Venders { get; set; } = null!;
        public virtual DbSet<Warehouse> Warehouses { get; set; } = null!;
        public virtual DbSet<WarehouseProduct> WarehouseProducts { get; set; } = null!;
        public virtual DbSet<Warning> Warnings { get; set; } = null!;
        public virtual DbSet<ZoomMeeting> ZoomMeetings { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=185.126.218.28;database=reina_erpdb;uid=reina_erpuser;pwd=qn7U6jjhOCE5", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.34-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");

            modelBuilder.Entity<ActivityLog>(entity =>
            {
                entity.ToTable("activity_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DealId)
                    .HasColumnType("int(11)")
                    .HasColumnName("deal_id");

                entity.Property(e => e.LogType)
                    .HasMaxLength(191)
                    .HasColumnName("log_type");

                entity.Property(e => e.ProjectId)
                    .HasColumnType("int(11)")
                    .HasColumnName("project_id");

                entity.Property(e => e.Remark)
                    .HasColumnType("text")
                    .HasColumnName("remark");

                entity.Property(e => e.TaskId)
                    .HasColumnType("int(11)")
                    .HasColumnName("task_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<AdminPaymentSetting>(entity =>
            {
                entity.ToTable("admin_payment_settings");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => new { e.Name, e.CreatedBy }, "admin_payment_settings_name_created_by_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Value)
                    .HasMaxLength(191)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<Allowance>(entity =>
            {
                entity.ToTable("allowances");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AllowanceOption)
                    .HasColumnType("int(11)")
                    .HasColumnName("allowance_option");

                entity.Property(e => e.Amount)
                    .HasColumnType("int(11)")
                    .HasColumnName("amount");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("employee_id");

                entity.Property(e => e.Title)
                    .HasMaxLength(191)
                    .HasColumnName("title");

                entity.Property(e => e.Type)
                    .HasMaxLength(191)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<AllowanceOption>(entity =>
            {
                entity.ToTable("allowance_options");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Announcement>(entity =>
            {
                entity.ToTable("announcements");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.BranchId)
                    .HasColumnType("int(11)")
                    .HasColumnName("branch_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(191)
                    .HasColumnName("department_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Description)
                    .HasMaxLength(191)
                    .HasColumnName("description");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(191)
                    .HasColumnName("employee_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.Title)
                    .HasMaxLength(191)
                    .HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<AnnouncementEmployee>(entity =>
            {
                entity.ToTable("announcement_employees");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AnnouncementId)
                    .HasColumnType("int(11)")
                    .HasColumnName("announcement_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("employee_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Appraisal>(entity =>
            {
                entity.ToTable("appraisals");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Administration)
                    .HasColumnType("int(11)")
                    .HasColumnName("administration");

                entity.Property(e => e.AppraisalDate)
                    .HasMaxLength(191)
                    .HasColumnName("appraisal_date");

                entity.Property(e => e.Attendance)
                    .HasColumnType("int(11)")
                    .HasColumnName("attendance");

                entity.Property(e => e.Branch)
                    .HasColumnType("int(11)")
                    .HasColumnName("branch");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CustomerExperience)
                    .HasColumnType("int(11)")
                    .HasColumnName("customer_experience");

                entity.Property(e => e.Employee)
                    .HasColumnType("int(11)")
                    .HasColumnName("employee");

                entity.Property(e => e.Integrity)
                    .HasColumnType("int(11)")
                    .HasColumnName("integrity");

                entity.Property(e => e.Marketing)
                    .HasColumnType("int(11)")
                    .HasColumnName("marketing");

                entity.Property(e => e.Professionalism)
                    .HasColumnType("int(11)")
                    .HasColumnName("professionalism");

                entity.Property(e => e.Rating)
                    .HasMaxLength(191)
                    .HasColumnName("rating");

                entity.Property(e => e.Remark)
                    .HasColumnType("text")
                    .HasColumnName("remark");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Asset>(entity =>
            {
                entity.ToTable("assets");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("double(8,2)")
                    .HasColumnName("amount");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("text")
                    .HasColumnName("employee_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.PurchaseDate).HasColumnName("purchase_date");

                entity.Property(e => e.SupportedDate).HasColumnName("supported_date");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<AttendanceEmployee>(entity =>
            {
                entity.ToTable("attendance_employees");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.ClockIn)
                    .HasColumnType("time")
                    .HasColumnName("clock_in");

                entity.Property(e => e.ClockOut)
                    .HasColumnType("time")
                    .HasColumnName("clock_out");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.EarlyLeaving)
                    .HasColumnType("time")
                    .HasColumnName("early_leaving");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("employee_id");

                entity.Property(e => e.Late)
                    .HasColumnType("time")
                    .HasColumnName("late");

                entity.Property(e => e.Overtime)
                    .HasColumnType("time")
                    .HasColumnName("overtime");

                entity.Property(e => e.Status)
                    .HasMaxLength(191)
                    .HasColumnName("status");

                entity.Property(e => e.TotalRest)
                    .HasColumnType("time")
                    .HasColumnName("total_rest");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Award>(entity =>
            {
                entity.ToTable("awards");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AwardType)
                    .HasMaxLength(191)
                    .HasColumnName("award_type");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Description)
                    .HasMaxLength(191)
                    .HasColumnName("description");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("employee_id");

                entity.Property(e => e.Gift)
                    .HasMaxLength(191)
                    .HasColumnName("gift");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<AwardType>(entity =>
            {
                entity.ToTable("award_types");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<BankAccount>(entity =>
            {
                entity.ToTable("bank_accounts");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(191)
                    .HasColumnName("account_number");

                entity.Property(e => e.BankAddress)
                    .HasColumnType("text")
                    .HasColumnName("bank_address");

                entity.Property(e => e.BankName)
                    .HasMaxLength(191)
                    .HasColumnName("bank_name");

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(191)
                    .HasColumnName("contact_number");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.HolderName)
                    .HasMaxLength(191)
                    .HasColumnName("holder_name");

                entity.Property(e => e.OpeningBalance)
                    .HasColumnType("double(15,2)")
                    .HasColumnName("opening_balance");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<BankTransfer>(entity =>
            {
                entity.ToTable("bank_transfers");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("double(15,2)")
                    .HasColumnName("amount");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.FromAccount)
                    .HasColumnType("int(11)")
                    .HasColumnName("from_account");

                entity.Property(e => e.PaymentMethod)
                    .HasColumnType("int(11)")
                    .HasColumnName("payment_method");

                entity.Property(e => e.Reference)
                    .HasMaxLength(191)
                    .HasColumnName("reference");

                entity.Property(e => e.ToAccount)
                    .HasColumnType("int(11)")
                    .HasColumnName("to_account");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.ToTable("bills");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.BillDate).HasColumnName("bill_date");

                entity.Property(e => e.BillId)
                    .HasMaxLength(191)
                    .HasColumnName("bill_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CategoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("category_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.DiscountApply)
                    .HasColumnType("int(11)")
                    .HasColumnName("discount_apply");

                entity.Property(e => e.DueDate).HasColumnName("due_date");

                entity.Property(e => e.OrderNumber)
                    .HasColumnType("int(11)")
                    .HasColumnName("order_number");

                entity.Property(e => e.SendDate).HasColumnName("send_date");

                entity.Property(e => e.ShippingDisplay)
                    .HasColumnType("int(11)")
                    .HasColumnName("shipping_display")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Status)
                    .HasColumnType("int(11)")
                    .HasColumnName("status");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.VenderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("vender_id");
            });

            modelBuilder.Entity<BillPayment>(entity =>
            {
                entity.ToTable("bill_payments");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AccountId)
                    .HasColumnType("int(11)")
                    .HasColumnName("account_id");

                entity.Property(e => e.AddReceipt)
                    .HasMaxLength(191)
                    .HasColumnName("add_receipt");

                entity.Property(e => e.Amount)
                    .HasPrecision(16, 2)
                    .HasColumnName("amount");

                entity.Property(e => e.BillId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bill_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.PaymentMethod)
                    .HasColumnType("int(11)")
                    .HasColumnName("payment_method");

                entity.Property(e => e.Reference)
                    .HasMaxLength(191)
                    .HasColumnName("reference");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<BillProduct>(entity =>
            {
                entity.ToTable("bill_products");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.BillId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bill_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.Discount)
                    .HasColumnType("double(8,2)")
                    .HasColumnName("discount");

                entity.Property(e => e.Price)
                    .HasPrecision(16, 2)
                    .HasColumnName("price");

                entity.Property(e => e.ProductId)
                    .HasColumnType("int(11)")
                    .HasColumnName("product_id");

                entity.Property(e => e.Quantity)
                    .HasPrecision(16, 2)
                    .HasColumnName("quantity");

                entity.Property(e => e.Tax)
                    .HasMaxLength(50)
                    .HasColumnName("tax")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.ToTable("branches");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Budget>(entity =>
            {
                entity.ToTable("budgets");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.ExpenseData)
                    .HasColumnType("text")
                    .HasColumnName("expense_data");

                entity.Property(e => e.From)
                    .HasMaxLength(191)
                    .HasColumnName("from");

                entity.Property(e => e.IncomeData)
                    .HasColumnType("text")
                    .HasColumnName("income_data");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.Period)
                    .HasMaxLength(191)
                    .HasColumnName("period");

                entity.Property(e => e.To)
                    .HasMaxLength(191)
                    .HasColumnName("to");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Bug>(entity =>
            {
                entity.ToTable("bugs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AssignTo)
                    .HasMaxLength(191)
                    .HasColumnName("assign_to");

                entity.Property(e => e.BugId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bug_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.DueDate).HasColumnName("due_date");

                entity.Property(e => e.Order)
                    .HasMaxLength(191)
                    .HasColumnName("order")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Priority)
                    .HasMaxLength(191)
                    .HasColumnName("priority");

                entity.Property(e => e.ProjectId)
                    .HasColumnType("int(11)")
                    .HasColumnName("project_id");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.Status)
                    .HasMaxLength(191)
                    .HasColumnName("status");

                entity.Property(e => e.Title)
                    .HasMaxLength(191)
                    .HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<BugComment>(entity =>
            {
                entity.ToTable("bug_comments");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.BugId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bug_id");

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("comment");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserType)
                    .HasMaxLength(100)
                    .HasColumnName("user_type");
            });

            modelBuilder.Entity<BugFile>(entity =>
            {
                entity.ToTable("bug_files");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.BugId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bug_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Extension)
                    .HasMaxLength(191)
                    .HasColumnName("extension");

                entity.Property(e => e.File)
                    .HasMaxLength(191)
                    .HasColumnName("file");

                entity.Property(e => e.FileSize)
                    .HasMaxLength(191)
                    .HasColumnName("file_size");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserType)
                    .HasMaxLength(191)
                    .HasColumnName("user_type");
            });

            modelBuilder.Entity<BugStatus>(entity =>
            {
                entity.ToTable("bug_statuses");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Order)
                    .HasColumnType("int(11)")
                    .HasColumnName("order");

                entity.Property(e => e.Title)
                    .HasMaxLength(191)
                    .HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<ChFavorite>(entity =>
            {
                entity.ToTable("ch_favorites");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.FavoriteId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("favorite_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<ChMessage>(entity =>
            {
                entity.ToTable("ch_messages");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Attachment)
                    .HasMaxLength(191)
                    .HasColumnName("attachment");

                entity.Property(e => e.Body)
                    .HasMaxLength(5000)
                    .HasColumnName("body");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.FromId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("from_id");

                entity.Property(e => e.Seen).HasColumnName("seen");

                entity.Property(e => e.ToId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("to_id");

                entity.Property(e => e.Type)
                    .HasMaxLength(191)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<ChartOfAccount>(entity =>
            {
                entity.ToTable("chart_of_accounts");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasColumnType("int(11)")
                    .HasColumnName("code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.IsEnabled)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_enabled")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.SubType)
                    .HasColumnType("int(11)")
                    .HasColumnName("sub_type");

                entity.Property(e => e.Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<ChartOfAccountSubType>(entity =>
            {
                entity.ToTable("chart_of_account_sub_types");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<ChartOfAccountType>(entity =>
            {
                entity.ToTable("chart_of_account_types");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<ClientDeal>(entity =>
            {
                entity.ToTable("client_deals");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.ClientId, "client_deals_client_id_foreign");

                entity.HasIndex(e => e.DealId, "client_deals_deal_id_foreign");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.ClientId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DealId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deal_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientDeals)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("client_deals_client_id_foreign");

                entity.HasOne(d => d.Deal)
                    .WithMany(p => p.ClientDeals)
                    .HasForeignKey(d => d.DealId)
                    .HasConstraintName("client_deals_deal_id_foreign");
            });

            modelBuilder.Entity<Commission>(entity =>
            {
                entity.ToTable("commissions");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("int(11)")
                    .HasColumnName("amount");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("employee_id");

                entity.Property(e => e.Title)
                    .HasMaxLength(191)
                    .HasColumnName("title");

                entity.Property(e => e.Type)
                    .HasMaxLength(191)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<CompanyPaymentSetting>(entity =>
            {
                entity.ToTable("company_payment_settings");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => new { e.Name, e.CreatedBy }, "company_payment_settings_name_created_by_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Value)
                    .HasMaxLength(191)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<CompanyPolicy>(entity =>
            {
                entity.ToTable("company_policies");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Attachment)
                    .HasMaxLength(191)
                    .HasColumnName("attachment");

                entity.Property(e => e.Branch)
                    .HasColumnType("int(11)")
                    .HasColumnName("branch");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.Title)
                    .HasMaxLength(191)
                    .HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Competency>(entity =>
            {
                entity.ToTable("competencies");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(191)
                    .HasColumnName("created_by");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.Type)
                    .HasMaxLength(191)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Complaint>(entity =>
            {
                entity.ToTable("complaints");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.ComplaintAgainst)
                    .HasColumnType("int(11)")
                    .HasColumnName("complaint_against");

                entity.Property(e => e.ComplaintDate).HasColumnName("complaint_date");

                entity.Property(e => e.ComplaintFrom)
                    .HasColumnType("int(11)")
                    .HasColumnName("complaint_from");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(191)
                    .HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasMaxLength(191)
                    .HasColumnName("description");

                entity.Property(e => e.Title)
                    .HasMaxLength(191)
                    .HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Contract>(entity =>
            {
                entity.ToTable("contracts");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.ClientName)
                    .HasColumnType("int(11)")
                    .HasColumnName("client_name");

                entity.Property(e => e.ClientSignature).HasColumnName("client_signature");

                entity.Property(e => e.CompanySignature).HasColumnName("company_signature");

                entity.Property(e => e.ContractDescription)
                    .HasColumnType("text")
                    .HasColumnName("contract_description");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasMaxLength(191)
                    .HasColumnName("description");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.ProjectId)
                    .HasMaxLength(191)
                    .HasColumnName("project_id");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.Status)
                    .HasMaxLength(191)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'pending'");

                entity.Property(e => e.Subject)
                    .HasMaxLength(191)
                    .HasColumnName("subject");

                entity.Property(e => e.Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Value)
                    .HasMaxLength(191)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<ContractAttachment>(entity =>
            {
                entity.ToTable("contract_attachment");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.ContractId)
                    .HasColumnType("int(11)")
                    .HasColumnName("contract_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Files)
                    .HasMaxLength(191)
                    .HasColumnName("files");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<ContractComment>(entity =>
            {
                entity.ToTable("contract_comment");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Comment)
                    .HasMaxLength(191)
                    .HasColumnName("comment");

                entity.Property(e => e.ContractId)
                    .HasColumnType("int(11)")
                    .HasColumnName("contract_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<ContractNote>(entity =>
            {
                entity.ToTable("contract_notes");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.ContractId)
                    .HasColumnType("int(11)")
                    .HasColumnName("contract_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Notes)
                    .HasMaxLength(191)
                    .HasColumnName("notes");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<ContractType>(entity =>
            {
                entity.ToTable("contract_types");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Coupon>(entity =>
            {
                entity.ToTable("coupons");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(191)
                    .HasColumnName("code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.Discount)
                    .HasColumnType("double(8,2)")
                    .HasColumnName("discount");

                entity.Property(e => e.IsActive)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Limit)
                    .HasColumnType("int(11)")
                    .HasColumnName("limit");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<CreditNote>(entity =>
            {
                entity.ToTable("credit_notes");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("double(15,2)")
                    .HasColumnName("amount");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Customer)
                    .HasColumnType("int(11)")
                    .HasColumnName("customer");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.Invoice)
                    .HasColumnType("int(11)")
                    .HasColumnName("invoice");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<CustomField>(entity =>
            {
                entity.ToTable("custom_fields");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Module)
                    .HasMaxLength(191)
                    .HasColumnName("module");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.Type)
                    .HasMaxLength(191)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<CustomFieldValue>(entity =>
            {
                entity.ToTable("custom_field_values");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.FieldId, "custom_field_values_field_id_foreign");

                entity.HasIndex(e => new { e.RecordId, e.FieldId }, "custom_field_values_record_id_field_id_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.FieldId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("field_id");

                entity.Property(e => e.RecordId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("record_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Value)
                    .HasMaxLength(191)
                    .HasColumnName("value");

                entity.HasOne(d => d.Field)
                    .WithMany(p => p.CustomFieldValues)
                    .HasForeignKey(d => d.FieldId)
                    .HasConstraintName("custom_field_values_field_id_foreign");
            });

            modelBuilder.Entity<CustomQuestion>(entity =>
            {
                entity.ToTable("custom_questions");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.IsRequired)
                    .HasMaxLength(191)
                    .HasColumnName("is_required");

                entity.Property(e => e.Question)
                    .HasMaxLength(191)
                    .HasColumnName("question");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customers");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Avatar)
                    .HasMaxLength(100)
                    .HasColumnName("avatar")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Balance)
                    .HasColumnType("double(8,2)")
                    .HasColumnName("balance");

                entity.Property(e => e.BillingAddress)
                    .HasColumnType("text")
                    .HasColumnName("billing_address");

                entity.Property(e => e.BillingCity)
                    .HasMaxLength(191)
                    .HasColumnName("billing_city");

                entity.Property(e => e.BillingCountry)
                    .HasMaxLength(191)
                    .HasColumnName("billing_country");

                entity.Property(e => e.BillingName)
                    .HasMaxLength(191)
                    .HasColumnName("billing_name");

                entity.Property(e => e.BillingPhone)
                    .HasMaxLength(191)
                    .HasColumnName("billing_phone");

                entity.Property(e => e.BillingState)
                    .HasMaxLength(191)
                    .HasColumnName("billing_state");

                entity.Property(e => e.BillingZip)
                    .HasMaxLength(191)
                    .HasColumnName("billing_zip");

                entity.Property(e => e.Contact)
                    .HasMaxLength(191)
                    .HasColumnName("contact");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.Email)
                    .HasMaxLength(191)
                    .HasColumnName("email");

                entity.Property(e => e.EmailVerifiedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("email_verified_at");

                entity.Property(e => e.IsActive)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Lang)
                    .HasMaxLength(191)
                    .HasColumnName("lang")
                    .HasDefaultValueSql("'en'");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.RememberToken)
                    .HasMaxLength(100)
                    .HasColumnName("remember_token");

                entity.Property(e => e.ShippingAddress)
                    .HasMaxLength(191)
                    .HasColumnName("shipping_address");

                entity.Property(e => e.ShippingCity)
                    .HasMaxLength(191)
                    .HasColumnName("shipping_city");

                entity.Property(e => e.ShippingCountry)
                    .HasMaxLength(191)
                    .HasColumnName("shipping_country");

                entity.Property(e => e.ShippingName)
                    .HasMaxLength(191)
                    .HasColumnName("shipping_name");

                entity.Property(e => e.ShippingPhone)
                    .HasMaxLength(191)
                    .HasColumnName("shipping_phone");

                entity.Property(e => e.ShippingState)
                    .HasMaxLength(191)
                    .HasColumnName("shipping_state");

                entity.Property(e => e.ShippingZip)
                    .HasMaxLength(191)
                    .HasColumnName("shipping_zip");

                entity.Property(e => e.TaxNumber)
                    .HasMaxLength(191)
                    .HasColumnName("tax_number");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Deal>(entity =>
            {
                entity.ToTable("deals");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.IsActive)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Labels)
                    .HasMaxLength(191)
                    .HasColumnName("labels");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.Notes)
                    .HasColumnType("text")
                    .HasColumnName("notes");

                entity.Property(e => e.Order)
                    .HasColumnType("int(11)")
                    .HasColumnName("order");

                entity.Property(e => e.Phone)
                    .HasMaxLength(191)
                    .HasColumnName("phone");

                entity.Property(e => e.PipelineId)
                    .HasColumnType("int(11)")
                    .HasColumnName("pipeline_id");

                entity.Property(e => e.Price)
                    .HasColumnType("double(8,2)")
                    .HasColumnName("price");

                entity.Property(e => e.Products)
                    .HasMaxLength(191)
                    .HasColumnName("products");

                entity.Property(e => e.Sources)
                    .HasMaxLength(191)
                    .HasColumnName("sources");

                entity.Property(e => e.StageId)
                    .HasColumnType("int(11)")
                    .HasColumnName("stage_id");

                entity.Property(e => e.Status)
                    .HasMaxLength(191)
                    .HasColumnName("status");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<DealCall>(entity =>
            {
                entity.ToTable("deal_calls");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.DealId, "deal_calls_deal_id_foreign");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CallResult)
                    .HasColumnType("text")
                    .HasColumnName("call_result");

                entity.Property(e => e.CallType)
                    .HasMaxLength(30)
                    .HasColumnName("call_type");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DealId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deal_id");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.Duration)
                    .HasMaxLength(20)
                    .HasColumnName("duration");

                entity.Property(e => e.Subject)
                    .HasMaxLength(191)
                    .HasColumnName("subject");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");

                entity.HasOne(d => d.Deal)
                    .WithMany(p => p.DealCalls)
                    .HasForeignKey(d => d.DealId)
                    .HasConstraintName("deal_calls_deal_id_foreign");
            });

            modelBuilder.Entity<DealDiscussion>(entity =>
            {
                entity.ToTable("deal_discussions");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.DealId, "deal_discussions_deal_id_foreign");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("comment");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.DealId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deal_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Deal)
                    .WithMany(p => p.DealDiscussions)
                    .HasForeignKey(d => d.DealId)
                    .HasConstraintName("deal_discussions_deal_id_foreign");
            });

            modelBuilder.Entity<DealEmail>(entity =>
            {
                entity.ToTable("deal_emails");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.DealId, "deal_emails_deal_id_foreign");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DealId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deal_id");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.Subject)
                    .HasMaxLength(191)
                    .HasColumnName("subject");

                entity.Property(e => e.To)
                    .HasMaxLength(191)
                    .HasColumnName("to");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Deal)
                    .WithMany(p => p.DealEmails)
                    .HasForeignKey(d => d.DealId)
                    .HasConstraintName("deal_emails_deal_id_foreign");
            });

            modelBuilder.Entity<DealFile>(entity =>
            {
                entity.ToTable("deal_files");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.DealId, "deal_files_deal_id_foreign");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DealId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deal_id");

                entity.Property(e => e.FileName)
                    .HasMaxLength(191)
                    .HasColumnName("file_name");

                entity.Property(e => e.FilePath)
                    .HasMaxLength(191)
                    .HasColumnName("file_path");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Deal)
                    .WithMany(p => p.DealFiles)
                    .HasForeignKey(d => d.DealId)
                    .HasConstraintName("deal_files_deal_id_foreign");
            });

            modelBuilder.Entity<DealTask>(entity =>
            {
                entity.ToTable("deal_tasks");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.DealId, "deal_tasks_deal_id_foreign");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.DealId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deal_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.Priority)
                    .HasMaxLength(191)
                    .HasColumnName("priority");

                entity.Property(e => e.Status)
                    .HasMaxLength(191)
                    .HasColumnName("status");

                entity.Property(e => e.Time)
                    .HasColumnType("time")
                    .HasColumnName("time");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Deal)
                    .WithMany(p => p.DealTasks)
                    .HasForeignKey(d => d.DealId)
                    .HasConstraintName("deal_tasks_deal_id_foreign");
            });

            modelBuilder.Entity<DebitNote>(entity =>
            {
                entity.ToTable("debit_notes");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("double(15,2)")
                    .HasColumnName("amount");

                entity.Property(e => e.Bill)
                    .HasColumnType("int(11)")
                    .HasColumnName("bill");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Vendor)
                    .HasColumnType("int(11)")
                    .HasColumnName("vendor");
            });

            modelBuilder.Entity<DeductionOption>(entity =>
            {
                entity.ToTable("deduction_options");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("departments");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.BranchId)
                    .HasColumnType("int(11)")
                    .HasColumnName("branch_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Designation>(entity =>
            {
                entity.ToTable("designations");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("department_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.ToTable("documents");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.IsRequired)
                    .HasMaxLength(191)
                    .HasColumnName("is_required");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<DucumentUpload>(entity =>
            {
                entity.ToTable("ducument_uploads");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.Document)
                    .HasMaxLength(191)
                    .HasColumnName("document");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.Role)
                    .HasMaxLength(191)
                    .HasColumnName("role");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<EmailTemplate>(entity =>
            {
                entity.ToTable("email_templates");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.From)
                    .HasMaxLength(191)
                    .HasColumnName("from");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.Slug)
                    .HasMaxLength(191)
                    .HasColumnName("slug");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<EmailTemplateLang>(entity =>
            {
                entity.ToTable("email_template_langs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Content)
                    .HasColumnType("text")
                    .HasColumnName("content");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Lang)
                    .HasMaxLength(100)
                    .HasColumnName("lang");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("parent_id");

                entity.Property(e => e.Subject)
                    .HasMaxLength(191)
                    .HasColumnName("subject");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employees");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AccountHolderName)
                    .HasMaxLength(191)
                    .HasColumnName("account_holder_name");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(191)
                    .HasColumnName("account_number");

                entity.Property(e => e.Address)
                    .HasMaxLength(191)
                    .HasColumnName("address");

                entity.Property(e => e.BankIdentifierCode)
                    .HasMaxLength(191)
                    .HasColumnName("bank_identifier_code");

                entity.Property(e => e.BankName)
                    .HasMaxLength(191)
                    .HasColumnName("bank_name");

                entity.Property(e => e.BranchId)
                    .HasColumnType("int(11)")
                    .HasColumnName("branch_id");

                entity.Property(e => e.BranchLocation)
                    .HasMaxLength(191)
                    .HasColumnName("branch_location");

                entity.Property(e => e.CompanyDoj)
                    .HasMaxLength(191)
                    .HasColumnName("company_doj");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("department_id");

                entity.Property(e => e.DesignationId)
                    .HasColumnType("int(11)")
                    .HasColumnName("designation_id");

                entity.Property(e => e.Dob).HasColumnName("dob");

                entity.Property(e => e.Documents)
                    .HasMaxLength(191)
                    .HasColumnName("documents");

                entity.Property(e => e.Email)
                    .HasMaxLength(191)
                    .HasColumnName("email");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(191)
                    .HasColumnName("employee_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Gender)
                    .HasMaxLength(191)
                    .HasColumnName("gender");

                entity.Property(e => e.IsActive)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(191)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(191)
                    .HasColumnName("phone");

                entity.Property(e => e.Salary)
                    .HasColumnType("int(11)")
                    .HasColumnName("salary");

                entity.Property(e => e.SalaryType)
                    .HasColumnType("int(11)")
                    .HasColumnName("salary_type");

                entity.Property(e => e.TaxPayerId)
                    .HasMaxLength(191)
                    .HasColumnName("tax_payer_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<EmployeeDocument>(entity =>
            {
                entity.ToTable("employee_documents");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.DocumentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("document_id");

                entity.Property(e => e.DocumentValue)
                    .HasMaxLength(191)
                    .HasColumnName("document_value");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("employee_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Estimation>(entity =>
            {
                entity.ToTable("estimations");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.ClientId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Discount)
                    .HasColumnType("double(8,2)")
                    .HasColumnName("discount");

                entity.Property(e => e.EstimationId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("estimation_id");

                entity.Property(e => e.IssueDate).HasColumnName("issue_date");

                entity.Property(e => e.Status)
                    .HasMaxLength(191)
                    .HasColumnName("status");

                entity.Property(e => e.TaxId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("tax_id");

                entity.Property(e => e.Terms)
                    .HasColumnType("text")
                    .HasColumnName("terms");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.ToTable("events");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.BranchId)
                    .HasColumnType("int(11)")
                    .HasColumnName("branch_id");

                entity.Property(e => e.Color)
                    .HasMaxLength(191)
                    .HasColumnName("color");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.Title)
                    .HasMaxLength(191)
                    .HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<EventEmployee>(entity =>
            {
                entity.ToTable("event_employees");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("employee_id");

                entity.Property(e => e.EventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Expense>(entity =>
            {
                entity.ToTable("expenses");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasPrecision(16, 2)
                    .HasColumnName("amount");

                entity.Property(e => e.Attachment)
                    .HasMaxLength(191)
                    .HasColumnName("attachment");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Description)
                    .HasMaxLength(191)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.ProjectId)
                    .HasColumnType("int(11)")
                    .HasColumnName("project_id");

                entity.Property(e => e.TaskId)
                    .HasColumnType("int(11)")
                    .HasColumnName("task_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<ExperienceCertificate>(entity =>
            {
                entity.ToTable("experience_certificates");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Lang)
                    .HasMaxLength(255)
                    .HasColumnName("lang");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<FailedJob>(entity =>
            {
                entity.ToTable("failed_jobs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Connection)
                    .HasColumnType("text")
                    .HasColumnName("connection");

                entity.Property(e => e.Exception).HasColumnName("exception");

                entity.Property(e => e.FailedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("failed_at")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Payload).HasColumnName("payload");

                entity.Property(e => e.Queue)
                    .HasColumnType("text")
                    .HasColumnName("queue");
            });

            modelBuilder.Entity<FormBuilder>(entity =>
            {
                entity.ToTable("form_builders");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Code, "form_builders_code_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(191)
                    .HasColumnName("code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.IsActive)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IsLeadActive)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_lead_active");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<FormField>(entity =>
            {
                entity.ToTable("form_fields");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.FormId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("form_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.Type)
                    .HasMaxLength(191)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<FormFieldResponse>(entity =>
            {
                entity.ToTable("form_field_responses");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.EmailId)
                    .HasColumnType("int(11)")
                    .HasColumnName("email_id");

                entity.Property(e => e.FormId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("form_id");

                entity.Property(e => e.NameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("name_id");

                entity.Property(e => e.PipelineId)
                    .HasColumnType("int(11)")
                    .HasColumnName("pipeline_id");

                entity.Property(e => e.SubjectId)
                    .HasColumnType("int(11)")
                    .HasColumnName("subject_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<FormResponse>(entity =>
            {
                entity.ToTable("form_responses");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.FormId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("form_id");

                entity.Property(e => e.Response)
                    .HasColumnType("text")
                    .HasColumnName("response");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<GenerateOfferLetter>(entity =>
            {
                entity.ToTable("generate_offer_letters");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Content)
                    .HasColumnType("text")
                    .HasColumnName("content");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Lang)
                    .HasMaxLength(100)
                    .HasColumnName("lang");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<GenratePayslipOption>(entity =>
            {
                entity.ToTable("genrate_payslip_options");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Goal>(entity =>
            {
                entity.ToTable("goals");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.From)
                    .HasMaxLength(191)
                    .HasColumnName("from");

                entity.Property(e => e.IsDisplay)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_display")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.To)
                    .HasMaxLength(191)
                    .HasColumnName("to");

                entity.Property(e => e.Type)
                    .HasMaxLength(191)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<GoalTracking>(entity =>
            {
                entity.ToTable("goal_trackings");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Branch)
                    .HasColumnType("int(11)")
                    .HasColumnName("branch");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.GoalType)
                    .HasColumnType("int(11)")
                    .HasColumnName("goal_type");

                entity.Property(e => e.Progress)
                    .HasColumnType("int(11)")
                    .HasColumnName("progress");

                entity.Property(e => e.Rating)
                    .HasMaxLength(191)
                    .HasColumnName("rating");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.Status)
                    .HasColumnType("int(11)")
                    .HasColumnName("status");

                entity.Property(e => e.Subject)
                    .HasMaxLength(191)
                    .HasColumnName("subject");

                entity.Property(e => e.TargetAchievement)
                    .HasMaxLength(191)
                    .HasColumnName("target_achievement");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<GoalType>(entity =>
            {
                entity.ToTable("goal_types");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Holiday>(entity =>
            {
                entity.ToTable("holidays");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.Occasion)
                    .HasColumnType("text")
                    .HasColumnName("occasion");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Indicator>(entity =>
            {
                entity.ToTable("indicators");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Administration)
                    .HasColumnType("int(11)")
                    .HasColumnName("administration");

                entity.Property(e => e.Attendance)
                    .HasColumnType("int(11)")
                    .HasColumnName("attendance");

                entity.Property(e => e.Branch)
                    .HasColumnType("int(11)")
                    .HasColumnName("branch");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedUser)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_user");

                entity.Property(e => e.CustomerExperience)
                    .HasColumnType("int(11)")
                    .HasColumnName("customer_experience");

                entity.Property(e => e.Department)
                    .HasColumnType("int(11)")
                    .HasColumnName("department");

                entity.Property(e => e.Designation)
                    .HasColumnType("int(11)")
                    .HasColumnName("designation");

                entity.Property(e => e.Integrity)
                    .HasColumnType("int(11)")
                    .HasColumnName("integrity");

                entity.Property(e => e.Marketing)
                    .HasColumnType("int(11)")
                    .HasColumnName("marketing");

                entity.Property(e => e.Professionalism)
                    .HasColumnType("int(11)")
                    .HasColumnName("professionalism");

                entity.Property(e => e.Rating)
                    .HasMaxLength(191)
                    .HasColumnName("rating");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<InterviewSchedule>(entity =>
            {
                entity.ToTable("interview_schedules");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Candidate)
                    .HasColumnType("int(11)")
                    .HasColumnName("candidate");

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("comment");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Employee)
                    .HasColumnType("int(11)")
                    .HasColumnName("employee");

                entity.Property(e => e.EmployeeResponse)
                    .HasMaxLength(191)
                    .HasColumnName("employee_response");

                entity.Property(e => e.Time)
                    .HasColumnType("time")
                    .HasColumnName("time");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("invoices");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CategoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("category_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("customer_id");

                entity.Property(e => e.DiscountApply)
                    .HasColumnType("int(11)")
                    .HasColumnName("discount_apply");

                entity.Property(e => e.DueDate).HasColumnName("due_date");

                entity.Property(e => e.InvoiceId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("invoice_id");

                entity.Property(e => e.IssueDate).HasColumnName("issue_date");

                entity.Property(e => e.RefNumber)
                    .HasColumnType("text")
                    .HasColumnName("ref_number");

                entity.Property(e => e.SendDate).HasColumnName("send_date");

                entity.Property(e => e.ShippingDisplay)
                    .HasColumnType("int(11)")
                    .HasColumnName("shipping_display")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Status)
                    .HasColumnType("int(11)")
                    .HasColumnName("status");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<InvoicePayment>(entity =>
            {
                entity.ToTable("invoice_payments");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AccountId)
                    .HasColumnType("int(11)")
                    .HasColumnName("account_id");

                entity.Property(e => e.AddReceipt)
                    .HasMaxLength(191)
                    .HasColumnName("add_receipt");

                entity.Property(e => e.Amount)
                    .HasPrecision(16, 2)
                    .HasColumnName("amount");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Currency)
                    .HasMaxLength(191)
                    .HasColumnName("currency");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.InvoiceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("invoice_id");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(191)
                    .HasColumnName("order_id");

                entity.Property(e => e.PaymentMethod)
                    .HasColumnType("int(11)")
                    .HasColumnName("payment_method");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(191)
                    .HasColumnName("payment_type")
                    .HasDefaultValueSql("'Manually'");

                entity.Property(e => e.Receipt)
                    .HasMaxLength(191)
                    .HasColumnName("receipt");

                entity.Property(e => e.Reference)
                    .HasMaxLength(191)
                    .HasColumnName("reference");

                entity.Property(e => e.TxnId)
                    .HasMaxLength(191)
                    .HasColumnName("txn_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<InvoiceProduct>(entity =>
            {
                entity.ToTable("invoice_products");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.Discount)
                    .HasColumnType("double(8,2)")
                    .HasColumnName("discount");

                entity.Property(e => e.InvoiceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("invoice_id");

                entity.Property(e => e.Price)
                    .HasPrecision(16, 2)
                    .HasColumnName("price");

                entity.Property(e => e.ProductId)
                    .HasColumnType("int(11)")
                    .HasColumnName("product_id");

                entity.Property(e => e.Quantity)
                    .HasPrecision(16, 2)
                    .HasColumnName("quantity");

                entity.Property(e => e.Tax)
                    .HasMaxLength(50)
                    .HasColumnName("tax")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<IpRestrict>(entity =>
            {
                entity.ToTable("ip_restricts");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Ip)
                    .HasMaxLength(191)
                    .HasColumnName("ip");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("jobs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Applicant)
                    .HasMaxLength(191)
                    .HasColumnName("applicant");

                entity.Property(e => e.Branch)
                    .HasColumnType("int(11)")
                    .HasColumnName("branch");

                entity.Property(e => e.Category)
                    .HasColumnType("int(11)")
                    .HasColumnName("category");

                entity.Property(e => e.Code)
                    .HasMaxLength(191)
                    .HasColumnName("code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CustomQuestion)
                    .HasMaxLength(191)
                    .HasColumnName("custom_question");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.Position)
                    .HasColumnType("int(11)")
                    .HasColumnName("position");

                entity.Property(e => e.Requirement)
                    .HasColumnType("text")
                    .HasColumnName("requirement");

                entity.Property(e => e.Skill)
                    .HasColumnType("text")
                    .HasColumnName("skill");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.Status)
                    .HasMaxLength(191)
                    .HasColumnName("status");

                entity.Property(e => e.Title)
                    .HasMaxLength(191)
                    .HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Visibility)
                    .HasMaxLength(191)
                    .HasColumnName("visibility");
            });

            modelBuilder.Entity<JobApplication>(entity =>
            {
                entity.ToTable("job_applications");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.City)
                    .HasMaxLength(191)
                    .HasColumnName("city");

                entity.Property(e => e.Country)
                    .HasMaxLength(191)
                    .HasColumnName("country");

                entity.Property(e => e.CoverLetter)
                    .HasColumnType("text")
                    .HasColumnName("cover_letter");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CustomQuestion)
                    .HasColumnType("text")
                    .HasColumnName("custom_question");

                entity.Property(e => e.Dob).HasColumnName("dob");

                entity.Property(e => e.Email)
                    .HasMaxLength(191)
                    .HasColumnName("email");

                entity.Property(e => e.Gender)
                    .HasMaxLength(191)
                    .HasColumnName("gender");

                entity.Property(e => e.IsArchive)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_archive");

                entity.Property(e => e.Job)
                    .HasColumnType("int(11)")
                    .HasColumnName("job");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.Order)
                    .HasColumnType("int(11)")
                    .HasColumnName("order");

                entity.Property(e => e.Phone)
                    .HasMaxLength(191)
                    .HasColumnName("phone");

                entity.Property(e => e.Profile)
                    .HasMaxLength(191)
                    .HasColumnName("profile");

                entity.Property(e => e.Rating)
                    .HasColumnType("int(11)")
                    .HasColumnName("rating");

                entity.Property(e => e.Resume)
                    .HasMaxLength(191)
                    .HasColumnName("resume");

                entity.Property(e => e.Skill)
                    .HasColumnType("text")
                    .HasColumnName("skill");

                entity.Property(e => e.Stage)
                    .HasColumnType("int(11)")
                    .HasColumnName("stage")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.State)
                    .HasMaxLength(191)
                    .HasColumnName("state");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<JobApplicationNote>(entity =>
            {
                entity.ToTable("job_application_notes");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.ApplicationId)
                    .HasColumnType("int(11)")
                    .HasColumnName("application_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasColumnName("note");

                entity.Property(e => e.NoteCreated)
                    .HasColumnType("int(11)")
                    .HasColumnName("note_created");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<JobCategory>(entity =>
            {
                entity.ToTable("job_categories");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Title)
                    .HasMaxLength(191)
                    .HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<JobOnBoard>(entity =>
            {
                entity.ToTable("job_on_boards");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Application)
                    .HasColumnType("int(11)")
                    .HasColumnName("application");

                entity.Property(e => e.ConvertToEmployee)
                    .HasColumnType("int(11)")
                    .HasColumnName("convert_to_employee");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.DaysOfWeek)
                    .HasColumnType("int(11)")
                    .HasColumnName("days_of_week");

                entity.Property(e => e.JobType)
                    .HasMaxLength(191)
                    .HasColumnName("job_type");

                entity.Property(e => e.JoiningDate).HasColumnName("joining_date");

                entity.Property(e => e.Salary)
                    .HasColumnType("int(11)")
                    .HasColumnName("salary");

                entity.Property(e => e.SalaryDuration)
                    .HasMaxLength(191)
                    .HasColumnName("salary_duration");

                entity.Property(e => e.SalaryType)
                    .HasMaxLength(191)
                    .HasColumnName("salary_type");

                entity.Property(e => e.Status)
                    .HasMaxLength(191)
                    .HasColumnName("status");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<JobStage>(entity =>
            {
                entity.ToTable("job_stages");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Order)
                    .HasColumnType("int(11)")
                    .HasColumnName("order");

                entity.Property(e => e.Title)
                    .HasMaxLength(191)
                    .HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<JoiningLetter>(entity =>
            {
                entity.ToTable("joining_letters");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Content)
                    .HasColumnType("text")
                    .HasColumnName("content");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Lang)
                    .HasMaxLength(100)
                    .HasColumnName("lang");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<JournalEntry>(entity =>
            {
                entity.ToTable("journal_entries");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.JournalId)
                    .HasColumnType("int(11)")
                    .HasColumnName("journal_id");

                entity.Property(e => e.Reference)
                    .HasMaxLength(191)
                    .HasColumnName("reference");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<JournalItem>(entity =>
            {
                entity.ToTable("journal_items");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Account)
                    .HasColumnType("int(11)")
                    .HasColumnName("account");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Credit)
                    .HasColumnType("double(8,2)")
                    .HasColumnName("credit");

                entity.Property(e => e.Debit)
                    .HasColumnType("double(8,2)")
                    .HasColumnName("debit");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.Journal)
                    .HasColumnType("int(11)")
                    .HasColumnName("journal");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Label>(entity =>
            {
                entity.ToTable("labels");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Color)
                    .HasMaxLength(191)
                    .HasColumnName("color");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.PipelineId)
                    .HasColumnType("int(11)")
                    .HasColumnName("pipeline_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<LandingPageSection>(entity =>
            {
                entity.ToTable("landing_page_sections");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Content)
                    .HasColumnType("text")
                    .HasColumnName("content");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DefaultContent)
                    .HasColumnType("text")
                    .HasColumnName("default_content");

                entity.Property(e => e.SectionBladeFileName)
                    .HasColumnType("text")
                    .HasColumnName("section_blade_file_name");

                entity.Property(e => e.SectionDemoImage)
                    .HasColumnType("text")
                    .HasColumnName("section_demo_image");

                entity.Property(e => e.SectionName)
                    .HasMaxLength(191)
                    .HasColumnName("section_name");

                entity.Property(e => e.SectionOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("section_order");

                entity.Property(e => e.SectionType)
                    .HasColumnType("enum('section-1','section-2','section-3','section-4','section-5','section-6','section-7','section-8','section-9','section-10','section-plan')")
                    .HasColumnName("section_type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Lead>(entity =>
            {
                entity.ToTable("leads");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Email, "leads_email_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(191)
                    .HasColumnName("email");

                entity.Property(e => e.IsActive)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IsConverted)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_converted");

                entity.Property(e => e.Labels)
                    .HasMaxLength(191)
                    .HasColumnName("labels");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.Notes)
                    .HasColumnType("text")
                    .HasColumnName("notes");

                entity.Property(e => e.Order)
                    .HasColumnType("int(11)")
                    .HasColumnName("order");

                entity.Property(e => e.Phone)
                    .HasMaxLength(191)
                    .HasColumnName("phone");

                entity.Property(e => e.PipelineId)
                    .HasColumnType("int(11)")
                    .HasColumnName("pipeline_id");

                entity.Property(e => e.Products)
                    .HasMaxLength(191)
                    .HasColumnName("products");

                entity.Property(e => e.Sources)
                    .HasMaxLength(191)
                    .HasColumnName("sources");

                entity.Property(e => e.StageId)
                    .HasColumnType("int(11)")
                    .HasColumnName("stage_id");

                entity.Property(e => e.Subject)
                    .HasMaxLength(191)
                    .HasColumnName("subject");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<LeadActivityLog>(entity =>
            {
                entity.ToTable("lead_activity_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.LeadId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("lead_id");

                entity.Property(e => e.LogType)
                    .HasMaxLength(191)
                    .HasColumnName("log_type");

                entity.Property(e => e.Remark)
                    .HasColumnType("text")
                    .HasColumnName("remark");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<LeadCall>(entity =>
            {
                entity.ToTable("lead_calls");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.LeadId, "lead_calls_lead_id_foreign");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CallResult)
                    .HasColumnType("text")
                    .HasColumnName("call_result");

                entity.Property(e => e.CallType)
                    .HasMaxLength(30)
                    .HasColumnName("call_type");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.Duration)
                    .HasMaxLength(20)
                    .HasColumnName("duration");

                entity.Property(e => e.LeadId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("lead_id");

                entity.Property(e => e.Subject)
                    .HasMaxLength(191)
                    .HasColumnName("subject");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.LeadCalls)
                    .HasForeignKey(d => d.LeadId)
                    .HasConstraintName("lead_calls_lead_id_foreign");
            });

            modelBuilder.Entity<LeadDiscussion>(entity =>
            {
                entity.ToTable("lead_discussions");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.LeadId, "lead_discussions_lead_id_foreign");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("comment");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.LeadId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("lead_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.LeadDiscussions)
                    .HasForeignKey(d => d.LeadId)
                    .HasConstraintName("lead_discussions_lead_id_foreign");
            });

            modelBuilder.Entity<LeadEmail>(entity =>
            {
                entity.ToTable("lead_emails");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.LeadId, "lead_emails_lead_id_foreign");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.LeadId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("lead_id");

                entity.Property(e => e.Subject)
                    .HasMaxLength(191)
                    .HasColumnName("subject");

                entity.Property(e => e.To)
                    .HasMaxLength(191)
                    .HasColumnName("to");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.LeadEmails)
                    .HasForeignKey(d => d.LeadId)
                    .HasConstraintName("lead_emails_lead_id_foreign");
            });

            modelBuilder.Entity<LeadFile>(entity =>
            {
                entity.ToTable("lead_files");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.LeadId, "lead_files_lead_id_foreign");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.FileName)
                    .HasMaxLength(191)
                    .HasColumnName("file_name");

                entity.Property(e => e.FilePath)
                    .HasMaxLength(191)
                    .HasColumnName("file_path");

                entity.Property(e => e.LeadId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("lead_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.LeadFiles)
                    .HasForeignKey(d => d.LeadId)
                    .HasConstraintName("lead_files_lead_id_foreign");
            });

            modelBuilder.Entity<LeadStage>(entity =>
            {
                entity.ToTable("lead_stages");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.Order)
                    .HasColumnType("int(11)")
                    .HasColumnName("order");

                entity.Property(e => e.PipelineId)
                    .HasColumnType("int(11)")
                    .HasColumnName("pipeline_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Leaf>(entity =>
            {
                entity.ToTable("leaves");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AppliedOn).HasColumnName("applied_on");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("employee_id");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.LeaveReason)
                    .HasMaxLength(191)
                    .HasColumnName("leave_reason");

                entity.Property(e => e.LeaveTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("leave_type_id");

                entity.Property(e => e.Remark)
                    .HasMaxLength(191)
                    .HasColumnName("remark");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.Status)
                    .HasMaxLength(191)
                    .HasColumnName("status");

                entity.Property(e => e.TotalLeaveDays)
                    .HasMaxLength(191)
                    .HasColumnName("total_leave_days");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<LeaveType>(entity =>
            {
                entity.ToTable("leave_types");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Days)
                    .HasColumnType("int(11)")
                    .HasColumnName("days");

                entity.Property(e => e.Title)
                    .HasMaxLength(191)
                    .HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Loan>(entity =>
            {
                entity.ToTable("loans");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("int(11)")
                    .HasColumnName("amount");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("employee_id");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.LoanOption)
                    .HasColumnType("int(11)")
                    .HasColumnName("loan_option");

                entity.Property(e => e.Reason)
                    .HasMaxLength(191)
                    .HasColumnName("reason");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.Title)
                    .HasMaxLength(191)
                    .HasColumnName("title");

                entity.Property(e => e.Type)
                    .HasMaxLength(191)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<LoanOption>(entity =>
            {
                entity.ToTable("loan_options");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<LogActivity>(entity =>
            {
                entity.ToTable("log_activities");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_by");

                entity.Property(e => e.ModuleId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("module_id");

                entity.Property(e => e.ModuleType)
                    .HasMaxLength(191)
                    .HasColumnName("module_type");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasColumnName("note");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.Time)
                    .HasColumnType("time")
                    .HasColumnName("time");

                entity.Property(e => e.Type)
                    .HasMaxLength(191)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Meeting>(entity =>
            {
                entity.ToTable("meetings");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.BranchId)
                    .HasColumnType("int(11)")
                    .HasColumnName("branch_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasColumnName("note");

                entity.Property(e => e.Time)
                    .HasColumnType("time")
                    .HasColumnName("time");

                entity.Property(e => e.Title)
                    .HasMaxLength(191)
                    .HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<MeetingEmployee>(entity =>
            {
                entity.ToTable("meeting_employees");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("employee_id");

                entity.Property(e => e.MeetingId)
                    .HasColumnType("int(11)")
                    .HasColumnName("meeting_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Migration>(entity =>
            {
                entity.ToTable("migrations");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Batch)
                    .HasColumnType("int(11)")
                    .HasColumnName("batch");

                entity.Property(e => e.Migration1)
                    .HasMaxLength(191)
                    .HasColumnName("migration");
            });

            modelBuilder.Entity<Milestone>(entity =>
            {
                entity.ToTable("milestones");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Cost)
                    .HasColumnType("double(15,2)")
                    .HasColumnName("cost");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.DueDate).HasColumnName("due_date");

                entity.Property(e => e.Progress)
                    .HasMaxLength(191)
                    .HasColumnName("progress");

                entity.Property(e => e.ProjectId)
                    .HasColumnType("int(11)")
                    .HasColumnName("project_id");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.Status)
                    .HasMaxLength(191)
                    .HasColumnName("status");

                entity.Property(e => e.Title)
                    .HasMaxLength(191)
                    .HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<ModelHasPermission>(entity =>
            {
                entity.HasKey(e => new { e.PermissionId, e.ModelId, e.ModelType })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("model_has_permissions");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => new { e.ModelId, e.ModelType }, "model_has_permissions_model_id_model_type_index");

                entity.Property(e => e.PermissionId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("permission_id");

                entity.Property(e => e.ModelId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("model_id");

                entity.Property(e => e.ModelType)
                    .HasMaxLength(191)
                    .HasColumnName("model_type");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.ModelHasPermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .HasConstraintName("model_has_permissions_permission_id_foreign");
            });

            modelBuilder.Entity<ModelHasRole>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.ModelId, e.ModelType })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("model_has_roles");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => new { e.ModelId, e.ModelType }, "model_has_roles_model_id_model_type_index");

                entity.Property(e => e.RoleId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("role_id");

                entity.Property(e => e.ModelId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("model_id");

                entity.Property(e => e.ModelType)
                    .HasMaxLength(191)
                    .HasColumnName("model_type");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.ModelHasRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("model_has_roles_role_id_foreign");
            });

            modelBuilder.Entity<NocCertificate>(entity =>
            {
                entity.ToTable("noc_certificates");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Lang)
                    .HasMaxLength(255)
                    .HasColumnName("lang");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.ToTable("notifications");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Data)
                    .HasColumnType("text")
                    .HasColumnName("data");

                entity.Property(e => e.IsRead)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_read");

                entity.Property(e => e.Type)
                    .HasColumnType("text")
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("orders");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.OrderId, "orders_order_id_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CardExpMonth)
                    .HasMaxLength(10)
                    .HasColumnName("card_exp_month");

                entity.Property(e => e.CardExpYear)
                    .HasMaxLength(10)
                    .HasColumnName("card_exp_year");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(10)
                    .HasColumnName("card_number");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(100)
                    .HasColumnName("order_id");

                entity.Property(e => e.PaymentStatus)
                    .HasMaxLength(100)
                    .HasColumnName("payment_status");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(191)
                    .HasColumnName("payment_type")
                    .HasDefaultValueSql("'Manually'");

                entity.Property(e => e.PlanId)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id");

                entity.Property(e => e.PlanName)
                    .HasMaxLength(100)
                    .HasColumnName("plan_name");

                entity.Property(e => e.Price)
                    .HasColumnType("double(8,2)")
                    .HasColumnName("price");

                entity.Property(e => e.PriceCurrency)
                    .HasMaxLength(10)
                    .HasColumnName("price_currency");

                entity.Property(e => e.Receipt)
                    .HasMaxLength(191)
                    .HasColumnName("receipt");

                entity.Property(e => e.TxnId)
                    .HasMaxLength(100)
                    .HasColumnName("txn_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<OtherPayment>(entity =>
            {
                entity.ToTable("other_payments");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("int(11)")
                    .HasColumnName("amount");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("employee_id");

                entity.Property(e => e.Title)
                    .HasMaxLength(191)
                    .HasColumnName("title");

                entity.Property(e => e.Type)
                    .HasMaxLength(191)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Overtime>(entity =>
            {
                entity.ToTable("overtimes");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("employee_id");

                entity.Property(e => e.Hours)
                    .HasColumnType("int(11)")
                    .HasColumnName("hours");

                entity.Property(e => e.NumberOfDays)
                    .HasColumnType("int(11)")
                    .HasColumnName("number_of_days");

                entity.Property(e => e.Rate)
                    .HasColumnType("int(11)")
                    .HasColumnName("rate");

                entity.Property(e => e.Title)
                    .HasMaxLength(191)
                    .HasColumnName("title");

                entity.Property(e => e.Type)
                    .HasMaxLength(191)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<PasswordReset>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("password_resets");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Email, "password_resets_email_index");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .HasMaxLength(191)
                    .HasColumnName("email");

                entity.Property(e => e.Token)
                    .HasMaxLength(191)
                    .HasColumnName("token");
            });

            modelBuilder.Entity<PaySlip>(entity =>
            {
                entity.ToTable("pay_slips");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Allowance)
                    .HasColumnType("text")
                    .HasColumnName("allowance");

                entity.Property(e => e.BasicSalary)
                    .HasColumnType("int(11)")
                    .HasColumnName("basic_salary");

                entity.Property(e => e.Commission)
                    .HasColumnType("text")
                    .HasColumnName("commission");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("employee_id");

                entity.Property(e => e.Loan)
                    .HasColumnType("text")
                    .HasColumnName("loan");

                entity.Property(e => e.NetPayble)
                    .HasColumnType("int(11)")
                    .HasColumnName("net_payble");

                entity.Property(e => e.OtherPayment)
                    .HasColumnType("text")
                    .HasColumnName("other_payment");

                entity.Property(e => e.Overtime)
                    .HasColumnType("text")
                    .HasColumnName("overtime");

                entity.Property(e => e.SalaryMonth)
                    .HasMaxLength(191)
                    .HasColumnName("salary_month");

                entity.Property(e => e.SaturationDeduction)
                    .HasColumnType("text")
                    .HasColumnName("saturation_deduction");

                entity.Property(e => e.Status)
                    .HasColumnType("int(11)")
                    .HasColumnName("status");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("payments");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AccountId)
                    .HasColumnType("int(11)")
                    .HasColumnName("account_id");

                entity.Property(e => e.AddReceipt)
                    .HasMaxLength(191)
                    .HasColumnName("add_receipt");

                entity.Property(e => e.Amount)
                    .HasPrecision(16, 2)
                    .HasColumnName("amount");

                entity.Property(e => e.CategoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("category_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.PaymentMethod)
                    .HasColumnType("int(11)")
                    .HasColumnName("payment_method");

                entity.Property(e => e.Recurring)
                    .HasMaxLength(191)
                    .HasColumnName("recurring");

                entity.Property(e => e.Reference)
                    .HasMaxLength(191)
                    .HasColumnName("reference");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.VenderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("vender_id");
            });

            modelBuilder.Entity<PayslipType>(entity =>
            {
                entity.ToTable("payslip_types");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<PerformanceType>(entity =>
            {
                entity.ToTable("performance_types");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.ToTable("permissions");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.GuardName)
                    .HasMaxLength(191)
                    .HasColumnName("guard_name");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Permissions)
                    .UsingEntity<Dictionary<string, object>>(
                        "RoleHasPermission",
                        l => l.HasOne<Role>().WithMany().HasForeignKey("RoleId").HasConstraintName("role_has_permissions_role_id_foreign"),
                        r => r.HasOne<Permission>().WithMany().HasForeignKey("PermissionId").HasConstraintName("role_has_permissions_permission_id_foreign"),
                        j =>
                        {
                            j.HasKey("PermissionId", "RoleId").HasName("PRIMARY").HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                            j.ToTable("role_has_permissions").HasCharSet("utf8mb4").UseCollation("utf8mb4_unicode_ci");

                            j.HasIndex(new[] { "RoleId" }, "role_has_permissions_role_id_foreign");

                            j.IndexerProperty<ulong>("PermissionId").HasColumnType("bigint(20) unsigned").HasColumnName("permission_id");

                            j.IndexerProperty<ulong>("RoleId").HasColumnType("bigint(20) unsigned").HasColumnName("role_id");
                        });
            });

            modelBuilder.Entity<PersonalAccessToken>(entity =>
            {
                entity.ToTable("personal_access_tokens");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Token, "personal_access_tokens_token_unique")
                    .IsUnique();

                entity.HasIndex(e => new { e.TokenableType, e.TokenableId }, "personal_access_tokens_tokenable_type_tokenable_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Abilities)
                    .HasColumnType("text")
                    .HasColumnName("abilities");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.LastUsedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("last_used_at");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.Token)
                    .HasMaxLength(64)
                    .HasColumnName("token");

                entity.Property(e => e.TokenableId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("tokenable_id");

                entity.Property(e => e.TokenableType)
                    .HasMaxLength(191)
                    .HasColumnName("tokenable_type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Pipeline>(entity =>
            {
                entity.ToTable("pipelines");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Plan>(entity =>
            {
                entity.ToTable("plans");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Name, "plans_name_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Account)
                    .HasColumnType("int(11)")
                    .HasColumnName("account");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Crm)
                    .HasColumnType("int(11)")
                    .HasColumnName("crm");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.Duration)
                    .HasMaxLength(100)
                    .HasColumnName("duration");

                entity.Property(e => e.Hrm)
                    .HasColumnType("int(11)")
                    .HasColumnName("hrm");

                entity.Property(e => e.Image)
                    .HasMaxLength(191)
                    .HasColumnName("image");

                entity.Property(e => e.MaxClients)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_clients");

                entity.Property(e => e.MaxCustomers)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_customers");

                entity.Property(e => e.MaxUsers)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_users");

                entity.Property(e => e.MaxVenders)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_venders");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Pos)
                    .HasColumnType("int(11)")
                    .HasColumnName("pos");

                entity.Property(e => e.Price)
                    .HasColumnType("double(8,2)")
                    .HasColumnName("price");

                entity.Property(e => e.Project)
                    .HasColumnType("int(11)")
                    .HasColumnName("project");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<PlanRequest>(entity =>
            {
                entity.ToTable("plan_requests");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Duration)
                    .HasMaxLength(20)
                    .HasColumnName("duration")
                    .HasDefaultValueSql("'monthly'");

                entity.Property(e => e.PlanId)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<Po>(entity =>
            {
                entity.ToTable("pos");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CategoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("category_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("customer_id");

                entity.Property(e => e.PosDate).HasColumnName("pos_date");

                entity.Property(e => e.PosId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("pos_id");

                entity.Property(e => e.ShippingDisplay)
                    .HasColumnType("int(11)")
                    .HasColumnName("shipping_display")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Status)
                    .HasColumnType("int(11)")
                    .HasColumnName("status");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.WarehouseId)
                    .HasColumnType("int(11)")
                    .HasColumnName("warehouse_id");
            });

            modelBuilder.Entity<PosPayment>(entity =>
            {
                entity.ToTable("pos_payments");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasMaxLength(191)
                    .HasColumnName("amount")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Discount)
                    .HasColumnType("double(8,2)")
                    .HasColumnName("discount");

                entity.Property(e => e.DiscountAmount)
                    .HasColumnType("double(8,2)")
                    .HasColumnName("discount_amount");

                entity.Property(e => e.PosId)
                    .HasColumnType("int(11)")
                    .HasColumnName("pos_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<PosProduct>(entity =>
            {
                entity.ToTable("pos_products");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.Discount)
                    .HasColumnType("double(8,2)")
                    .HasColumnName("discount");

                entity.Property(e => e.PosId)
                    .HasColumnType("int(11)")
                    .HasColumnName("pos_id");

                entity.Property(e => e.Price)
                    .HasColumnType("double(8,2)")
                    .HasColumnName("price");

                entity.Property(e => e.ProductId)
                    .HasColumnType("int(11)")
                    .HasColumnName("product_id");

                entity.Property(e => e.Quantity)
                    .HasColumnType("int(11)")
                    .HasColumnName("quantity");

                entity.Property(e => e.Tax)
                    .HasMaxLength(191)
                    .HasColumnName("tax")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<ProductService>(entity =>
            {
                entity.ToTable("product_services");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CategoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("category_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.OlmasiGerekenStok)
                    .HasColumnType("int(11)")
                    .HasColumnName("olmasi_gereken_stok");

                entity.Property(e => e.ProImage)
                    .HasMaxLength(191)
                    .HasColumnName("pro_image");

                entity.Property(e => e.PurchasePrice)
                    .HasPrecision(16, 2)
                    .HasColumnName("purchase_price");

                entity.Property(e => e.Quantity)
                    .HasColumnType("int(11)")
                    .HasColumnName("quantity");

                entity.Property(e => e.SalePrice)
                    .HasPrecision(16, 2)
                    .HasColumnName("sale_price");

                entity.Property(e => e.Sku)
                    .HasMaxLength(191)
                    .HasColumnName("sku");

                entity.Property(e => e.TaxId)
                    .HasMaxLength(50)
                    .HasColumnName("tax_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Type)
                    .HasMaxLength(191)
                    .HasColumnName("type");

                entity.Property(e => e.UnitId)
                    .HasColumnType("int(11)")
                    .HasColumnName("unit_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<ProductServiceCategory>(entity =>
            {
                entity.ToTable("product_service_categories");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Color)
                    .HasMaxLength(191)
                    .HasColumnName("color")
                    .HasDefaultValueSql("'#fc544b'");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.Type)
                    .HasMaxLength(191)
                    .HasColumnName("type")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<ProductServiceUnit>(entity =>
            {
                entity.ToTable("product_service_units");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("projects");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Budget)
                    .HasColumnType("int(11)")
                    .HasColumnName("budget");

                entity.Property(e => e.ClientId)
                    .HasColumnType("int(11)")
                    .HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.EstimatedHrs)
                    .HasMaxLength(191)
                    .HasColumnName("estimated_hrs");

                entity.Property(e => e.ProjectImage)
                    .HasMaxLength(191)
                    .HasColumnName("project_image");

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(191)
                    .HasColumnName("project_name");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.Status)
                    .HasMaxLength(191)
                    .HasColumnName("status");

                entity.Property(e => e.Tags)
                    .HasColumnType("text")
                    .HasColumnName("tags");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<ProjectEmailTemplate>(entity =>
            {
                entity.ToTable("project_email_templates");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.IsActive)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ProjectId)
                    .HasColumnType("int(11)")
                    .HasColumnName("project_id");

                entity.Property(e => e.TemplateId)
                    .HasColumnType("int(11)")
                    .HasColumnName("template_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<ProjectInvoice>(entity =>
            {
                entity.ToTable("project_invoices");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.ClientId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.DueDate).HasColumnName("due_date");

                entity.Property(e => e.InvoiceId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("invoice_id");

                entity.Property(e => e.ProjectId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("project_id");

                entity.Property(e => e.Status)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.TaxId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("tax_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<ProjectTask>(entity =>
            {
                entity.ToTable("project_tasks");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AssignTo)
                    .HasColumnType("text")
                    .HasColumnName("assign_to");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.EstimatedHrs)
                    .HasColumnType("int(11)")
                    .HasColumnName("estimated_hrs");

                entity.Property(e => e.IsComplete)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_complete");

                entity.Property(e => e.IsFavourite)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_favourite");

                entity.Property(e => e.MarkedAt).HasColumnName("marked_at");

                entity.Property(e => e.MilestoneId)
                    .HasColumnType("int(11)")
                    .HasColumnName("milestone_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.Order)
                    .HasColumnType("int(11)")
                    .HasColumnName("order");

                entity.Property(e => e.Priority)
                    .HasMaxLength(50)
                    .HasColumnName("priority")
                    .HasDefaultValueSql("'medium'");

                entity.Property(e => e.PriorityColor)
                    .HasMaxLength(50)
                    .HasColumnName("priority_color");

                entity.Property(e => e.Progress)
                    .HasMaxLength(5)
                    .HasColumnName("progress")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ProjectId)
                    .HasColumnType("int(11)")
                    .HasColumnName("project_id");

                entity.Property(e => e.StageId)
                    .HasColumnType("int(11)")
                    .HasColumnName("stage_id");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<ProjectUser>(entity =>
            {
                entity.ToTable("project_users");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.InvitedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("invited_by");

                entity.Property(e => e.ProjectId)
                    .HasColumnType("int(11)")
                    .HasColumnName("project_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<Projectstage>(entity =>
            {
                entity.ToTable("projectstages");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Color)
                    .HasMaxLength(15)
                    .HasColumnName("color");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.Order)
                    .HasColumnType("int(11)")
                    .HasColumnName("order");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Promotion>(entity =>
            {
                entity.ToTable("promotions");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(191)
                    .HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasMaxLength(191)
                    .HasColumnName("description");

                entity.Property(e => e.DesignationId)
                    .HasColumnType("int(11)")
                    .HasColumnName("designation_id");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("employee_id");

                entity.Property(e => e.PromotionDate).HasColumnName("promotion_date");

                entity.Property(e => e.PromotionTitle)
                    .HasMaxLength(191)
                    .HasColumnName("promotion_title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Proposal>(entity =>
            {
                entity.ToTable("proposals");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CategoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("category_id");

                entity.Property(e => e.ConvertedInvoiceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("converted_invoice_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("customer_id");

                entity.Property(e => e.DiscountApply)
                    .HasColumnType("int(11)")
                    .HasColumnName("discount_apply");

                entity.Property(e => e.IsConvert)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_convert");

                entity.Property(e => e.IssueDate).HasColumnName("issue_date");

                entity.Property(e => e.ProposalId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("proposal_id");

                entity.Property(e => e.SendDate).HasColumnName("send_date");

                entity.Property(e => e.Status)
                    .HasColumnType("int(11)")
                    .HasColumnName("status");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<ProposalProduct>(entity =>
            {
                entity.ToTable("proposal_products");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.Discount)
                    .HasColumnType("double(8,2)")
                    .HasColumnName("discount");

                entity.Property(e => e.Price)
                    .HasPrecision(16, 2)
                    .HasColumnName("price");

                entity.Property(e => e.ProductId)
                    .HasColumnType("int(11)")
                    .HasColumnName("product_id");

                entity.Property(e => e.ProposalId)
                    .HasColumnType("int(11)")
                    .HasColumnName("proposal_id");

                entity.Property(e => e.Quantity)
                    .HasColumnType("int(11)")
                    .HasColumnName("quantity");

                entity.Property(e => e.Tax)
                    .HasMaxLength(50)
                    .HasColumnName("tax")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Purchase>(entity =>
            {
                entity.ToTable("purchases");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CategoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("category_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.DiscountApply)
                    .HasColumnType("int(11)")
                    .HasColumnName("discount_apply");

                entity.Property(e => e.PurchaseDate).HasColumnName("purchase_date");

                entity.Property(e => e.PurchaseId)
                    .HasMaxLength(191)
                    .HasColumnName("purchase_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PurchaseNumber)
                    .HasColumnType("int(11)")
                    .HasColumnName("purchase_number");

                entity.Property(e => e.SendDate).HasColumnName("send_date");

                entity.Property(e => e.ShippingDisplay)
                    .HasColumnType("int(11)")
                    .HasColumnName("shipping_display")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Status)
                    .HasColumnType("int(11)")
                    .HasColumnName("status");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.VenderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("vender_id");

                entity.Property(e => e.WarehouseId)
                    .HasColumnType("int(11)")
                    .HasColumnName("warehouse_id");
            });

            modelBuilder.Entity<PurchasePayment>(entity =>
            {
                entity.ToTable("purchase_payments");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AccountId)
                    .HasColumnType("int(11)")
                    .HasColumnName("account_id");

                entity.Property(e => e.AddReceipt)
                    .HasMaxLength(191)
                    .HasColumnName("add_receipt");

                entity.Property(e => e.Amount)
                    .HasColumnType("double(8,2)")
                    .HasColumnName("amount");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.PaymentMethod)
                    .HasColumnType("int(11)")
                    .HasColumnName("payment_method");

                entity.Property(e => e.PurchaseId)
                    .HasColumnType("int(11)")
                    .HasColumnName("purchase_id");

                entity.Property(e => e.Reference)
                    .HasMaxLength(191)
                    .HasColumnName("reference");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<PurchaseProduct>(entity =>
            {
                entity.ToTable("purchase_products");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.Discount)
                    .HasColumnType("double(8,2)")
                    .HasColumnName("discount");

                entity.Property(e => e.Price)
                    .HasColumnType("double(8,2)")
                    .HasColumnName("price");

                entity.Property(e => e.ProductId)
                    .HasColumnType("int(11)")
                    .HasColumnName("product_id");

                entity.Property(e => e.PurchaseId)
                    .HasColumnType("int(11)")
                    .HasColumnName("purchase_id");

                entity.Property(e => e.Quantity)
                    .HasColumnType("int(11)")
                    .HasColumnName("quantity");

                entity.Property(e => e.Tax)
                    .HasMaxLength(50)
                    .HasColumnName("tax");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Resignation>(entity =>
            {
                entity.ToTable("resignations");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasMaxLength(191)
                    .HasColumnName("description");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("employee_id");

                entity.Property(e => e.NoticeDate).HasColumnName("notice_date");

                entity.Property(e => e.ResignationDate).HasColumnName("resignation_date");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Revenue>(entity =>
            {
                entity.ToTable("revenues");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AccountId)
                    .HasColumnType("int(11)")
                    .HasColumnName("account_id");

                entity.Property(e => e.AddReceipt)
                    .HasMaxLength(191)
                    .HasColumnName("add_receipt");

                entity.Property(e => e.Amount)
                    .HasPrecision(16, 2)
                    .HasColumnName("amount");

                entity.Property(e => e.CategoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("category_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.PaymentMethod)
                    .HasColumnType("int(11)")
                    .HasColumnName("payment_method");

                entity.Property(e => e.Reference)
                    .HasMaxLength(191)
                    .HasColumnName("reference");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("roles");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.GuardName)
                    .HasMaxLength(191)
                    .HasColumnName("guard_name");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<SaturationDeduction>(entity =>
            {
                entity.ToTable("saturation_deductions");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("int(11)")
                    .HasColumnName("amount");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.DeductionOption)
                    .HasColumnType("int(11)")
                    .HasColumnName("deduction_option");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("employee_id");

                entity.Property(e => e.Title)
                    .HasMaxLength(191)
                    .HasColumnName("title");

                entity.Property(e => e.Type)
                    .HasMaxLength(191)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<SetSalary>(entity =>
            {
                entity.ToTable("set_salaries");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.ToTable("settings");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => new { e.Name, e.CreatedBy }, "settings_name_created_by_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Value)
                    .HasColumnType("text")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<Source>(entity =>
            {
                entity.ToTable("sources");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Stage>(entity =>
            {
                entity.ToTable("stages");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.Order)
                    .HasColumnType("int(11)")
                    .HasColumnName("order");

                entity.Property(e => e.PipelineId)
                    .HasColumnType("int(11)")
                    .HasColumnName("pipeline_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<StockReport>(entity =>
            {
                entity.ToTable("stock_reports");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.ProductId)
                    .HasColumnType("int(11)")
                    .HasColumnName("product_id");

                entity.Property(e => e.Quantity)
                    .HasColumnType("int(11)")
                    .HasColumnName("quantity");

                entity.Property(e => e.Type)
                    .HasMaxLength(191)
                    .HasColumnName("type");

                entity.Property(e => e.TypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("type_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Support>(entity =>
            {
                entity.ToTable("supports");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Attachment)
                    .HasMaxLength(191)
                    .HasColumnName("attachment");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.Priority)
                    .HasMaxLength(191)
                    .HasColumnName("priority");

                entity.Property(e => e.Status)
                    .HasMaxLength(191)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Subject)
                    .HasMaxLength(191)
                    .HasColumnName("subject");

                entity.Property(e => e.TicketCode)
                    .HasMaxLength(191)
                    .HasColumnName("ticket_code");

                entity.Property(e => e.TicketCreated)
                    .HasColumnType("int(11)")
                    .HasColumnName("ticket_created");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.User)
                    .HasColumnType("int(11)")
                    .HasColumnName("user");
            });

            modelBuilder.Entity<SupportReply>(entity =>
            {
                entity.ToTable("support_replies");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.IsRead)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_read");

                entity.Property(e => e.SupportId)
                    .HasColumnType("int(11)")
                    .HasColumnName("support_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.User)
                    .HasColumnType("int(11)")
                    .HasColumnName("user");
            });

            modelBuilder.Entity<TaskChecklist>(entity =>
            {
                entity.ToTable("task_checklists");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .HasColumnType("int(11)")
                    .HasColumnName("status");

                entity.Property(e => e.TaskId)
                    .HasColumnType("int(11)")
                    .HasColumnName("task_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserType)
                    .HasMaxLength(191)
                    .HasColumnName("user_type");
            });

            modelBuilder.Entity<TaskComment>(entity =>
            {
                entity.ToTable("task_comments");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("comment");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.TaskId)
                    .HasColumnType("int(11)")
                    .HasColumnName("task_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");

                entity.Property(e => e.UserType)
                    .HasMaxLength(191)
                    .HasColumnName("user_type");
            });

            modelBuilder.Entity<TaskFile>(entity =>
            {
                entity.ToTable("task_files");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Extension)
                    .HasMaxLength(191)
                    .HasColumnName("extension");

                entity.Property(e => e.File)
                    .HasMaxLength(191)
                    .HasColumnName("file");

                entity.Property(e => e.FileSize)
                    .HasMaxLength(191)
                    .HasColumnName("file_size");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.TaskId)
                    .HasColumnType("int(11)")
                    .HasColumnName("task_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserType)
                    .HasMaxLength(191)
                    .HasColumnName("user_type");
            });

            modelBuilder.Entity<TaskStage>(entity =>
            {
                entity.ToTable("task_stages");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Color)
                    .HasMaxLength(15)
                    .HasColumnName("color");

                entity.Property(e => e.Complete).HasColumnName("complete");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.Order)
                    .HasColumnType("int(11)")
                    .HasColumnName("order");

                entity.Property(e => e.ProjectId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("project_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Taxis>(entity =>
            {
                entity.ToTable("taxes");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.Rate)
                    .HasColumnType("text")
                    .HasColumnName("rate");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Termination>(entity =>
            {
                entity.ToTable("terminations");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasMaxLength(191)
                    .HasColumnName("description");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("employee_id");

                entity.Property(e => e.NoticeDate).HasColumnName("notice_date");

                entity.Property(e => e.TerminationDate).HasColumnName("termination_date");

                entity.Property(e => e.TerminationType)
                    .HasMaxLength(191)
                    .HasColumnName("termination_type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<TerminationType>(entity =>
            {
                entity.ToTable("termination_types");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<TimeTracker>(entity =>
            {
                entity.ToTable("time_trackers");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("end_time");

                entity.Property(e => e.IsActive)
                    .HasMaxLength(191)
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IsBillable)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_billable");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.ProjectId)
                    .HasColumnType("int(11)")
                    .HasColumnName("project_id");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("start_time");

                entity.Property(e => e.TagId)
                    .HasColumnType("text")
                    .HasColumnName("tag_id");

                entity.Property(e => e.TaskId)
                    .HasColumnType("int(11)")
                    .HasColumnName("task_id");

                entity.Property(e => e.TotalTime)
                    .HasMaxLength(191)
                    .HasColumnName("total_time")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Timesheet>(entity =>
            {
                entity.ToTable("timesheets");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.ProjectId)
                    .HasColumnType("int(11)")
                    .HasColumnName("project_id");

                entity.Property(e => e.TaskId)
                    .HasColumnType("int(11)")
                    .HasColumnName("task_id");

                entity.Property(e => e.Time)
                    .HasColumnType("time")
                    .HasColumnName("time");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<TrackPhoto>(entity =>
            {
                entity.ToTable("track_photos");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.ImgPath)
                    .HasMaxLength(191)
                    .HasColumnName("img_path");

                entity.Property(e => e.Status)
                    .HasMaxLength(191)
                    .HasColumnName("status");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");

                entity.Property(e => e.TrackId)
                    .HasColumnType("int(11)")
                    .HasColumnName("track_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<Trainer>(entity =>
            {
                entity.ToTable("trainers");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasColumnType("text")
                    .HasColumnName("address");

                entity.Property(e => e.Branch)
                    .HasMaxLength(191)
                    .HasColumnName("branch");

                entity.Property(e => e.Contact)
                    .HasMaxLength(191)
                    .HasColumnName("contact");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Email)
                    .HasMaxLength(191)
                    .HasColumnName("email");

                entity.Property(e => e.Expertise)
                    .HasColumnType("text")
                    .HasColumnName("expertise");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(191)
                    .HasColumnName("firstname");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(191)
                    .HasColumnName("lastname");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Training>(entity =>
            {
                entity.ToTable("trainings");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Branch)
                    .HasColumnType("int(11)")
                    .HasColumnName("branch");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.Employee)
                    .HasColumnType("int(11)")
                    .HasColumnName("employee");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.Performance)
                    .HasColumnType("int(11)")
                    .HasColumnName("performance");

                entity.Property(e => e.Remarks)
                    .HasColumnType("text")
                    .HasColumnName("remarks");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.Status)
                    .HasColumnType("int(11)")
                    .HasColumnName("status");

                entity.Property(e => e.Trainer)
                    .HasColumnType("int(11)")
                    .HasColumnName("trainer");

                entity.Property(e => e.TrainerOption)
                    .HasColumnType("int(11)")
                    .HasColumnName("trainer_option");

                entity.Property(e => e.TrainingCost)
                    .HasColumnType("double(8,2)")
                    .HasColumnName("training_cost");

                entity.Property(e => e.TrainingType)
                    .HasColumnType("int(11)")
                    .HasColumnName("training_type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<TrainingType>(entity =>
            {
                entity.ToTable("training_types");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable("transactions");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Account)
                    .HasColumnType("int(11)")
                    .HasColumnName("account");

                entity.Property(e => e.Amount)
                    .HasPrecision(16, 2)
                    .HasColumnName("amount");

                entity.Property(e => e.Category)
                    .HasMaxLength(191)
                    .HasColumnName("category");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.PaymentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("payment_id");

                entity.Property(e => e.Type)
                    .HasMaxLength(191)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");

                entity.Property(e => e.UserType)
                    .HasMaxLength(191)
                    .HasColumnName("user_type");
            });

            modelBuilder.Entity<Transfer>(entity =>
            {
                entity.ToTable("transfers");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.BranchId)
                    .HasColumnType("int(11)")
                    .HasColumnName("branch_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(191)
                    .HasColumnName("created_by");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("department_id");

                entity.Property(e => e.Description)
                    .HasMaxLength(191)
                    .HasColumnName("description");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("employee_id");

                entity.Property(e => e.TransferDate).HasColumnName("transfer_date");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Travel>(entity =>
            {
                entity.ToTable("travels");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(191)
                    .HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasMaxLength(191)
                    .HasColumnName("description");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("employee_id");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.PlaceOfVisit)
                    .HasMaxLength(191)
                    .HasColumnName("place_of_visit");

                entity.Property(e => e.PurposeOfVisit)
                    .HasMaxLength(191)
                    .HasColumnName("purpose_of_visit");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Email, "users_email_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.ActiveStatus).HasColumnName("active_status");

                entity.Property(e => e.Avatar)
                    .HasMaxLength(100)
                    .HasColumnName("avatar");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.DarkMode).HasColumnName("dark_mode");

                entity.Property(e => e.DefaultPipeline)
                    .HasColumnType("int(11)")
                    .HasColumnName("default_pipeline");

                entity.Property(e => e.DeleteStatus)
                    .HasColumnType("int(11)")
                    .HasColumnName("delete_status")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Email)
                    .HasMaxLength(191)
                    .HasColumnName("email");

                entity.Property(e => e.EmailVerifiedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("email_verified_at");

                entity.Property(e => e.IsActive)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Lang)
                    .HasMaxLength(100)
                    .HasColumnName("lang");

                entity.Property(e => e.LastLoginAt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_login_at");

                entity.Property(e => e.MessengerColor)
                    .HasMaxLength(191)
                    .HasColumnName("messenger_color")
                    .HasDefaultValueSql("'#2180f3'");

                entity.Property(e => e.Mode)
                    .HasMaxLength(10)
                    .HasColumnName("mode")
                    .HasDefaultValueSql("'light'");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(191)
                    .HasColumnName("password");

                entity.Property(e => e.Plan)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan");

                entity.Property(e => e.PlanExpireDate).HasColumnName("plan_expire_date");

                entity.Property(e => e.RememberToken)
                    .HasMaxLength(100)
                    .HasColumnName("remember_token");

                entity.Property(e => e.RequestedPlan)
                    .HasColumnType("int(11)")
                    .HasColumnName("requested_plan");

                entity.Property(e => e.Type)
                    .HasMaxLength(100)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<UserContact>(entity =>
            {
                entity.ToTable("user_contacts");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("parent_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<UserCoupon>(entity =>
            {
                entity.ToTable("user_coupons");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Coupon)
                    .HasColumnType("int(11)")
                    .HasColumnName("coupon");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Order)
                    .HasMaxLength(191)
                    .HasColumnName("order");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.User)
                    .HasColumnType("int(11)")
                    .HasColumnName("user");
            });

            modelBuilder.Entity<UserDeal>(entity =>
            {
                entity.ToTable("user_deals");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.DealId, "user_deals_deal_id_foreign");

                entity.HasIndex(e => e.UserId, "user_deals_user_id_foreign");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DealId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deal_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("user_id");

                entity.HasOne(d => d.Deal)
                    .WithMany(p => p.UserDeals)
                    .HasForeignKey(d => d.DealId)
                    .HasConstraintName("user_deals_deal_id_foreign");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserDeals)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("user_deals_user_id_foreign");
            });

            modelBuilder.Entity<UserEmailTemplate>(entity =>
            {
                entity.ToTable("user_email_templates");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.IsActive)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.TemplateId)
                    .HasColumnType("int(11)")
                    .HasColumnName("template_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<UserLead>(entity =>
            {
                entity.ToTable("user_leads");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.LeadId, "user_leads_lead_id_foreign");

                entity.HasIndex(e => e.UserId, "user_leads_user_id_foreign");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.LeadId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("lead_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("user_id");

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.UserLeads)
                    .HasForeignKey(d => d.LeadId)
                    .HasConstraintName("user_leads_lead_id_foreign");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserLeads)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("user_leads_user_id_foreign");
            });

            modelBuilder.Entity<UserToDo>(entity =>
            {
                entity.ToTable("user_to_dos");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.IsComplete).HasColumnName("is_complete");

                entity.Property(e => e.Title)
                    .HasMaxLength(191)
                    .HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<Vender>(entity =>
            {
                entity.ToTable("venders");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Email, "venders_email_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Avatar)
                    .HasMaxLength(100)
                    .HasColumnName("avatar")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Balance)
                    .HasColumnType("double(8,2)")
                    .HasColumnName("balance");

                entity.Property(e => e.BillingAddress)
                    .HasColumnType("text")
                    .HasColumnName("billing_address");

                entity.Property(e => e.BillingCity)
                    .HasMaxLength(191)
                    .HasColumnName("billing_city");

                entity.Property(e => e.BillingCountry)
                    .HasMaxLength(191)
                    .HasColumnName("billing_country");

                entity.Property(e => e.BillingName)
                    .HasMaxLength(191)
                    .HasColumnName("billing_name");

                entity.Property(e => e.BillingPhone)
                    .HasMaxLength(191)
                    .HasColumnName("billing_phone");

                entity.Property(e => e.BillingState)
                    .HasMaxLength(191)
                    .HasColumnName("billing_state");

                entity.Property(e => e.BillingZip)
                    .HasMaxLength(191)
                    .HasColumnName("billing_zip");

                entity.Property(e => e.Contact)
                    .HasMaxLength(191)
                    .HasColumnName("contact");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Email)
                    .HasMaxLength(191)
                    .HasColumnName("email");

                entity.Property(e => e.EmailVerifiedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("email_verified_at");

                entity.Property(e => e.IsActive)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Lang)
                    .HasMaxLength(191)
                    .HasColumnName("lang")
                    .HasDefaultValueSql("'en'");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(191)
                    .HasColumnName("password");

                entity.Property(e => e.RememberToken)
                    .HasMaxLength(100)
                    .HasColumnName("remember_token");

                entity.Property(e => e.ShippingAddress)
                    .HasMaxLength(191)
                    .HasColumnName("shipping_address");

                entity.Property(e => e.ShippingCity)
                    .HasMaxLength(191)
                    .HasColumnName("shipping_city");

                entity.Property(e => e.ShippingCountry)
                    .HasMaxLength(191)
                    .HasColumnName("shipping_country");

                entity.Property(e => e.ShippingName)
                    .HasMaxLength(191)
                    .HasColumnName("shipping_name");

                entity.Property(e => e.ShippingPhone)
                    .HasMaxLength(191)
                    .HasColumnName("shipping_phone");

                entity.Property(e => e.ShippingState)
                    .HasMaxLength(191)
                    .HasColumnName("shipping_state");

                entity.Property(e => e.ShippingZip)
                    .HasMaxLength(191)
                    .HasColumnName("shipping_zip");

                entity.Property(e => e.TaxNumber)
                    .HasMaxLength(191)
                    .HasColumnName("tax_number");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.VenderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("vender_id");
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.ToTable("warehouses");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasColumnType("text")
                    .HasColumnName("address");

                entity.Property(e => e.City)
                    .HasMaxLength(191)
                    .HasColumnName("city");

                entity.Property(e => e.CityZip)
                    .HasMaxLength(191)
                    .HasColumnName("city_zip");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<WarehouseProduct>(entity =>
            {
                entity.ToTable("warehouse_products");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.ProductId)
                    .HasColumnType("int(11)")
                    .HasColumnName("product_id");

                entity.Property(e => e.Quantity)
                    .HasColumnType("int(11)")
                    .HasColumnName("quantity");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.WarehouseId)
                    .HasColumnType("int(11)")
                    .HasColumnName("warehouse_id");
            });

            modelBuilder.Entity<Warning>(entity =>
            {
                entity.ToTable("warnings");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(191)
                    .HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasMaxLength(191)
                    .HasColumnName("description");

                entity.Property(e => e.Subject)
                    .HasMaxLength(191)
                    .HasColumnName("subject");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.WarningBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("warning_by");

                entity.Property(e => e.WarningDate).HasColumnName("warning_date");

                entity.Property(e => e.WarningTo)
                    .HasColumnType("int(11)")
                    .HasColumnName("warning_to");
            });

            modelBuilder.Entity<ZoomMeeting>(entity =>
            {
                entity.ToTable("zoom_meetings");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.ClientId)
                    .HasColumnType("int(11)")
                    .HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Duration)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration");

                entity.Property(e => e.JoinUrl)
                    .HasMaxLength(191)
                    .HasColumnName("join_url");

                entity.Property(e => e.MeetingId)
                    .HasColumnType("int(11)")
                    .HasColumnName("meeting_id");

                entity.Property(e => e.Password)
                    .HasMaxLength(191)
                    .HasColumnName("password");

                entity.Property(e => e.ProjectId)
                    .HasColumnType("int(11)")
                    .HasColumnName("project_id");

                entity.Property(e => e.StartDate)
                    .HasColumnType("timestamp")
                    .HasColumnName("start_date")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.StartUrl)
                    .HasColumnType("text")
                    .HasColumnName("start_url");

                entity.Property(e => e.Status)
                    .HasMaxLength(191)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'waiting'");

                entity.Property(e => e.Title)
                    .HasMaxLength(191)
                    .HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasMaxLength(191)
                    .HasColumnName("user_id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
