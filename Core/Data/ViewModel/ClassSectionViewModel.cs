using Core.Data.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.ViewModel
{
    public class ClassSectionViewModel
    {
        public int ClassSectionId { get; set; }
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public string SectionName { get; set; }
        public string IsActive { get; set; }
        public int ClassTeacherId { get; set; }
        public string TeacherName { get; set; }
        public bool TeacherIsActive { get; set; }
    }
}
