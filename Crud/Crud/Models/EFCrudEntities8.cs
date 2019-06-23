namespace Crud.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class EFCrudEntities8 : DbContext
    {
        public EFCrudEntities8()
            : base("name=EFCrudEntities8")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<tblGrades> tblGrades { get; set; }
        public virtual DbSet<tblMark> tblMark { get; set; }
        public virtual DbSet<tblStudents> tblStudents { get; set; }
    }
}
