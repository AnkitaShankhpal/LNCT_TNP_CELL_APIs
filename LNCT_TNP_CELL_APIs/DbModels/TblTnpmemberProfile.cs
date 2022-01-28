using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DemoApiUsingJWT.DbModels
{
    [Table("TblTNPMemberProfile")]
    public partial class TblTnpmemberProfile
    {
        [Key]
        [Column("TNPMemberID")]
        public int TnpmemberId { get; set; }
        public string? Name { get; set; }
        [Column("DepartmentID")]
        public int? DepartmentId { get; set; }

        [ForeignKey(nameof(DepartmentId))]
        [InverseProperty(nameof(TblDepartment.TblTnpmemberProfiles))]
        public virtual TblDepartment? Department { get; set; }
    }
}
