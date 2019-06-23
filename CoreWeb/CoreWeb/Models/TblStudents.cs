using System;
using System.Collections.Generic;

namespace CoreWeb.Models
{
    public partial class TblStudents
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Regno { get; set; }
        public int? GradeId { get; set; }

        public virtual TblGrades Grade { get; set; }
    }
}
