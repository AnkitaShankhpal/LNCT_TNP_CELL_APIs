using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DemoApiUsingJWT.DbModels
{
    [Table("TblCourse")]
    public partial class TblCourse
    {
        public TblCourse()
        {
            TblStudentAcademics = new HashSet<TblStudentAcademic>();
            TblStudentProfiles = new HashSet<TblStudentProfile>();
        }

        [Key]
        public int CourseId { get; set; }
        public string? CourseName { get; set; }

        [InverseProperty(nameof(TblStudentAcademic.Course))]
        public virtual ICollection<TblStudentAcademic> TblStudentAcademics { get; set; }
        [InverseProperty(nameof(TblStudentProfile.Course))]
        public virtual ICollection<TblStudentProfile> TblStudentProfiles { get; set; }
    }
}
