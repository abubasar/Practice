using System;
using System.Collections.Generic;

namespace CoreWeb.Models
{
    public partial class TblGrades
    {
        public TblGrades()
        {
            TblMark = new HashSet<TblMark>();
            TblStudents = new HashSet<TblStudents>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TblMark> TblMark { get; set; }
        public virtual ICollection<TblStudents> TblStudents { get; set; }
    }
}
