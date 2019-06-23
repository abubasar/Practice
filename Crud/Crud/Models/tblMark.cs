using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crud.Models
{
    using System;
    using System.Collections.Generic;

    public partial class tblMark
    {
        public int Id { get; set; }
        public Nullable<int> Mark { get; set; }
        public Nullable<int> GradeId { get; set; }

        public virtual tblGrades tblGrades { get; set; }
    }
}