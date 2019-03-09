namespace SchoolAttendanceSystem
{
    partial class FormAttendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.comboBoxSection = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.dataGridViewAttendance = new System.Windows.Forms.DataGridView();
            this.AttendanceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Roll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAttend = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Section:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(90, 7);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(121, 24);
            this.comboBoxClass.TabIndex = 2;
            this.comboBoxClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxClass_SelectedIndexChanged);
            // 
            // comboBoxSection
            // 
            this.comboBoxSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSection.FormattingEnabled = true;
            this.comboBoxSection.Location = new System.Drawing.Point(90, 39);
            this.comboBoxSection.Name = "comboBoxSection";
            this.comboBoxSection.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSection.TabIndex = 3;
            this.comboBoxSection.SelectedIndexChanged += new System.EventHandler(this.comboBoxSection_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(321, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(420, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(254, 22);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLoad.FlatAppearance.BorderSize = 0;
            this.buttonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLoad.Location = new System.Drawing.Point(228, 39);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(92, 25);
            this.buttonLoad.TabIndex = 7;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonInsert.FlatAppearance.BorderSize = 0;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(533, 538);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(141, 40);
            this.buttonInsert.TabIndex = 8;
            this.buttonInsert.Text = "Confirm";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // dataGridViewAttendance
            // 
            this.dataGridViewAttendance.AllowUserToAddRows = false;
            this.dataGridViewAttendance.AllowUserToDeleteRows = false;
            this.dataGridViewAttendance.AllowUserToResizeColumns = false;
            this.dataGridViewAttendance.AllowUserToResizeRows = false;
            this.dataGridViewAttendance.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttendanceId,
            this.Roll,
            this.IdNumber,
            this.StudentName,
            this.StudentId,
            this.IsAttend});
            this.dataGridViewAttendance.Location = new System.Drawing.Point(15, 84);
            this.dataGridViewAttendance.MultiSelect = false;
            this.dataGridViewAttendance.Name = "dataGridViewAttendance";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewAttendance.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewAttendance.Size = new System.Drawing.Size(659, 448);
            this.dataGridViewAttendance.TabIndex = 97;
            // 
            // AttendanceId
            // 
            this.AttendanceId.DataPropertyName = "AttendanceId";
            this.AttendanceId.HeaderText = "Id";
            this.AttendanceId.Name = "AttendanceId";
            this.AttendanceId.ReadOnly = true;
            this.AttendanceId.Visible = false;
            // 
            // Roll
            // 
            this.Roll.DataPropertyName = "Roll";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Roll.DefaultCellStyle = dataGridViewCellStyle11;
            this.Roll.HeaderText = "Roll";
            this.Roll.Name = "Roll";
            this.Roll.ReadOnly = true;
            this.Roll.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // IdNumber
            // 
            this.IdNumber.DataPropertyName = "IdNumber";
            this.IdNumber.HeaderText = "IdNumber";
            this.IdNumber.Name = "IdNumber";
            this.IdNumber.ReadOnly = true;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "Student Name";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentName.Width = 290;
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.HeaderText = "Student Id";
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            this.StudentId.Visible = false;
            // 
            // IsAttend
            // 
            this.IsAttend.DataPropertyName = "IsAttend";
            this.IsAttend.HeaderText = "Attend?";
            this.IsAttend.Name = "IsAttend";
            // 
            // FormAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 599);
            this.Controls.Add(this.dataGridViewAttendance);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSection);
            this.Controls.Add(this.comboBoxClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAttendance";
            this.Text = "FormAttendance";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAttendance_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.ComboBox comboBoxSection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.DataGridView dataGridViewAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roll;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsAttend;
    }
}