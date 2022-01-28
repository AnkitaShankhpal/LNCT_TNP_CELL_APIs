using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DemoApiUsingJWT.DbModels
{
    [Table("TblStudentSSC")]
    public partial class TblStudentSsc
    {
        [Key]
        public int Id { get; set; }
        public string? Percentage { get; set; }
        public string? SchoolName { get; set; }
        public string? Board { get; set; }
        [Column("StudentID")]
        public int? StudentId { get; set; }
        [Column("YOP", TypeName = "date")]
        public DateTime? Yop { get; set; }

        [ForeignKey(nameof(StudentId))]
        [InverseProperty(nameof(TblStudentRegister.TblStudentSscs))]
        public virtual TblStudentRegister? Student { get; set; }
    }
}
