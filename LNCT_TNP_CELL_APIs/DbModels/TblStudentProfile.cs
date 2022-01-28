using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DemoApiUsingJWT.DbModels
{
    [Table("TblStudentProfile")]
    public partial class TblStudentProfile
    {
        [Key]
        public int Id { get; set; }
        public string? EmailId { get; set; }
        public string? MobileNo { get; set; }
        public string? FatherName { get; set; }
        public string? CurrentAddress { get; set; }
        [Column("DOB", TypeName = "date")]
        public DateTime? Dob { get; set; }
        [Column("StudentID")]
        public int? StudentId { get; set; }
        [Column("BranchID")]
        public int? BranchId { get; set; }
        [Column("DepartmentID")]
        public int? DepartmentId { get; set; }
        [Column("CourseID")]
        public int? CourseId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedOn { get; set; }

        [ForeignKey(nameof(BranchId))]
        [InverseProperty(nameof(TblBranch.TblStudentProfiles))]
        public virtual TblBranch? Branch { get; set; }
        [ForeignKey(nameof(CourseId))]
        [InverseProperty(nameof(TblCourse.TblStudentProfiles))]
        public virtual TblCourse? Course { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        [InverseProperty(nameof(TblDepartment.TblStudentProfiles))]
        public virtual TblDepartment? Department { get; set; }
        [ForeignKey(nameof(StudentId))]
        [InverseProperty(nameof(TblStudentRegister.TblStudentProfiles))]
        public virtual TblStudentRegister? Student { get; set; }
    }
}
