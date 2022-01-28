using DemoApiUsingJWT.DbModels;

namespace DemoApiUsingJWT.Repository
{
    public interface IStudentAcademicRepository
    {
        void AddStudentAcademic(TblStudentAcademic tblStudentAcademic);
        List<TblStudentAcademic> GetAllStudentAcademic();

        TblStudentAcademic GetStudentAcademic(int id);

        bool UpdateStudentAcademic(TblStudentAcademic tblStudentAcademic);

        TblStudentAcademic DeleteStudentAcademic(int id);
    }
}
