//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Data.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Exam
    {
        public Exam()
        {
            this.Marks = new HashSet<Mark>();
        }
    
        public int ExamId { get; set; }
        public string ExamName { get; set; }
        public bool IsActive { get; set; }
        public double FinalPercentage { get; set; }
    
        public virtual ICollection<Mark> Marks { get; set; }
    }
}