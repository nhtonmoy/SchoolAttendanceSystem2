namespace SchoolAttendanceSystem
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeMyInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promoteStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClassSectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSubjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClassSubjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.academicYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonStudentList = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAttendance = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAddMarks = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonPromoteStudents = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.teacherToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userInfoToolStripMenuItem,
            this.changeMyInformationToolStripMenuItem,
            this.changePasswordToolStripMenuItem1,
            this.logOutToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // userInfoToolStripMenuItem
            // 
            this.userInfoToolStripMenuItem.Name = "userInfoToolStripMenuItem";
            this.userInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userInfoToolStripMenuItem.Text = "User Info";
            this.userInfoToolStripMenuItem.Click += new System.EventHandler(this.userInfoToolStripMenuItem_Click);
            // 
            // changeMyInformationToolStripMenuItem
            // 
            this.changeMyInformationToolStripMenuItem.Name = "changeMyInformationToolStripMenuItem";
            this.changeMyInformationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeMyInformationToolStripMenuItem.Text = "Edit My Information";
            this.changeMyInformationToolStripMenuItem.Click += new System.EventHandler(this.changeMyInformationToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem1
            // 
            this.changePasswordToolStripMenuItem1.Name = "changePasswordToolStripMenuItem1";
            this.changePasswordToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.changePasswordToolStripMenuItem1.Text = "Change Password";
            this.changePasswordToolStripMenuItem1.Click += new System.EventHandler(this.changePasswordToolStripMenuItem1_Click);
            // 
            // logOutToolStripMenuItem1
            // 
            this.logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            this.logOutToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.logOutToolStripMenuItem1.Text = "Log Out";
            this.logOutToolStripMenuItem1.Click += new System.EventHandler(this.logOutToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentListToolStripMenuItem,
            this.attendanceToolStripMenuItem,
            this.addMarksToolStripMenuItem,
            this.promoteStudentsToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // studentListToolStripMenuItem
            // 
            this.studentListToolStripMenuItem.Name = "studentListToolStripMenuItem";
            this.studentListToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.studentListToolStripMenuItem.Text = "Student List";
            this.studentListToolStripMenuItem.Click += new System.EventHandler(this.studentListToolStripMenuItem_Click);
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.attendanceToolStripMenuItem.Text = "Attendance";
            this.attendanceToolStripMenuItem.Click += new System.EventHandler(this.attendanceToolStripMenuItem_Click);
            // 
            // addMarksToolStripMenuItem
            // 
            this.addMarksToolStripMenuItem.Name = "addMarksToolStripMenuItem";
            this.addMarksToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.addMarksToolStripMenuItem.Text = "Add Marks";
            this.addMarksToolStripMenuItem.Click += new System.EventHandler(this.addMarksToolStripMenuItem_Click);
            // 
            // promoteStudentsToolStripMenuItem
            // 
            this.promoteStudentsToolStripMenuItem.Name = "promoteStudentsToolStripMenuItem";
            this.promoteStudentsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.promoteStudentsToolStripMenuItem.Text = "Promote Students";
            this.promoteStudentsToolStripMenuItem.Click += new System.EventHandler(this.promoteStudentsToolStripMenuItem_Click);
            // 
            // teacherToolStripMenuItem
            // 
            this.teacherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTeacherToolStripMenuItem,
            this.designationToolStripMenuItem});
            this.teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            this.teacherToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.teacherToolStripMenuItem.Text = "Teacher";
            // 
            // addTeacherToolStripMenuItem
            // 
            this.addTeacherToolStripMenuItem.Name = "addTeacherToolStripMenuItem";
            this.addTeacherToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addTeacherToolStripMenuItem.Text = "Teacher List";
            this.addTeacherToolStripMenuItem.Click += new System.EventHandler(this.addTeacherToolStripMenuItem_Click);
            // 
            // designationToolStripMenuItem
            // 
            this.designationToolStripMenuItem.Name = "designationToolStripMenuItem";
            this.designationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.designationToolStripMenuItem.Text = "Designation";
            this.designationToolStripMenuItem.Click += new System.EventHandler(this.designationToolStripMenuItem_Click);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffListToolStripMenuItem});
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.staffToolStripMenuItem.Text = "Staff";
            // 
            // staffListToolStripMenuItem
            // 
            this.staffListToolStripMenuItem.Name = "staffListToolStripMenuItem";
            this.staffListToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.staffListToolStripMenuItem.Text = "Staff List";
            this.staffListToolStripMenuItem.Click += new System.EventHandler(this.staffListToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClassToolStripMenuItem,
            this.addClassSectionToolStripMenuItem,
            this.addExamToolStripMenuItem,
            this.addSubjectToolStripMenuItem,
            this.addClassSubjectToolStripMenuItem,
            this.academicYearToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // addClassToolStripMenuItem
            // 
            this.addClassToolStripMenuItem.Name = "addClassToolStripMenuItem";
            this.addClassToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.addClassToolStripMenuItem.Text = "Add Class";
            this.addClassToolStripMenuItem.Click += new System.EventHandler(this.addClassToolStripMenuItem_Click);
            // 
            // addClassSectionToolStripMenuItem
            // 
            this.addClassSectionToolStripMenuItem.Name = "addClassSectionToolStripMenuItem";
            this.addClassSectionToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.addClassSectionToolStripMenuItem.Text = "Add Section To Class";
            this.addClassSectionToolStripMenuItem.Click += new System.EventHandler(this.addClassSectionToolStripMenuItem_Click);
            // 
            // addExamToolStripMenuItem
            // 
            this.addExamToolStripMenuItem.Name = "addExamToolStripMenuItem";
            this.addExamToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.addExamToolStripMenuItem.Text = "Add Exam";
            this.addExamToolStripMenuItem.Click += new System.EventHandler(this.addExamToolStripMenuItem_Click);
            // 
            // addSubjectToolStripMenuItem
            // 
            this.addSubjectToolStripMenuItem.Name = "addSubjectToolStripMenuItem";
            this.addSubjectToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.addSubjectToolStripMenuItem.Text = "Add Subject";
            this.addSubjectToolStripMenuItem.Click += new System.EventHandler(this.addSubjectToolStripMenuItem_Click);
            // 
            // addClassSubjectToolStripMenuItem
            // 
            this.addClassSubjectToolStripMenuItem.Name = "addClassSubjectToolStripMenuItem";
            this.addClassSubjectToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.addClassSubjectToolStripMenuItem.Text = "Add Subject To Class";
            this.addClassSubjectToolStripMenuItem.Click += new System.EventHandler(this.addClassSubjectToolStripMenuItem_Click);
            // 
            // academicYearToolStripMenuItem
            // 
            this.academicYearToolStripMenuItem.Name = "academicYearToolStripMenuItem";
            this.academicYearToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.academicYearToolStripMenuItem.Text = "Academic Year";
            this.academicYearToolStripMenuItem.Click += new System.EventHandler(this.academicYearToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.toolStripButtonStudentList,
            this.toolStripSeparator5,
            this.toolStripButtonAttendance,
            this.toolStripSeparator6,
            this.toolStripButtonAddMarks,
            this.toolStripSeparator1,
            this.toolStripButtonPromoteStudents,
            this.toolStripSeparator7});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(140, 514);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(138, 6);
            // 
            // toolStripButtonStudentList
            // 
            this.toolStripButtonStudentList.AutoSize = false;
            this.toolStripButtonStudentList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonStudentList.Image = global::SchoolAttendanceSystem.Properties.Resources.Student_List;
            this.toolStripButtonStudentList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStudentList.Name = "toolStripButtonStudentList";
            this.toolStripButtonStudentList.Size = new System.Drawing.Size(120, 50);
            this.toolStripButtonStudentList.Text = "Student List";
            this.toolStripButtonStudentList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButtonStudentList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonStudentList.Click += new System.EventHandler(this.toolStripButtonStudentList_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(138, 6);
            // 
            // toolStripButtonAttendance
            // 
            this.toolStripButtonAttendance.AutoSize = false;
            this.toolStripButtonAttendance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonAttendance.Image = global::SchoolAttendanceSystem.Properties.Resources.Attendance;
            this.toolStripButtonAttendance.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAttendance.Name = "toolStripButtonAttendance";
            this.toolStripButtonAttendance.Size = new System.Drawing.Size(120, 50);
            this.toolStripButtonAttendance.Text = "Attendance";
            this.toolStripButtonAttendance.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButtonAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonAttendance.Click += new System.EventHandler(this.toolStripButtonAttendance_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(138, 6);
            // 
            // toolStripButtonAddMarks
            // 
            this.toolStripButtonAddMarks.AutoSize = false;
            this.toolStripButtonAddMarks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonAddMarks.Image = global::SchoolAttendanceSystem.Properties.Resources.AddMarks;
            this.toolStripButtonAddMarks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddMarks.Name = "toolStripButtonAddMarks";
            this.toolStripButtonAddMarks.Size = new System.Drawing.Size(120, 50);
            this.toolStripButtonAddMarks.Text = "Add Marks";
            this.toolStripButtonAddMarks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButtonAddMarks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonAddMarks.Click += new System.EventHandler(this.toolStripButtonAddMarks_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // toolStripButtonPromoteStudents
            // 
            this.toolStripButtonPromoteStudents.AutoSize = false;
            this.toolStripButtonPromoteStudents.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonPromoteStudents.Image = global::SchoolAttendanceSystem.Properties.Resources.PromoteStudent;
            this.toolStripButtonPromoteStudents.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPromoteStudents.Name = "toolStripButtonPromoteStudents";
            this.toolStripButtonPromoteStudents.Size = new System.Drawing.Size(120, 50);
            this.toolStripButtonPromoteStudents.Text = "Promote Students";
            this.toolStripButtonPromoteStudents.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButtonPromoteStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonPromoteStudents.Click += new System.EventHandler(this.toolStripButtonPromoteStudents_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(138, 6);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 538);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonStudentList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButtonAttendance;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promoteStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClassSectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addExamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSubjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClassSubjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddMarks;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonPromoteStudents;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem userInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeMyInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem designationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem academicYearToolStripMenuItem;
    }
}