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
    
    public partial class StudentClassSection
    {
        public int StudentClassSectionId { get; set; }
        public int ClassSectionId { get; set; }
        public int StudentId { get; set; }
        public int Roll { get; set; }
        public int YearId { get; set; }
        public int StatusId { get; set; }
    
        public virtual AcademicYear AcademicYear { get; set; }
        public virtual BaseData BaseData { get; set; }
        public virtual ClassSection ClassSection { get; set; }
        public virtual Student Student { get; set; }
    }
}
