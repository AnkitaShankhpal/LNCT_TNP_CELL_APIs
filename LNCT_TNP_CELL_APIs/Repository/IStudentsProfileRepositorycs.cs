using DemoApiUsingJWT.DbModels;

namespace DemoApiUsingJWT.Repository
{
    public interface IStudentsProfileRepository
    {
        void AddStudentProfile(TblStudentProfile tblStudentProfile);
        bool UpdateStudentProfile(TblStudentProfile tblStudentProfile);

        List<TblStudentProfile> GetAllStudentProfiles();

        TblStudentProfile GetStudentProfile(int id);

         TblStudentProfile DeleteStudentProfile(int id);
    }
}
