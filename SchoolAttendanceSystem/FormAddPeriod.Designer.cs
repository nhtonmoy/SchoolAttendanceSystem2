namespace SchoolAttendanceSystem
{
    partial class FormAddPeriod
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PeriodId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.buttonUpdateList = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PeriodId,
            this.PeriodName,
            this.TimeFrom,
            this.TimeTo});
            this.dataGridView1.Location = new System.Drawing.Point(12, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(366, 313);
            this.dataGridView1.TabIndex = 0;
            // 
            // PeriodId
            // 
            this.PeriodId.DataPropertyName = "PeriodId";
            this.PeriodId.HeaderText = "PeriodId";
            this.PeriodId.Name = "PeriodId";
            this.PeriodId.Visible = false;
            // 
            // PeriodName
            // 
            this.PeriodName.DataPropertyName = "PeriodName";
            this.PeriodName.HeaderText = "Period Name";
            this.PeriodName.Name = "PeriodName";
            // 
            // TimeFrom
            // 
            this.TimeFrom.DataPropertyName = "TimeFrom";
            dataGridViewCellStyle1.Format = "t";
            dataGridViewCellStyle1.NullValue = null;
            this.TimeFrom.DefaultCellStyle = dataGridViewCellStyle1;
            this.TimeFrom.HeaderText = "Start Time";
            this.TimeFrom.Name = "TimeFrom";
            // 
            // TimeTo
            // 
            this.TimeTo.DataPropertyName = "TimeTo";
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = null;
            this.TimeTo.DefaultCellStyle = dataGridViewCellStyle2;
            this.TimeTo.HeaderText = "End Time";
            this.TimeTo.Name = "TimeTo";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "Period Name:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeeName.Location = new System.Drawing.Point(164, 10);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(214, 22);
            this.textBoxEmployeeName.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "End Time:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "Start Time:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.CustomFormat = "hh:mm tt";
            this.dateTimePickerBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(164, 38);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(214, 22);
            this.dateTimePickerBirthDate.TabIndex = 44;
            // 
            // buttonUpdateList
            // 
            this.buttonUpdateList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUpdateList.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonUpdateList.FlatAppearance.BorderSize = 0;
            this.buttonUpdateList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateList.Location = new System.Drawing.Point(275, 94);
            this.buttonUpdateList.Name = "buttonUpdateList";
            this.buttonUpdateList.Size = new System.Drawing.Size(103, 25);
            this.buttonUpdateList.TabIndex = 49;
            this.buttonUpdateList.Text = "Update List";
            this.buttonUpdateList.UseVisualStyleBackColor = false;
            this.buttonUpdateList.Click += new System.EventHandler(this.buttonAddPeriod_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "hh:mm tt";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(164, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 22);
            this.dateTimePicker1.TabIndex = 50;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(166, 94);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(103, 25);
            this.buttonDelete.TabIndex = 51;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // FormAddPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 488);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonUpdateList);
            this.Controls.Add(this.dateTimePickerBirthDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEmployeeName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddPeriod";
            this.Text = "FormAddPeriod";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddPeriod_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.Button buttonUpdateList;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeTo;
    }
}