using System;
using System.Collections.Generic;

namespace CoreWeb.Models
{
    public partial class TblMark
    {
        public int Id { get; set; }
        public int? Mark { get; set; }
        public int? GradeId { get; set; }

        public virtual TblGrades Grade { get; set; }
    }
}
