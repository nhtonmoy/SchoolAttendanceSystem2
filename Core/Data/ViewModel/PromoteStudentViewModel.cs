using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.ViewModel
{
    public class PromoteStudentViewModel
    {
        public int PromotionHistoryId { get; set; }
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public int ClassSectionId { get; set; }
        public string SectionName { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string IdNumber { get; set; }
        public int Roll { get; set; }
        public int NextYearId { get; set; }
        public int CurrentYearId { get; set; }
        public bool IsPassed { get; set; }
        public int StatusId { get; set; }
        public int previousClassId { get; set; }
        public int? CurrentClassId { get; set; }
        public string Remarks { get; set; }

        //Todo: Edited
        public string ViewPromote { get { return "Promote"; } }
        public double AverageMarks { get; set; }
        public string IsProcessed { get; set; }

    }
}
