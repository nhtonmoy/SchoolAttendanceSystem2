namespace SchoolAttendanceSystem
{
    partial class FormAddExam
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxPercentage = new System.Windows.Forms.TextBox();
            this.labelFinalPercentage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewExam = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxIsActive = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxExam = new System.Windows.Forms.TextBox();
            this.labelExam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExam)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPercentage
            // 
            this.textBoxPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPercentage.Location = new System.Drawing.Point(176, 36);
            this.textBoxPercentage.Name = "textBoxPercentage";
            this.textBoxPercentage.Size = new System.Drawing.Size(54, 22);
            this.textBoxPercentage.TabIndex = 81;
            // 
            // labelFinalPercentage
            // 
            this.labelFinalPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinalPercentage.Location = new System.Drawing.Point(33, 36);
            this.labelFinalPercentage.Name = "labelFinalPercentage";
            this.labelFinalPercentage.Size = new System.Drawing.Size(137, 25);
            this.labelFinalPercentage.TabIndex = 80;
            this.labelFinalPercentage.Text = "Final Percentage :";
            this.labelFinalPercentage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 25);
            this.label4.TabIndex = 82;
            this.label4.Text = "%";
            // 
            // dataGridViewExam
            // 
            this.dataGridViewExam.AllowUserToDeleteRows = false;
            this.dataGridViewExam.AllowUserToResizeColumns = false;
            this.dataGridViewExam.AllowUserToResizeRows = false;
            this.dataGridViewExam.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewExam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ExamName,
            this.FinalPercentage,
            this.IsActive});
            this.dataGridViewExam.Location = new System.Drawing.Point(36, 186);
            this.dataGridViewExam.MultiSelect = false;
            this.dataGridViewExam.Name = "dataGridViewExam";
            this.dataGridViewExam.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewExam.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewExam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExam.Size = new System.Drawing.Size(391, 296);
            this.dataGridViewExam.TabIndex = 89;
            this.dataGridViewExam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewExam_CellClick);
            this.dataGridViewExam.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewExam_DataBindingComplete);
            this.dataGridViewExam.SelectionChanged += new System.EventHandler(this.dataGridViewExam_SelectionChanged);
            this.dataGridViewExam.Enter += new System.EventHandler(this.dataGridViewExam_Enter);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "ExamId";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 80;
            // 
            // ExamName
            // 
            this.ExamName.DataPropertyName = "ExamName";
            this.ExamName.HeaderText = "Exam Name";
            this.ExamName.Name = "ExamName";
            this.ExamName.ReadOnly = true;
            this.ExamName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ExamName.Width = 195;
            // 
            // FinalPercentage
            // 
            this.FinalPercentage.DataPropertyName = "FinalPercentage";
            this.FinalPercentage.HeaderText = "%";
            this.FinalPercentage.Name = "FinalPercentage";
            this.FinalPercentage.ReadOnly = true;
            this.FinalPercentage.Width = 90;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IsActive.DefaultCellStyle = dataGridViewCellStyle2;
            this.IsActive.HeaderText = "Active?";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            this.IsActive.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IsActive.Width = 60;
            // 
            // checkBoxIsActive
            // 
            this.checkBoxIsActive.AutoSize = true;
            this.checkBoxIsActive.Checked = true;
            this.checkBoxIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIsActive.Location = new System.Drawing.Point(176, 64);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIsActive.TabIndex = 88;
            this.checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-34, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 87;
            this.label2.Text = "Active? :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxExam
            // 
            this.textBoxExam.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExam.Location = new System.Drawing.Point(176, 8);
            this.textBoxExam.Name = "textBoxExam";
            this.textBoxExam.Size = new System.Drawing.Size(251, 22);
            this.textBoxExam.TabIndex = 86;
            // 
            // labelExam
            // 
            this.labelExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExam.Location = new System.Drawing.Point(-2, 9);
            this.labelExam.Name = "labelExam";
            this.labelExam.Size = new System.Drawing.Size(137, 25);
            this.labelExam.TabIndex = 85;
            this.labelExam.Text = "Exam Name :";
            this.labelExam.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 84;
            this.label1.Text = "Exam List :";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(291, 94);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(105, 40);
            this.buttonAdd.TabIndex = 83;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(170, 94);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(105, 40);
            this.buttonUpdate.TabIndex = 91;
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
            this.buttonReset.Location = new System.Drawing.Point(49, 94);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(105, 40);
            this.buttonReset.TabIndex = 90;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // FormAddExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 494);
            this.Controls.Add(this.dataGridViewExam);
            this.Controls.Add(this.checkBoxIsActive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxExam);
            this.Controls.Add(this.labelExam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPercentage);
            this.Controls.Add(this.labelFinalPercentage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddExam";
            this.Text = "FormAddExam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddExam_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPercentage;
        private System.Windows.Forms.Label labelFinalPercentage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewExam;
        private System.Windows.Forms.CheckBox checkBoxIsActive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxExam;
        private System.Windows.Forms.Label labelExam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
    }
}