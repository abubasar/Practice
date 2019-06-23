using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoreWeb.Models
{
    public partial class EFCrudContext : DbContext
    {
        public EFCrudContext()
        {
        }

        public EFCrudContext(DbContextOptions<EFCrudContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblGrades> TblGrades { get; set; }
        public virtual DbSet<TblMark> TblMark { get; set; }
        public virtual DbSet<TblStudents> TblStudents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-NE4FIP0\\SOFTCODE;Database=EFCrud;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity<TblGrades>(entity =>
            {
                entity.ToTable("tblGrades");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TblMark>(entity =>
            {
                entity.ToTable("tblMark");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.TblMark)
                    .HasForeignKey(d => d.GradeId)
                    .HasConstraintName("FK__tblMark__GradeId__267ABA7A");
            });

            modelBuilder.Entity<TblStudents>(entity =>
            {
                entity.ToTable("tblStudents");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.TblStudents)
                    .HasForeignKey(d => d.GradeId)
                    .HasConstraintName("FK__tblStuden__Grade__276EDEB3");
            });
        }
    }
}
