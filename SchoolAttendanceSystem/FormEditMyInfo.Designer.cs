namespace SchoolAttendanceSystem
{
    partial class FormEditMyInfo
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
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.dateTimePickerJoinDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBloodGroup = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonOther = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.richTextBoxAddress = new System.Windows.Forms.RichTextBox();
            this.textBoxReligion = new System.Windows.Forms.TextBox();
            this.buttonRemoveImage = new System.Windows.Forms.Button();
            this.buttonChangeImage = new System.Windows.Forms.Button();
            this.pictureBoxEmployee = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(183, 62);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(305, 22);
            this.textBoxEmail.TabIndex = 107;
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // labelEmail
            // 
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(12, 65);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(159, 23);
            this.labelEmail.TabIndex = 106;
            this.labelEmail.Text = "E-mail:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(183, 34);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(305, 22);
            this.textBoxUsername.TabIndex = 103;
            this.textBoxUsername.Leave += new System.EventHandler(this.textBoxUsername_Leave);
            // 
            // labelUsername
            // 
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(12, 37);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(159, 23);
            this.labelUsername.TabIndex = 102;
            this.labelUsername.Text = "Username:";
            // 
            // dateTimePickerJoinDate
            // 
            this.dateTimePickerJoinDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerJoinDate.Location = new System.Drawing.Point(183, 233);
            this.dateTimePickerJoinDate.Name = "dateTimePickerJoinDate";
            this.dateTimePickerJoinDate.Size = new System.Drawing.Size(305, 22);
            this.dateTimePickerJoinDate.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 23);
            this.label2.TabIndex = 98;
            this.label2.Text = "Join Date:";
            // 
            // comboBoxBloodGroup
            // 
            this.comboBoxBloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.comboBoxBloodGroup.Location = new System.Drawing.Point(183, 175);
            this.comboBoxBloodGroup.Name = "comboBoxBloodGroup";
            this.comboBoxBloodGroup.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBloodGroup.TabIndex = 95;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonOther);
            this.groupBox1.Controls.Add(this.radioButtonFemale);
            this.groupBox1.Controls.Add(this.radioButtonMale);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(183, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 23);
            this.groupBox1.TabIndex = 94;
            this.groupBox1.TabStop = false;
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
            this.dateTimePickerBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(183, 90);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(305, 22);
            this.dateTimePickerBirthDate.TabIndex = 93;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.Location = new System.Drawing.Point(183, 205);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(305, 22);
            this.textBoxPhone.TabIndex = 90;
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeeName.Location = new System.Drawing.Point(183, 6);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(305, 22);
            this.textBoxEmployeeName.TabIndex = 88;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(338, 343);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(150, 40);
            this.buttonUpdate.TabIndex = 92;
            this.buttonUpdate.Text = "Update Info";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdateStaff_Click);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 261);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 25);
            this.label15.TabIndex = 87;
            this.label15.Text = "Address:";
            // 
            // labelPhone
            // 
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(12, 208);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(159, 25);
            this.labelPhone.TabIndex = 86;
            this.labelPhone.Text = "Phone:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 25);
            this.label7.TabIndex = 85;
            this.label7.Text = "Blood Group:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 23);
            this.label6.TabIndex = 84;
            this.label6.Text = "Religion:";
            // 
            // labelGender
            // 
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(12, 123);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(159, 23);
            this.labelGender.TabIndex = 83;
            this.labelGender.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 23);
            this.label4.TabIndex = 82;
            this.label4.Text = "Date Of Birth:";
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(159, 23);
            this.labelName.TabIndex = 81;
            this.labelName.Text = "Name:";
            // 
            // richTextBoxAddress
            // 
            this.richTextBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxAddress.Location = new System.Drawing.Point(183, 261);
            this.richTextBoxAddress.Name = "richTextBoxAddress";
            this.richTextBoxAddress.Size = new System.Drawing.Size(305, 56);
            this.richTextBoxAddress.TabIndex = 91;
            this.richTextBoxAddress.Text = "";
            // 
            // textBoxReligion
            // 
            this.textBoxReligion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReligion.Location = new System.Drawing.Point(183, 147);
            this.textBoxReligion.Name = "textBoxReligion";
            this.textBoxReligion.Size = new System.Drawing.Size(305, 22);
            this.textBoxReligion.TabIndex = 89;
            // 
            // buttonRemoveImage
            // 
            this.buttonRemoveImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRemoveImage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonRemoveImage.FlatAppearance.BorderSize = 0;
            this.buttonRemoveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveImage.Location = new System.Drawing.Point(615, 175);
            this.buttonRemoveImage.Name = "buttonRemoveImage";
            this.buttonRemoveImage.Size = new System.Drawing.Size(80, 25);
            this.buttonRemoveImage.TabIndex = 109;
            this.buttonRemoveImage.Text = "Remove";
            this.buttonRemoveImage.UseVisualStyleBackColor = false;
            this.buttonRemoveImage.Visible = false;
            // 
            // buttonChangeImage
            // 
            this.buttonChangeImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonChangeImage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonChangeImage.FlatAppearance.BorderSize = 0;
            this.buttonChangeImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeImage.Location = new System.Drawing.Point(525, 175);
            this.buttonChangeImage.Name = "buttonChangeImage";
            this.buttonChangeImage.Size = new System.Drawing.Size(80, 25);
            this.buttonChangeImage.TabIndex = 108;
            this.buttonChangeImage.Text = "Change";
            this.buttonChangeImage.UseVisualStyleBackColor = false;
            this.buttonChangeImage.Visible = false;
            // 
            // pictureBoxEmployee
            // 
            this.pictureBoxEmployee.Image = global::SchoolAttendanceSystem.Properties.Resources.blank_profile_picture;
            this.pictureBoxEmployee.InitialImage = global::SchoolAttendanceSystem.Properties.Resources.blank_profile_picture;
            this.pictureBoxEmployee.Location = new System.Drawing.Point(525, -1);
            this.pictureBoxEmployee.Name = "pictureBoxEmployee";
            this.pictureBoxEmployee.Size = new System.Drawing.Size(170, 170);
            this.pictureBoxEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEmployee.TabIndex = 96;
            this.pictureBoxEmployee.TabStop = false;
            this.pictureBoxEmployee.Visible = false;
            // 
            // FormEditMyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 436);
            this.Controls.Add(this.buttonRemoveImage);
            this.Controls.Add(this.buttonChangeImage);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.dateTimePickerJoinDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxEmployee);
            this.Controls.Add(this.comboBoxBloodGroup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePickerBirthDate);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxEmployeeName);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.richTextBoxAddress);
            this.Controls.Add(this.textBoxReligion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditMyInfo";
            this.Text = "Edit My Info";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEditEmployeeInfo_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.DateTimePicker dateTimePickerJoinDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxEmployee;
        private System.Windows.Forms.ComboBox comboBoxBloodGroup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonOther;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.RichTextBox richTextBoxAddress;
        private System.Windows.Forms.TextBox textBoxReligion;
        private System.Windows.Forms.Button buttonRemoveImage;
        private System.Windows.Forms.Button buttonChangeImage;
    }
}