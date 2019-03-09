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
    public class SettingService
    {
        private readonly Entities _db = FactoryDB.GetDB();
        

        public bool AddSubject(Subject subject)
        {
            var sub = _db.Subjects.Add(subject);
            
            try
            {
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            subject.SubjectId = sub.SubjectId;
            return true;
        }

        public List<AcademicYear> GetAcademicYears()
        {
            return _db.AcademicYears.ToList();
        }

        
        public List<SubjectViewModel> GetSubjectList()
        {

            var list = _db.Subjects.Select(x => new SubjectViewModel { SubjectId = x.SubjectId, SubjectName = x.SubjectName, IsActive = x.IsActive ? "Yes":"No" }).ToList();
            return list;
            
        }

        public List<AttendanceViewModel> GetDailyAttendanceListByClassSection(int classSectionId, DateTime date)
        {
            var activeYear = GetCurrentYear();
            var status = EnumStatus.Current.ToString();
            var currentStatusId = _db.BaseDatas.First(x => x.Value == status).Id;
            var studentList = (from s in _db.Students
                               join scs in _db.StudentClassSections on s.StudentId equals scs.StudentId
                               join cs in _db.ClassSections on scs.ClassSectionId equals cs.ClassSectionId
                               join c in _db.Classes on cs.ClassId equals c.ClassId
                               join p in _db.People on s.PersonId equals p.PersonId
                               where scs.ClassSectionId == classSectionId && scs.StatusId == currentStatusId && scs.YearId==activeYear
                               select new AttendanceViewModel
                               {
                                   ClassId = cs.ClassId,
                                   ClassName = c.ClassName,
                                   ClassSectionId = cs.ClassSectionId,
                                   SectionName = cs.SectionName,
                                   StudentId = s.StudentId,
                                   StudentName = p.Name,
                                   IdNumber = s.IdNumber,
                                   Roll = scs.Roll,
                                   AttendanceDate = date
                               }).ToList();
            foreach(var student in studentList)
            {
                var attendance = _db.Attendances.FirstOrDefault(x => x.StudentId == student.StudentId && x.Date == date.Date);
                if(attendance!=null)
                {
                    student.AttendanceId = attendance.AttendanceId;
                    student.IsAttend = attendance.IsAttend;
                }
                else
                {
                    
                    student.AttendanceId = -1;
                    student.IsAttend = true;
                }
            }
            return studentList;
        }

        public string GetOrderBy()
        {
            var order = _db.Classes.OrderByDescending(x => x.ClassId).FirstOrDefault();
            return (order.OrderBy + (1)).ToString();
        }

        

        public bool CheckAtLeastOneCurrentYear(int yearId)
        {
            return _db.AcademicYears.Any(x => x.YearId == yearId && x.IsCurrent);
        }

        public List<PromoteStudentViewModel> GetStudentListForPromotion(int classId)
        {
            var status = EnumStatus.Current.ToString();
            var currentStatusId = _db.BaseDatas.First(x => x.Value == status).Id;
            var studentList = (from s in _db.Students
                               join scs in _db.StudentClassSections on s.StudentId equals scs.StudentId
                               join cs in _db.ClassSections on scs.ClassSectionId equals cs.ClassSectionId
                               join c in _db.Classes on cs.ClassId equals c.ClassId
                               join y in _db.AcademicYears on scs.YearId equals y.YearId
                               join p in _db.People on s.PersonId equals p.PersonId
                               where cs.ClassId == classId && y.IsCurrent && scs.StatusId == currentStatusId
                               select new PromoteStudentViewModel
                               {
                                   ClassId = cs.ClassId,
                                   ClassName = c.ClassName,
                                   ClassSectionId = cs.ClassSectionId,
                                   SectionName = cs.SectionName,
                                   StudentName = p.Name,
                                   IdNumber = s.IdNumber,
                                   Roll = scs.Roll,
                                   CurrentYearId = y.YearId,
                                   StatusId = scs.StatusId,
                                   StudentId = s.StudentId
                               }).ToList();

            foreach (var student in studentList)
            {
                if (_db.TempPromotionTables.Any(x => x.StudentId == student.StudentId))
                {
                    student.IsProcessed = "Yes";
                }
                else student.IsProcessed = "No";
            }

            return studentList;
        }



        public List<int> GetClassOrderByList()
        {
            var list = _db.Classes.Select(x => x.OrderBy).ToList();
            return list;
        }
        public bool UpdateDailyAttendance(List<AttendanceViewModel> list)
        {
            foreach (var item in list)
            {
                if(item.AttendanceId!=-1)
                {
                    var att = _db.Attendances.First(x => x.AttendanceId == item.AttendanceId);
                    att.IsAttend = item.IsAttend;
                }
                else
                {
                    _db.Attendances.Add(new Attendance
                    {
                        Date = item.AttendanceDate.Date,
                        IsAttend = item.IsAttend,
                        StudentId = item.StudentId,
                        UpdatedBy = CommonService.userInfo.UserId
                    });
                }

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
                return true;
        }

        public List<SubjectViewModel> GetActiveSubjectList()
        {

            var list = _db.Subjects.Where(p => p.IsActive==true).Select(x => new SubjectViewModel { SubjectId = x.SubjectId, SubjectName = x.SubjectName, IsActive = x.IsActive ? "Yes" : "No" }).ToList();
            return list;

        }

        public int GetCurrentYear()
        {
            var data = _db.AcademicYears.First(x => x.IsCurrent == true);
            return data.YearId;
        }

        public bool AddAcademicYear(AcademicYear year)
        {
            if (year.IsCurrent)
            {
                if (!RemoveAcademicYearCurrentStatus())
                {
                    return false;
                }
            }
            var data = _db.AcademicYears.Add(year);
            try
            {
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            year.YearId = data.YearId;
            return true;
        }

        public bool CheckAcademicYearExists(string year)
        {
            var data = _db.AcademicYears.FirstOrDefault(x => x.Year == year);
            return data != null;
        }

        public bool UpdateSubject(Subject subjectModel)
        {
            var subject = _db.Subjects.First(x => x.SubjectId == subjectModel.SubjectId);
            subject.SubjectName = subjectModel.SubjectName;
            subject.IsActive = subjectModel.IsActive;
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

        public bool RemoveAcademicYearCurrentStatus()
        {
            var data = _db.AcademicYears.FirstOrDefault(x => x.IsCurrent == true);
            if (data == null) return true;
            data.IsCurrent = false;
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

        public bool UpdateAcademicYear(AcademicYear year)
        {
            if (year.IsCurrent)
            {
                if (!RemoveAcademicYearCurrentStatus())
                {
                    return false;
                }
            }
            var data = _db.AcademicYears.First(x => x.YearId == year.YearId);
            data.Year = year.Year;
            data.IsCurrent = year.IsCurrent;
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



        public bool AddClass(Class cl)
        {
            cl.IsActive = true;
            var cls = _db.Classes.Add(cl);

            try
            {
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            cl.ClassId = cls.ClassId;
            return true;
        }

        public List<ClassSectionViewModel> GetClassSectionList(int classId)
        {
            var list = (from t in _db.Teachers
                        join e in _db.Employees on t.EmployeeId equals e.EmployeeId
                        join p in _db.People on e.PersonId equals p.PersonId
                        join cs in _db.ClassSections on t.TeacherId equals cs.ClassTeacherId
                        join c in _db.Classes on cs.ClassId equals c.ClassId
                        where (c.ClassId == classId)
                        select new ClassSectionViewModel { ClassSectionId = cs.ClassSectionId, ClassId = c.ClassId, SectionName = cs.SectionName, TeacherName = p.Name, IsActive = cs.IsActive ? "Yes" : "No" }).ToList();
            //var list = _db.ClassSections.Where(p => p.ClassId == classId).Select(x => new ClassSectionViewModel { ClassSectionId = x.ClassSectionId, SectionName = x.SectionName, IsActive = x.IsActive ? "Yes" : "No"}).ToList();
            return list;
        }

        public List<ClassViewModel> GetClassList()
        {
            var list = _db.Classes.Select(x => new ClassViewModel { ClassId = x.ClassId, ClassName = x.ClassName, OrderBy= x.OrderBy, IsActive = x.IsActive ? "Yes" : "No" }).ToList();
            return list;
        }

        public List<ClassViewModel> GetActiveClassList()
        {
            var list = _db.Classes.Where(p=>p.IsActive==true).Select(x => new ClassViewModel { ClassId = x.ClassId, ClassName = x.ClassName, IsActive = x.IsActive ? "Yes" : "No" }).ToList();
            return list;
        }

        public List<SubjectViewModel> GetActiveSubjectListByTeacherId(int teacherId)
        {
            var teacherExpertiseIds = _db.TeacherExpertises.Where(x => x.TeacherId == teacherId).Select(p => p.SubjectId).ToList();
            return _db.Subjects.Where(x => teacherExpertiseIds.Contains(x.SubjectId)).Select(x => new SubjectViewModel { SubjectId = x.SubjectId, SubjectName = x.SubjectName, IsActive = x.IsActive ? "Yes" : "No" }).ToList();
        }

        public bool UpdateClass(Class classModel)
        {
            var cls = _db.Classes.First(x => x.ClassId == classModel.ClassId);
            cls.ClassName = classModel.ClassName;
            cls.IsActive = classModel.IsActive;
            cls.OrderBy = classModel.OrderBy;
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

       

        public bool AddClassSection(ClassSection classSec)
        {
            
            var clSec = _db.ClassSections.Add(classSec);
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

        public bool AddDesignation(Designation designation)
        {
            designation.IsActive = true;
            var desig = _db.Designations.Add(designation);

            try
            {
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            designation.DesignationId = desig.DesignationId;
            return true;
        }
        public List<DesignationViewModel> GetDesignationList()
        {
            var list = _db.Designations.Select(x => new DesignationViewModel { DesignationId = x.DesignationId, DesignationName = x.DesignationName, IsActive = x.IsActive ? "Yes" : "No" }).ToList();
            return list;
        }

        public bool UpdateDesignation(Designation designationModel)
        {
            var desig = _db.Designations.First(x => x.DesignationId == designationModel.DesignationId);
            desig.DesignationName = designationModel.DesignationName;
            desig.IsActive = designationModel.IsActive;
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

        public bool UpdateSection(ClassSection classSection)
        {
            var cls = _db.ClassSections.First(x => x.ClassSectionId == classSection.ClassSectionId);
            
            cls.SectionName = classSection.SectionName;
            cls.IsActive = classSection.IsActive;
            cls.ClassTeacherId = classSection.ClassTeacherId;
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

        public bool AddExam(Exam exam)
        {
            var exm = _db.Exams.Add(exam);

            try
            {
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            exam.ExamId = exm.ExamId;
            return true;
        }
        public bool UpdateExam(Exam examModel)
        {
            var exam = _db.Exams.First(x => x.ExamId == examModel.ExamId);
            exam.ExamName = examModel.ExamName;
            exam.IsActive = examModel.IsActive;
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

        public List<ExamViewModel> GetExamList()
        {

            var list = _db.Exams.Select(x => new ExamViewModel { ExamId = x.ExamId, ExamName = x.ExamName, FinalPercentage = x.FinalPercentage, IsActive = x.IsActive ? "Yes" : "No" }).ToList();
            return list;

        }

        public List<ExamViewModel> GetActiveExamList()
        {

            var list = _db.Exams.Where(p => p.IsActive == true).Select(x => new ExamViewModel { ExamId = x.ExamId, ExamName = x.ExamName, FinalPercentage = x.FinalPercentage, IsActive = x.IsActive ? "Yes" : "No" }).ToList();
            return list;

        }

        public List<MarksViewModel> GetListForMarksTable(int studentId, int examId)
        {
            var activeYear = _db.AcademicYears.FirstOrDefault(x => x.IsCurrent);
            if (activeYear == null)
            {
                return new List<MarksViewModel>();
            }
            var classSecId = _db.StudentClassSections.First(x => x.StudentId == studentId).ClassSectionId;
            var marksList = _db.Marks.Where(x => x.ExamId == examId && x.StudentId == studentId && x.YearId == activeYear.YearId).ToList();
            var classSectionSubjectsList = _db.ClassSectionSubjects.Where(x => x.ClassSectionId == classSecId).ToList();
            var subjectIdList = classSectionSubjectsList.Select(x => x.SubjectId).ToList();
            var subjectList = _db.Subjects.Where(x => subjectIdList.Contains(x.SubjectId)).ToList();
            List<MarksViewModel> marksModelList = new List<MarksViewModel>();
            foreach (var classSectionSubject in classSectionSubjectsList)
            {
                var marks = marksList.FirstOrDefault(x => x.ClassSectionSubjectId == classSectionSubject.Id);
                var subject = subjectList.First(x => x.SubjectId == classSectionSubject.SubjectId);
                MarksViewModel markModel = new MarksViewModel
                {
                    SubjectId = subject.SubjectId,
                    Subject = subject.SubjectName,
                    StudentId = studentId,
                    ClassSectionSubjectId = classSectionSubject.Id,
                    Marks = marks != null ? marks.Marks : 0,
                    MarksId = marks != null ? marks.MarksId : -1,
                    ExamId = examId
                };
                marksModelList.Add(markModel);
            }

            return marksModelList;
        }

        public bool UpdateMarksTable(List<MarksViewModel> marksViewModels)
        {
            var activeYear = _db.AcademicYears.FirstOrDefault(x => x.IsCurrent);
            if (activeYear == null)
            {
                return false;
            }
            foreach (var marks in marksViewModels)
            {
                if (marks.MarksId != -1)
                {
                    var dbmarks = _db.Marks.First(x => x.MarksId == marks.MarksId);
                    dbmarks.Marks = marks.Marks;
                }
                else
                {
                    _db.Marks.Add(new Mark
                    {
                        ExamId = marks.ExamId,
                        StudentId = marks.StudentId,
                        ClassSectionSubjectId = marks.ClassSectionSubjectId,
                        Marks = marks.Marks,
                        YearId = activeYear.YearId,
                        UpdateBy = CommonService.userInfo.UserId
                    });
                }


            }

            try
            {
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }


        public List<ClassSectionViewModel> GetActiveClassSectionList(int classId)
        {
            var list = _db.ClassSections.Where(p => p.ClassId == classId && p.IsActive == true).Select(x => new ClassSectionViewModel { ClassSectionId = x.ClassSectionId, SectionName = x.SectionName, IsActive = x.IsActive ? "Yes" : "No" }).ToList();
            return list;
        }

        public List<SubjectViewModel> GetActiveSubjectListByClassSectionId(int classSectionId)
        {
            var list = _db.ClassSectionSubjects.Where(x => x.ClassSectionId == classSectionId).Select(x => x.SubjectId).ToList();
            return _db.Subjects.Where(x => list.Contains(x.SubjectId)).Select(x => new SubjectViewModel { SubjectId = x.SubjectId, SubjectName = x.SubjectName, IsActive = x.IsActive ? "Yes" : "No" }).ToList();
        }


        public bool AssigningSubjetToClassSection(List<ClassSectionSubjectViewModel> classSecSubList)
        {
            var subjectList = _db.Subjects.ToList();
            foreach (var classSecSub in classSecSubList)
            {
                foreach (var item in subjectList)
                {
                    var csSub = _db.ClassSectionSubjects.FirstOrDefault(x =>
                        x.ClassSectionId == classSecSub.ClassSectionId && x.SubjectId == item.SubjectId);
                    if (csSub != null)
                    {
                        bool isActive = classSecSub.SubjectList.Any(x => x.SubjectId == csSub.SubjectId);
                        csSub.IsActive = isActive;
                    }
                    else
                    {
                        if (classSecSub.SubjectList.Any(x => x.SubjectId == item.SubjectId))
                        {
                            _db.ClassSectionSubjects.Add(new ClassSectionSubject { ClassSectionId = classSecSub.ClassSectionId, SubjectId = item.SubjectId, IsActive = true });
                        }
                    }
                }
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
            return true;
        }


        public List<ClassSectionViewModel> GetClassSectionId(int classId)
        {
            var list = _db.ClassSections.Where(p => p.ClassId == classId && p.IsActive == true).Select(x => new ClassSectionViewModel { ClassSectionId = x.ClassSectionId, SectionName = x.SectionName, IsActive = x.IsActive ? "Yes" : "No" }).ToList();
            return list;
        }

        public string GetAttendanceRationByStudent(int studentId)
        {
            var attendCount = _db.Attendances.Count(x => x.StudentId == studentId && x.IsAttend);
            var absentCount = _db.Attendances.Count(x => x.StudentId == studentId && !x.IsAttend);
            return attendCount + "/" + (attendCount + absentCount);
        }

        public string GetNextClassByClassId(int classId)
        {
            string nextClass = "Passed,-1";
            var thisClassOrder = _db.Classes.First(x => x.ClassId == classId).OrderBy;
            var classList = _db.Classes.Where(x => x.IsActive).OrderBy(x => x.OrderBy).ToList();
            foreach (var cls in classList)
            {
                if (cls.ClassId > thisClassOrder)
                {
                    nextClass = cls.ClassName + "," + cls.ClassId;
                    break;
                }
            }

            return nextClass;
        }

        public double CalculateMarksForPromotion(int studentId)
        {
            double totalMarks = 0;
            var activeYear = GetCurrentYear();

            var marksList = _db.Marks.Where(x =>
                x.StudentId == studentId && x.YearId == activeYear);
            foreach (var marks in marksList)
            {
                totalMarks += (marks.Marks * marks.Exam.FinalPercentage) / 100;
            }

            return totalMarks;
        }

        public TempPromotionTable GetTempPromoteDataByStudent(int studentId)
        {
            int currentYear = GetCurrentYear();
            return _db.TempPromotionTables.FirstOrDefault(x =>
                x.StudentId == studentId && x.CurrentYearId == currentYear);
        }

        public bool UpdateTempPromoteData(TempPromotionTable temp)
        {
            TempPromotionTable data;
            if (temp.Id == -1)
            {
                data = _db.TempPromotionTables.Add(temp);

            }
            else
            {
                data = _db.TempPromotionTables.First(x => x.Id == temp.Id);
                data.IsPassed = temp.IsPassed;
                data.Remarks = temp.Remarks;
                data.NextClassSectionId = temp.NextClassSectionId;
                data.NextClassId = temp.NextClassId;
            }

            try
            {
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

            temp.Id = data.Id;
            return true;
        }
        public bool ExecutePromotionOfStudents(List<PromoteStudentViewModel> oldPromotionList)
        {
            var statusCategory = EnumBaseData.StudentStatus.ToString();
            var statusPassed = EnumStatus.Passed.ToString();
            var statusCurrent = EnumStatus.Current.ToString();
            var activeYear = GetCurrentYear();
            List<int> studentIdList = oldPromotionList.Select(p => p.StudentId).ToList();
            var tempList =
                _db.TempPromotionTables.Where(x => studentIdList.Contains(x.StudentId)).OrderByDescending(x => x.AverageMarks).ToList();
            foreach (var temp in tempList)
            {
                var promotion = oldPromotionList.First(x => x.StudentId == temp.StudentId);
                promotion.AverageMarks = temp.AverageMarks;
            }

            var promotionList = oldPromotionList.OrderByDescending(x => x.AverageMarks).ToList();
            var newYear = (int.Parse(_db.AcademicYears.First(x => x.IsCurrent).Year) + 1).ToString();
            int newYearId;
            if (!_db.AcademicYears.Any(x => x.Year == newYear))
            {
                var year = _db.AcademicYears.Add(new AcademicYear
                {
                    Year = newYear
                });
                newYearId = year.YearId;
            }
            else
            {
                newYearId = _db.AcademicYears.First(x => x.Year == newYear).YearId;
            }
            foreach (var promotion in promotionList)
            {
                var temp = _db.TempPromotionTables.First(x =>
                    x.StudentId == promotion.StudentId && x.CurrentYearId == activeYear);
                if (temp.IsPassed)
                {
                    var promoteData = _db.PromotionHistories.Add(new PromotionHistory
                    {
                        StudentId = promotion.StudentId,
                        PreviousClassId = promotion.ClassId,
                        CurrentClassId = temp.NextClassId,
                        Remarks = temp.Remarks,
                        PreviousYearId = activeYear,
                        UpdatedBy = CommonService.userInfo.UserId
                    });
                    if (temp.NextClassId == null)
                    {

                        var clsSecData = _db.StudentClassSections.First(x => x.ClassSectionId == promotion.ClassSectionId);
                        clsSecData.StatusId =
                            _db.BaseDatas.First(x => x.Category == statusCategory && x.Value == statusPassed).Id;
                    }
                    else
                    {
                        _db.StudentClassSections.Add(new StudentClassSection
                        {
                            ClassSectionId = (int)temp.NextClassSectionId,
                            StudentId = temp.StudentId,
                            Roll = GenerateRollNumber((int)temp.NextClassSectionId, int.Parse(newYear)) + 1,
                            YearId = newYearId,
                            StatusId = _db.BaseDatas.First(x => x.Category == statusCategory && x.Value == statusCurrent).Id
                        });
                        var clsSecData = _db.StudentClassSections.First(x => x.ClassSectionId == promotion.ClassSectionId && x.StudentId == promotion.StudentId && x.YearId == activeYear);
                        clsSecData.StatusId =
                            _db.BaseDatas.First(x => x.Category == statusCategory && x.Value == statusPassed).Id;
                    }
                }
                else
                {

                    _db.StudentClassSections.Add(new StudentClassSection
                    {
                        ClassSectionId = promotion.ClassSectionId,
                        StudentId = temp.StudentId,
                        Roll = GenerateRollNumber(promotion.ClassSectionId, int.Parse(newYear)) + 1,
                        YearId = newYearId,
                        StatusId = _db.BaseDatas.First(x => x.Category == statusCategory && x.Value == statusCurrent).Id
                    });
                    var clsSecData = _db.StudentClassSections.First(x => x.ClassSectionId == promotion.ClassSectionId && x.StudentId == promotion.StudentId && x.YearId == activeYear);
                    clsSecData.StatusId =
                        _db.BaseDatas.First(x => x.Category == statusCategory && x.Value == statusPassed).Id;


                }

                _db.TempPromotionTables.Remove(temp);

            }

            try
            {
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }

        private int GenerateRollNumber(int classSectionId, int yearId)
        {
            var data = _db.StudentClassSections.Where(x => x.ClassSectionId == classSectionId && x.YearId == yearId).ToList();
            if (data.Any())
            {
                return data.Max(x => x.Roll);
            }
            return 0;
        }
    }
}
