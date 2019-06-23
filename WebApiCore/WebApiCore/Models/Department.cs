using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCore.Models
{
    public class Department
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime EntryAt { get; set; }
        public virtual ICollection<Trainee> Trainees { get; set; }
    }
}
