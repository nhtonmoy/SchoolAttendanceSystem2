using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.ViewModel
{
    public class ExamViewModel
    {
        public int ExamId { get; set; }
        public string ExamName { get; set; }
        public string IsActive { get; set; }
        public double FinalPercentage { get; set; }
    }
}
