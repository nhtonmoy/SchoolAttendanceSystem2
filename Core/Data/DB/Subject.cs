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
    
    public partial class Subject
    {
        public Subject()
        {
            this.ClassSectionDayPeriodSubjects = new HashSet<ClassSectionDayPeriodSubject>();
            this.ClassSectionSubjects = new HashSet<ClassSectionSubject>();
            this.TeacherExpertises = new HashSet<TeacherExpertise>();
        }
    
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public bool IsActive { get; set; }
    
        public virtual ICollection<ClassSectionDayPeriodSubject> ClassSectionDayPeriodSubjects { get; set; }
        public virtual ICollection<ClassSectionSubject> ClassSectionSubjects { get; set; }
        public virtual ICollection<TeacherExpertise> TeacherExpertises { get; set; }
    }
}
