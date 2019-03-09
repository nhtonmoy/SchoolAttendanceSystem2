using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.ViewModel
{
    public class ClassViewModel
    {
        public string ClassName { get; set; }
        public string IsActive { get; set; }
        public int ClassId { get; set; }
        public int OrderBy { get; set; }
    }
}
