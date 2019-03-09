namespace SchoolAttendanceSystem
{
    partial class FormAcademicYear
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
            this.checkBoxIsCurrent = new System.Windows.Forms.CheckBox();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.comboBoxAcademicYear = new System.Windows.Forms.ComboBox();
            this.labelAcademicYear = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelSelectYear = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // checkBoxIsCurrent
            // 
            this.checkBoxIsCurrent.AutoSize = true;
            this.checkBoxIsCurrent.Checked = true;
            this.checkBoxIsCurrent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIsCurrent.Location = new System.Drawing.Point(148, 65);
            this.checkBoxIsCurrent.Name = "checkBoxIsCurrent";
            this.checkBoxIsCurrent.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIsCurrent.TabIndex = 210;
            this.checkBoxIsCurrent.UseVisualStyleBackColor = true;
            // 
            // labelCurrent
            // 
            this.labelCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrent.Location = new System.Drawing.Point(15, 63);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.Size = new System.Drawing.Size(127, 25);
            this.labelCurrent.TabIndex = 213;
            this.labelCurrent.Text = "Current?  :";
            this.labelCurrent.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBoxAcademicYear
            // 
            this.comboBoxAcademicYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAcademicYear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAcademicYear.FormattingEnabled = true;
            this.comboBoxAcademicYear.Location = new System.Drawing.Point(148, 6);
            this.comboBoxAcademicYear.Name = "comboBoxAcademicYear";
            this.comboBoxAcademicYear.Size = new System.Drawing.Size(184, 24);
            this.comboBoxAcademicYear.TabIndex = 208;
            this.comboBoxAcademicYear.SelectedIndexChanged += new System.EventHandler(this.comboBoxAcademicYear_SelectedIndexChanged);
            // 
            // labelAcademicYear
            // 
            this.labelAcademicYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAcademicYear.Location = new System.Drawing.Point(12, 40);
            this.labelAcademicYear.Name = "labelAcademicYear";
            this.labelAcademicYear.Size = new System.Drawing.Size(130, 25);
            this.labelAcademicYear.TabIndex = 212;
            this.labelAcademicYear.Text = "Academic Year:";
            this.labelAcademicYear.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(182, 112);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(150, 40);
            this.buttonUpdate.TabIndex = 214;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelSelectYear
            // 
            this.labelSelectYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectYear.Location = new System.Drawing.Point(12, 9);
            this.labelSelectYear.Name = "labelSelectYear";
            this.labelSelectYear.Size = new System.Drawing.Size(130, 25);
            this.labelSelectYear.TabIndex = 215;
            this.labelSelectYear.Text = "Select Year:";
            this.labelSelectYear.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(237, 82);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(112, 15);
            this.label20.TabIndex = 217;
            this.label20.Text = "Required Filed *";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(335, 40);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 17);
            this.label19.TabIndex = 216;
            this.label19.Text = "*";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(183, 21);
            this.dateTimePicker1.TabIndex = 218;
            // 
            // FormAcademicYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 177);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.labelSelectYear);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.checkBoxIsCurrent);
            this.Controls.Add(this.labelCurrent);
            this.Controls.Add(this.comboBoxAcademicYear);
            this.Controls.Add(this.labelAcademicYear);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAcademicYear";
            this.Text = "Academic Year";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAcademicYear_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxIsCurrent;
        private System.Windows.Forms.Label labelCurrent;
        private System.Windows.Forms.ComboBox comboBoxAcademicYear;
        private System.Windows.Forms.Label labelAcademicYear;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelSelectYear;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}