namespace SchoolAttendanceSystem
{
    partial class FormAddClass
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
            this.dataGridViewClass = new System.Windows.Forms.DataGridView();
            this.checkBoxIsActive = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.labelClass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textBoxOrderBy = new System.Windows.Forms.TextBox();
            this.labelOrderBy = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClass
            // 
            this.dataGridViewClass.AllowUserToAddRows = false;
            this.dataGridViewClass.AllowUserToDeleteRows = false;
            this.dataGridViewClass.AllowUserToResizeColumns = false;
            this.dataGridViewClass.AllowUserToResizeRows = false;
            this.dataGridViewClass.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ClassName,
            this.IsActive,
            this.OrderBy});
            this.dataGridViewClass.Location = new System.Drawing.Point(35, 182);
            this.dataGridViewClass.MultiSelect = false;
            this.dataGridViewClass.Name = "dataGridViewClass";
            this.dataGridViewClass.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewClass.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClass.Size = new System.Drawing.Size(360, 288);
            this.dataGridViewClass.TabIndex = 91;
            this.dataGridViewClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClass_CellClick);
            this.dataGridViewClass.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewClass_DataBindingComplete);
            this.dataGridViewClass.SelectionChanged += new System.EventHandler(this.dataGridViewClass_SelectionChanged);
            this.dataGridViewClass.Enter += new System.EventHandler(this.dataGridViewClass_Enter);
            // 
            // checkBoxIsActive
            // 
            this.checkBoxIsActive.AutoSize = true;
            this.checkBoxIsActive.Checked = true;
            this.checkBoxIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIsActive.Location = new System.Drawing.Point(144, 78);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIsActive.TabIndex = 90;
            this.checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 89;
            this.label2.Text = "Active?:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxClass
            // 
            this.textBoxClass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClass.Location = new System.Drawing.Point(144, 12);
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.Size = new System.Drawing.Size(251, 22);
            this.textBoxClass.TabIndex = 88;
            // 
            // labelClass
            // 
            this.labelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.Location = new System.Drawing.Point(1, 15);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(137, 25);
            this.labelClass.TabIndex = 87;
            this.labelClass.Text = "Class:";
            this.labelClass.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 86;
            this.label1.Text = "Class List:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(290, 105);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(105, 40);
            this.buttonAdd.TabIndex = 85;
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
            this.buttonUpdate.Location = new System.Drawing.Point(169, 105);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(105, 40);
            this.buttonUpdate.TabIndex = 93;
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
            this.buttonReset.Location = new System.Drawing.Point(48, 105);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(105, 40);
            this.buttonReset.TabIndex = 92;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // textBoxOrderBy
            // 
            this.textBoxOrderBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxOrderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOrderBy.Location = new System.Drawing.Point(144, 37);
            this.textBoxOrderBy.Name = "textBoxOrderBy";
            this.textBoxOrderBy.Size = new System.Drawing.Size(251, 22);
            this.textBoxOrderBy.TabIndex = 95;
            // 
            // labelOrderBy
            // 
            this.labelOrderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderBy.Location = new System.Drawing.Point(1, 40);
            this.labelOrderBy.Name = "labelOrderBy";
            this.labelOrderBy.Size = new System.Drawing.Size(137, 25);
            this.labelOrderBy.TabIndex = 94;
            this.labelOrderBy.Text = "OrderBy:";
            this.labelOrderBy.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "ClassId";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // ClassName
            // 
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "Class Name";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            this.ClassName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClassName.Width = 130;
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
            // OrderBy
            // 
            this.OrderBy.DataPropertyName = "OrderBy";
            this.OrderBy.HeaderText = "Order";
            this.OrderBy.Name = "OrderBy";
            this.OrderBy.ReadOnly = true;
            // 
            // FormAddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 502);
            this.Controls.Add(this.textBoxOrderBy);
            this.Controls.Add(this.labelOrderBy);
            this.Controls.Add(this.dataGridViewClass);
            this.Controls.Add(this.checkBoxIsActive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxClass);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonReset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddClass";
            this.Text = "FormAddClass";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddClass_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClass;
        private System.Windows.Forms.CheckBox checkBoxIsActive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxClass;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox textBoxOrderBy;
        private System.Windows.Forms.Label labelOrderBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderBy;
    }
}