using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DemoApiUsingJWT.DbModels
{
    [Table("AskQuery")]
    public partial class AskQuery
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string? SubjectOfQuery { get; set; }
        [Column("StudentID")]
        public int? StudentId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        public string? Problem { get; set; }

        [ForeignKey(nameof(StudentId))]
        [InverseProperty(nameof(TblStudentRegister.AskQueries))]
        public virtual TblStudentRegister? Student { get; set; }
    }
}
