using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DemoApiUsingJWT.DbModels
{
    [Table("TblStudentPostGraduate")]
    public partial class TblStudentPostGraduate
    {
        [Key]
        public int Id { get; set; }
        public string? Percentage { get; set; }
        [Column("YOP", TypeName = "date")]
        public DateTime? Yop { get; set; }
        public string? Back { get; set; }
        public int? YearGap { get; set; }
        [Column("StudentID")]
        public int? StudentId { get; set; }

        [ForeignKey(nameof(StudentId))]
        [InverseProperty(nameof(TblStudentRegister.TblStudentPostGraduates))]
        public virtual TblStudentRegister? Student { get; set; }
    }
}
