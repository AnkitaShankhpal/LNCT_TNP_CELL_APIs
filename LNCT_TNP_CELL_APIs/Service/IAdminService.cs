using DemoApiUsingJWT.Request;

namespace DemoApiUsingJWT.Service
{
    public interface IAdminService
    {
        void AddStudent(StudentRegisterRequestModel model);
        List<StudentRegisterRequestModel> GetAllStudents();
        StudentRegisterRequestModel GetStudent(int id);
        bool UpdateStudent(int id, StudentRegisterRequestModel model);
        StudentRegisterRequestModel DeleteStudent(int id);

        void AddTNPMember(TnpMemberRegisterRequestModel model);
        List<TnpMemberRegisterRequestModel> GetAllTNPMember();
        TnpMemberRegisterRequestModel GetTNPMember(int id);
        bool UpdateTNPMember(TnpMemberRegisterRequestModel model);
        TnpMemberRegisterRequestModel DeleteTnpMember(int id);
      
    }
}
