using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCore.Models
{
    public class Course
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public int Credit { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
