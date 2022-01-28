using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DemoApiUsingJWT.DbModels
{
    [Table("TblTNPMemberRegister")]
    public partial class TblTnpmemberRegister
    {
        [Key]
        [Column("TNPID")]
        public int Tnpid { get; set; }
        [StringLength(100)]
        public string? Name { get; set; }
        [Column("EmailID")]
        [StringLength(100)]
        public string? EmailId { get; set; }
        [StringLength(100)]
        public string? Password { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedOn { get; set; }
        [StringLength(50)]
        public string? Department { get; set; }
    }
}
