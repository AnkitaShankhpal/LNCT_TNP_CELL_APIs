using DemoApiUsingJWT.DbModels;

namespace DemoApiUsingJWT.Repository.Implementation
{
    public class StudentsProfileRepository: IStudentsProfileRepository
    {
       
            private CoreDbContext DbContext;
            public StudentsProfileRepository()
            {
                DbContext = new CoreDbContext();
            }
            public void AddStudentProfile(TblStudentProfile tblStudentProfile)
            {
                var studentExist = DbContext.TblStudentRegisters.FirstOrDefault(x => x.StudentId == tblStudentProfile.StudentId);
                if (studentExist != null)
                {
                    var studentProfileExist = DbContext.TblStudentProfiles.FirstOrDefault(x => x.StudentId == studentExist.StudentId);
                    if (studentProfileExist == null)
                    {
                        DbContext.TblStudentProfiles.Add(tblStudentProfile);
                        DbContext.SaveChanges();
                    }
                    //studentProfileExist is not null its mean studentProfile is already exist:
                }

            }

            public List<TblStudentProfile> GetAllStudentProfiles()
            {
                var result = DbContext.TblStudentProfiles.ToList();
                return result;
            }

            public TblStudentProfile GetStudentProfile(int id)
            {
                var result = DbContext.TblStudentProfiles.FirstOrDefault(x => x.Id == id);
                return result;
            }

            public bool UpdateStudentProfile(TblStudentProfile tblStudentProfile)
            {
                var result = DbContext.TblStudentProfiles.FirstOrDefault(x => x.Id == tblStudentProfile.Id);
                if (result != null)
                {
                    result.Department = tblStudentProfile.Department;
                    result.EmailId = tblStudentProfile.EmailId;
                    result.Dob = tblStudentProfile.Dob;
                    result.Branch = tblStudentProfile.Branch;
                    result.FatherName = tblStudentProfile.FatherName;
                    result.MobileNo = tblStudentProfile.MobileNo;
                    DbContext.SaveChanges();
                    return true;
                }
                return false;
            }

        public TblStudentProfile DeleteStudentProfile(int id)
        {
            var result = DbContext.TblStudentProfiles.FirstOrDefault(x => x.Id == id);
            if (result != null)
            {
                DbContext.TblStudentProfiles.Remove(result);
                DbContext.SaveChanges();
                return result;
            }
            return result;
        }

    }
    
}
