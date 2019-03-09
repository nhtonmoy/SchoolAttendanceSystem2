namespace SchoolAttendanceSystem
{
    partial class FormAddMarks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.comboBoxSection = new System.Windows.Forms.ComboBox();
            this.labelSection = new System.Windows.Forms.Label();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.labelClass = new System.Windows.Forms.Label();
            this.buttonUpdateMarks = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSectionName = new System.Windows.Forms.Label();
            this.labelSeaction = new System.Windows.Forms.Label();
            this.labelClassname = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelRoll = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelIdNumber = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Roll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewMarks = new System.Windows.Forms.DataGridView();
            this.SubjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarksId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.labelMarksGridError = new System.Windows.Forms.Label();
            this.labelClassNameLoad = new System.Windows.Forms.Label();
            this.comboBoxExam = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLoad.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLoad.FlatAppearance.BorderSize = 0;
            this.buttonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.Location = new System.Drawing.Point(414, 5);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(103, 25);
            this.buttonLoad.TabIndex = 66;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // comboBoxSection
            // 
            this.comboBoxSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSection.Enabled = false;
            this.comboBoxSection.FormattingEnabled = true;
            this.comboBoxSection.Location = new System.Drawing.Point(279, 8);
            this.comboBoxSection.Name = "comboBoxSection";
            this.comboBoxSection.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSection.TabIndex = 65;
            // 
            // labelSection
            // 
            this.labelSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSection.Location = new System.Drawing.Point(217, 9);
            this.labelSection.Name = "labelSection";
            this.labelSection.Size = new System.Drawing.Size(60, 25);
            this.labelSection.TabIndex = 64;
            this.labelSection.Text = "Section:";
            this.labelSection.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(73, 8);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClass.TabIndex = 63;
            this.comboBoxClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxClass_SelectedIndexChanged);
            // 
            // labelClass
            // 
            this.labelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.Location = new System.Drawing.Point(7, 9);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(60, 25);
            this.labelClass.TabIndex = 62;
            this.labelClass.Text = "Class:";
            this.labelClass.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonUpdateMarks
            // 
            this.buttonUpdateMarks.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUpdateMarks.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonUpdateMarks.FlatAppearance.BorderSize = 0;
            this.buttonUpdateMarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateMarks.Location = new System.Drawing.Point(669, 478);
            this.buttonUpdateMarks.Name = "buttonUpdateMarks";
            this.buttonUpdateMarks.Size = new System.Drawing.Size(114, 40);
            this.buttonUpdateMarks.TabIndex = 74;
            this.buttonUpdateMarks.Text = "Update";
            this.buttonUpdateMarks.UseVisualStyleBackColor = false;
            this.buttonUpdateMarks.Click += new System.EventHandler(this.buttonUpdateMarks_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.labelSectionName);
            this.groupBox1.Controls.Add(this.labelSeaction);
            this.groupBox1.Controls.Add(this.labelClassname);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBoxExam);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelRoll);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.labelIdNumber);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(414, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 102);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Info";
            // 
            // labelSectionName
            // 
            this.labelSectionName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSectionName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSectionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSectionName.Location = new System.Drawing.Point(250, 45);
            this.labelSectionName.Name = "labelSectionName";
            this.labelSectionName.Size = new System.Drawing.Size(113, 23);
            this.labelSectionName.TabIndex = 105;
            this.labelSectionName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSeaction
            // 
            this.labelSeaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeaction.Location = new System.Drawing.Point(189, 48);
            this.labelSeaction.Name = "labelSeaction";
            this.labelSeaction.Size = new System.Drawing.Size(55, 23);
            this.labelSeaction.TabIndex = 104;
            this.labelSeaction.Text = "Section:";
            // 
            // labelClassname
            // 
            this.labelClassname.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelClassname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelClassname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClassname.Location = new System.Drawing.Point(56, 44);
            this.labelClassname.Name = "labelClassname";
            this.labelClassname.Size = new System.Drawing.Size(127, 23);
            this.labelClassname.TabIndex = 103;
            this.labelClassname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 23);
            this.label8.TabIndex = 102;
            this.label8.Text = "Class:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 52;
            this.label4.Text = "Exam:";
            // 
            // labelRoll
            // 
            this.labelRoll.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRoll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoll.Location = new System.Drawing.Point(270, 17);
            this.labelRoll.Name = "labelRoll";
            this.labelRoll.Size = new System.Drawing.Size(93, 23);
            this.labelRoll.TabIndex = 51;
            this.labelRoll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 23);
            this.label3.TabIndex = 50;
            this.label3.Text = "Roll:";
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(56, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(164, 23);
            this.labelName.TabIndex = 49;
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 23);
            this.label7.TabIndex = 48;
            this.label7.Text = "Name:";
            // 
            // labelIdNumber
            // 
            this.labelIdNumber.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelIdNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelIdNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdNumber.Location = new System.Drawing.Point(33, 72);
            this.labelIdNumber.Name = "labelIdNumber";
            this.labelIdNumber.Size = new System.Drawing.Size(150, 23);
            this.labelIdNumber.TabIndex = 45;
            this.labelIdNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(7, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 23);
            this.label16.TabIndex = 44;
            this.label16.Text = "ID:";
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.AllowUserToAddRows = false;
            this.dataGridViewStudent.AllowUserToDeleteRows = false;
            this.dataGridViewStudent.AllowUserToResizeColumns = false;
            this.dataGridViewStudent.AllowUserToResizeRows = false;
            this.dataGridViewStudent.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Roll,
            this.StudentName});
            this.dataGridViewStudent.Location = new System.Drawing.Point(35, 38);
            this.dataGridViewStudent.MultiSelect = false;
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewStudent.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudent.Size = new System.Drawing.Size(373, 434);
            this.dataGridViewStudent.TabIndex = 95;
            this.dataGridViewStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudent_CellClick);
            this.dataGridViewStudent.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewStudent_DataBindingComplete);
            this.dataGridViewStudent.SelectionChanged += new System.EventHandler(this.dataGridViewStudent_SelectionChanged);
            this.dataGridViewStudent.Enter += new System.EventHandler(this.dataGridViewStudent_Enter);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Roll
            // 
            this.Roll.DataPropertyName = "RollNumber";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Roll.DefaultCellStyle = dataGridViewCellStyle2;
            this.Roll.HeaderText = "Roll";
            this.Roll.Name = "Roll";
            this.Roll.ReadOnly = true;
            this.Roll.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Roll.Width = 80;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "Name";
            this.StudentName.HeaderText = "Name";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentName.Width = 220;
            // 
            // dataGridViewMarks
            // 
            this.dataGridViewMarks.AllowUserToAddRows = false;
            this.dataGridViewMarks.AllowUserToDeleteRows = false;
            this.dataGridViewMarks.AllowUserToResizeColumns = false;
            this.dataGridViewMarks.AllowUserToResizeRows = false;
            this.dataGridViewMarks.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMarks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectId,
            this.SubjectName,
            this.MarksId,
            this.Marks});
            this.dataGridViewMarks.Location = new System.Drawing.Point(414, 146);
            this.dataGridViewMarks.MultiSelect = false;
            this.dataGridViewMarks.Name = "dataGridViewMarks";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewMarks.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewMarks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewMarks.Size = new System.Drawing.Size(369, 326);
            this.dataGridViewMarks.TabIndex = 96;
            this.dataGridViewMarks.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMarks_CellEndEdit);
            this.dataGridViewMarks.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridViewMarks_CellValidating);
            // 
            // SubjectId
            // 
            this.SubjectId.DataPropertyName = "ClassSectionSubjectId";
            this.SubjectId.HeaderText = "Id";
            this.SubjectId.Name = "SubjectId";
            this.SubjectId.ReadOnly = true;
            this.SubjectId.Visible = false;
            // 
            // SubjectName
            // 
            this.SubjectName.DataPropertyName = "Subject";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SubjectName.DefaultCellStyle = dataGridViewCellStyle5;
            this.SubjectName.HeaderText = "Subject";
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.ReadOnly = true;
            this.SubjectName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SubjectName.Width = 200;
            // 
            // MarksId
            // 
            this.MarksId.DataPropertyName = "MarksId";
            this.MarksId.HeaderText = "Marks Id";
            this.MarksId.Name = "MarksId";
            this.MarksId.ReadOnly = true;
            this.MarksId.Visible = false;
            // 
            // Marks
            // 
            this.Marks.DataPropertyName = "Marks";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Marks.DefaultCellStyle = dataGridViewCellStyle6;
            this.Marks.HeaderText = "Marks";
            this.Marks.Name = "Marks";
            this.Marks.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(197, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 17);
            this.label14.TabIndex = 200;
            this.label14.Text = "*";
            // 
            // labelMarksGridError
            // 
            this.labelMarksGridError.AutoSize = true;
            this.labelMarksGridError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarksGridError.ForeColor = System.Drawing.Color.Red;
            this.labelMarksGridError.Location = new System.Drawing.Point(411, 490);
            this.labelMarksGridError.Name = "labelMarksGridError";
            this.labelMarksGridError.Size = new System.Drawing.Size(0, 15);
            this.labelMarksGridError.TabIndex = 205;
            // 
            // labelClassNameLoad
            // 
            this.labelClassNameLoad.AutoSize = true;
            this.labelClassNameLoad.Location = new System.Drawing.Point(10, 504);
            this.labelClassNameLoad.Name = "labelClassNameLoad";
            this.labelClassNameLoad.Size = new System.Drawing.Size(35, 13);
            this.labelClassNameLoad.TabIndex = 206;
            this.labelClassNameLoad.Text = "label2";
            this.labelClassNameLoad.Visible = false;
            // 
            // comboBoxExam
            // 
            this.comboBoxExam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExam.Enabled = false;
            this.comboBoxExam.FormattingEnabled = true;
            this.comboBoxExam.Items.AddRange(new object[] {
            "Class 1",
            "Class 2",
            "Class 3",
            "Class 4",
            "Class 5",
            "Class 6",
            "Class 7",
            "Class 8",
            "Class 9",
            "Class 10"});
            this.comboBoxExam.Location = new System.Drawing.Point(242, 71);
            this.comboBoxExam.Name = "comboBoxExam";
            this.comboBoxExam.Size = new System.Drawing.Size(121, 23);
            this.comboBoxExam.TabIndex = 97;
            this.comboBoxExam.SelectedIndexChanged += new System.EventHandler(this.comboBoxExam_SelectedIndexChanged);
            // 
            // FormAddMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 524);
            this.Controls.Add(this.labelClassNameLoad);
            this.Controls.Add(this.labelMarksGridError);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dataGridViewMarks);
            this.Controls.Add(this.dataGridViewStudent);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonUpdateMarks);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.comboBoxSection);
            this.Controls.Add(this.labelSection);
            this.Controls.Add(this.comboBoxClass);
            this.Controls.Add(this.labelClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddMarks";
            this.Text = "FormAddMarks";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddMarks_FormClosed);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.ComboBox comboBoxSection;
        private System.Windows.Forms.Label labelSection;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Button buttonUpdateMarks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelIdNumber;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelRoll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.DataGridView dataGridViewMarks;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roll;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.Label labelMarksGridError;
        private System.Windows.Forms.Label labelSectionName;
        private System.Windows.Forms.Label labelSeaction;
        private System.Windows.Forms.Label labelClassname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelClassNameLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarksId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marks;
        private System.Windows.Forms.ComboBox comboBoxExam;
    }
}