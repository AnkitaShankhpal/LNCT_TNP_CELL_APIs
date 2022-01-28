using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DemoApiUsingJWT.DbModels
{
    public partial class TblStudentAcademic
    {
        [Key]
        public int Id { get; set; }
        [Column("StudentID")]
        public int? StudentId { get; set; }
        [Column("SSC_Percentage")]
        [StringLength(50)]
        public string? SscPercentage { get; set; }
        [Column("SSC_SchoolName")]
        [StringLength(100)]
        public string? SscSchoolName { get; set; }
        [Column("SSC_Board")]
        [StringLength(50)]
        public string? SscBoard { get; set; }
        [Column("SSC_YOP")]
        [StringLength(50)]
        public string? SscYop { get; set; }
        [Column("HSC_Percentage")]
        [StringLength(50)]
        public string? HscPercentage { get; set; }
        [Column("HSC_SchoolName")]
        [StringLength(100)]
        public string? HscSchoolName { get; set; }
        [Column("HSC_Board")]
        [StringLength(50)]
        public string? HscBoard { get; set; }
        [Column("HSC_YOP")]
        [StringLength(50)]
        public string? HscYop { get; set; }
        [Column("Diploma_Percentage")]
        [StringLength(50)]
        public string? DiplomaPercentage { get; set; }
        [Column("Diploma_YOP")]
        [StringLength(50)]
        public string? DiplomaYop { get; set; }
        [Column("UG_Percentage")]
        [StringLength(50)]
        public string? UgPercentage { get; set; }
        [Column("UG_YOP")]
        [StringLength(50)]
        public string? UgYop { get; set; }
        [Column("UG_Back")]
        [StringLength(50)]
        public string? UgBack { get; set; }
        [Column("UG_YearGap")]
        [StringLength(50)]
        public string? UgYearGap { get; set; }
        [Column("PG_Percentage")]
        [StringLength(50)]
        public string? PgPercentage { get; set; }
        [Column("PG_YOP")]
        [StringLength(50)]
        public string? PgYop { get; set; }
        [Column("PG_Back")]
        [StringLength(50)]
        public string? PgBack { get; set; }
        [Column("PG_YearGap")]
        [StringLength(50)]
        public string? PgYearGap { get; set; }
        [Column("DepartmentID")]
        public int? DepartmentId { get; set; }
        [Column("CourseID")]
        public int? CourseId { get; set; }
        [Column("BranchID")]
        public int? BranchId { get; set; }

        [ForeignKey(nameof(BranchId))]
        [InverseProperty(nameof(TblBranch.TblStudentAcademics))]
        public virtual TblBranch? Branch { get; set; }
        [ForeignKey(nameof(CourseId))]
        [InverseProperty(nameof(TblCourse.TblStudentAcademics))]
        public virtual TblCourse? Course { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        [InverseProperty(nameof(TblDepartment.TblStudentAcademics))]
        public virtual TblDepartment? Department { get; set; }
        [ForeignKey(nameof(StudentId))]
        [InverseProperty(nameof(TblStudentRegister.TblStudentAcademics))]
        public virtual TblStudentRegister? Student { get; set; }
       
    }
}
