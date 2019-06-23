namespace Crud.Models
{
    using System;
    using System.Collections.Generic;

    public partial class tblStudents
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Regno { get; set; }
        public Nullable<int> GradeId { get; set; }

        public virtual tblGrades tblGrades { get; set; }
    }
}
