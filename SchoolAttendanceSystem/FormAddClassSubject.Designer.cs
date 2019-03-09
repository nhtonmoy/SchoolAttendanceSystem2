namespace SchoolAttendanceSystem
{
    partial class FormAddClassSubject
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
            this.labelClass = new System.Windows.Forms.Label();
            this.listBoxSubject = new System.Windows.Forms.ListBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAddSubject = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSection = new System.Windows.Forms.Label();
            this.checkBoxAllSection = new System.Windows.Forms.CheckBox();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.comboBoxSection = new System.Windows.Forms.ComboBox();
            this.labelAllSection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelClass
            // 
            this.labelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.Location = new System.Drawing.Point(-10, 18);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(137, 25);
            this.labelClass.TabIndex = 36;
            this.labelClass.Text = "Class :";
            this.labelClass.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // listBoxSubject
            // 
            this.listBoxSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSubject.FormattingEnabled = true;
            this.listBoxSubject.ItemHeight = 16;
            this.listBoxSubject.Location = new System.Drawing.Point(133, 69);
            this.listBoxSubject.Name = "listBoxSubject";
            this.listBoxSubject.ScrollAlwaysVisible = true;
            this.listBoxSubject.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxSubject.Size = new System.Drawing.Size(251, 308);
            this.listBoxSubject.TabIndex = 55;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(332, 383);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(150, 40);
            this.buttonUpdate.TabIndex = 57;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAddSubject
            // 
            this.buttonAddSubject.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddSubject.BackgroundImage = global::SchoolAttendanceSystem.Properties.Resources.AddIcon;
            this.buttonAddSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddSubject.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAddSubject.FlatAppearance.BorderSize = 0;
            this.buttonAddSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSubject.Location = new System.Drawing.Point(403, 210);
            this.buttonAddSubject.Name = "buttonAddSubject";
            this.buttonAddSubject.Size = new System.Drawing.Size(50, 50);
            this.buttonAddSubject.TabIndex = 58;
            this.buttonAddSubject.UseVisualStyleBackColor = false;
            this.buttonAddSubject.Click += new System.EventHandler(this.buttonAddSubject_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-10, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 59;
            this.label1.Text = "Select Subjects :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelSection
            // 
            this.labelSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSection.Location = new System.Drawing.Point(274, 18);
            this.labelSection.Name = "labelSection";
            this.labelSection.Size = new System.Drawing.Size(81, 25);
            this.labelSection.TabIndex = 61;
            this.labelSection.Text = "Section :";
            this.labelSection.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // checkBoxAllSection
            // 
            this.checkBoxAllSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAllSection.Location = new System.Drawing.Point(133, 48);
            this.checkBoxAllSection.Name = "checkBoxAllSection";
            this.checkBoxAllSection.Size = new System.Drawing.Size(14, 15);
            this.checkBoxAllSection.TabIndex = 62;
            this.checkBoxAllSection.UseVisualStyleBackColor = true;
            this.checkBoxAllSection.CheckedChanged += new System.EventHandler(this.checkBoxAllSection_CheckedChanged);
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClass.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(133, 15);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(121, 24);
            this.comboBoxClass.TabIndex = 64;
            this.comboBoxClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxClass_SelectedIndexChanged);
            // 
            // comboBoxSection
            // 
            this.comboBoxSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSection.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSection.FormattingEnabled = true;
            this.comboBoxSection.Location = new System.Drawing.Point(361, 15);
            this.comboBoxSection.Name = "comboBoxSection";
            this.comboBoxSection.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSection.TabIndex = 65;
            this.comboBoxSection.SelectedIndexChanged += new System.EventHandler(this.comboBoxSection_SelectedIndexChanged);
            // 
            // labelAllSection
            // 
            this.labelAllSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAllSection.Location = new System.Drawing.Point(35, 46);
            this.labelAllSection.Name = "labelAllSection";
            this.labelAllSection.Size = new System.Drawing.Size(92, 25);
            this.labelAllSection.TabIndex = 63;
            this.labelAllSection.Text = "All Section:";
            this.labelAllSection.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormAddClassSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 435);
            this.Controls.Add(this.comboBoxSection);
            this.Controls.Add(this.comboBoxClass);
            this.Controls.Add(this.labelAllSection);
            this.Controls.Add(this.checkBoxAllSection);
            this.Controls.Add(this.labelSection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddSubject);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.listBoxSubject);
            this.Controls.Add(this.labelClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddClassSubject";
            this.Text = "AddClassSubject";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddClassSubject_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddClassSubject_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.ListBox listBoxSubject;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAddSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSection;
        private System.Windows.Forms.CheckBox checkBoxAllSection;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.ComboBox comboBoxSection;
        private System.Windows.Forms.Label labelAllSection;
    }
}