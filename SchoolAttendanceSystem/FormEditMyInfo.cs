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
    public partial class FormEditMyInfo : Form
    {
        private readonly CommonService _commonService = new CommonService();
        private List<BaseData> genderList;
        private readonly EmployeeService _employeeService = new EmployeeService();
        private String ErrorMessage = "";
        private List<String> ErrorList = new List<String>();
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
        public FormEditMyInfo()
        {
            InitializeComponent();
            LoadData();


        }



        private static FormEditMyInfo _instance;
        public static FormEditMyInfo Instance
        {
            get { return _instance ?? (_instance = new FormEditMyInfo()); }
        }

        private void FormEditEmployeeInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
        private void LoadData()
        {
            textBoxEmployeeName.Text = CommonService.personInfo.Name;
            textBoxUsername.Text = CommonService.userInfo.Username;
            textBoxEmail.Text = CommonService.userInfo.Email;
            dateTimePickerBirthDate.Text = CommonService.personInfo.BirthDate.ToString();
            if (CommonService.personInfo.GenderId == 1)
                radioButtonFemale.Checked = true;
            else if (CommonService.personInfo.GenderId == 2)
                radioButtonMale.Checked = true;
            else if (CommonService.personInfo.GenderId == 3)
                radioButtonOther.Checked = true;
            textBoxReligion.Text = CommonService.personInfo.Religion;

            textBoxPhone.Text = CommonService.empInfo.Phone;
            richTextBoxAddress.Text = CommonService.personInfo.Address;
            genderList = _commonService.GetBaseDataByCatagory(EnumBaseData.Gender.ToString());
            var bloodGroupList = _commonService.GetBaseDataByCatagory(EnumBaseData.BloodGroup.ToString());
            bloodGroupList.Insert(0, new BaseData { Value = "--Select--", Id = -1 });
            comboBoxBloodGroup.DataSource = bloodGroupList;
            comboBoxBloodGroup.DisplayMember = "Value";
            comboBoxBloodGroup.ValueMember = "Id";
            comboBoxBloodGroup.SelectedValue = CommonService.personInfo.BloodGroupId == null ? -1 : CommonService.personInfo.BloodGroupId;

        }
        private void buttonUpdateStaff_Click(object sender, EventArgs e)
        {
            if (EmptyCheck())
            {
                MessageBox.Show("All fields should be filled properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DoValidation())
            {
                var person = new Person();
                person.Name = textBoxEmployeeName.Text;
                person.PersonId = CommonService.personInfo.PersonId;
                person.Religion = textBoxReligion.Text;
                person.BirthDate = dateTimePickerBirthDate.Value;
                person.BloodGroupId = (int)comboBoxBloodGroup.SelectedValue == -1 ? (int?)null : (int)comboBoxBloodGroup.SelectedValue;
                person.GenderId = GetSelectedGenderId();
                person.Address = richTextBoxAddress.Text;

                var userInfo = new User();
                userInfo.UserId = CommonService.userInfo.UserId;
                userInfo.Username = textBoxUsername.Text;
                userInfo.Email = textBoxEmail.Text;

                var empInfo = new Employee();
                empInfo.EmployeeId = CommonService.empInfo.EmployeeId;
                empInfo.JoinDate = dateTimePickerJoinDate.Value;
                empInfo.Phone = textBoxPhone.Text;


                if (_commonService.UpdateMyInfo(person, userInfo, empInfo))
                {
                    MessageBox.Show("Data Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //ClearFields();

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

        private bool DoValidation()
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
            textBoxEmail.Validating -= TextBoxEmail_Validating;



            radioButtonFemale.Validating -= RadioButtonGender_Validating;
            radioButtonMale.Validating -= RadioButtonGender_Validating;
            radioButtonOther.Validating -= RadioButtonGender_Validating;

            textBoxPhone.Validating -= TextBoxPhone_Validating;
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

            

            if (textBoxEmail.Text.Length <= 0)
            {
                ProcessInvalid(labelEmail);
                emptyCount++;
            }
            else ProcessValid(labelEmail);

            bool genderChecked = radioButtonMale.Checked ^ radioButtonFemale.Checked ^ radioButtonOther.Checked;
            if (!genderChecked)
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
            if (textBoxUsername.Text == CommonService.userInfo.Username) return;
            bool isValid = true;
            string regularExpression = _commonService.UsernameRegex;
            if (textBoxUsername.Text.Length >= 5 && textBoxUsername.Text.Length <= 20)
            {
                if (_commonService.CheckUsernameExists(textBoxUsername.Text))
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


        
        void TextBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxEmail.Text == CommonService.userInfo.Email) return;
            bool isValid = true;
            string regularExpression = _commonService.EmailRegex;
            if (_commonService.CheckEmailExists(textBoxEmail.Text))
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
            if (!isValid)
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
            if (textBoxUsername.Text == CommonService.userInfo.Username) return;
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
            if (textBoxEmail.Text == CommonService.userInfo.Email) return;
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
