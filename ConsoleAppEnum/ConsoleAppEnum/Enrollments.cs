//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleAppEnum
{
    using System;
    using System.Collections.Generic;
    
    public partial class Enrollments
    {
        public string Id { get; set; }
        public string StudentId { get; set; }
        public string CourseId { get; set; }
        public bool IsPaid { get; set; }
        public double PaidTotal { get; set; }
        public double Due { get; set; }
        public bool IsCompleted { get; set; }
        public Nullable<int> CompletedContent { get; set; }
        public System.DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual Courses Courses { get; set; }
        public virtual Students Students { get; set; }
    }
}