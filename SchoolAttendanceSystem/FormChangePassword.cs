using Core.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolAttendanceSystem
{
    public partial class FormChangePassword : Form
    {
        private readonly CommonService _commonService = new CommonService();
        private string ErrorMessage = "";
        public FormChangePassword()
        {
            InitializeComponent();
        }
        private static FormChangePassword _instance;
        public static FormChangePassword Instance
        {
            get { return _instance ?? (_instance = new FormChangePassword()); }
        }
        private void FormChangePassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxOld.Text.Equals(CommonService.userInfo.Password))
            {
                if (DoValidation())
                {
                    if (textBoxConfirmNew.Text.Equals(textBoxNew.Text))
                    {
                        _commonService.ChangePassword(textBoxNew.Text);
                        MessageBox.Show("Password Changed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CommonService.userInfo.Password = textBoxNew.Text;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Confirm password doesn't match New password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (textBoxNew.Text.Equals(""))
                {
                    MessageBox.Show("Password Can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }
            else
            {
                MessageBox.Show("Invalid old password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool DoValidation()
        {
            AttachValidation();
            bool res = ValidateChildren();

            DetachValidation();
            return res;
            
        }

        private void DetachValidation()
        {
            textBoxOld.Validating -= TextBoxOld_Validating;
        }

        private void AttachValidation()
        {
            textBoxOld.Validating += TextBoxOld_Validating;
        }

        void TextBoxOld_Validating(object sender, CancelEventArgs e)
        {
            string regularExpression = _commonService.PasswordRegex;
            if (Regex.IsMatch(textBoxNew.Text, regularExpression))
            {
                
            }
            else
            {
                if (textBoxNew.Text != string.Empty)
                {
                    ErrorMessage = "Password: doesn't contain SPACE .\nAnd be at least 5 characters in length, max 50";
                    //ErrorMessage = string.Empty;
                }
                e.Cancel = true;
            }
        }

        
    }
}
