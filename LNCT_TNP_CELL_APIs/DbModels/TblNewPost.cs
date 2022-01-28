using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DemoApiUsingJWT.DbModels
{
    [Table("TblNewPost")]
    public partial class TblNewPost
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Post { get; set; }
        public string? PostFile { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
    }
}
