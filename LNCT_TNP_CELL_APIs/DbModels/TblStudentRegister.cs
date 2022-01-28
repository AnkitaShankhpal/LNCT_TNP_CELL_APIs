using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DemoApiUsingJWT.DbModels
{
    [Table("TblStudentRegister")]
    public partial class TblStudentRegister
    {
        public TblStudentRegister()
        {
            AskQueries = new HashSet<AskQuery>();
            TblStudentAcademics = new HashSet<TblStudentAcademic>();
            TblStudentDiplomas = new HashSet<TblStudentDiploma>();
            TblStudentHscs = new HashSet<TblStudentHsc>();
            TblStudentPostGraduates = new HashSet<TblStudentPostGraduate>();
            TblStudentProfiles = new HashSet<TblStudentProfile>();
            TblStudentSscs = new HashSet<TblStudentSsc>();
            TblStudentUndertGraduates = new HashSet<TblStudentUndertGraduate>();
        }

        [Key]
        [Column("StudentID")]
        public int StudentId { get; set; }
        public string? EnrollmentNo { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Password { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Name { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedOn { get; set; }

        [InverseProperty(nameof(AskQuery.Student))]
        public virtual ICollection<AskQuery> AskQueries { get; set; }
        [InverseProperty(nameof(TblStudentAcademic.Student))]
        public virtual ICollection<TblStudentAcademic> TblStudentAcademics { get; set; }
        [InverseProperty(nameof(TblStudentDiploma.Student))]
        public virtual ICollection<TblStudentDiploma> TblStudentDiplomas { get; set; }
        [InverseProperty(nameof(TblStudentHsc.Student))]
        public virtual ICollection<TblStudentHsc> TblStudentHscs { get; set; }
        [InverseProperty(nameof(TblStudentPostGraduate.Student))]
        public virtual ICollection<TblStudentPostGraduate> TblStudentPostGraduates { get; set; }
        [InverseProperty(nameof(TblStudentProfile.Student))]
        public virtual ICollection<TblStudentProfile> TblStudentProfiles { get; set; }
        [InverseProperty(nameof(TblStudentSsc.Student))]
        public virtual ICollection<TblStudentSsc> TblStudentSscs { get; set; }
        [InverseProperty(nameof(TblStudentUndertGraduate.Student))]
        public virtual ICollection<TblStudentUndertGraduate> TblStudentUndertGraduates { get; set; }
    }
}
