using Core.Data.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.ViewModel
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string EmployeeNumber { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int GenderId { get; set; }
        public List<BaseData> GenderList { get; set; }
        public string Religion { get; set; }
        public int? BloodGroupId { get; set; }
        public List<BaseData> BloodGroupList { get; set; }
        public string Phone { get; set; }
        public DateTime JoinDate { get; set; }
        public string Address { get; set; }
        public int DesignationId { get; set; }
        public List<Designation> DesignationList { get; set; }
        public string DesignationName { get; set; }
        public List<Subject> SelectedExpertiseList { get; set; }
        public List<Subject> ExpertiseList { get; set; }
        public bool IsActive { get; set; }


    }
}
