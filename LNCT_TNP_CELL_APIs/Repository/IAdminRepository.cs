using DemoApiUsingJWT.DbModels;
using DemoApiUsingJWT.Request;

namespace DemoApiUsingJWT.Repository
{
    public interface IAdminRepository
    {
        void AddStudent(TblStudentRegister tblStudentRegister);
        List<TblStudentRegister> GetAllStudents();
        TblStudentRegister GetStudent(int id);
        bool UpdateStudent(int id, TblStudentRegister tblStudentRegister);
        TblStudentRegister DeleteStudent(int id);


        void AddTNPMember(TblTnpmemberRegister tblTnpmember);
        List<TblTnpmemberRegister> GetAllTNPMember();
        TblTnpmemberRegister GetTNPMember(int id);

        bool UpdateTNPMember(TblTnpmemberRegister tblTnpmember);

        TblTnpmemberRegister DeleteTNPMember(int id);
     
    }
}
