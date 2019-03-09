using Core.Enum;
using Core.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolAttendanceSystem
{
    public partial class FormMain : Form
    {
        private readonly CommonService _commonService = new CommonService();
        public FormMain()
        {
            InitializeComponent();
            
            foreach (Control control in Controls)
            {
                if (control is MdiClient)
                    control.Paint += mdiBackgroundPaint;

            }
            
        }

        

        private void mdiBackgroundPaint(object sender, PaintEventArgs e)
        {
            var mdi = sender as MdiClient;
            if (mdi == null) return;
            int WinHeight = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height;
            int WinWidth = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width;

            Font drawFont = new Font("Arial", 12, FontStyle.Bold);

            StringFormat drawFormat = new StringFormat();

            e.Graphics.Clip = new System.Drawing.Region(mdi.ClientRectangle);
            string s = "Name: "+CommonService.personInfo.Name;
            string s2 = "User Type: " + (CommonService.isAdmin ? "Admin" : "Staff");
            var stringSize = e.Graphics.MeasureString(s, drawFont);
            e.Graphics.DrawString(s, drawFont, Brushes.GhostWhite, 10, 10, drawFormat);
            e.Graphics.DrawString(s2, drawFont, Brushes.GhostWhite, 10, 30, drawFormat);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        

        private void toolStripButtonAddStudent_Click(object sender, EventArgs e)
        {
            FormAddNewStudent.Instance.MdiParent = this;
            FormAddNewStudent.Instance.Show();
            FormAddNewStudent.Instance.BringToFront();
            FormAddNewStudent.Instance.Activate();
            FormAddNewStudent.Instance.WindowState = FormWindowState.Normal;
            FormAddNewStudent.Instance.Focus();

        }

        private void toolStripButtonStudentList_Click(object sender, EventArgs e)
        {
            FormStudentList.Instance.MdiParent = this;
            FormStudentList.Instance.Show();
            FormStudentList.Instance.BringToFront();
            FormStudentList.Instance.Activate();
            FormStudentList.Instance.WindowState = FormWindowState.Normal;
            FormStudentList.Instance.Focus();
        }

        private void toolStripButtonAttendance_Click(object sender, EventArgs e)
        {
            FormAttendance.Instance.MdiParent = this;
            FormAttendance.Instance.Show();
            FormAttendance.Instance.BringToFront();
            FormAttendance.Instance.Activate();
            FormAttendance.Instance.WindowState = FormWindowState.Normal;
            FormAttendance.Instance.Focus();
        }

        private void toolStripButtonAddMarks_Click(object sender, EventArgs e)
        {
            FormAddMarks.Instance.MdiParent = this;
            FormAddMarks.Instance.Show();
            FormAddMarks.Instance.BringToFront();
            FormAddMarks.Instance.Activate();
            FormAddMarks.Instance.WindowState = FormWindowState.Normal;
            FormAddMarks.Instance.Focus();
        }

        private void toolStripButtonPromoteStudents_Click(object sender, EventArgs e)
        {
            FormPromoteStudent.Instance.MdiParent = this;
            FormPromoteStudent.Instance.Show();
            FormPromoteStudent.Instance.BringToFront();
            FormPromoteStudent.Instance.Activate();
            FormPromoteStudent.Instance.WindowState = FormWindowState.Normal;
            FormPromoteStudent.Instance.Focus();
        }

        private void toolStripButtonRoutine_Click(object sender, EventArgs e)
        {
            FormGeneratePeriod.Instance.MdiParent = this;
            FormGeneratePeriod.Instance.Show();
            FormGeneratePeriod.Instance.BringToFront();
            FormGeneratePeriod.Instance.Activate();
            FormGeneratePeriod.Instance.WindowState = FormWindowState.Normal;
            FormGeneratePeriod.Instance.Focus();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddNewStudent.Instance.MdiParent = this;
            FormAddNewStudent.Instance.Show();
            FormAddNewStudent.Instance.BringToFront();
            FormAddNewStudent.Instance.Activate();
            FormAddNewStudent.Instance.WindowState = FormWindowState.Normal;
            FormAddNewStudent.Instance.Focus();
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStudentList.Instance.MdiParent = this;
            FormStudentList.Instance.Show();
            FormStudentList.Instance.BringToFront();
            FormStudentList.Instance.Activate();
            FormStudentList.Instance.WindowState = FormWindowState.Normal;
            FormStudentList.Instance.Focus();
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAttendance.Instance.MdiParent = this;
            FormAttendance.Instance.Show();
            FormAttendance.Instance.BringToFront();
            FormAttendance.Instance.Activate();
            FormAttendance.Instance.WindowState = FormWindowState.Normal;
            FormAttendance.Instance.Focus();
        }

        private void addMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddMarks.Instance.MdiParent = this;
            FormAddMarks.Instance.Show();
            FormAddMarks.Instance.BringToFront();
            FormAddMarks.Instance.Activate();
            FormAddMarks.Instance.WindowState = FormWindowState.Normal;
            FormAddMarks.Instance.Focus();
        }

        private void promoteStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPromoteStudent.Instance.MdiParent = this;
            FormPromoteStudent.Instance.Show();
            FormPromoteStudent.Instance.BringToFront();
            FormPromoteStudent.Instance.Activate();
            FormPromoteStudent.Instance.WindowState = FormWindowState.Normal;
            FormPromoteStudent.Instance.Focus();
        }

        private void addTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddNewTeacher.Instance.MdiParent = this;
            FormAddNewTeacher.Instance.Show();
            FormAddNewTeacher.Instance.BringToFront();
            FormAddNewTeacher.Instance.Activate();
            FormAddNewTeacher.Instance.WindowState = FormWindowState.Normal;
            FormAddNewTeacher.Instance.Focus();
        }

        private void teacherListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormStaffList.Instance.MdiParent = this;
            FormStaffList.Instance.Show();
            FormStaffList.Instance.BringToFront();
            FormStaffList.Instance.Activate();
            FormStaffList.Instance.WindowState = FormWindowState.Normal;
            FormStaffList.Instance.Focus();
        }

        private void assignSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAssignTeacherSubject.Instance.MdiParent = this;
            FormAssignTeacherSubject.Instance.Show();
            FormAssignTeacherSubject.Instance.BringToFront();
            FormAssignTeacherSubject.Instance.Activate();
            FormAssignTeacherSubject.Instance.WindowState = FormWindowState.Normal;
            FormAssignTeacherSubject.Instance.Focus();
        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddNewStaff.Instance.MdiParent = this;
            FormAddNewStaff.Instance.Show();
            FormAddNewStaff.Instance.BringToFront();
            FormAddNewStaff.Instance.Activate();
            FormAddNewStaff.Instance.WindowState = FormWindowState.Normal;
            FormAddNewStaff.Instance.Focus();
        }

        private void staffListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormStaffList.Instance.MdiParent = this;
            FormStaffList.Instance.Show();
            FormStaffList.Instance.BringToFront();
            FormStaffList.Instance.Activate();
            FormStaffList.Instance.WindowState = FormWindowState.Normal;
            FormStaffList.Instance.Focus();
        }

        
        private void addClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddClass.Instance.MdiParent = this;
            FormAddClass.Instance.Show();
            FormAddClass.Instance.BringToFront();
            FormAddClass.Instance.Activate();
            FormAddClass.Instance.WindowState = FormWindowState.Normal;
            FormAddClass.Instance.Focus();
        }

        private void addClassSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAssignClassSection.Instance.MdiParent = this;
            FormAssignClassSection.Instance.Show();
            FormAssignClassSection.Instance.BringToFront();
            FormAssignClassSection.Instance.Activate();
            FormAssignClassSection.Instance.WindowState = FormWindowState.Normal;
            FormAssignClassSection.Instance.Focus();
        }

        private void addExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddExam.Instance.MdiParent = this;
            FormAddExam.Instance.Show();
            FormAddExam.Instance.BringToFront();
            FormAddExam.Instance.Activate();
            FormAddExam.Instance.WindowState = FormWindowState.Normal;
            FormAddExam.Instance.Focus();
        }

        private void addPeriodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddPeriod.Instance.MdiParent = this;
            FormAddPeriod.Instance.Show();
            FormAddPeriod.Instance.BringToFront();
            FormAddPeriod.Instance.Activate();
            FormAddPeriod.Instance.WindowState = FormWindowState.Normal;
            FormAddPeriod.Instance.Focus();
        }

        private void addSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddSubject.Instance.MdiParent = this;
            FormAddSubject.Instance.Show();
            FormAddSubject.Instance.BringToFront();
            FormAddSubject.Instance.Activate();
            FormAddSubject.Instance.WindowState = FormWindowState.Normal;
            FormAddSubject.Instance.Focus();
        }

        private void addClassSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddClassSubject.Instance.MdiParent = this;
            FormAddClassSubject.Instance.Show();
            FormAddClassSubject.Instance.BringToFront();
            FormAddClassSubject.Instance.Activate();
            FormAddClassSubject.Instance.WindowState = FormWindowState.Normal;
            FormAddClassSubject.Instance.Focus();
        }

        private void generateRoutineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGeneratePeriod.Instance.MdiParent = this;
            FormGeneratePeriod.Instance.Show();
            FormGeneratePeriod.Instance.BringToFront();
            FormGeneratePeriod.Instance.Activate();
            FormGeneratePeriod.Instance.WindowState = FormWindowState.Normal;
            FormGeneratePeriod.Instance.Focus();
        }

        
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            Hide();
        }

        private void changePasswordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormChangePassword().ShowDialog();
        }

        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormUserInfo().ShowDialog();
        }

        private void changeMyInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormEditMyInfo().ShowDialog();
        }

        private void designationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddDesignation.Instance.MdiParent = this;
            FormAddDesignation.Instance.Show();
            FormAddDesignation.Instance.BringToFront();
            FormAddDesignation.Instance.Activate();
            FormAddDesignation.Instance.WindowState = FormWindowState.Normal;
            FormAddDesignation.Instance.Focus();
        }

        private void academicYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAcademicYear.Instance.MdiParent = this;
            FormAcademicYear.Instance.Show();
            FormAcademicYear.Instance.BringToFront();
            FormAcademicYear.Instance.Activate();
            FormAcademicYear.Instance.WindowState = FormWindowState.Normal;
            FormAcademicYear.Instance.Focus();
        }
    }
}
