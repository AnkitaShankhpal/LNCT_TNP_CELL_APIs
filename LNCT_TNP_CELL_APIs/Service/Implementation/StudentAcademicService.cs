using DemoApiUsingJWT.DbModels;
using DemoApiUsingJWT.Repository;
using DemoApiUsingJWT.Request;

namespace DemoApiUsingJWT.Service.Implementation
{
    public class StudentAcademicService : IStudentAcademicService
    {
        private IStudentAcademicRepository _studentAcademicRepository;

        public StudentAcademicService(IStudentAcademicRepository studentAcademicRepository)
        {
                _studentAcademicRepository = studentAcademicRepository;
        }
        public void AddStudentAcademic(StudentAcademicRequestModel studentAcademic)
        {
            TblStudentAcademic std = new TblStudentAcademic();
            std.StudentId  = studentAcademic.StudentId;
            std.SscSchoolName = studentAcademic.SscSchoolName;
            std.SscPercentage = studentAcademic.SscPercentage;
            std.SscBoard= studentAcademic.SscBoard;
            std.SscYop=studentAcademic.SscYop;
            std.HscSchoolName = studentAcademic.HscSchoolName;
            std.HscPercentage = studentAcademic.HscPercentage;
            std.HscBoard= studentAcademic.HscBoard;
            std.HscYop = studentAcademic.HscYop;
            std.PgPercentage = studentAcademic.PgPercentage;
            std.PgYearGap=studentAcademic.PgYearGap;
            std.PgYop=studentAcademic.PgYop;    
            std.PgBack=studentAcademic.PgBack;
            std.UgPercentage = studentAcademic.UgPercentage;
            std.UgYearGap = studentAcademic.UgYearGap;
            std.UgYop = studentAcademic.UgYop;
            std.UgBack=studentAcademic.UgBack;
            //std.DepartmentId= studentAcademic.DepartmentId;
           // std.CourseId =studentAcademic.CourseId;
           // std.BranchId = studentAcademic.BranchId;
            _studentAcademicRepository.AddStudentAcademic(std);
        }

        public StudentAcademicRequestModel DeleteStudentAcademic(int id)
        {
            StudentAcademicRequestModel deltstdAcd = new StudentAcademicRequestModel();
     
             var result =_studentAcademicRepository.DeleteStudentAcademic(id);
             deltstdAcd.BranchId = (int)result.BranchId;
            deltstdAcd.CourseId= (int)result.CourseId;
            deltstdAcd.DepartmentId= (int)result.DepartmentId;
            deltstdAcd.DiplomaPercentage = result.DiplomaPercentage;
            deltstdAcd.DiplomaYop   =result.DiplomaYop; 
            deltstdAcd.PgYearGap = result.PgYearGap;
            deltstdAcd.PgPercentage = result.PgPercentage;
            deltstdAcd.PgBack = result.PgBack;
            deltstdAcd.PgYop = result.PgYop;
            deltstdAcd.UgYearGap = result.UgYearGap;
            deltstdAcd.UgYop = result.UgYop;    
            deltstdAcd.UgBack=result.UgBack;
            deltstdAcd.SscSchoolName=result.SscSchoolName;
            deltstdAcd.SscPercentage=result.SscPercentage;
            deltstdAcd.SscBoard=result.SscBoard;
            deltstdAcd.SscYop=result.SscYop;
            deltstdAcd.HscSchoolName = result.HscSchoolName;
            deltstdAcd.HscPercentage = result.HscPercentage;
            deltstdAcd.HscBoard=result.HscBoard;
            deltstdAcd.HscYop=result.HscYop;
            return deltstdAcd;
           
        }

        public List<StudentAcademicRequestModel> GetAllStudentAcademic()
        {
            List<StudentAcademicRequestModel> list = new List<StudentAcademicRequestModel>();
            var result = _studentAcademicRepository.GetAllStudentAcademic();
            foreach (var item in result)
            {
                StudentAcademicRequestModel str = new StudentAcademicRequestModel();
                str.Id = item.Id;
                str.DiplomaPercentage = item.DiplomaPercentage;
                str.DiplomaYop = item.DiplomaYop;
                str.PgYearGap = item.PgYearGap;
                str.PgPercentage = item.PgPercentage;
                str.PgBack=item.PgBack;
                str.UgPercentage = item.UgPercentage;
                str.UgYearGap = item.UgYearGap;
                str.UgBack=item.UgBack;
                str.PgYop = item.PgYop; 
                str.SscSchoolName = item.SscSchoolName;
                str.SscPercentage = item.SscPercentage;
                str.SscBoard=item.SscBoard;
                str.SscYop=item.SscYop;
                str.HscSchoolName=item.HscSchoolName;
                str.HscPercentage=item.HscPercentage;
                str.HscBoard=item.HscBoard;
                str.HscYop=item.HscYop;
               // str.StudentId = item.StudentId;
                //str.DepartmentId = (int)item.DepartmentId;
                //str.CourseId = (int)item.CourseId;
                //str.BranchId = (int)item.BranchId;
              
                list.Add(str);
            }
            return list;
        }

        public StudentAcademicRequestModel GetStudentAcademic(int id)
        {
            StudentAcademicRequestModel str = new StudentAcademicRequestModel();
            var result = _studentAcademicRepository.GetStudentAcademic(id);
            str.DiplomaPercentage = result.DiplomaPercentage;
            str.DiplomaYop = result.DiplomaYop;
            str.PgYearGap = result.PgYearGap;
            str.PgPercentage = result.PgPercentage;
            str.PgBack = result.PgBack;
            str.UgPercentage = result.UgPercentage;
            str.UgYearGap = result.UgYearGap;
            str.UgBack = result.UgBack;
            str.PgYop = result.PgYop;
            str.SscSchoolName = result.SscSchoolName;
            str.SscPercentage = result.SscPercentage;
            str.SscBoard = result.SscBoard;
            str.SscYop = result.SscYop;
            str.HscSchoolName = result.HscSchoolName;
            str.HscPercentage = result.HscPercentage;
            str.HscBoard = result.HscBoard;
            str.HscYop = result.HscYop;
            
            return str;
        }

        public bool UpdatedStudentAcademic(StudentAcademicRequestModel model)
        {
            TblStudentAcademic str = new TblStudentAcademic();
            str.Id = model.Id;
            str.DiplomaPercentage = model.DiplomaPercentage;
            str.DiplomaYop = model.DiplomaYop;
            str.PgYearGap = model.PgYearGap;
            str.PgPercentage = model.PgPercentage;
            str.PgBack = model.PgBack;
            str.UgPercentage = model.UgPercentage;
            str.UgYearGap = model.UgYearGap;
            str.UgBack = model.UgBack;
            str.PgYop = model.PgYop;
            str.SscSchoolName = model.SscSchoolName;
            str.SscPercentage = model.SscPercentage;
            str.SscBoard = model.SscBoard;
            str.SscYop = model.SscYop;
            str.HscSchoolName = model.HscSchoolName;
            str.HscPercentage = model.HscPercentage;
            str.HscBoard = model.HscBoard;
            str.HscYop = model.HscYop;
            return (_studentAcademicRepository.UpdateStudentAcademic(str));
        }
    }
}
