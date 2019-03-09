namespace SchoolAttendanceSystem
{
    partial class FormEditStudentInfo
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
            this.comboBoxSection = new System.Windows.Forms.ComboBox();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.comboBoxBloodGroup = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonOther = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonUpdate = new System.Windows.Forms.Button();
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
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxStudent = new System.Windows.Forms.PictureBox();
            this.buttonRemoveImage = new System.Windows.Forms.Button();
            this.buttonChangeImage = new System.Windows.Forms.Button();
            this.checkBoxIsActive = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSection
            // 
            this.comboBoxSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSection.FormattingEnabled = true;
            this.comboBoxSection.Location = new System.Drawing.Point(187, 239);
            this.comboBoxSection.Name = "comboBoxSection";
            this.comboBoxSection.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSection.TabIndex = 78;
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
            this.comboBoxClass.Location = new System.Drawing.Point(187, 215);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClass.TabIndex = 76;
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
            this.comboBoxBloodGroup.Location = new System.Drawing.Point(187, 165);
            this.comboBoxBloodGroup.Name = "comboBoxBloodGroup";
            this.comboBoxBloodGroup.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBloodGroup.TabIndex = 75;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonOther);
            this.groupBox1.Controls.Add(this.radioButtonFemale);
            this.groupBox1.Controls.Add(this.radioButtonMale);
            this.groupBox1.Location = new System.Drawing.Point(187, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 23);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonOther
            // 
            this.radioButtonOther.AutoSize = true;
            this.radioButtonOther.Location = new System.Drawing.Point(214, 3);
            this.radioButtonOther.Name = "radioButtonOther";
            this.radioButtonOther.Size = new System.Drawing.Size(51, 17);
            this.radioButtonOther.TabIndex = 2;
            this.radioButtonOther.TabStop = true;
            this.radioButtonOther.Text = "Other";
            this.radioButtonOther.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(110, 3);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(59, 17);
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
            this.radioButtonMale.Size = new System.Drawing.Size(48, 17);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(187, 87);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(305, 20);
            this.dateTimePicker1.TabIndex = 73;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(351, 445);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(141, 33);
            this.buttonUpdate.TabIndex = 72;
            this.buttonUpdate.Text = "Update Info";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // richTextBoxAddress
            // 
            this.richTextBoxAddress.Location = new System.Drawing.Point(187, 338);
            this.richTextBoxAddress.Name = "richTextBoxAddress";
            this.richTextBoxAddress.Size = new System.Drawing.Size(305, 68);
            this.richTextBoxAddress.TabIndex = 71;
            this.richTextBoxAddress.Text = "";
            // 
            // textBoxMotherProfession
            // 
            this.textBoxMotherProfession.Location = new System.Drawing.Point(187, 313);
            this.textBoxMotherProfession.Name = "textBoxMotherProfession";
            this.textBoxMotherProfession.Size = new System.Drawing.Size(305, 20);
            this.textBoxMotherProfession.TabIndex = 70;
            // 
            // textBoxFatherProfession
            // 
            this.textBoxFatherProfession.Location = new System.Drawing.Point(187, 288);
            this.textBoxFatherProfession.Name = "textBoxFatherProfession";
            this.textBoxFatherProfession.Size = new System.Drawing.Size(305, 20);
            this.textBoxFatherProfession.TabIndex = 69;
            // 
            // textBoxRollNumber
            // 
            this.textBoxRollNumber.Location = new System.Drawing.Point(187, 263);
            this.textBoxRollNumber.Name = "textBoxRollNumber";
            this.textBoxRollNumber.Size = new System.Drawing.Size(305, 20);
            this.textBoxRollNumber.TabIndex = 68;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(187, 190);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(305, 20);
            this.textBoxPhone.TabIndex = 67;
            // 
            // textBoxReligion
            // 
            this.textBoxReligion.Location = new System.Drawing.Point(187, 140);
            this.textBoxReligion.Name = "textBoxReligion";
            this.textBoxReligion.Size = new System.Drawing.Size(305, 20);
            this.textBoxReligion.TabIndex = 66;
            // 
            // textBoxMotherName
            // 
            this.textBoxMotherName.Location = new System.Drawing.Point(187, 66);
            this.textBoxMotherName.Name = "textBoxMotherName";
            this.textBoxMotherName.Size = new System.Drawing.Size(305, 20);
            this.textBoxMotherName.TabIndex = 65;
            // 
            // textBoxFatherName
            // 
            this.textBoxFatherName.Location = new System.Drawing.Point(187, 43);
            this.textBoxFatherName.Name = "textBoxFatherName";
            this.textBoxFatherName.Size = new System.Drawing.Size(305, 20);
            this.textBoxFatherName.TabIndex = 64;
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Location = new System.Drawing.Point(187, 20);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(305, 20);
            this.textBoxStudentName.TabIndex = 63;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(22, 339);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 25);
            this.label15.TabIndex = 62;
            this.label15.Text = "Address:";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 314);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(159, 25);
            this.label14.TabIndex = 61;
            this.label14.Text = "Mother\'s Profession:";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(22, 289);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 25);
            this.label13.TabIndex = 60;
            this.label13.Text = "Father\'s Profession:";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 25);
            this.label11.TabIndex = 59;
            this.label11.Text = "Roll Number:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 25);
            this.label10.TabIndex = 58;
            this.label10.Text = "Section:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 25);
            this.label9.TabIndex = 57;
            this.label9.Text = "Class:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 25);
            this.label8.TabIndex = 56;
            this.label8.Text = "Phone:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 25);
            this.label7.TabIndex = 55;
            this.label7.Text = "Blood Group:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 23);
            this.label6.TabIndex = 54;
            this.label6.Text = "Religion:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 23);
            this.label5.TabIndex = 53;
            this.label5.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 23);
            this.label4.TabIndex = 52;
            this.label4.Text = "Date Of Birth:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 23);
            this.label3.TabIndex = 51;
            this.label3.Text = "Mother\'s Name:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 23);
            this.label2.TabIndex = 50;
            this.label2.Text = "Father\'s Name:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 23);
            this.label1.TabIndex = 49;
            this.label1.Text = "Name:";
            // 
            // pictureBoxStudent
            // 
            this.pictureBoxStudent.Image = global::SchoolAttendanceSystem.Properties.Resources.blank_profile_picture;
            this.pictureBoxStudent.Location = new System.Drawing.Point(561, 24);
            this.pictureBoxStudent.Name = "pictureBoxStudent";
            this.pictureBoxStudent.Size = new System.Drawing.Size(170, 170);
            this.pictureBoxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStudent.TabIndex = 77;
            this.pictureBoxStudent.TabStop = false;
            // 
            // buttonRemoveImage
            // 
            this.buttonRemoveImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRemoveImage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonRemoveImage.FlatAppearance.BorderSize = 0;
            this.buttonRemoveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveImage.Location = new System.Drawing.Point(651, 200);
            this.buttonRemoveImage.Name = "buttonRemoveImage";
            this.buttonRemoveImage.Size = new System.Drawing.Size(80, 25);
            this.buttonRemoveImage.TabIndex = 83;
            this.buttonRemoveImage.Text = "Remove";
            this.buttonRemoveImage.UseVisualStyleBackColor = false;
            // 
            // buttonChangeImage
            // 
            this.buttonChangeImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonChangeImage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonChangeImage.FlatAppearance.BorderSize = 0;
            this.buttonChangeImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeImage.Location = new System.Drawing.Point(561, 200);
            this.buttonChangeImage.Name = "buttonChangeImage";
            this.buttonChangeImage.Size = new System.Drawing.Size(80, 25);
            this.buttonChangeImage.TabIndex = 82;
            this.buttonChangeImage.Text = "Change";
            this.buttonChangeImage.UseVisualStyleBackColor = false;
            // 
            // checkBoxIsActive
            // 
            this.checkBoxIsActive.AutoSize = true;
            this.checkBoxIsActive.Checked = true;
            this.checkBoxIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIsActive.Location = new System.Drawing.Point(187, 414);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIsActive.TabIndex = 85;
            this.checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 412);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 25);
            this.label12.TabIndex = 84;
            this.label12.Text = "Active? :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormEditStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 490);
            this.Controls.Add(this.checkBoxIsActive);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonRemoveImage);
            this.Controls.Add(this.buttonChangeImage);
            this.Controls.Add(this.comboBoxSection);
            this.Controls.Add(this.pictureBoxStudent);
            this.Controls.Add(this.comboBoxClass);
            this.Controls.Add(this.comboBoxBloodGroup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.richTextBoxAddress);
            this.Controls.Add(this.textBoxMotherProfession);
            this.Controls.Add(this.textBoxFatherProfession);
            this.Controls.Add(this.textBoxRollNumber);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxReligion);
            this.Controls.Add(this.textBoxMotherName);
            this.Controls.Add(this.textBoxFatherName);
            this.Controls.Add(this.textBoxStudentName);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditStudentInfo";
            this.Text = "FormEditStudentInfo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEditStudentInfo_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxSection;
        private System.Windows.Forms.PictureBox pictureBoxStudent;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.ComboBox comboBoxBloodGroup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonOther;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonUpdate;
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
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRemoveImage;
        private System.Windows.Forms.Button buttonChangeImage;
        private System.Windows.Forms.CheckBox checkBoxIsActive;
        private System.Windows.Forms.Label label12;
    }
}