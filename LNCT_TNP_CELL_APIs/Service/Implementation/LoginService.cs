using DemoApiUsingJWT.Repository;

namespace DemoApiUsingJWT.Service.Implementation
{
    public class LoginService : ILoginService
    {
        private ILoginRepository _loginRepository;

        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
        public string Admin_Login(string userName, string password)
        {

            return _loginRepository.Admin_Login(userName, password);
        }

        public string Student_Login(string EnrollmentNo, string password)
        {
            return _loginRepository.Student_Login(EnrollmentNo, password);
        }

        public string TNP_Login(string userName, string password)
        {
            return _loginRepository.TNP_Login(userName, password);
        }
    }
}
