namespace SchoolAttendanceSystem
{
    partial class FormChangePassword
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
            this.textBoxOld = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNew = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxConfirmNew = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxOld
            // 
            this.textBoxOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOld.Location = new System.Drawing.Point(155, 19);
            this.textBoxOld.Name = "textBoxOld";
            this.textBoxOld.PasswordChar = '•';
            this.textBoxOld.Size = new System.Drawing.Size(251, 22);
            this.textBoxOld.TabIndex = 79;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 25);
            this.label6.TabIndex = 78;
            this.label6.Text = "Old Password:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxNew
            // 
            this.textBoxNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNew.Location = new System.Drawing.Point(155, 58);
            this.textBoxNew.Name = "textBoxNew";
            this.textBoxNew.PasswordChar = '•';
            this.textBoxNew.Size = new System.Drawing.Size(251, 22);
            this.textBoxNew.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 80;
            this.label1.Text = "New Password:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxConfirmNew
            // 
            this.textBoxConfirmNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmNew.Location = new System.Drawing.Point(155, 103);
            this.textBoxConfirmNew.Name = "textBoxConfirmNew";
            this.textBoxConfirmNew.PasswordChar = '•';
            this.textBoxConfirmNew.Size = new System.Drawing.Size(251, 22);
            this.textBoxConfirmNew.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 82;
            this.label2.Text = "Confirm Password:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(292, 150);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(114, 40);
            this.buttonUpdate.TabIndex = 84;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // FormChangePassword
            // 
            this.AcceptButton = this.buttonUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 212);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxConfirmNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOld);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormChangePassword";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormChangePassword_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOld;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxConfirmNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUpdate;
    }
}