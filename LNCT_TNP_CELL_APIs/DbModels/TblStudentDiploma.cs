using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DemoApiUsingJWT.DbModels
{
    [Table("TblStudentDiploma")]
    public partial class TblStudentDiploma
    {
        [Key]
        public int Id { get; set; }
        public string? Percentage { get; set; }
        [Column("YOP", TypeName = "date")]
        public DateTime? Yop { get; set; }
        [Column("StudentID")]
        public int? StudentId { get; set; }

        [ForeignKey(nameof(StudentId))]
        [InverseProperty(nameof(TblStudentRegister.TblStudentDiplomas))]
        public virtual TblStudentRegister? Student { get; set; }
    }
}
