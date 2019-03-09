namespace SchoolAttendanceSystem
{
    partial class FormPromoteStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.labelClass = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonPromote = new System.Windows.Forms.Button();
            this.Roll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marks = new System.Windows.Forms.DataGridViewLinkColumn();
            this.IsProcessed = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.buttonLoad.Location = new System.Drawing.Point(205, 13);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(88, 25);
            this.buttonLoad.TabIndex = 71;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
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
            this.comboBoxClass.Location = new System.Drawing.Point(81, 16);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(106, 21);
            this.comboBoxClass.TabIndex = 68;
            this.comboBoxClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxClass_SelectedIndexChanged);
            // 
            // labelClass
            // 
            this.labelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.Location = new System.Drawing.Point(-10, 17);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(73, 25);
            this.labelClass.TabIndex = 67;
            this.labelClass.Text = "Class:";
            this.labelClass.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Roll,
            this.Section,
            this.StudentName,
            this.StudentId,
            this.Marks,
            this.IsProcessed});
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(566, 437);
            this.dataGridView1.TabIndex = 72;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonPromote
            // 
            this.buttonPromote.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPromote.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonPromote.FlatAppearance.BorderSize = 0;
            this.buttonPromote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPromote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPromote.Location = new System.Drawing.Point(464, 496);
            this.buttonPromote.Name = "buttonPromote";
            this.buttonPromote.Size = new System.Drawing.Size(114, 40);
            this.buttonPromote.TabIndex = 75;
            this.buttonPromote.Text = "Execute";
            this.buttonPromote.UseVisualStyleBackColor = false;
            this.buttonPromote.Click += new System.EventHandler(this.buttonPromote_Click);
            // 
            // Roll
            // 
            this.Roll.DataPropertyName = "Roll";
            this.Roll.HeaderText = "Roll";
            this.Roll.Name = "Roll";
            this.Roll.ReadOnly = true;
            this.Roll.Width = 60;
            // 
            // Section
            // 
            this.Section.DataPropertyName = "SectionName";
            this.Section.HeaderText = "Section";
            this.Section.Name = "Section";
            this.Section.ReadOnly = true;
            this.Section.Width = 80;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "Student Name";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Width = 200;
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.HeaderText = "StudentId";
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            this.StudentId.Visible = false;
            // 
            // Marks
            // 
            this.Marks.DataPropertyName = "ViewPromote";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Marks.DefaultCellStyle = dataGridViewCellStyle5;
            this.Marks.HeaderText = "Action";
            this.Marks.Name = "Marks";
            this.Marks.ReadOnly = true;
            this.Marks.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Marks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Marks.Text = "Marks";
            this.Marks.Width = 75;
            // 
            // IsProcessed
            // 
            this.IsProcessed.DataPropertyName = "IsProcessed";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IsProcessed.DefaultCellStyle = dataGridViewCellStyle6;
            this.IsProcessed.HeaderText = "Processed?";
            this.IsProcessed.Name = "IsProcessed";
            this.IsProcessed.ReadOnly = true;
            this.IsProcessed.Width = 85;
            // 
            // FormPromoteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(590, 548);
            this.Controls.Add(this.buttonPromote);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.comboBoxClass);
            this.Controls.Add(this.labelClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPromoteStudent";
            this.Text = "FormPromoteStudent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPromoteStudent_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonPromote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewLinkColumn Marks;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsProcessed;
    }
}