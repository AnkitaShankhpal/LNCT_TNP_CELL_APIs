using DemoApiUsingJWT.Request;

namespace DemoApiUsingJWT.Service
{
    public interface IStudentAcademicService
    {
        void  AddStudentAcademic(StudentAcademicRequestModel studentAcademic);

        StudentAcademicRequestModel GetStudentAcademic(int id);

        List<StudentAcademicRequestModel> GetAllStudentAcademic();

        StudentAcademicRequestModel DeleteStudentAcademic(int id);

        bool UpdatedStudentAcademic(StudentAcademicRequestModel studentAcademic);
    }
}
