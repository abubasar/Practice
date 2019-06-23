using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyUniv.Models
{
        public class StudentMetadata
        {
            [Required]
            [StringLength(50)]
            [Display(Name = "Last Name")]
            public string LastName;
            [Required]
            [StringLength(50)]
            [Display(Name = "First Name")]
            public string FirstName;

            [StringLength(50)]
            [Display(Name = "Middle Name")]
            public string MiddleName;
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
            [Display(Name = "Enrollment Date")]
            public Nullable<System.DateTime> EnrollmentDate;

        
    }

        public class EnrollmentMetadata
        {
            [Range(0, 4)]
            public Nullable<decimal> Grade;
        }
    }

