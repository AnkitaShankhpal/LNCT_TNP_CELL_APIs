using DemoApiUsingJWT.Request;

namespace DemoApiUsingJWT.Service
{
    public interface IStudentsProfileService
    {

        void AddStudentProfile(StudentProfileRequestModel model);
        List<StudentProfileRequestModel> GetAllStudentProfile();

        StudentProfileRequestModel GetStudentProfile(int id);

        bool UpdateStudentProfile(StudentProfileRequestModel model);

        StudentProfileRequestModel DeleteStudentProfile(int id);
    }
}
