using Core.Data.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Data.ViewModel;
using Core.Enum;

namespace Core.Service
{
    public class CommonService
    {
        private Entities _db = FactoryDB.GetDB();
        public static User userInfo;
        public static Employee empInfo;
        public static bool isAdmin = false;
        public static Person personInfo;
        public string NameRegex { get { return @"^[\p{L}\s'.-]+$"; } }
        public string UsernameRegex { get { return @"^[a-zA-Z0-9]+$"; } }
        //^[\+\d]?(?:[\d-.\s()]*)$
        public string PasswordRegex { get { return @"^[^\s]{5,50}$"; } }
        public string EmailRegex { get { return @"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$"; } }
        public string PhoneRegex { get { return @"^[\+\d]?(?:[\d-.\s()]*)$"; } }
        public bool CheckFirstRun()
        {
            var data = _db.Settings.FirstOrDefault();
            if (data == null) return true;
            var data2 = _db.Admins.FirstOrDefault();
            if (data2 == null) return true;
            return false;
        }
        public List<BaseData> GetBaseDataByCatagory(string category)
        {
            var status = EnumStatus.Passed.ToString();
            return _db.BaseDatas.Where(x => x.Category == category && x.Value != status).ToList();
        }

        public void ChangePassword(string text)
        {
            var user = _db.Users.First(x => x.UserId == userInfo.UserId);
            user.Password = text;
            try
            {
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
             }
        }

        public bool SaveFirstRunInfo(Setting settings, EmployeeViewModel admin)
        {
            _db.Settings.Add(settings);
            _db.AcademicYears.Add(new AcademicYear
            {
                Year = DateTime.Now.Year.ToString(),
                IsCurrent = true
            });
            var person = _db.People.Add(new Person
            {
                Name = admin.Name,
                BirthDate = admin.DateOfBirth,
                GenderId = admin.GenderId,
                CreatedDate = DateTime.Now
            });
            var employee = _db.Employees.Add(new Employee
            {
                JoinDate = admin.JoinDate,
                Phone = admin.Phone,
                PersonId = person.PersonId,
                IdNumber = "A00001",
                IsActive = true

            });
            var user = _db.Users.Add(new User
            {
                Username = admin.Username,
                Password = admin.Password,
                Email = admin.Email,
                UserTypeId = GetBaseDataByCatagory(EnumBaseData.UserType.ToString()).First(x => x.Value == EnumUserType.Admin.ToString()).Id

            });
            _db.Admins.Add(new Admin
            {
                UserId = user.UserId,
                EmployeeId = employee.EmployeeId
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
            return true;
        }

        

        internal string GenerateIdNumber(string s)
        {
            string number="";
            if(s=="SF")
            {
                var data = _db.Staffs.OrderByDescending(x => x.StaffId).First();
                if (data == null) return "SF10001";
                else
                {
                    var idNumber = _db.Employees.First(x => x.EmployeeId == data.EmployeeId).IdNumber;
                    int i = int.Parse(idNumber.Replace("SF", ""));
                    number = "SF" + ++i;
                    
                }
                
            }
            if(s=="T")
            {
                var data = _db.Teachers.OrderByDescending(x => x.TeacherId).FirstOrDefault();
                if (data == null) return "T10001";
                else
                {
                    var idNumber = _db.Employees.First(x => x.EmployeeId == data.EmployeeId).IdNumber;
                    int i = int.Parse(idNumber.Replace("T", ""));
                    number = "T" + ++i;
                }
            }
            if(s=="ST")
            {
                var data = _db.Students.OrderByDescending(x => x.StudentId).FirstOrDefault();
                if (data == null) return "ST10001";
                else
                {
                    var idNumber = _db.Students.First(x => x.StudentId == data.StudentId).IdNumber;
                    int i = int.Parse(idNumber.Replace("ST", ""));
                    number = "ST" + ++i;
                }
            }
            return number;
        }

        public bool UpdateMyInfo(Person person, User userInfo, Employee empInfo)
        {
            var p = _db.People.First(x => x.PersonId == person.PersonId);
            p.Name = person.Name;
            p.Religion=person.Religion;
            p.BirthDate= person.BirthDate;
            p.BloodGroupId= person.BloodGroupId;
            p.GenderId= person.GenderId;
            p.Address= person.Address;

            var u = _db.Users.First(x => x.UserId == userInfo.UserId);
            u.Username = userInfo.Username;
            u.Email = userInfo.Email;

            var e = _db.Employees.First(x => x.EmployeeId == empInfo.EmployeeId);
            e.JoinDate = empInfo.JoinDate;
            e.Phone = empInfo.Phone;

            

            try
            {
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            CommonService.userInfo = u;
            CommonService.personInfo = p;
            CommonService.empInfo = e;
            return true;

        }

        public bool CheckCredential(string username, string password)
        {
            var data = _db.Users.FirstOrDefault(x => x.Username == username && x.Password == password);
            if (data == null) return false;
            userInfo = data;
            var bData = _db.BaseDatas.First(x => x.Id == userInfo.UserTypeId);
            if (bData.Value == EnumUserType.Admin.ToString()) isAdmin = true; else isAdmin = false;
            int employeeId;
            if (isAdmin)
            {
                employeeId = _db.Admins.First(q => q.UserId == data.UserId).EmployeeId;
            }
            else
            {
                employeeId = _db.Staffs.First(q => q.UserId == data.UserId).EmployeeId;
            }
            var personId = _db.Employees.First(p => p.EmployeeId == employeeId).PersonId;
            personInfo = _db.People.First(x => x.PersonId == personId);
            empInfo = _db.Employees.First(x => x.EmployeeId == employeeId);
            return true;
        }

        public bool CheckUsernameExists(string text)
        {
            var data = _db.Users.FirstOrDefault(x => x.Username==text);
            if (data == null) return false;
            return true;
        }

        public bool CheckEmailExists(string text)
        {
            var data = _db.Users.FirstOrDefault(x => x.Email == text);
            if (data == null) return false;
            return true;
        }
    }
}
