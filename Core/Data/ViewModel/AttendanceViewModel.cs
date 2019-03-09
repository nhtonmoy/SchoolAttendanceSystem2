using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.ViewModel
{
    public class AttendanceViewModel
    {
        public long AttendanceId { get; set; }
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public int ClassSectionId { get; set; }
        public string SectionName { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string IdNumber { get; set; }
        public int Roll { get; set; }
        public bool IsAttend { get; set; }
        public DateTime AttendanceDate { get; set; }

    }
}
