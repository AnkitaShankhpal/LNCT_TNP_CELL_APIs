using DemoApiUsingJWT.DbModels;

namespace DemoApiUsingJWT.Repository.Implementation
{
    public class StudentAcademicRepository : IStudentAcademicRepository
    {
        private CoreDbContext DbContext;
        public StudentAcademicRepository()
        {
            DbContext = new CoreDbContext();
        }
        public void AddStudentAcademic(TblStudentAcademic tblStudentAcademic)
        {
            var studentExist = DbContext.TblStudentRegisters.FirstOrDefault(x => x.StudentId == tblStudentAcademic.StudentId);
            if (studentExist != null)
            {
                var studentAcademicDetailExist = DbContext.TblStudentProfiles.FirstOrDefault(x => x.StudentId== tblStudentAcademic.StudentId);
                if (studentAcademicDetailExist == null)
                {
                    DbContext.TblStudentAcademics.Add(tblStudentAcademic);
                    DbContext.SaveChanges();
                }
                
            }
            //DbContext.TblStudentAcademics.Add(tblStudentAcademic);
            //DbContext.SaveChanges();
        }

        public TblStudentAcademic DeleteStudentAcademic(int id)
        {
            var result= DbContext.TblStudentAcademics.FirstOrDefault(x => x.Id == id);
            if (result != null)
            { 
                DbContext.TblStudentAcademics.Remove(result);
                DbContext.SaveChanges();
                return result;
            }
            return result;
        }

        public List<TblStudentAcademic> GetAllStudentAcademic()
        {
            return DbContext.TblStudentAcademics.ToList();

        }

        public TblStudentAcademic GetStudentAcademic(int id)
        {
          var result=  DbContext.TblStudentAcademics.FirstOrDefault(x=>x.Id == id);
            return result;
        }

        public bool UpdateStudentAcademic(TblStudentAcademic tblStudentAcademic)
        {
          var result=  DbContext.TblStudentAcademics.FirstOrDefault(x=>x.Id == tblStudentAcademic.Id);
            if (result != null)
            {
                result.SscSchoolName = tblStudentAcademic.SscSchoolName;
                result.SscPercentage = tblStudentAcademic.SscPercentage;
                result.SscBoard=tblStudentAcademic.SscBoard;
                result.SscYop = tblStudentAcademic.SscYop;
                result.HscSchoolName = tblStudentAcademic.HscSchoolName;
                result.HscPercentage = tblStudentAcademic.HscPercentage;
                result.HscBoard = tblStudentAcademic.HscBoard;
                result.HscYop = tblStudentAcademic.HscYop;
                result.PgPercentage = tblStudentAcademic.PgPercentage;
                result.PgYearGap=tblStudentAcademic.PgYearGap;
                result.PgYop=tblStudentAcademic.PgYop;
                result.PgBack = tblStudentAcademic.PgBack;
                result.DiplomaPercentage = tblStudentAcademic.DiplomaPercentage;
                result.DiplomaYop = tblStudentAcademic.DiplomaYop;
                result.UgPercentage=tblStudentAcademic.UgPercentage;
                result.UgYearGap = tblStudentAcademic.UgYearGap;
                result.UgBack=tblStudentAcademic.UgBack;
                result.UgYop = tblStudentAcademic.PgYop;
                result.DepartmentId=tblStudentAcademic.DepartmentId;
                result.Department=tblStudentAcademic.Department;
                result.BranchId = tblStudentAcademic.BranchId;
                result.Branch = tblStudentAcademic.Branch;
                result.CourseId = tblStudentAcademic.CourseId;
                result.Course=tblStudentAcademic.Course;
                DbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
