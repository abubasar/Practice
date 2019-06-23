using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCore.Models
{
    public class Enrollment
    {
        [Key]
        public string Id { get; set; }
        public string TraineeId { get; set; }
        public string CourseId { get; set; }
        [ForeignKey("TraineeId")]
        public virtual Trainee Trainee { get; set; }
        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }
    
    }
}
