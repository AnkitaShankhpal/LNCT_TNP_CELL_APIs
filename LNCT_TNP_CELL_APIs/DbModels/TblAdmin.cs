using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DemoApiUsingJWT.DbModels
{
    [Keyless]
    [Table("TblAdmin")]
    public partial class TblAdmin
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string? Name { get; set; }
        [StringLength(60)]
        public string? EmailAddress { get; set; }
        [StringLength(50)]
        public string? Password { get; set; }
    }
}
