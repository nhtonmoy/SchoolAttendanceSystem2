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
    
    public partial class Mark
    {
        public int MarksId { get; set; }
        public int ExamId { get; set; }
        public int StudentId { get; set; }
        public int ClassSectionSubjectId { get; set; }
        public double Marks { get; set; }
        public int YearId { get; set; }
        public int UpdateBy { get; set; }
    
        public virtual AcademicYear AcademicYear { get; set; }
        public virtual ClassSectionSubject ClassSectionSubject { get; set; }
        public virtual Exam Exam { get; set; }
        public virtual Student Student { get; set; }
        public virtual User User { get; set; }
    }
}