namespace SchoolAttendanceSystem
{
    partial class FormAssignClassSection
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewClassList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxTeacher = new System.Windows.Forms.ComboBox();
            this.labelTeacher = new System.Windows.Forms.Label();
            this.checkBoxIsActive = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSection = new System.Windows.Forms.TextBox();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelSection = new System.Windows.Forms.Label();
            this.dataGridViewSection = new System.Windows.Forms.DataGridView();
            this.CSId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassTeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSection)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClassList
            // 
            this.dataGridViewClassList.AllowUserToAddRows = false;
            this.dataGridViewClassList.AllowUserToDeleteRows = false;
            this.dataGridViewClassList.AllowUserToResizeColumns = false;
            this.dataGridViewClassList.AllowUserToResizeRows = false;
            this.dataGridViewClassList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClassList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClassList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClassList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ClassName});
            this.dataGridViewClassList.Location = new System.Drawing.Point(12, 37);
            this.dataGridViewClassList.MultiSelect = false;
            this.dataGridViewClassList.Name = "dataGridViewClassList";
            this.dataGridViewClassList.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewClassList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewClassList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClassList.Size = new System.Drawing.Size(181, 389);
            this.dataGridViewClassList.TabIndex = 0;
            this.dataGridViewClassList.SelectionChanged += new System.EventHandler(this.dataGridViewClassList_SelectionChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "ClassId";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 130;
            // 
            // ClassName
            // 
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "Class Name";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            this.ClassName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClassName.Width = 110;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 78;
            this.label1.Text = "Class List:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.comboBoxTeacher);
            this.groupBox1.Controls.Add(this.labelTeacher);
            this.groupBox1.Controls.Add(this.checkBoxIsActive);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.buttonReset);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxSection);
            this.groupBox1.Controls.Add(this.labelClass);
            this.groupBox1.Controls.Add(this.labelSection);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(199, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 185);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Section Info";
            // 
            // comboBoxTeacher
            // 
            this.comboBoxTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTeacher.FormattingEnabled = true;
            this.comboBoxTeacher.Location = new System.Drawing.Point(126, 75);
            this.comboBoxTeacher.Name = "comboBoxTeacher";
            this.comboBoxTeacher.Size = new System.Drawing.Size(158, 23);
            this.comboBoxTeacher.TabIndex = 98;
            // 
            // labelTeacher
            // 
            this.labelTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeacher.Location = new System.Drawing.Point(49, 75);
            this.labelTeacher.Name = "labelTeacher";
            this.labelTeacher.Size = new System.Drawing.Size(71, 25);
            this.labelTeacher.TabIndex = 88;
            this.labelTeacher.Text = "Teacher:";
            this.labelTeacher.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // checkBoxIsActive
            // 
            this.checkBoxIsActive.AutoSize = true;
            this.checkBoxIsActive.Checked = true;
            this.checkBoxIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIsActive.Location = new System.Drawing.Point(126, 124);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIsActive.TabIndex = 2;
            this.checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 86;
            this.label5.Text = "Active?:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(126, 154);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(80, 25);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonReset.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonReset.FlatAppearance.BorderSize = 0;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(40, 154);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(80, 25);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(212, 154);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 25);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 83;
            this.label4.Text = "Class:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxSection
            // 
            this.textBoxSection.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSection.Location = new System.Drawing.Point(126, 47);
            this.textBoxSection.Name = "textBoxSection";
            this.textBoxSection.Size = new System.Drawing.Size(158, 22);
            this.textBoxSection.TabIndex = 1;
            // 
            // labelClass
            // 
            this.labelClass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.Location = new System.Drawing.Point(126, 21);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(158, 23);
            this.labelClass.TabIndex = 0;
            this.labelClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSection
            // 
            this.labelSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSection.Location = new System.Drawing.Point(49, 50);
            this.labelSection.Name = "labelSection";
            this.labelSection.Size = new System.Drawing.Size(71, 25);
            this.labelSection.TabIndex = 81;
            this.labelSection.Text = "Section:";
            this.labelSection.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dataGridViewSection
            // 
            this.dataGridViewSection.AllowUserToAddRows = false;
            this.dataGridViewSection.AllowUserToDeleteRows = false;
            this.dataGridViewSection.AllowUserToResizeColumns = false;
            this.dataGridViewSection.AllowUserToResizeRows = false;
            this.dataGridViewSection.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSection.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CSId,
            this.SectionName,
            this.IsActive,
            this.TeacherName,
            this.ClassTeacherId});
            this.dataGridViewSection.Location = new System.Drawing.Point(199, 228);
            this.dataGridViewSection.MultiSelect = false;
            this.dataGridViewSection.Name = "dataGridViewSection";
            this.dataGridViewSection.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewSection.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSection.Size = new System.Drawing.Size(441, 198);
            this.dataGridViewSection.TabIndex = 2;
            this.dataGridViewSection.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSection_CellClick);
            this.dataGridViewSection.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewSection_DataBindingComplete);
            this.dataGridViewSection.SelectionChanged += new System.EventHandler(this.dataGridViewSection_SelectionChanged);
            this.dataGridViewSection.Enter += new System.EventHandler(this.dataGridViewSection_Enter);
            // 
            // CSId
            // 
            this.CSId.DataPropertyName = "ClassSectionId";
            this.CSId.HeaderText = "Id";
            this.CSId.Name = "CSId";
            this.CSId.ReadOnly = true;
            this.CSId.Visible = false;
            this.CSId.Width = 180;
            // 
            // SectionName
            // 
            this.SectionName.DataPropertyName = "SectionName";
            this.SectionName.HeaderText = "Section Name";
            this.SectionName.Name = "SectionName";
            this.SectionName.ReadOnly = true;
            this.SectionName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SectionName.Width = 110;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "Active?";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            this.IsActive.Width = 60;
            // 
            // TeacherName
            // 
            this.TeacherName.DataPropertyName = "TeacherName";
            this.TeacherName.HeaderText = "Class Teacher";
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.ReadOnly = true;
            this.TeacherName.Width = 200;
            // 
            // ClassTeacherId
            // 
            this.ClassTeacherId.DataPropertyName = "ClassTeacherId";
            this.ClassTeacherId.HeaderText = "ClassTeacherId";
            this.ClassTeacherId.Name = "ClassTeacherId";
            this.ClassTeacherId.ReadOnly = true;
            this.ClassTeacherId.Visible = false;
            // 
            // FormAssignClassSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 438);
            this.Controls.Add(this.dataGridViewSection);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewClassList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAssignClassSection";
            this.Text = "FormAssignClassSection";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAssignClassSection_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewClassList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.DataGridView dataGridViewSection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSection;
        private System.Windows.Forms.Label labelSection;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.CheckBox checkBoxIsActive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.ComboBox comboBoxTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassTeacherId;
    }
}