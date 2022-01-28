using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DemoApiUsingJWT.DbModels
{
    public partial class CoreDbContext : DbContext
    {
        public CoreDbContext()
        {

        }

        public CoreDbContext(DbContextOptions<CoreDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AskQuery> AskQueries { get; set; } = null!;
        public virtual DbSet<ExceptionLogger> ExceptionLoggers { get; set; } = null!;
        public virtual DbSet<TblAdmin> TblAdmins { get; set; } = null!;
        public virtual DbSet<TblBranch> TblBranches { get; set; } = null!;
        public virtual DbSet<TblCourse> TblCourses { get; set; } = null!;
        public virtual DbSet<TblDepartment> TblDepartments { get; set; } = null!;
        public virtual DbSet<TblNewPost> TblNewPosts { get; set; } = null!;
        public virtual DbSet<TblStudentAcademic> TblStudentAcademics { get; set; } = null!;
        public virtual DbSet<TblStudentDiploma> TblStudentDiplomas { get; set; } = null!;
        public virtual DbSet<TblStudentHsc> TblStudentHscs { get; set; } = null!;
        public virtual DbSet<TblStudentPostGraduate> TblStudentPostGraduates { get; set; } = null!;
        public virtual DbSet<TblStudentProfile> TblStudentProfiles { get; set; } = null!;
        public virtual DbSet<TblStudentRegister> TblStudentRegisters { get; set; } = null!;
        public virtual DbSet<TblStudentSsc> TblStudentSscs { get; set; } = null!;
        public virtual DbSet<TblStudentUndertGraduate> TblStudentUndertGraduates { get; set; } = null!;
        public virtual DbSet<TblTnpmemberProfile> TblTnpmemberProfiles { get; set; } = null!;
        public virtual DbSet<TblTnpmemberRegister> TblTnpmemberRegisters { get; set; } = null!;
        public object TblStudentRegister { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(LocalDb)\\MsSQLLocalDB;Database=LNCT_TNP_DB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Latin1_General_CI_AI");

            modelBuilder.Entity<AskQuery>(entity =>
            {
                entity.HasOne(d => d.Student)
                    .WithMany(p => p.AskQueries)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__AskQuery__Studen__3C34F16F");
            });

            modelBuilder.Entity<TblAdmin>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TblBranch>(entity =>
            {
                entity.HasKey(e => e.BranchId)
                    .HasName("PK__TblBranc__A1682FC58D00D1D9");
            });

            modelBuilder.Entity<TblCourse>(entity =>
            {
                entity.HasKey(e => e.CourseId)
                    .HasName("PK__TblCours__C92D71A7F30B37FC");
            });

            modelBuilder.Entity<TblDepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentId)
                    .HasName("PK__TblDepar__B2079BEDE5DCDBB3");
            });

            modelBuilder.Entity<TblStudentAcademic>(entity =>
            {
                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TblStudentAcademics)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK__TblStuden__Branc__72C60C4A");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.TblStudentAcademics)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__TblStuden__Cours__71D1E811");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.TblStudentAcademics)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK__TblStuden__Depar__70DDC3D8");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.TblStudentAcademics)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__TblStuden__Stude__6FE99F9F");
            });

            modelBuilder.Entity<TblStudentDiploma>(entity =>
            {
                entity.HasOne(d => d.Student)
                    .WithMany(p => p.TblStudentDiplomas)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__TblStuden__Stude__25869641");
            });

            modelBuilder.Entity<TblStudentHsc>(entity =>
            {
                entity.HasOne(d => d.Student)
                    .WithMany(p => p.TblStudentHscs)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__TblStuden__Stude__1FCDBCEB");
            });

            modelBuilder.Entity<TblStudentPostGraduate>(entity =>
            {
                entity.HasOne(d => d.Student)
                    .WithMany(p => p.TblStudentPostGraduates)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__TblStuden__Stude__286302EC");
            });

            modelBuilder.Entity<TblStudentProfile>(entity =>
            {
                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TblStudentProfiles)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK__TblStuden__Branc__1B0907CE");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.TblStudentProfiles)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__TblStuden__Cours__1CF15040");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.TblStudentProfiles)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK__TblStuden__Depar__1BFD2C07");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.TblStudentProfiles)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__TblStuden__Stude__1A14E395");
            });

            modelBuilder.Entity<TblStudentRegister>(entity =>
            {
                entity.HasKey(e => e.StudentId)
                    .HasName("PK__TblStude__32C52A79473CC2D1");
            });

            modelBuilder.Entity<TblStudentSsc>(entity =>
            {
                entity.HasOne(d => d.Student)
                    .WithMany(p => p.TblStudentSscs)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__TblStuden__Stude__22AA2996");
            });

            modelBuilder.Entity<TblStudentUndertGraduate>(entity =>
            {
                entity.HasOne(d => d.Student)
                    .WithMany(p => p.TblStudentUndertGraduates)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__TblStuden__Stude__2B3F6F97");
            });

            modelBuilder.Entity<TblTnpmemberProfile>(entity =>
            {
                entity.HasKey(e => e.TnpmemberId)
                    .HasName("PK__TblTNPMe__20F5CC633E20AB96");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.TblTnpmemberProfiles)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK__TblTNPMem__Depar__34C8D9D1");
            });

            modelBuilder.Entity<TblTnpmemberRegister>(entity =>
            {
                entity.HasKey(e => e.Tnpid)
                    .HasName("PK__TblTNPMe__FD33620C8B33AD7D");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
