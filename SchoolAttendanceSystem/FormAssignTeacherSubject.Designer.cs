namespace SchoolAttendanceSystem
{
    partial class FormAssignTeacherSubject
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
            this.buttonLoad = new System.Windows.Forms.Button();
            this.comboBoxSection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SubjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teacher = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLoad.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLoad.FlatAppearance.BorderSize = 0;
            this.buttonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.Location = new System.Drawing.Point(530, 14);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(103, 25);
            this.buttonLoad.TabIndex = 66;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            // 
            // comboBoxSection
            // 
            this.comboBoxSection.FormattingEnabled = true;
            this.comboBoxSection.Items.AddRange(new object[] {
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
            this.comboBoxSection.Location = new System.Drawing.Point(316, 17);
            this.comboBoxSection.Name = "comboBoxSection";
            this.comboBoxSection.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSection.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 64;
            this.label1.Text = "Section:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBoxClass
            // 
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
            this.comboBoxClass.Location = new System.Drawing.Point(78, 17);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClass.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 62;
            this.label6.Text = "Class:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectId,
            this.Subject,
            this.Teacher});
            this.dataGridView1.Location = new System.Drawing.Point(13, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(620, 355);
            this.dataGridView1.TabIndex = 67;
            // 
            // SubjectId
            // 
            this.SubjectId.HeaderText = "SubjectId";
            this.SubjectId.Name = "SubjectId";
            this.SubjectId.Visible = false;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            this.Subject.Width = 280;
            // 
            // Teacher
            // 
            this.Teacher.HeaderText = "Teacher";
            this.Teacher.Name = "Teacher";
            this.Teacher.Width = 280;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(483, 419);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(150, 40);
            this.buttonUpdate.TabIndex = 68;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // FormAssignTeacherSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 471);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.comboBoxSection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxClass);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAssignTeacherSubject";
            this.Text = "FormAssignTeacherSubject";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAssignTeacherSubject_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.ComboBox comboBoxSection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewComboBoxColumn Teacher;
    }
}