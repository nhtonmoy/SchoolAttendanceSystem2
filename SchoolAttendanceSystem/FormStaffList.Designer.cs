namespace SchoolAttendanceSystem
{
    partial class FormStaffList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxIsActive = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRemoveImage = new System.Windows.Forms.Button();
            this.buttonUploadImage = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.dateTimePickerJoinDate = new System.Windows.Forms.DateTimePicker();
            this.labelJoinDate = new System.Windows.Forms.Label();
            this.pictureBoxEmployee = new System.Windows.Forms.PictureBox();
            this.comboBoxBloodGroup = new System.Windows.Forms.ComboBox();
            this.groupBoxRadioButton = new System.Windows.Forms.GroupBox();
            this.radioButtonOther = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelBloodGroup = new System.Windows.Forms.Label();
            this.labelReligion = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.richTextBoxAddress = new System.Windows.Forms.RichTextBox();
            this.textBoxReligion = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonUpdateStaff = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployee)).BeginInit();
            this.groupBoxRadioButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
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
            this.StaffName,
            this.IsActive});
            this.dataGridView1.Location = new System.Drawing.Point(11, 40);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(491, 571);
            this.dataGridView1.TabIndex = 2;
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
            // 
            // StaffName
            // 
            this.StaffName.DataPropertyName = "Name";
            this.StaffName.HeaderText = "Name";
            this.StaffName.Name = "StaffName";
            this.StaffName.ReadOnly = true;
            this.StaffName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StaffName.Width = 260;
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
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(278, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(187, 20);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxIsActive);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonRemoveImage);
            this.groupBox1.Controls.Add(this.buttonUploadImage);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.labelEmail);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.labelPassword);
            this.groupBox1.Controls.Add(this.textBoxUsername);
            this.groupBox1.Controls.Add(this.labelUsername);
            this.groupBox1.Controls.Add(this.dateTimePickerJoinDate);
            this.groupBox1.Controls.Add(this.labelJoinDate);
            this.groupBox1.Controls.Add(this.pictureBoxEmployee);
            this.groupBox1.Controls.Add(this.comboBoxBloodGroup);
            this.groupBox1.Controls.Add(this.groupBoxRadioButton);
            this.groupBox1.Controls.Add(this.dateTimePickerBirthDate);
            this.groupBox1.Controls.Add(this.textBoxPhone);
            this.groupBox1.Controls.Add(this.textBoxEmployeeName);
            this.groupBox1.Controls.Add(this.labelAddress);
            this.groupBox1.Controls.Add(this.labelPhone);
            this.groupBox1.Controls.Add(this.labelBloodGroup);
            this.groupBox1.Controls.Add(this.labelReligion);
            this.groupBox1.Controls.Add(this.labelGender);
            this.groupBox1.Controls.Add(this.labelDOB);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.richTextBoxAddress);
            this.groupBox1.Controls.Add(this.textBoxReligion);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.buttonReset);
            this.groupBox1.Controls.Add(this.buttonUpdateStaff);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(508, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 597);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Staff Info";
            // 
            // checkBoxIsActive
            // 
            this.checkBoxIsActive.AutoSize = true;
            this.checkBoxIsActive.Checked = true;
            this.checkBoxIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIsActive.Location = new System.Drawing.Point(174, 368);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIsActive.TabIndex = 11;
            this.checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 207;
            this.label2.Text = "Active? :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonRemoveImage
            // 
            this.buttonRemoveImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRemoveImage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonRemoveImage.FlatAppearance.BorderSize = 0;
            this.buttonRemoveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveImage.Location = new System.Drawing.Point(599, 199);
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
            this.buttonUploadImage.Location = new System.Drawing.Point(509, 199);
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
            this.label20.Location = new System.Drawing.Point(387, 391);
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
            this.label19.Location = new System.Drawing.Point(485, 283);
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
            this.label18.Location = new System.Drawing.Point(485, 253);
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
            this.label17.Location = new System.Drawing.Point(485, 168);
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
            this.label16.Location = new System.Drawing.Point(485, 140);
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
            this.label14.Location = new System.Drawing.Point(485, 110);
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
            this.label13.Location = new System.Drawing.Point(485, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 17);
            this.label13.TabIndex = 198;
            this.label13.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(485, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 17);
            this.label1.TabIndex = 197;
            this.label1.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(485, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 17);
            this.label3.TabIndex = 196;
            this.label3.Text = "*";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(174, 107);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(305, 22);
            this.textBoxEmail.TabIndex = 3;
            // 
            // labelEmail
            // 
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(8, 110);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(130, 25);
            this.labelEmail.TabIndex = 195;
            this.labelEmail.Text = "E-mail:";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(174, 79);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '•';
            this.textBoxPassword.Size = new System.Drawing.Size(305, 22);
            this.textBoxPassword.TabIndex = 2;
            // 
            // labelPassword
            // 
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(8, 82);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(130, 25);
            this.labelPassword.TabIndex = 194;
            this.labelPassword.Text = "Password:";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(174, 51);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(305, 22);
            this.textBoxUsername.TabIndex = 1;
            // 
            // labelUsername
            // 
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(8, 54);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(130, 25);
            this.labelUsername.TabIndex = 193;
            this.labelUsername.Text = "Username:";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateTimePickerJoinDate
            // 
            this.dateTimePickerJoinDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerJoinDate.Location = new System.Drawing.Point(174, 278);
            this.dateTimePickerJoinDate.Name = "dateTimePickerJoinDate";
            this.dateTimePickerJoinDate.Size = new System.Drawing.Size(305, 22);
            this.dateTimePickerJoinDate.TabIndex = 9;
            // 
            // labelJoinDate
            // 
            this.labelJoinDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJoinDate.Location = new System.Drawing.Point(8, 283);
            this.labelJoinDate.Name = "labelJoinDate";
            this.labelJoinDate.Size = new System.Drawing.Size(130, 25);
            this.labelJoinDate.TabIndex = 192;
            this.labelJoinDate.Text = "Join Date:";
            this.labelJoinDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBoxEmployee
            // 
            this.pictureBoxEmployee.Image = global::SchoolAttendanceSystem.Properties.Resources.blank_profile_picture;
            this.pictureBoxEmployee.InitialImage = global::SchoolAttendanceSystem.Properties.Resources.blank_profile_picture;
            this.pictureBoxEmployee.Location = new System.Drawing.Point(509, 23);
            this.pictureBoxEmployee.Name = "pictureBoxEmployee";
            this.pictureBoxEmployee.Size = new System.Drawing.Size(170, 170);
            this.pictureBoxEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEmployee.TabIndex = 191;
            this.pictureBoxEmployee.TabStop = false;
            this.pictureBoxEmployee.Visible = false;
            // 
            // comboBoxBloodGroup
            // 
            this.comboBoxBloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBloodGroup.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBloodGroup.FormattingEnabled = true;
            this.comboBoxBloodGroup.Location = new System.Drawing.Point(174, 220);
            this.comboBoxBloodGroup.Name = "comboBoxBloodGroup";
            this.comboBoxBloodGroup.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBloodGroup.TabIndex = 7;
            // 
            // groupBoxRadioButton
            // 
            this.groupBoxRadioButton.Controls.Add(this.radioButtonOther);
            this.groupBoxRadioButton.Controls.Add(this.radioButtonFemale);
            this.groupBoxRadioButton.Controls.Add(this.radioButtonMale);
            this.groupBoxRadioButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRadioButton.Location = new System.Drawing.Point(174, 163);
            this.groupBoxRadioButton.Name = "groupBoxRadioButton";
            this.groupBoxRadioButton.Size = new System.Drawing.Size(305, 23);
            this.groupBoxRadioButton.TabIndex = 5;
            this.groupBoxRadioButton.TabStop = false;
            // 
            // radioButtonOther
            // 
            this.radioButtonOther.AutoSize = true;
            this.radioButtonOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOther.Location = new System.Drawing.Point(214, 3);
            this.radioButtonOther.Name = "radioButtonOther";
            this.radioButtonOther.Size = new System.Drawing.Size(63, 20);
            this.radioButtonOther.TabIndex = 2;
            this.radioButtonOther.TabStop = true;
            this.radioButtonOther.Text = "Other";
            this.radioButtonOther.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale.Location = new System.Drawing.Point(104, 3);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(78, 20);
            this.radioButtonFemale.TabIndex = 1;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.Location = new System.Drawing.Point(6, 3);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(60, 20);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(174, 135);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(305, 22);
            this.dateTimePickerBirthDate.TabIndex = 4;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.Location = new System.Drawing.Point(174, 250);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(305, 22);
            this.textBoxPhone.TabIndex = 8;
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxEmployeeName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeeName.Location = new System.Drawing.Point(174, 23);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(305, 22);
            this.textBoxEmployeeName.TabIndex = 0;
            // 
            // labelAddress
            // 
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(8, 309);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(130, 25);
            this.labelAddress.TabIndex = 190;
            this.labelAddress.Text = "Address:";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelPhone
            // 
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(8, 253);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(130, 25);
            this.labelPhone.TabIndex = 189;
            this.labelPhone.Text = "Phone:";
            this.labelPhone.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelBloodGroup
            // 
            this.labelBloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBloodGroup.Location = new System.Drawing.Point(8, 223);
            this.labelBloodGroup.Name = "labelBloodGroup";
            this.labelBloodGroup.Size = new System.Drawing.Size(130, 25);
            this.labelBloodGroup.TabIndex = 188;
            this.labelBloodGroup.Text = "Blood Group:";
            this.labelBloodGroup.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelReligion
            // 
            this.labelReligion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReligion.Location = new System.Drawing.Point(8, 195);
            this.labelReligion.Name = "labelReligion";
            this.labelReligion.Size = new System.Drawing.Size(130, 25);
            this.labelReligion.TabIndex = 187;
            this.labelReligion.Text = "Religion:";
            this.labelReligion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelGender
            // 
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(8, 168);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(130, 25);
            this.labelGender.TabIndex = 186;
            this.labelGender.Text = "Gender:";
            this.labelGender.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDOB
            // 
            this.labelDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDOB.Location = new System.Drawing.Point(8, 140);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(130, 25);
            this.labelDOB.TabIndex = 185;
            this.labelDOB.Text = "Date Of Birth:";
            this.labelDOB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.SystemColors.Control;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(8, 26);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(130, 25);
            this.labelName.TabIndex = 184;
            this.labelName.Text = "Name:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // richTextBoxAddress
            // 
            this.richTextBoxAddress.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxAddress.Location = new System.Drawing.Point(174, 306);
            this.richTextBoxAddress.Name = "richTextBoxAddress";
            this.richTextBoxAddress.Size = new System.Drawing.Size(305, 56);
            this.richTextBoxAddress.TabIndex = 10;
            this.richTextBoxAddress.Text = "";
            // 
            // textBoxReligion
            // 
            this.textBoxReligion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReligion.Location = new System.Drawing.Point(174, 192);
            this.textBoxReligion.Name = "textBoxReligion";
            this.textBoxReligion.Size = new System.Drawing.Size(305, 22);
            this.textBoxReligion.TabIndex = 6;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(336, 551);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(150, 40);
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
            this.buttonReset.Location = new System.Drawing.Point(13, 551);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(150, 40);
            this.buttonReset.TabIndex = 16;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonUpdateStaff
            // 
            this.buttonUpdateStaff.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonUpdateStaff.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonUpdateStaff.FlatAppearance.BorderSize = 0;
            this.buttonUpdateStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateStaff.Location = new System.Drawing.Point(175, 551);
            this.buttonUpdateStaff.Name = "buttonUpdateStaff";
            this.buttonUpdateStaff.Size = new System.Drawing.Size(150, 40);
            this.buttonUpdateStaff.TabIndex = 15;
            this.buttonUpdateStaff.Text = "Update Info";
            this.buttonUpdateStaff.UseVisualStyleBackColor = false;
            this.buttonUpdateStaff.Click += new System.EventHandler(this.buttonUpdateStaff_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SchoolAttendanceSystem.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(469, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // FormStaffList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 623);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStaffList";
            this.Text = "Staff List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEmployeeList_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployee)).EndInit();
            this.groupBoxRadioButton.ResumeLayout(false);
            this.groupBoxRadioButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonUpdateStaff;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.DateTimePicker dateTimePickerJoinDate;
        private System.Windows.Forms.Label labelJoinDate;
        private System.Windows.Forms.PictureBox pictureBoxEmployee;
        private System.Windows.Forms.ComboBox comboBoxBloodGroup;
        private System.Windows.Forms.GroupBox groupBoxRadioButton;
        private System.Windows.Forms.RadioButton radioButtonOther;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelBloodGroup;
        private System.Windows.Forms.Label labelReligion;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.RichTextBox richTextBoxAddress;
        private System.Windows.Forms.TextBox textBoxReligion;
        private System.Windows.Forms.Button buttonRemoveImage;
        private System.Windows.Forms.Button buttonUploadImage;
        private System.Windows.Forms.CheckBox checkBoxIsActive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
    }
}