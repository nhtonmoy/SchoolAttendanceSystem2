using Core.Data.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.ViewModel
{
    public class ClassSectionSubjectViewModel
    {
        public int ClassSectionId { get; set; }
        public List<Subject> SubjectList { get; set; }
    }
}
