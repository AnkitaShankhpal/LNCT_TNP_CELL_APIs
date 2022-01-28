using DemoApiUsingJWT.DbModels;

namespace DemoApiUsingJWT.Repository.Implementation
{
    public class LoginRepository : ILoginRepository
    {
         private CoreDbContext DbContext;

        public LoginRepository()
        {
            DbContext = new CoreDbContext();
        }
        public string Admin_Login(string userName, string password)
        {
            var result = DbContext.TblAdmins.FirstOrDefault(x => x.EmailAddress == userName && x.Password == password);
            var str = "Invalid UserName & Password:";
            if (result != null)
            {
                str = "Welcome";
                return str;
            }
            return str;
        }

        public string Student_Login(string EnrollmentNo, string password)
        {
            var result = DbContext.TblStudentRegisters.FirstOrDefault(x => x.EnrollmentNo == EnrollmentNo && x.Password == password);
            var str = "Invalid UserName & Password:";
            if (result != null)
            {
                str = "Welcome";
                return str;
            }
            return str;
        }

        public string TNP_Login(string userName, string password)
        {
            var result = DbContext.TblTnpmemberRegisters.FirstOrDefault(x => x.EmailId == userName && x.Password == password);
            var str = "Invalid UserName & Password:";
            if (result != null)
            {
                str = "Welcome";
                return str;
            }
            return str;
        }
    }
}
