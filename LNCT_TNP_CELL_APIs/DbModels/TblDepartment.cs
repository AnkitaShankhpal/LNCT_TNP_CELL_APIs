using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DemoApiUsingJWT.DbModels
{
    [Table("TblDepartment")]
    public partial class TblDepartment
    {
        public TblDepartment()
        {
            TblStudentAcademics = new HashSet<TblStudentAcademic>();
            TblStudentProfiles = new HashSet<TblStudentProfile>();
            TblTnpmemberProfiles = new HashSet<TblTnpmemberProfile>();
        }

        [Key]
        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }

        [InverseProperty(nameof(TblStudentAcademic.Department))]
        public virtual ICollection<TblStudentAcademic> TblStudentAcademics { get; set; }
        [InverseProperty(nameof(TblStudentProfile.Department))]
        public virtual ICollection<TblStudentProfile> TblStudentProfiles { get; set; }
        [InverseProperty(nameof(TblTnpmemberProfile.Department))]
        public virtual ICollection<TblTnpmemberProfile> TblTnpmemberProfiles { get; set; }
    }
}
