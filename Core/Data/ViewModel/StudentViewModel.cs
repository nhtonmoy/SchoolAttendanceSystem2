using Core.Data.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.ViewModel
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string IdNumber { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int GenderId { get; set; }
        public int? BloodGroupId { get; set; }
        public string Religion { get; set; }
        public string Phone { get; set; }
        public string FatherProfession { get; set; }
        public string MotherProfession { get; set; }
        public string Address{ get; set; }
        public bool IsActive { get; set; }
        public int ClassId { get; set; }
        public int SectionId { get; set; }
        public int RollNumber { get; set; }
        public int StatusId { get; set; }
        public string Email { get; set; }
        public string SectionName { get; set; }
        public List<ClassSection> Sections { get; set; }
        public List<Class> Classes { get; set; }
        

    }
}
