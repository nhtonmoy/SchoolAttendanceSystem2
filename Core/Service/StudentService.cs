using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Data.ViewModel;
using Core.Data.DB;
using Core.Enum;

namespace Core.Service
{
    public class StudentService
    {
        private readonly Entities _db = FactoryDB.GetDB();
        private CommonService _commonService = new CommonService();
        private SettingService _settingService = new SettingService();
        public bool AddNewStudent(StudentViewModel studentModel)
        {
            var person = _db.People.Add(new Person
            {
                Name = studentModel.Name,
                BirthDate = studentModel.DateOfBirth,
                GenderId = studentModel.GenderId,
                Religion = studentModel.Religion,
                BloodGroupId = studentModel.BloodGroupId,
                Address = studentModel.Address,
                CreatedBy = CommonService.userInfo.UserId,
                CreatedDate = DateTime.Now
            });

            var student = _db.Students.Add(new Student
            {
                PersonId = person.PersonId,
                FatherName = studentModel.FatherName,
                FatherProfession = studentModel.FatherProfession,
                MotherName = studentModel.MotherName,
                MotherProfession = studentModel.MotherProfession,
                Email = studentModel.Email,
                Phone=studentModel.Phone,
                IdNumber = _commonService.GenerateIdNumber("ST"),
                IsActive = studentModel.IsActive
            });
            var studentClassSection = _db.StudentClassSections.Add(new StudentClassSection
            {
                StudentId = student.StudentId,
                ClassSectionId = studentModel.SectionId,
                Roll = studentModel.RollNumber,
                YearId = _settingService.GetCurrentYear(),
                StatusId=studentModel.StatusId
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
        

        public List<StudentViewModel> GetActiveStudentForMarksByClass(int classId)
        {
            var classSectionList = _db.ClassSections.Where(x => x.ClassId == classId).ToList();
            var classSectionIdList = classSectionList.Select(x => x.ClassSectionId).ToList();
            var activeYear = _db.AcademicYears.FirstOrDefault(x => x.IsCurrent);
            if (activeYear == null)
            {
                return new List<StudentViewModel>();
            }

            var studentList = (from s in _db.Students
                               join scs in _db.StudentClassSections on s.StudentId equals scs.StudentId
                               join cs in _db.ClassSections on scs.ClassSectionId equals cs.ClassSectionId
                               join p in _db.People on s.PersonId equals p.PersonId
                               where (scs.YearId == activeYear.YearId) && classSectionIdList.Contains(scs.ClassSectionId)
                               select new StudentViewModel { RollNumber = scs.Roll, Name = p.Name, Id = s.StudentId, IdNumber = s.IdNumber, ClassId = cs.ClassId, SectionName = cs.SectionName }).ToList();
            return studentList;
        }

        public List<StudentViewModel> GetActiveStudentForMarksByClassSection(int classSectionId)
        {
            var status = EnumStatus.Current.ToString();
            var currentStatusId = _db.BaseDatas.First(x => x.Value == status).Id;
            var classSection = _db.ClassSections.First(x => x.ClassSectionId == classSectionId);
            var activeYear = _db.AcademicYears.FirstOrDefault(x => x.IsCurrent);
            if (activeYear == null)
            {
                return new List<StudentViewModel>();
            }

            var studentList = (from s in _db.Students
                               join scs in _db.StudentClassSections on s.StudentId equals scs.StudentId
                               join p in _db.People on s.PersonId equals p.PersonId
                               where scs.YearId == activeYear.YearId && scs.ClassSectionId == classSectionId && scs.StatusId == currentStatusId
                               select new StudentViewModel { RollNumber = scs.Roll, Name = p.Name, Id = s.StudentId, IdNumber = s.IdNumber, ClassId = classSection.ClassId, SectionName = classSection.SectionName }).ToList();
            return studentList;
        }

        public int GenerateRollNumber(int classSectionId)
        {
            var data = _db.StudentClassSections.Where(x => x.ClassSectionId == classSectionId).ToList();
            if(data.Any())
            {
                return data.Max(x => x.Roll);
            }
            return 0;
        }

        public List<StudentListViewModel> GetStudentList()
        {
            var list = (from s in _db.Students
                        join p in _db.People
                        on s.PersonId equals p.PersonId
                        select new StudentListViewModel { Id = s.StudentId, IdNumber = s.IdNumber, Name = p.Name, IsActive = s.IsActive ? "Yes" : "No" }).ToList();
            return list;
        }
        public List<StudentListViewModel> GetStudentListByClassSection(int classSectionId)
        {
            var activeYear = _settingService.GetCurrentYear();
            var status = EnumStatus.Current.ToString();
            var currentStatusId = _db.BaseDatas.First(x => x.Value == status).Id;
            var list = (from s in _db.Students
                        join p in _db.People
                        on s.PersonId equals p.PersonId
                        join scs in _db.StudentClassSections on s.StudentId equals scs.StudentId
                        join cs in _db.ClassSections on scs.ClassSectionId equals cs.ClassSectionId
                        where cs.ClassSectionId == classSectionId && scs.StatusId == currentStatusId && scs.YearId == activeYear
                        select new StudentListViewModel
                        {
                            Id = s.StudentId,
                            IdNumber = s.IdNumber,
                            Name = p.Name,
                            IsActive = s.IsActive ? "Yes" : "No"
                        }).ToList();
            return list;
        }
        public bool UpdateStudent(StudentViewModel studentModel)
        {
            var student = _db.Students.First(x => x.StudentId == studentModel.Id);
            var person = _db.People.First(x => x.PersonId == student.PersonId);
            student.Phone = studentModel.Phone;
            student.IsActive = studentModel.IsActive;

            person.Name = studentModel.Name;
            student.FatherName = studentModel.FatherName;
            student.MotherName = studentModel.MotherName;
            student.FatherProfession = studentModel.FatherProfession;
            student.MotherProfession = studentModel.MotherProfession;
            person.BirthDate = studentModel.DateOfBirth;
            person.BloodGroupId = studentModel.BloodGroupId;
            person.GenderId = studentModel.GenderId;
            person.Religion = studentModel.Religion;
            person.Address = studentModel.Address;

            try
            {
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            studentModel.Id = student.StudentId;
            return true;

        }

        public List<StudentListViewModel> SearchStudentList(string text, int classecId)
        {
            var list = (from s in _db.Students
                        join p in _db.People
                        on s.PersonId equals p.PersonId
                        join scs in _db.StudentClassSections
                        on s.StudentId equals scs.StudentId
                        join ac in _db.AcademicYears
                        on scs.YearId equals ac.YearId
                        where p.Name.Contains(text) && scs.ClassSectionId == classecId && ac.IsCurrent
                        select new StudentListViewModel { Name = p.Name, Id = s.StudentId, IdNumber = s.IdNumber, IsActive = s.IsActive ? "Yes" : "No" }).ToList();
            return list;
        }
        public StudentViewModel GetStudentById(int studentId)
        {
            var actyear = _db.AcademicYears.FirstOrDefault(x => x.IsCurrent);
            if (actyear == null) { return new StudentViewModel(); }
            var student = _db.Students.First(x => x.StudentId == studentId);
            var person = _db.People.First(x => x.PersonId == student.PersonId);
            var stdclssec = _db.StudentClassSections.First(x => x.StudentId == studentId && x.YearId == actyear.YearId);
            var clasec = _db.ClassSections.First(x => x.ClassSectionId == stdclssec.ClassSectionId);

            StudentViewModel studentViewModel = new StudentViewModel
            {
                Name = person.Name,
                FatherName = student.FatherName,
                MotherName = student.MotherName,
                FatherProfession = student.FatherProfession,
                MotherProfession = student.MotherProfession,
                DateOfBirth = person.BirthDate,
                BloodGroupId = person.BloodGroupId,
                GenderId = person.GenderId,
                Religion = person.Religion,
                Address = person.Address,
                Phone = student.Phone,
                Email = student.Email,
                IsActive = student.IsActive,
                RollNumber = stdclssec.Roll,
                ClassId = clasec.ClassId,
                SectionId = clasec.ClassSectionId,
                StatusId = stdclssec.StatusId

            };
            return studentViewModel;
        }
    }
}

