using Core.Data.DB;
using Core.Data.ViewModel;
using Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service
{
    public class EmployeeService
    {
        private readonly Entities _db = FactoryDB.GetDB();
        private CommonService _commonService = new CommonService();
        public List<BaseData> GetBaseDataByCatagory(string category)
        {
            return _db.BaseDatas.Where(x => x.Category == category).ToList();
        }

        public bool AddNewStaff(EmployeeViewModel employee)
        {
            var person = _db.People.Add(new Person
            {
                Name = employee.Name,
                BirthDate = employee.DateOfBirth,
                GenderId = employee.GenderId,
                CreatedDate = DateTime.Now,
                BloodGroupId = employee.BloodGroupId,
                Religion = employee.Religion,
                Address = employee.Address,
                CreatedBy = CommonService.userInfo.UserId
            });

            var user = _db.Users.Add(new User
            {
                Username = employee.Username,
                Password = employee.Password,
                Email = employee.Email,
                UserTypeId = GetBaseDataByCatagory(EnumBaseData.UserType.ToString()).First(x => x.Value == EnumUserType.Staff.ToString()).Id
            });

            var emp = _db.Employees.Add(new Employee
            {
                PersonId = person.PersonId,
                Phone = employee.Phone,
                JoinDate = employee.JoinDate,
                IdNumber = _commonService.GenerateIdNumber("SF"),
                IsActive = employee.IsActive

            });
            var staff = _db.Staffs.Add(new Staff
            {
                UserId=user.UserId,
                EmployeeId=emp.EmployeeId
            });
            try
            {
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            employee.Id = staff.StaffId;
            return true;
        }

        public List<ClassSectionViewModel> GetTeacherListForClassSection()
        {
            var list = (from e in _db.Employees
                        join p in _db.People
                        on e.PersonId equals p.PersonId
                        join t in _db.Teachers
                        on e.EmployeeId equals t.EmployeeId
                        select new ClassSectionViewModel { TeacherName = p.Name, ClassTeacherId = t.TeacherId, TeacherIsActive = true }).ToList();
            return list;
        }

        public List<EmployeeListViewModel> GetStaffList()
        {
            var list = (from e in _db.Employees
                        join p in _db.People
                        on e.PersonId equals p.PersonId
                        join s in _db.Staffs
                        on e.EmployeeId equals s.EmployeeId
                        select new EmployeeListViewModel { Name = p.Name, Id = s.StaffId, IdNumber = e.IdNumber, IsActive = e.IsActive?"Yes":"No" }).ToList() ;
            return list;
        }

        public EmployeeViewModel GetStaffById(int staffId)
        {
            var staff = _db.Staffs.First(x => x.StaffId == staffId);
            var user = _db.Users.First(x => x.UserId == staff.UserId);
            var employee = _db.Employees.First(x => x.EmployeeId == staff.EmployeeId);
            var person = _db.People.First(x => x.PersonId == employee.PersonId);
            EmployeeViewModel employeeViewModel = new EmployeeViewModel
            {
                Name = person.Name,
                DateOfBirth=person.BirthDate,
                BloodGroupId=person.BloodGroupId,
                GenderId=person.GenderId,
                Religion=person.Religion,
                Address=person.Address,
                JoinDate=employee.JoinDate,
                Phone=employee.Phone,
                Username=user.Username,
                Password=user.Password,
                Email=user.Email,
                IsActive = employee.IsActive
                
            };
            return employeeViewModel;
        }
        public EmployeeViewModel GetTeacherById(int teacherId)
        {
            var teacher = _db.Teachers.First(x => x.TeacherId == teacherId);
            var employee = _db.Employees.First(x => x.EmployeeId == teacher.EmployeeId);
            var person = _db.People.First(x => x.PersonId == employee.PersonId);
            //var expertise = GetSubjectByTeacherId(teacherId);
            //    //return _db.Designations.Where(x => x.DesignationName == designation && x.IsActive==true).ToList();
            EmployeeViewModel employeeViewModel = new EmployeeViewModel
            {
                Name = person.Name,
                GenderId=person.GenderId,
                DateOfBirth = person.BirthDate,
                BloodGroupId = person.BloodGroupId,
                Religion = person.Religion,
                Address = person.Address,
                JoinDate = employee.JoinDate,
                Phone = employee.Phone,
                Email = teacher.Email,
                IsActive = employee.IsActive,
                DesignationId = teacher.DesignationId
            };
            return employeeViewModel;
        }
        //public List<Subject> GetSubjectByTeacherId(int teacherId)
        //{
        //    var expertise = _db.TeacherExpertises.Where(x => x.TeacherId == teacherId).ToList();
        //    foreach(var item in expertise)
        //    {
        //        var data = (EmployeeViewModel)item;

        //    }
        //    //foreach (var item in listBoxExpertise.SelectedItems)
        //    //{
        //    //    var data = (SubjectViewModel)item;
        //    //    Subject sub = new Subject { SubjectId = data.SubjectId, SubjectName = data.SubjectName, IsActive = data.IsActive == "Yes" ? true : false };
        //    //    subjects.Add(sub);
        //    //}

        //    return expertise;
        //}
        public List<EmployeeListViewModel> GetTeacherList()
        {
            var list = (from e in _db.Employees
                        join p in _db.People
                        on e.PersonId equals p.PersonId
                        join t in _db.Teachers
                        on e.EmployeeId equals t.EmployeeId
                        select new EmployeeListViewModel { Id = t.TeacherId, IdNumber = e.IdNumber, Name = p.Name, IsActive = e.IsActive ? "Yes" : "No" }).ToList();
            return list;
        }

        public List<EmployeeViewModel> GetDesignations()
        {
            var list = (from e in _db.Designations
                        where e.IsActive == true
                        select new EmployeeViewModel { DesignationName = e.DesignationName, DesignationId = e.DesignationId}).ToList();
            return list;
        }


        //public List<Designation> GetDesignations(List<DesignationViewModel> designation)
        //{
        //    //return _db.Designations.Where(x => x.DesignationName == designation && x.IsActive==true).ToList();
        //}
        public bool AddNewTeacher(EmployeeViewModel employee)
        {
            var person = _db.People.Add(new Person
            {
                Name = employee.Name,
                BirthDate = employee.DateOfBirth,
                GenderId = employee.GenderId,
                CreatedDate = DateTime.Now,
                BloodGroupId = employee.BloodGroupId,
                Religion = employee.Religion,
                Address = employee.Address,
                CreatedBy = CommonService.userInfo.UserId
            });

            var emp = _db.Employees.Add(new Employee
            {
                PersonId = person.PersonId,
                Phone = employee.Phone,
                JoinDate = employee.JoinDate,
                IdNumber = _commonService.GenerateIdNumber("T"),
                IsActive = employee.IsActive

            });
            var teacher = _db.Teachers.Add(new Teacher
            {
                DesignationId = employee.DesignationId,
                EmployeeId = emp.EmployeeId,
                Email = employee.Email
            });
            foreach(var item in employee.ExpertiseList)
            {
                _db.TeacherExpertises.Add(new TeacherExpertise { TeacherId = teacher.TeacherId, SubjectId = item.SubjectId });
            }
            try
            {
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            employee.Id = teacher.TeacherId;
            return true;
        }

        public bool UpdateStaff(EmployeeViewModel staffModel)
        {
            var staff = _db.Staffs.First(x => x.StaffId == staffModel.Id);
            //var user = _db.Users.First(x => x.UserId == staff.UserId);
            var employee = _db.Employees.First(x => x.EmployeeId == staff.EmployeeId);
            var person = _db.People.First(x => x.PersonId == employee.PersonId);

            employee.JoinDate = staffModel.JoinDate;
            employee.Phone = staffModel.Phone;
            employee.IsActive = staffModel.IsActive;

            person.Name = staffModel.Name;
            person.BirthDate = staffModel.DateOfBirth;
            person.BloodGroupId = staffModel.BloodGroupId;
            person.GenderId = staffModel.GenderId;
            person.Religion = staffModel.Religion;
            person.Address = staffModel.Address;

            try
            {
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            staffModel.Id = staff.StaffId;
            return true;

        }
        public bool UpdateTeacher(EmployeeViewModel teacherModel)
        {
            var teacher = _db.Teachers.First(x => x.TeacherId == teacherModel.Id);
            var employee = _db.Employees.First(x => x.EmployeeId == teacher.EmployeeId);
            var person = _db.People.First(x => x.PersonId == employee.PersonId);

            employee.JoinDate = teacherModel.JoinDate;
            employee.Phone = teacherModel.Phone;
            employee.IsActive = teacherModel.IsActive;

            person.Name = teacherModel.Name;
            person.BirthDate = teacherModel.DateOfBirth;
            person.BloodGroupId = teacherModel.BloodGroupId;
            person.GenderId = teacherModel.GenderId;
            person.Religion = teacherModel.Religion;
            person.Address = teacherModel.Address;

            teacher.DesignationId = teacherModel.DesignationId;
            try
            {
                _db.SaveChanges();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }
        public List<EmployeeListViewModel> SearchEmployeeList(string text)
        {
            var list = (from e in _db.Employees
                        join p in _db.People
                        on e.PersonId equals p.PersonId
                        join s in _db.Staffs
                        on e.EmployeeId equals s.EmployeeId
                        where p.Name.Contains(text)
                        select new EmployeeListViewModel { Name = p.Name, Id = s.StaffId, IdNumber = e.IdNumber, IsActive = e.IsActive ? "Yes" : "No" }).ToList();
            return list;
        }
        public List<EmployeeListViewModel> SearchTeacherList(string text)
        {
            var list = (from e in _db.Employees
                        join p in _db.People
                        on e.PersonId equals p.PersonId
                        join s in _db.Teachers
                        on e.EmployeeId equals s.EmployeeId
                        where p.Name.Contains(text)
                        select new EmployeeListViewModel { Name = p.Name, Id = s.TeacherId, IdNumber = e.IdNumber, IsActive = e.IsActive ? "Yes" : "No" }).ToList();
            return list;
        }


    }
}
