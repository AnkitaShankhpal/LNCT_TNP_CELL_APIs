using DemoApiUsingJWT.DbModels;
using DemoApiUsingJWT.Repository;
using DemoApiUsingJWT.Request;

namespace DemoApiUsingJWT.Service.Implementation
{
    public class AdminService : IAdminService
    {
        private IAdminRepository _admRepository;

        
        public AdminService(IAdminRepository adminRepository)
        {
            _admRepository = adminRepository;
        }
        public void AddStudent(StudentRegisterRequestModel model)
        {
            TblStudentRegister str = new TblStudentRegister();
            str.EnrollmentNo = model.EnrollmentNo;
            str.Password = model.Password;
            str.Name = model.Name;
            str.CreatedOn = DateTime.Now;
            _admRepository.AddStudent(str);
          
        }

        public void AddTNPMember(TnpMemberRegisterRequestModel model)
        {
            
            TblTnpmemberRegister tnp = new TblTnpmemberRegister();
            tnp.EmailId = model.EmailId;
            tnp.Name = model.Name;
            tnp.Password = model.Password;
            tnp.Department= model.Department;
            tnp.CreatedOn = DateTime.Now;
            _admRepository.AddTNPMember(tnp);
          
        }

        public StudentRegisterRequestModel DeleteStudent(int id)
        {
            StudentRegisterRequestModel stdDelete = new StudentRegisterRequestModel();
            var result = _admRepository.DeleteStudent(id);
            stdDelete.EnrollmentNo = result.EnrollmentNo;
            stdDelete.Name = result.Name;
            stdDelete.Password = result.Password;


            return stdDelete;
        }

        public List<StudentRegisterRequestModel> GetAllStudents()
        {
            List<StudentRegisterRequestModel> list = new List<StudentRegisterRequestModel>();
            var result = _admRepository.GetAllStudents();
            foreach (var item in result)
            {
                StudentRegisterRequestModel str = new StudentRegisterRequestModel();
                str.StudentId= item.StudentId;
                str.Name = item.Name;
                str.EnrollmentNo = item.EnrollmentNo;
                str.Password = item.Password;
                list.Add(str);
            }
            return list;
        }

        public List<TnpMemberRegisterRequestModel> GetAllTNPMember()
        {
            List<TnpMemberRegisterRequestModel> list = new List<TnpMemberRegisterRequestModel>();
            var result = _admRepository.GetAllTNPMember();
            foreach (var item in result)
            { 
                TnpMemberRegisterRequestModel tnp = new TnpMemberRegisterRequestModel();
                tnp.Tnpid = item.Tnpid;
                tnp.EmailId= item.EmailId;
                tnp.Name = item.Name;
                tnp.Password = item.Password;
                tnp.Department= item.Department;
                list.Add(tnp);
            }
            return list;
        }

        public StudentRegisterRequestModel GetStudent(int id)
        {
            StudentRegisterRequestModel str = new StudentRegisterRequestModel();
            var result = _admRepository.GetStudent(id);
            str.StudentId = result.StudentId;
            str.Name = result.Name;
            str.EnrollmentNo = result.EnrollmentNo;
            str.Password = result.Password;

            return str;
        }

        public TnpMemberRegisterRequestModel GetTNPMember(int id)
        {
            TnpMemberRegisterRequestModel tnp = new TnpMemberRegisterRequestModel();
            var result = _admRepository.GetTNPMember(id);
            tnp.Tnpid = result.Tnpid;
            tnp.EmailId= result.EmailId;
            tnp.Name= result.Name;
            tnp.Password= result.Password;
            tnp.Department = result.Department;

            return tnp;
        }

        public bool UpdateStudent(int id, StudentRegisterRequestModel model)
        {
            TblStudentRegister str = new TblStudentRegister();
           
            str.Name = model.Name;
            str.EnrollmentNo = model.EnrollmentNo;
            str.Password = model.Password;
            str.ModifiedOn = DateTime.Now;
            return (_admRepository.UpdateStudent(id, str));
        }

        public bool UpdateTNPMember(TnpMemberRegisterRequestModel model)
        {
            TblTnpmemberRegister tnp = new TblTnpmemberRegister();
            tnp.Tnpid = model.Tnpid;
            tnp.EmailId = model.EmailId;
            tnp.Name = model.Name;
            tnp.Password= model.Password;
            tnp.Department= model.Department;
            return (_admRepository.UpdateTNPMember(tnp));
        }

        public TnpMemberRegisterRequestModel DeleteTnpMember(int id)
        {
            TnpMemberRegisterRequestModel delttTnp = new TnpMemberRegisterRequestModel();
            var result = _admRepository.DeleteTNPMember(id);
            delttTnp.EmailId = result.EmailId;
            delttTnp.Name=result.Name;
            delttTnp.Password = result.Password;
            delttTnp.Department= result.Department;

            return delttTnp;
        }

      
    }
}
