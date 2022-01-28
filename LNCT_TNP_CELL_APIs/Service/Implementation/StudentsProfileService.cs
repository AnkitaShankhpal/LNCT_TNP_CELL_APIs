using DemoApiUsingJWT.DbModels;
using DemoApiUsingJWT.Repository;
using DemoApiUsingJWT.Repository.Implementation;
using DemoApiUsingJWT.Request;

namespace DemoApiUsingJWT.Service.Implementation
{
    public class StudentsProfileService : IStudentsProfileService
    {
        private IStudentsProfileRepository _studentsProfileRepository;
        public StudentsProfileService(IStudentsProfileRepository studentsProfileRepository)
        {
            _studentsProfileRepository = studentsProfileRepository;
        }
        public void AddStudentProfile(StudentProfileRequestModel model)
        {
            TblStudentProfile tblStudentProfile = new TblStudentProfile();
            tblStudentProfile.Id = model.Id;
            tblStudentProfile.StudentId = model.StudentId;
            tblStudentProfile.FatherName = model.FatherName;
            tblStudentProfile.EmailId = model.EmailId;
            tblStudentProfile.MobileNo = model.MobileNo;
            tblStudentProfile.CurrentAddress = model.CurrentAddress;
            tblStudentProfile.CreatedOn = DateTime.Now;
            _studentsProfileRepository.AddStudentProfile(tblStudentProfile);
        }

        public List<StudentProfileRequestModel> GetAllStudentProfile()
        {
            List<StudentProfileRequestModel> List = new List<StudentProfileRequestModel>();
            var result = _studentsProfileRepository.GetAllStudentProfiles();
            foreach (var iteam in result)
            {
                StudentProfileRequestModel sprm = new StudentProfileRequestModel();
                sprm.Id = iteam.Id;
                sprm.FatherName = iteam.FatherName;
                sprm.EmailId = iteam.EmailId;
                sprm.MobileNo = iteam.MobileNo;
                sprm.CurrentAddress = iteam.CurrentAddress;
                sprm.CreatedOn = DateTime.Now;
                List.Add(sprm);
            }
            return List;
        }

        public StudentProfileRequestModel GetStudentProfile(int id)
        {
            StudentProfileRequestModel stprm = new StudentProfileRequestModel();
            var result = _studentsProfileRepository.GetStudentProfile(id);
            stprm.FatherName = result.FatherName;
            stprm.EmailId = result.EmailId;
            stprm.MobileNo = result.MobileNo;
            stprm.CurrentAddress = result.CurrentAddress;
            stprm.CreatedOn = DateTime.Now;

            return stprm;
        }

        public bool UpdateStudentProfile(StudentProfileRequestModel model)
        {
            TblStudentProfile tblStudent =  new TblStudentProfile();
            tblStudent.Id = model.Id;
            tblStudent.FatherName= model.FatherName;
            tblStudent.EmailId = model.EmailId;
            tblStudent.Dob = model.Dob;
            tblStudent.MobileNo= model.MobileNo;
            tblStudent.CurrentAddress= model.CurrentAddress;
            tblStudent.ModifiedOn = DateTime.Now;
            return(_studentsProfileRepository.UpdateStudentProfile(tblStudent));
        }

        public StudentProfileRequestModel DeleteStudentProfile(int id)
        {
            StudentProfileRequestModel deltstdAcd = new StudentProfileRequestModel();

            var result = _studentsProfileRepository.DeleteStudentProfile(id);
            deltstdAcd.FatherName = result.FatherName;
            deltstdAcd.ModifiedOn= DateTime.Now;
            deltstdAcd.CurrentAddress= result.CurrentAddress;
            deltstdAcd.EmailId=result.EmailId;
            //deltstdAcd.Dob = result.Dob;
            return deltstdAcd;

        }
    }
}
