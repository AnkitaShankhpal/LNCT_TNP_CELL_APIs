using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DemoApiUsingJWT.DbModels
{
    [Table("ExceptionLogger")]
    public partial class ExceptionLogger
    {
        [Key]
        public int Id { get; set; }
        public string? ExceptionMessage { get; set; }
        [StringLength(100)]
        public string? ControllerName { get; set; }
        public string? ExceptionStackTrace { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LogTime { get; set; }
    }
}
