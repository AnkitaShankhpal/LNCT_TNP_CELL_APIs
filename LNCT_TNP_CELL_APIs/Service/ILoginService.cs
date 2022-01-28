namespace DemoApiUsingJWT.Service
{
    public interface ILoginService 
    {
        string Student_Login(string EnrollmentNo, string password);

        string TNP_Login(string userName, string password);

        string Admin_Login(string userName, string password);
    }
}
