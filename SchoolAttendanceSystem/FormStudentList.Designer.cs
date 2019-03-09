namespace SchoolAttendanceSystem
{
    partial class FormStudentList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.comboBoxLoadSection = new System.Windows.Forms.ComboBox();
            this.comboBoxLoadClass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.comboBoxSection = new System.Windows.Forms.ComboBox();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxBloodGroup = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonOther = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.richTextBoxAddress = new System.Windows.Forms.RichTextBox();
            this.textBoxMotherProfession = new System.Windows.Forms.TextBox();
            this.textBoxFatherProfession = new System.Windows.Forms.TextBox();
            this.textBoxRollNumber = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxReligion = new System.Windows.Forms.TextBox();
            this.textBoxMotherName = new System.Windows.Forms.TextBox();
            this.textBoxFatherName = new System.Windows.Forms.TextBox();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.labelMotherProfession = new System.Windows.Forms.Label();
            this.labelFatherProfession = new System.Windows.Forms.Label();
            this.labelRoll = new System.Windows.Forms.Label();
            this.labelSection = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.labelMother = new System.Windows.Forms.Label();
            this.labelFather = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.checkBoxIsActive = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRemoveImage = new System.Windows.Forms.Button();
            this.buttonUploadImage = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBoxEmployee = new System.Windows.Forms.PictureBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonUpdateStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLoad.FlatAppearance.BorderSize = 0;
            this.buttonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLoad.Location = new System.Drawing.Point(333, 11);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(92, 25);
            this.buttonLoad.TabIndex = 13;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // comboBoxLoadSection
            // 
            this.comboBoxLoadSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoadSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLoadSection.FormattingEnabled = true;
            this.comboBoxLoadSection.Location = new System.Drawing.Point(237, 12);
            this.comboBoxLoadSection.Name = "comboBoxLoadSection";
            this.comboBoxLoadSection.Size = new System.Drawing.Size(90, 24);
            this.comboBoxLoadSection.TabIndex = 11;
            // 
            // comboBoxLoadClass
            // 
            this.comboBoxLoadClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoadClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLoadClass.FormattingEnabled = true;
            this.comboBoxLoadClass.Location = new System.Drawing.Point(68, 12);
            this.comboBoxLoadClass.Name = "comboBoxLoadClass";
            this.comboBoxLoadClass.Size = new System.Drawing.Size(90, 24);
            this.comboBoxLoadClass.TabIndex = 10;
            this.comboBoxLoadClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxLoadClass_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Section:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Class:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(208, 61);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(187, 20);
            this.textBoxSearch.TabIndex = 93;
            this.textBoxSearch.Text = "Search...";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IdNumber,
            this.StudentName,
            this.IsActive});
            this.dataGridView1.Location = new System.Drawing.Point(15, 85);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(410, 442);
            this.dataGridView1.TabIndex = 94;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.Enter += new System.EventHandler(this.dataGridView1_Enter);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // IdNumber
            // 
            this.IdNumber.DataPropertyName = "IdNumber";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IdNumber.DefaultCellStyle = dataGridViewCellStyle2;
            this.IdNumber.HeaderText = "ID";
            this.IdNumber.Name = "IdNumber";
            this.IdNumber.ReadOnly = true;
            this.IdNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IdNumber.Width = 80;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "Name";
            this.StudentName.HeaderText = "Name";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentName.Width = 200;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IsActive.DefaultCellStyle = dataGridViewCellStyle3;
            this.IsActive.HeaderText = "Active?";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            this.IsActive.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IsActive.Width = 60;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SchoolAttendanceSystem.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(401, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.labelEmail);
            this.groupBox1.Controls.Add(this.labelStatus);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.comboBoxSection);
            this.groupBox1.Controls.Add(this.comboBoxClass);
            this.groupBox1.Controls.Add(this.comboBoxStatus);
            this.groupBox1.Controls.Add(this.comboBoxBloodGroup);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dateTimePickerBirthDate);
            this.groupBox1.Controls.Add(this.richTextBoxAddress);
            this.groupBox1.Controls.Add(this.textBoxMotherProfession);
            this.groupBox1.Controls.Add(this.textBoxFatherProfession);
            this.groupBox1.Controls.Add(this.textBoxRollNumber);
            this.groupBox1.Controls.Add(this.textBoxPhone);
            this.groupBox1.Controls.Add(this.textBoxReligion);
            this.groupBox1.Controls.Add(this.textBoxMotherName);
            this.groupBox1.Controls.Add(this.textBoxFatherName);
            this.groupBox1.Controls.Add(this.textBoxStudentName);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.labelMotherProfession);
            this.groupBox1.Controls.Add(this.labelFatherProfession);
            this.groupBox1.Controls.Add(this.labelRoll);
            this.groupBox1.Controls.Add(this.labelSection);
            this.groupBox1.Controls.Add(this.labelClass);
            this.groupBox1.Controls.Add(this.labelPhone);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.labelGender);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.labelMother);
            this.groupBox1.Controls.Add(this.labelFather);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.checkBoxIsActive);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonRemoveImage);
            this.groupBox1.Controls.Add(this.buttonUploadImage);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pictureBoxEmployee);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.buttonReset);
            this.groupBox1.Controls.Add(this.buttonUpdateStudent);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(431, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 516);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Info";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(653, 361);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 17);
            this.label12.TabIndex = 244;
            this.label12.Text = "*";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(171, 360);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(242, 21);
            this.textBoxEmail.TabIndex = 243;
            // 
            // labelEmail
            // 
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(6, 361);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(159, 25);
            this.labelEmail.TabIndex = 242;
            this.labelEmail.Text = "Email:";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(423, 361);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(100, 25);
            this.labelStatus.TabIndex = 240;
            this.labelStatus.Text = "Status:";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.Red;
            this.label30.Location = new System.Drawing.Point(653, 336);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(14, 17);
            this.label30.TabIndex = 237;
            this.label30.Text = "*";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Red;
            this.label29.Location = new System.Drawing.Point(653, 307);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(14, 17);
            this.label29.TabIndex = 236;
            this.label29.Text = "*";
            // 
            // comboBoxSection
            // 
            this.comboBoxSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSection.FormattingEnabled = true;
            this.comboBoxSection.Location = new System.Drawing.Point(529, 304);
            this.comboBoxSection.Name = "comboBoxSection";
            this.comboBoxSection.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSection.TabIndex = 235;
            this.comboBoxSection.SelectedIndexChanged += new System.EventHandler(this.comboBoxSection_SelectedIndexChanged);
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Items.AddRange(new object[] {
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
            this.comboBoxClass.Location = new System.Drawing.Point(529, 275);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(121, 23);
            this.comboBoxClass.TabIndex = 234;
            this.comboBoxClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxClass_SelectedIndexChanged);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.Enabled = false;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "A+",
            "B+",
            "O+",
            "AB+",
            "A-",
            "B-",
            "O-",
            "AB-"});
            this.comboBoxStatus.Location = new System.Drawing.Point(529, 358);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 23);
            this.comboBoxStatus.TabIndex = 233;
            // 
            // comboBoxBloodGroup
            // 
            this.comboBoxBloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBloodGroup.FormattingEnabled = true;
            this.comboBoxBloodGroup.Items.AddRange(new object[] {
            "A+",
            "B+",
            "O+",
            "AB+",
            "A-",
            "B-",
            "O-",
            "AB-"});
            this.comboBoxBloodGroup.Location = new System.Drawing.Point(171, 182);
            this.comboBoxBloodGroup.Name = "comboBoxBloodGroup";
            this.comboBoxBloodGroup.Size = new System.Drawing.Size(121, 23);
            this.comboBoxBloodGroup.TabIndex = 233;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonOther);
            this.groupBox2.Controls.Add(this.radioButtonFemale);
            this.groupBox2.Controls.Add(this.radioButtonMale);
            this.groupBox2.Location = new System.Drawing.Point(171, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 23);
            this.groupBox2.TabIndex = 232;
            this.groupBox2.TabStop = false;
            // 
            // radioButtonOther
            // 
            this.radioButtonOther.AutoSize = true;
            this.radioButtonOther.Location = new System.Drawing.Point(178, 3);
            this.radioButtonOther.Name = "radioButtonOther";
            this.radioButtonOther.Size = new System.Drawing.Size(60, 19);
            this.radioButtonOther.TabIndex = 2;
            this.radioButtonOther.TabStop = true;
            this.radioButtonOther.Text = "Other";
            this.radioButtonOther.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(82, 3);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(73, 19);
            this.radioButtonFemale.TabIndex = 1;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(6, 3);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(57, 19);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(171, 101);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(242, 21);
            this.dateTimePickerBirthDate.TabIndex = 231;
            // 
            // richTextBoxAddress
            // 
            this.richTextBoxAddress.Location = new System.Drawing.Point(171, 286);
            this.richTextBoxAddress.Name = "richTextBoxAddress";
            this.richTextBoxAddress.Size = new System.Drawing.Size(242, 68);
            this.richTextBoxAddress.TabIndex = 230;
            this.richTextBoxAddress.Text = "";
            // 
            // textBoxMotherProfession
            // 
            this.textBoxMotherProfession.Location = new System.Drawing.Point(171, 259);
            this.textBoxMotherProfession.Name = "textBoxMotherProfession";
            this.textBoxMotherProfession.Size = new System.Drawing.Size(242, 21);
            this.textBoxMotherProfession.TabIndex = 229;
            // 
            // textBoxFatherProfession
            // 
            this.textBoxFatherProfession.Location = new System.Drawing.Point(171, 234);
            this.textBoxFatherProfession.Name = "textBoxFatherProfession";
            this.textBoxFatherProfession.Size = new System.Drawing.Size(242, 21);
            this.textBoxFatherProfession.TabIndex = 228;
            // 
            // textBoxRollNumber
            // 
            this.textBoxRollNumber.Enabled = false;
            this.textBoxRollNumber.Location = new System.Drawing.Point(529, 333);
            this.textBoxRollNumber.Name = "textBoxRollNumber";
            this.textBoxRollNumber.Size = new System.Drawing.Size(121, 21);
            this.textBoxRollNumber.TabIndex = 227;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(171, 207);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(242, 21);
            this.textBoxPhone.TabIndex = 226;
            // 
            // textBoxReligion
            // 
            this.textBoxReligion.Location = new System.Drawing.Point(171, 157);
            this.textBoxReligion.Name = "textBoxReligion";
            this.textBoxReligion.Size = new System.Drawing.Size(242, 21);
            this.textBoxReligion.TabIndex = 225;
            // 
            // textBoxMotherName
            // 
            this.textBoxMotherName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxMotherName.Location = new System.Drawing.Point(171, 74);
            this.textBoxMotherName.Name = "textBoxMotherName";
            this.textBoxMotherName.Size = new System.Drawing.Size(242, 21);
            this.textBoxMotherName.TabIndex = 224;
            // 
            // textBoxFatherName
            // 
            this.textBoxFatherName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxFatherName.Location = new System.Drawing.Point(171, 45);
            this.textBoxFatherName.Name = "textBoxFatherName";
            this.textBoxFatherName.Size = new System.Drawing.Size(242, 21);
            this.textBoxFatherName.TabIndex = 223;
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxStudentName.Location = new System.Drawing.Point(171, 20);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(242, 21);
            this.textBoxStudentName.TabIndex = 222;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 289);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 25);
            this.label15.TabIndex = 221;
            this.label15.Text = "Address:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelMotherProfession
            // 
            this.labelMotherProfession.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotherProfession.Location = new System.Drawing.Point(6, 260);
            this.labelMotherProfession.Name = "labelMotherProfession";
            this.labelMotherProfession.Size = new System.Drawing.Size(159, 25);
            this.labelMotherProfession.TabIndex = 220;
            this.labelMotherProfession.Text = "Mother\'s Profession:";
            this.labelMotherProfession.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelFatherProfession
            // 
            this.labelFatherProfession.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFatherProfession.Location = new System.Drawing.Point(6, 235);
            this.labelFatherProfession.Name = "labelFatherProfession";
            this.labelFatherProfession.Size = new System.Drawing.Size(159, 25);
            this.labelFatherProfession.TabIndex = 219;
            this.labelFatherProfession.Text = "Father\'s Profession:";
            this.labelFatherProfession.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelRoll
            // 
            this.labelRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoll.Location = new System.Drawing.Point(420, 334);
            this.labelRoll.Name = "labelRoll";
            this.labelRoll.Size = new System.Drawing.Size(103, 25);
            this.labelRoll.TabIndex = 218;
            this.labelRoll.Text = "Roll Number:";
            this.labelRoll.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelSection
            // 
            this.labelSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSection.Location = new System.Drawing.Point(419, 305);
            this.labelSection.Name = "labelSection";
            this.labelSection.Size = new System.Drawing.Size(104, 25);
            this.labelSection.TabIndex = 217;
            this.labelSection.Text = "Section:";
            this.labelSection.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelClass
            // 
            this.labelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.Location = new System.Drawing.Point(419, 276);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(104, 25);
            this.labelClass.TabIndex = 216;
            this.labelClass.Text = "Class:";
            this.labelClass.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelPhone
            // 
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(6, 208);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(159, 25);
            this.labelPhone.TabIndex = 215;
            this.labelPhone.Text = "Phone:";
            this.labelPhone.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(6, 183);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(159, 25);
            this.label22.TabIndex = 214;
            this.label22.Text = "Blood Group:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(6, 158);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(159, 23);
            this.label23.TabIndex = 213;
            this.label23.Text = "Religion:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelGender
            // 
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(6, 131);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(159, 23);
            this.labelGender.TabIndex = 212;
            this.labelGender.Text = "Gender:";
            this.labelGender.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(6, 106);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(159, 23);
            this.label25.TabIndex = 211;
            this.label25.Text = "Date Of Birth:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelMother
            // 
            this.labelMother.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMother.Location = new System.Drawing.Point(6, 75);
            this.labelMother.Name = "labelMother";
            this.labelMother.Size = new System.Drawing.Size(159, 23);
            this.labelMother.TabIndex = 210;
            this.labelMother.Text = "Mother\'s Name:";
            this.labelMother.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelFather
            // 
            this.labelFather.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFather.Location = new System.Drawing.Point(6, 48);
            this.labelFather.Name = "labelFather";
            this.labelFather.Size = new System.Drawing.Size(159, 23);
            this.labelFather.TabIndex = 209;
            this.labelFather.Text = "Father\'s Name:";
            this.labelFather.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(6, 21);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(159, 23);
            this.labelName.TabIndex = 208;
            this.labelName.Text = "Name:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // checkBoxIsActive
            // 
            this.checkBoxIsActive.AutoSize = true;
            this.checkBoxIsActive.Checked = true;
            this.checkBoxIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIsActive.Location = new System.Drawing.Point(171, 389);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIsActive.TabIndex = 11;
            this.checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 207;
            this.label4.Text = "Active? :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonRemoveImage
            // 
            this.buttonRemoveImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRemoveImage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonRemoveImage.FlatAppearance.BorderSize = 0;
            this.buttonRemoveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveImage.Location = new System.Drawing.Point(587, 199);
            this.buttonRemoveImage.Name = "buttonRemoveImage";
            this.buttonRemoveImage.Size = new System.Drawing.Size(80, 25);
            this.buttonRemoveImage.TabIndex = 13;
            this.buttonRemoveImage.Text = "Remove";
            this.buttonRemoveImage.UseVisualStyleBackColor = false;
            this.buttonRemoveImage.Visible = false;
            // 
            // buttonUploadImage
            // 
            this.buttonUploadImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUploadImage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonUploadImage.FlatAppearance.BorderSize = 0;
            this.buttonUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUploadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUploadImage.Location = new System.Drawing.Point(497, 199);
            this.buttonUploadImage.Name = "buttonUploadImage";
            this.buttonUploadImage.Size = new System.Drawing.Size(80, 25);
            this.buttonUploadImage.TabIndex = 12;
            this.buttonUploadImage.Text = "Upload";
            this.buttonUploadImage.UseVisualStyleBackColor = false;
            this.buttonUploadImage.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(321, 407);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(112, 15);
            this.label20.TabIndex = 204;
            this.label20.Text = "Required Filed *";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(653, 276);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 17);
            this.label19.TabIndex = 203;
            this.label19.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(419, 259);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 17);
            this.label18.TabIndex = 202;
            this.label18.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(419, 235);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 17);
            this.label17.TabIndex = 201;
            this.label17.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(419, 208);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 17);
            this.label16.TabIndex = 200;
            this.label16.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(419, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 17);
            this.label14.TabIndex = 199;
            this.label14.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(419, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 17);
            this.label13.TabIndex = 198;
            this.label13.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(419, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 17);
            this.label5.TabIndex = 197;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(419, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 17);
            this.label6.TabIndex = 196;
            this.label6.Text = "*";
            // 
            // pictureBoxEmployee
            // 
            this.pictureBoxEmployee.Image = global::SchoolAttendanceSystem.Properties.Resources.blank_profile_picture;
            this.pictureBoxEmployee.InitialImage = global::SchoolAttendanceSystem.Properties.Resources.blank_profile_picture;
            this.pictureBoxEmployee.Location = new System.Drawing.Point(497, 23);
            this.pictureBoxEmployee.Name = "pictureBoxEmployee";
            this.pictureBoxEmployee.Size = new System.Drawing.Size(170, 170);
            this.pictureBoxEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEmployee.TabIndex = 191;
            this.pictureBoxEmployee.TabStop = false;
            this.pictureBoxEmployee.Visible = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(317, 463);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(116, 40);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Add New";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonReset.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonReset.FlatAppearance.BorderSize = 0;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(73, 463);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(116, 40);
            this.buttonReset.TabIndex = 16;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonUpdateStudent
            // 
            this.buttonUpdateStudent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonUpdateStudent.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonUpdateStudent.FlatAppearance.BorderSize = 0;
            this.buttonUpdateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateStudent.Location = new System.Drawing.Point(195, 463);
            this.buttonUpdateStudent.Name = "buttonUpdateStudent";
            this.buttonUpdateStudent.Size = new System.Drawing.Size(116, 40);
            this.buttonUpdateStudent.TabIndex = 15;
            this.buttonUpdateStudent.Text = "Update Info";
            this.buttonUpdateStudent.UseVisualStyleBackColor = false;
            this.buttonUpdateStudent.Click += new System.EventHandler(this.buttonUpdateStudent_Click);
            // 
            // FormStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 536);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.comboBoxLoadSection);
            this.Controls.Add(this.comboBoxLoadClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStudentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Student List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStudentList_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.ComboBox comboBoxLoadSection;
        private System.Windows.Forms.ComboBox comboBoxLoadClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxIsActive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRemoveImage;
        private System.Windows.Forms.Button buttonUploadImage;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBoxEmployee;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonUpdateStudent;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox comboBoxSection;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.ComboBox comboBoxBloodGroup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonOther;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.RichTextBox richTextBoxAddress;
        private System.Windows.Forms.TextBox textBoxMotherProfession;
        private System.Windows.Forms.TextBox textBoxFatherProfession;
        private System.Windows.Forms.TextBox textBoxRollNumber;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxReligion;
        private System.Windows.Forms.TextBox textBoxMotherName;
        private System.Windows.Forms.TextBox textBoxFatherName;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelMotherProfession;
        private System.Windows.Forms.Label labelFatherProfession;
        private System.Windows.Forms.Label labelRoll;
        private System.Windows.Forms.Label labelSection;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label labelMother;
        private System.Windows.Forms.Label labelFather;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label12;
    }
}