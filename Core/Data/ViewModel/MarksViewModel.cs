using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.ViewModel
{
    public class MarksViewModel
    {
        public int MarksId { get; set; }
        //change database field type to float
        public double Marks { get; set; }
        public int ClassSectionSubjectId { get; set; }
        public string Subject { get; set; }
        public int SubjectId { get; set; }
        public int StudentId { get; set; }
        public int ExamId { get; set; }
    }
}
