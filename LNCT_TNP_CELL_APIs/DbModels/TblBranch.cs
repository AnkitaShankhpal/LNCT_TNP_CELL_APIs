using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DemoApiUsingJWT.DbModels
{
    [Table("TblBranch")]
    public partial class TblBranch
    {
        public TblBranch()
        {
            TblStudentAcademics = new HashSet<TblStudentAcademic>();
            TblStudentProfiles = new HashSet<TblStudentProfile>();
        }

        [Key]
        public int BranchId { get; set; }
        public string? BranchName { get; set; }

        [InverseProperty(nameof(TblStudentAcademic.Branch))]
        public virtual ICollection<TblStudentAcademic> TblStudentAcademics { get; set; }
        [InverseProperty(nameof(TblStudentProfile.Branch))]
        public virtual ICollection<TblStudentProfile> TblStudentProfiles { get; set; }
    }
}
