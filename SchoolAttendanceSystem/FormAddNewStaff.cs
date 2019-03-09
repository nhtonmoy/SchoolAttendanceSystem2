using Core.Data.DB;
using Core.Data.ViewModel;
using Core.Enum;
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
    public partial class FormAddNewStaff : Form
    {
        private readonly EmployeeService _employeeService = new EmployeeService();
        private List<BaseData> genderList;
        private readonly CommonService _commonService = new CommonService();
        //private List<BaseData> bloodGroupList;

        private String ErrorMessage = "";
        private List<String> ErrorList = new List<String>();

        //private List<BaseData> bloodGroupList;
        public FormAddNewStaff()
        {
            InitializeComponent();
            LoadData();

        }

        private void LoadData()
        {
            var bloodGroupList = _commonService.GetBaseDataByCatagory(EnumBaseData.BloodGroup.ToString());
            bloodGroupList.Insert(0, new BaseData { Value = "--Select--", Id = -1 });
            comboBoxBloodGroup.DataSource = bloodGroupList;
            comboBoxBloodGroup.DisplayMember = "Value";
            comboBoxBloodGroup.ValueMember = "Id";

            genderList = _commonService.GetBaseDataByCatagory(EnumBaseData.Gender.ToString());

            dateTimePickerBirthDate.MaxDate = DateTime.Now.AddYears(-18);
            dateTimePickerBirthDate.MinDate = DateTime.Now.AddYears(-70);
            dateTimePickerJoinDate.MaxDate = DateTime.Now;
        }

        private static FormAddNewStaff _instance;
        public static FormAddNewStaff Instance
        {
            get { return _instance ?? (_instance = new FormAddNewStaff()); }
        }

        private void FormAddNewStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }



        bool DoValidation()
        {
            AttachValidation();
            bool res = ValidateChildren();

            DetachValidation();
            return res;
        }
        private void AttachValidation()
        {
            textBoxEmployeeName.Validating += TextBoxEmployeeName_Validating;
            textBoxUsername.Validating += TextBoxUsername_Validating;
            textBoxPassword.Validating += TextBoxPassword_Validating;
            textBoxEmail.Validating += TextBoxEmail_Validating;

            radioButtonFemale.Validating += RadioButtonGender_Validating;
            radioButtonMale.Validating += RadioButtonGender_Validating;
            radioButtonOther.Validating += RadioButtonGender_Validating;

            textBoxPhone.Validating += TextBoxPhone_Validating;
        }
        private void DetachValidation()
        {
            textBoxEmployeeName.Validating -= TextBoxEmployeeName_Validating;
            textBoxUsername.Validating -= TextBoxUsername_Validating;
            textBoxPassword.Validating -= TextBoxPassword_Validating;
            textBoxEmail.Validating -= TextBoxEmail_Validating;

            radioButtonFemale.Validating -= RadioButtonGender_Validating;
            radioButtonMale.Validating -= RadioButtonGender_Validating;
            radioButtonOther.Validating -= RadioButtonGender_Validating;

            textBoxPhone.Validating -= TextBoxPhone_Validating;
        }



        private void buttonAddStaff_Click(object sender, EventArgs e)
        {
            if (EmptyCheck())
            {
                MessageBox.Show("All fields should be filled properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DoValidation())
            {
                var staff = new EmployeeViewModel
                {
                    Name = textBoxEmployeeName.Text,
                    Username = textBoxUsername.Text,
                    Password = textBoxPassword.Text,
                    Email = textBoxEmail.Text,
                    DateOfBirth = DateTime.Parse(dateTimePickerBirthDate.Text),
                    GenderId = GetSelectedGenderId(),
                    Religion = textBoxReligion.Text,
                    Phone = textBoxPhone.Text,
                    JoinDate = DateTime.Parse(dateTimePickerJoinDate.Text),
                    Address = richTextBoxAddress.Text,
                    BloodGroupId = (int)comboBoxBloodGroup.SelectedValue == -1 ? (int?)null : (int)comboBoxBloodGroup.SelectedValue
                };
                if (_employeeService.AddNewStaff(staff))
                {

                    MessageBox.Show("Data Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            else
            {
                if (ErrorList.Count == 0)
                {
                    MessageBox.Show("All fields should be filled properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ErrorList.First(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ErrorList.Clear();
                }


            }
            ErrorMessage = "";

        }

        private void ClearFields()
        {
            foreach (Control cntrl in Controls)
            {
                switch (cntrl.GetType().ToString())
                {
                    case "System.Windows.Forms.ComboBox":
                        ((ComboBox)cntrl).SelectedIndex = 0;
                        break;
                    case "System.Windows.Forms.TextBox":
                        ((TextBox)cntrl).Clear();
                        break;
                    case "System.Windows.Forms.PictureBox":
                        ((PictureBox)cntrl).Image = Properties.Resources.blank_profile_picture;
                        break;
                    case "System.Windows.Forms.DateTimePicker":
                        if (((DateTimePicker)cntrl) == dateTimePickerBirthDate) dateTimePickerBirthDate.Value = dateTimePickerBirthDate.MaxDate;
                        else if (((DateTimePicker)cntrl) == dateTimePickerJoinDate) dateTimePickerJoinDate.Value = dateTimePickerJoinDate.MaxDate;
                        break;
                    case "System.Windows.Forms.RadioButton":
                        ((RadioButton)cntrl).Checked = false;
                        break;
                }
            }
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            radioButtonOther.Checked = false;
        }

        private bool EmptyCheck()
        {
            int emptyCount = 0;

            if (textBoxEmployeeName.Text.Length <= 0)
            {
                ProcessInvalid(labelName);
                emptyCount++;
            }
            else
                ProcessValid(labelName);

            if (textBoxUsername.Text.Length <= 0)
            {
                ProcessInvalid(labelUsername);
                emptyCount++;
            }
            else
                ProcessValid(labelUsername);

            if (textBoxPassword.Text.Length <= 0)
            {
                ProcessInvalid(labelPassword);
                emptyCount++;
            }
            else ProcessValid(labelPassword);

            if (textBoxEmail.Text.Length <= 0)
            {
                ProcessInvalid(labelEmail);
                emptyCount++;
            }
            else ProcessValid(labelEmail);

            bool sexChecked = radioButtonMale.Checked ^ radioButtonFemale.Checked ^ radioButtonOther.Checked;
            if (!sexChecked)
            {
                ProcessInvalid(labelGender);
                emptyCount++;
            }
            else
                ProcessValid(labelGender);

            if (textBoxPhone.Text.Length <= 0)
            {
                ProcessInvalid(labelPhone);
                emptyCount++;
            }
            else ProcessValid(labelPhone);

            if (emptyCount > 0)
                return true;

            return false;
        }
        void ProcessInvalid(Control control)
        {
            control.ForeColor = Color.Red;
        }

        void ProcessValid(Control control)
        {
            control.ResetForeColor();
        }


        private int GetSelectedGenderId()
        {
            string gender = "";
            if (radioButtonFemale.Checked)
            {
                gender = EnumGender.Female.ToString();
            }
            else if (radioButtonMale.Checked)
            {
                gender = EnumGender.Male.ToString();
            }
            else
            {
                gender = EnumGender.Other.ToString();
            }
            return genderList.First(x => x.Value == gender).Id;
        }

        void TextBoxEmployeeName_Validating(object sender, CancelEventArgs e)
        {
            string regularExpression = _commonService.NameRegex;
            if (Regex.IsMatch(textBoxEmployeeName.Text, regularExpression))
            {
                ProcessValid(labelName);
            }
            else
            {
                ProcessInvalid(labelName);
                if (textBoxEmployeeName.Text != string.Empty)
                {
                    ErrorMessage = "Name: Enter Valid Name.\n";
                    ErrorList.Add(ErrorMessage);
                    ErrorMessage = string.Empty;
                }
                e.Cancel = true;
            }
        }


        void TextBoxUsername_Validating(object sender, CancelEventArgs e)
        {
            bool isValid = true;
            string regularExpression = _commonService.UsernameRegex;
            if (textBoxUsername.Text.Length >= 5 && textBoxUsername.Text.Length <= 20)
            {
                if(_commonService.CheckUsernameExists(textBoxUsername.Text))
                {
                    isValid = false;
                    ErrorMessage = "Username: already exists";
                }
                else if (Regex.IsMatch(textBoxUsername.Text, regularExpression))
                {
                    ProcessValid(labelUsername);
                }
                else
                {
                    isValid = false;
                    ErrorMessage = "Username: contains only numbers and characters";
                }
            }
            else
            {
                isValid = false;
                ErrorMessage = "Username: must be at least 5 characters in length, max 20";
            }
            if (!isValid)
            {

                ProcessInvalid(labelUsername);
                if (textBoxUsername.Text != string.Empty)
                {
                   // ErrorMessage = "Username: contains only numbers and characters.\nAnd be at least 5 characters in length, max 20";
                    ErrorList.Add(ErrorMessage);
                    ErrorMessage = string.Empty;
                }
                e.Cancel = true;
            }
        }


        void TextBoxPassword_Validating(object sender, CancelEventArgs e)
        {
            string regularExpression = _commonService.PasswordRegex;
            if (Regex.IsMatch(textBoxPassword.Text, regularExpression))
            {
                ProcessValid(labelPassword);
            }
            else
            {
                ProcessInvalid(labelPassword);
                if (textBoxPassword.Text != string.Empty)
                {
                    ErrorMessage = "Password: doesn't contain SPACE .\nAnd be at least 5 characters in length, max 50";
                    ErrorList.Add(ErrorMessage);
                    ErrorMessage = string.Empty;
                }
                e.Cancel = true;
            }
        }
        void TextBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            bool isValid = true;
            string regularExpression = _commonService.EmailRegex;
            if(_commonService.CheckEmailExists(textBoxEmail.Text))
            {
                isValid = false;
                ErrorMessage = "Email: already exists";
            }
            else if (Regex.IsMatch(textBoxEmail.Text, regularExpression))
            {

                ProcessValid(labelEmail);
            }
            else
            {
                isValid = false;
                ErrorMessage = @"Email: format should be 'email@example.com'";
            }
            if(!isValid)
            {
                ProcessInvalid(labelEmail);
                if (textBoxEmail.Text != string.Empty)
                {
                    ErrorList.Add(ErrorMessage);
                    ErrorMessage = string.Empty;
                }
                e.Cancel = true;
            }
        }

        void RadioButtonGender_Validating(object sender, CancelEventArgs e)
        {
            bool res = radioButtonMale.Checked ^ radioButtonFemale.Checked ^ radioButtonOther.Checked;

            if (res)
            {
                ProcessValid(labelGender);
            }
            else
            {
                e.Cancel = true;
                ProcessInvalid(labelGender);
            }
        }

        void TextBoxPhone_Validating(object sender, CancelEventArgs e)
        {
            bool isValid = true;
            string regularExpression = _commonService.PhoneRegex;
            if (textBoxPhone.Text.Length >= 3 && textBoxPhone.Text.Length <= 20)
            {
                if (Regex.IsMatch(textBoxPhone.Text, regularExpression))
                {
                    ProcessValid(labelPhone);
                }
                else
                {
                    ProcessInvalid(labelPhone);
                    isValid = false;
                }
            }
            else
            {
                isValid = false;
                ProcessInvalid(labelPhone);
            }
            if (!isValid)
            {
                if (textBoxPhone.Text != string.Empty)
                {
                    ErrorMessage = "Phone: be at least 3 characters in length, max 20";
                    ErrorList.Add(ErrorMessage);
                    ErrorMessage = string.Empty;
                }
                e.Cancel = true;
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (_commonService.CheckUsernameExists(textBoxUsername.Text))
            {
                
                ProcessInvalid(labelUsername);
                ErrorMessage = "Username: already exists";
                MessageBox.Show(ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorMessage = string.Empty;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (_commonService.CheckEmailExists(textBoxEmail.Text))
            {

                ProcessInvalid(labelEmail);
                ErrorMessage = "Email: already exists";
                MessageBox.Show(ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorMessage = string.Empty;
            }
        }
    }
}
