//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyUniv.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            this.Enrollment = new HashSet<Enrollment>();
            this.CourseInstructor = new HashSet<CourseInstructor>();
        }
    
        public int CourseId { get; set; }
        public string Title { get; set; }
        public Nullable<int> Credits { get; set; }
        public Nullable<int> DepartmentId { get; set; }
    
        public virtual Course Course1 { get; set; }
        public virtual Course Course2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Enrollment> Enrollment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseInstructor> CourseInstructor { get; set; }
        public virtual Department Department { get; set; }
    }
}
