using DemoApiUsingJWT.DbModels;
using DemoApiUsingJWT.Request;
using DemoApiUsingJWT.Repository;

namespace DemoApiUsingJWT.Repository.Implementation
{
    public class AdminRepository : IAdminRepository
    {
        private CoreDbContext DbContext;
        public AdminRepository()
        {
            DbContext = new CoreDbContext();
        }
        public void AddStudent(TblStudentRegister tblStudentRegister)
        {
            DbContext.TblStudentRegisters.Add(tblStudentRegister);
            DbContext.SaveChanges();
        }

        public List<TblStudentRegister> GetAllStudents()
        {
            var result = DbContext.TblStudentRegisters.ToList();
            return result;
        }

        public TblStudentRegister DeleteStudent(int id)
        {
            var deltStudent = DbContext.TblStudentRegisters.FirstOrDefault(x=>x.StudentId == id);
            if (deltStudent != null)
            {
                DbContext.TblStudentRegisters.Remove(deltStudent);
                DbContext.SaveChanges();
            }
            return deltStudent;
        }

       
        public TblStudentRegister GetStudent(int id)
        {
            var getStudent = DbContext.TblStudentRegisters.FirstOrDefault(x => x.StudentId == id);
            return getStudent;
        }

        public bool UpdateStudent(int id, TblStudentRegister tblStudentRegister)
        {
            var updateStudent = DbContext.TblStudentRegisters.FirstOrDefault(y => y.StudentId == id);
            if (updateStudent != null)
            { 
                updateStudent.EnrollmentNo = tblStudentRegister.EnrollmentNo;
                updateStudent.Password = tblStudentRegister.Password;
                updateStudent.Name = tblStudentRegister.Name;
                updateStudent.ModifiedOn = DateTime.Now;
                DbContext.SaveChanges();
                return true;
            }
           return false;
        }

        public void AddTNPMember(TblTnpmemberRegister tblTnpmember)
        {
           DbContext.TblTnpmemberRegisters.Add(tblTnpmember);
           DbContext.SaveChanges();
           //var getTnp = DbContext.TblTnpmemberRegisters.FirstOrDefault(x => x.Tnpid == tblTnpmember.Tnpid);
            //return getTnp;
        }

        public List<TblTnpmemberRegister> GetAllTNPMember()
        {
            var result = DbContext.TblTnpmemberRegisters.ToList();
            return result;
        }

        public TblTnpmemberRegister GetTNPMember(int id)
        {
            var getTNP = DbContext.TblTnpmemberRegisters.FirstOrDefault(x=>x.Tnpid == id);
            return getTNP;
        }

        public bool UpdateTNPMember(TblTnpmemberRegister tblTnpmember)
        {
            var updateTnp = DbContext.TblTnpmemberRegisters.FirstOrDefault(x=>x.Tnpid == tblTnpmember.Tnpid);
            if (updateTnp != null)
            { 
                updateTnp.Name= tblTnpmember.Name;
                updateTnp.Password= tblTnpmember.Password;
                updateTnp.Department= tblTnpmember.Department;
                updateTnp.EmailId= tblTnpmember.EmailId;
                updateTnp.ModifiedOn = DateTime.Now;
                DbContext.SaveChanges();
                return true;
             }
            return false;
        }

        public TblTnpmemberRegister DeleteTNPMember(int id)
        {
            var deltTnp = DbContext.TblTnpmemberRegisters.FirstOrDefault(x=>x.Tnpid == id);
            if (deltTnp != null)
            {
                DbContext.TblTnpmemberRegisters.Remove(deltTnp);
                DbContext.SaveChanges();
            }
            return deltTnp;
        }
    }
}
