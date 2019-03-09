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
    public partial class FormStudentList : Form
    {
        private readonly StudentService _studentService = new StudentService();
        private readonly SettingService _settingService = new SettingService();
        private readonly CommonService _commonService = new CommonService();
        bool isUpdate = false;
        private List<BaseData> genderList;
        string gridViewSelectedId = "";
        private List<BaseData> statusList;
        private String ErrorMessage = "";
        private List<String> ErrorList = new List<String>();

        public FormStudentList()
        {
            InitializeComponent();
            dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged;
            LoadData();
            buttonUpdateStudent.Enabled = false;
            buttonUpdateStudent.BackColor = SystemColors.ControlLight;

        }
        private static FormStudentList _instance;
        public static FormStudentList Instance
        {
            get { return _instance ?? (_instance = new FormStudentList()); }
        }

        private void FormStudentList_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void LoadData()
        {
            textBoxSearch.Text = "Search...";
            LoadStudentStatusComboBox();
            LoadClassesComboBox();
            comboBoxSection.Enabled = false;
            genderList = _commonService.GetBaseDataByCatagory(EnumBaseData.Gender.ToString());
            GetBloodGroupComboBox();
            comboBoxStatus.SelectedValue = statusList.First(x => x.Value.Equals("Current")).Id;

            //var bloodGroupList = _commonService.GetBaseDataByCatagory(EnumBaseData.BloodGroup.ToString());
            //bloodGroupList.Insert(0, new BaseData { Value = "--Select--", Id = -1 });
            //comboBoxBloodGroup.DataSource = bloodGroupList;
            //comboBoxBloodGroup.DisplayMember = "Value";
            //comboBoxBloodGroup.ValueMember = "Id";

            //genderList = _commonService.GetBaseDataByCatagory(EnumBaseData.Gender.ToString());

            dateTimePickerBirthDate.MaxDate = DateTime.Now.AddYears(-6);
            dateTimePickerBirthDate.MinDate = DateTime.Now.AddYears(-18);
            LoadClassList(_settingService.GetClassList());
            //LoadDataStudent(_studentService.GetStudentList());

        }
        private void LoadClassList(List<ClassViewModel> list)
        {
            comboBoxLoadClass.DataSource = list;
            comboBoxLoadClass.DisplayMember = "ClassName";
            comboBoxLoadClass.ValueMember = "ClassId";
        }
        private void LoadSectionList(List<ClassSectionViewModel> list)
        {
            comboBoxLoadSection.DataSource = list;
            comboBoxLoadSection.DisplayMember = "SectionName";
            comboBoxLoadSection.ValueMember = "ClassSectionId";
        }
        private void comboBoxLoadClass_SelectedIndexChanged(object sender, EventArgs e)
        {

            var data = (ClassViewModel)comboBoxLoadClass.SelectedItem;
            LoadSectionList(_settingService.GetActiveClassSectionList(data.ClassId));
        }

        private void LoadDataStudent(List<StudentListViewModel> list)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = list;
        }

        private void LoadStudentStatusComboBox()
        {
            statusList = _commonService.GetBaseDataByCatagory(EnumBaseData.StudentStatus.ToString());
            comboBoxStatus.DataSource = statusList;
            comboBoxStatus.DisplayMember = "Value";
            comboBoxStatus.ValueMember = "Id";
        }
        private void GetBloodGroupComboBox()
        {
            var bloodGroupList = _commonService.GetBaseDataByCatagory(EnumBaseData.BloodGroup.ToString());
            bloodGroupList.Insert(0, new BaseData { Value = "--Select--", Id = -1 });
            comboBoxBloodGroup.DataSource = bloodGroupList;
            comboBoxBloodGroup.DisplayMember = "Value";
            comboBoxBloodGroup.ValueMember = "Id";
        }

        private void LoadClassesComboBox()
        {
            List<ClassViewModel> classList = _settingService.GetActiveClassList();
            classList.Insert(0, new ClassViewModel { ClassId = -1, ClassName = "--Select--" });
            comboBoxClass.DataSource = classList;
            comboBoxClass.DisplayMember = "ClassName";
            comboBoxClass.ValueMember = "ClassId";
        }
        private void LoadSectionsComboBox()
        {
            var sectionList = _settingService.GetClassSectionList((int)comboBoxClass.SelectedValue);
            sectionList.Insert(0, new ClassSectionViewModel { ClassSectionId = -1, SectionName = "--Select--" });
            comboBoxSection.DataSource = sectionList;
            comboBoxSection.DisplayMember = "SectionName";
            comboBoxSection.ValueMember = "ClassSectionId";
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxClass.SelectedIndex == 0)
            {
                comboBoxSection.Enabled = false;
                return;
            }
            else
            {
                comboBoxSection.Enabled = true;
            }
            LoadSectionsComboBox();
            textBoxRollNumber.Clear();

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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (EmptyCheck())
            {
                MessageBox.Show("All fields should be filled properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DoValidation())
            {
                var student = new StudentViewModel
                {
                    Name = textBoxStudentName.Text,
                    FatherName = textBoxFatherName.Text,
                    MotherName = textBoxMotherName.Text,
                    FatherProfession = textBoxFatherProfession.Text,
                    MotherProfession = textBoxMotherProfession.Text,
                    Email = textBoxEmail.Text,
                    Religion = textBoxReligion.Text,
                    Phone = textBoxPhone.Text,
                    DateOfBirth = DateTime.Parse(dateTimePickerBirthDate.Text),
                    GenderId = GetSelectedGenderId(),
                    IsActive = checkBoxIsActive.Checked,
                    BloodGroupId = (int)comboBoxBloodGroup.SelectedValue == -1 ? (int?)null : (int)comboBoxBloodGroup.SelectedValue,
                    Address = richTextBoxAddress.Text,
                    ClassId = (int)comboBoxClass.SelectedValue,
                    SectionId = (int)comboBoxSection.SelectedValue,
                    RollNumber = int.Parse(textBoxRollNumber.Text),
                    StatusId = (int)comboBoxStatus.SelectedValue
                };
                if (_studentService.AddNewStudent(student))
                {
                    gridViewSelectedId = student.Id.ToString();
                    comboBoxLoadClass.SelectedValue = student.ClassId;
                    comboBoxLoadSection.SelectedValue = student.SectionId;
                    buttonLoad.PerformClick();
                    //LoadDataStudent(_studentService.GetStudentListByClassSection((int)comboBoxLoadSection.SelectedValue));
                    //dataGridView1.Refresh();
                    MessageBox.Show("Data Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private bool EmptyCheck()
        {
            int emptyCount = 0;

            if (textBoxStudentName.Text.Length <= 0)
            {
                ProcessInvalid(labelName);
                emptyCount++;
            }
            else
                ProcessValid(labelName);

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

            if (comboBoxClass.SelectedIndex <= 0)
            {
                ProcessInvalid(labelClass);
                emptyCount++;
            }
            else ProcessValid(labelClass);

            if (comboBoxSection.SelectedIndex <= 0)
            {
                ProcessInvalid(labelSection);
                emptyCount++;
            }
            else ProcessValid(labelSection);

            if (comboBoxStatus.SelectedIndex < 0)
            {
                ProcessInvalid(labelStatus);
                emptyCount++;
            }
            else ProcessValid(labelStatus);

            if (textBoxFatherName.Text.Length <= 0)
            {
                ProcessInvalid(labelFather);
                emptyCount++;
            }
            else ProcessValid(labelFather);

            if (textBoxMotherName.Text.Length <= 0)
            {
                ProcessInvalid(labelMother);
                emptyCount++;
            }
            else ProcessValid(labelMother);

            if (textBoxFatherProfession.Text.Length <= 0)
            {
                ProcessInvalid(labelFatherProfession);
                emptyCount++;
            }
            else ProcessValid(labelFatherProfession);

            if (textBoxMotherProfession.Text.Length <= 0)
            {
                ProcessInvalid(labelMotherProfession);
                emptyCount++;
            }
            else ProcessValid(labelMotherProfession);

            if (emptyCount > 0)
                return true;

            return false;
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
            textBoxStudentName.Validating += textBoxStudentName_Validating;
            textBoxEmail.Validating += TextBoxEmail_Validating;
            radioButtonFemale.Validating += RadioButtonGender_Validating;
            radioButtonMale.Validating += RadioButtonGender_Validating;
            radioButtonOther.Validating += RadioButtonGender_Validating;

            textBoxPhone.Validating += TextBoxPhone_Validating;

        }
        private void DetachValidation()
        {
            textBoxStudentName.Validating -= textBoxStudentName_Validating;
            textBoxEmail.Validating -= TextBoxEmail_Validating;
            radioButtonFemale.Validating -= RadioButtonGender_Validating;
            radioButtonMale.Validating -= RadioButtonGender_Validating;
            radioButtonOther.Validating -= RadioButtonGender_Validating;

            textBoxPhone.Validating -= TextBoxPhone_Validating;
        }

        private void TextBoxPhone_Validating(object sender, CancelEventArgs e)
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

        private void RadioButtonGender_Validating(object sender, CancelEventArgs e)
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

        private void TextBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            bool isValid = true;
            string regularExpression = _commonService.EmailRegex;
            if (_commonService.CheckEmailExists(textBoxEmail.Text))
            {
                isValid = false;
                ErrorMessage = "Email: already exists";
            }
            else if (string.IsNullOrEmpty(textBoxEmail.Text) || Regex.IsMatch(textBoxEmail.Text, regularExpression))
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

        private void textBoxStudentName_Validating(object sender, CancelEventArgs e)
        {
            string regularExpression = _commonService.NameRegex;
            if (Regex.IsMatch(textBoxStudentName.Text, regularExpression))
            {
                ProcessValid(labelName);
            }
            else
            {
                ProcessInvalid(labelName);
                if (textBoxStudentName.Text != string.Empty)
                {
                    ErrorMessage = "Name: Enter Valid Name.\n";
                    ErrorList.Add(ErrorMessage);
                    ErrorMessage = string.Empty;
                }
                e.Cancel = true;
            }
        }
        private void buttonUpdateStudent_Click(object sender, EventArgs e)
        {
            isUpdate = true;
            if (EmptyCheck())
            {
                MessageBox.Show("All fields should be filled properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DoValidation())
            {
                var data = (StudentListViewModel)dataGridView1.SelectedRows[0].DataBoundItem;
                var student = new StudentViewModel
                {
                    Id = data.Id,
                    Name = textBoxStudentName.Text,
                    FatherName = textBoxFatherName.Text,
                    MotherName = textBoxMotherName.Text,
                    FatherProfession = textBoxFatherProfession.Text,
                    MotherProfession = textBoxMotherProfession.Text,
                    DateOfBirth = DateTime.Parse(dateTimePickerBirthDate.Text),
                    GenderId = GetSelectedGenderId(),
                    Religion = textBoxReligion.Text,
                    Phone = textBoxPhone.Text,
                    
                    Address = richTextBoxAddress.Text,
                    BloodGroupId = (int)comboBoxBloodGroup.SelectedValue == -1 ? (int?)null : (int)comboBoxBloodGroup.SelectedValue,
                    ClassId = (int)comboBoxClass.SelectedValue,
                    SectionId = (int)comboBoxSection.SelectedValue,
                    RollNumber = int.Parse(textBoxRollNumber.Text),
                    StatusId = (int)comboBoxStatus.SelectedValue,
                    IsActive = checkBoxIsActive.Checked
                };
                if (_studentService.UpdateStudent(student))
                {
                    gridViewSelectedId = student.Id.ToString();
                    LoadDataStudent(_studentService.GetStudentListByClassSection((int)comboBoxLoadSection.SelectedValue));
                    dataGridView1.Refresh();
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
        

        private void ProcessValid(Control control)
        {
            control.ResetForeColor();
        }

        void ProcessInvalid(Control control)
        {
            control.ForeColor = Color.Red;
        }
        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Search...")
            {
                textBoxSearch.Text = "";
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Equals(""))
            {
                textBoxSearch.Text = "Search...";
            }
        }

        //private void textBoxSearch_TextChanged(object sender, EventArgs e)
        //{
        //    if (textBoxSearch.Text == "Search...") return;
        //    ClearFields();
        //    //LoadDataTeacher(_employeeService.SearchTeacherList(textBoxSearch.Text));
        //}

        private void ClearFields()
        {
            foreach (Control c in Controls)
            {
                if (c is GroupBox)
                {
                    foreach (Control cntrl in c.Controls)
                    {
                        switch (cntrl.GetType().ToString())
                        {
                            case "System.Windows.Forms.ComboBox":
                                if (((ComboBox)cntrl) != comboBoxSection && ((ComboBox)cntrl) != comboBoxLoadSection && ((ComboBox)cntrl) != comboBoxLoadClass)
                                ((ComboBox)cntrl).SelectedIndex = 0;
                                comboBoxSection.DataSource = null;
                                comboBoxSection.Items.Clear();
                                break;
                            case "System.Windows.Forms.TextBox":
                                ((TextBox)cntrl).Clear();
                                break;
                            case "System.Windows.Forms.PictureBox":
                                ((PictureBox)cntrl).Image = Properties.Resources.blank_profile_picture;
                                break;
                            case "System.Windows.Forms.DateTimePicker":
                                if (((DateTimePicker)cntrl) == dateTimePickerBirthDate) dateTimePickerBirthDate.Value = dateTimePickerBirthDate.MaxDate;
                                //else if (((DateTimePicker)cntrl) == dateTimePickerJoinDate) dateTimePickerJoinDate.Value = dateTimePickerJoinDate.MaxDate;
                                break;
                            case "System.Windows.Forms.Label":
                                Label label = ((Label)cntrl);
                                if (!label.Text.Contains("*")) label.ForeColor = SystemColors.ControlText;
                                break;
                            case "System.Windows.Forms.CheckBox":
                                ((CheckBox)cntrl).Checked = true;
                                break;
                        }
                    }
                }
            }
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            radioButtonOther.Checked = false;
            richTextBoxAddress.Text = "";
        }

        private void comboBoxSection_SelectedIndexChanged(object sender, EventArgs e)
        {
           // if (comboBoxSection.Items.Count < 1) return;
            if (comboBoxSection.SelectedIndex < 1) return;
            var roll = _studentService.GenerateRollNumber((int)comboBoxSection.SelectedValue);
            textBoxRollNumber.Text = (++roll).ToString();
        }

        private void LoadStudent(StudentViewModel student)
        {
            textBoxStudentName.Text = student.Name;
            textBoxFatherName.Text = student.FatherName;
            textBoxMotherName.Text = student.MotherName;
            textBoxFatherProfession.Text = student.FatherProfession;
            textBoxMotherProfession.Text = student.MotherProfession;
            textBoxEmail.Text = student.Email;
            textBoxReligion.Text = student.Religion;
            dateTimePickerBirthDate.Value = student.DateOfBirth;
            comboBoxBloodGroup.SelectedValue = student.BloodGroupId == null ? -1 : student.BloodGroupId;
            textBoxPhone.Text = student.Phone;
            richTextBoxAddress.Text = student.Address;
            if(EnumGender.Female.ToString() == genderList.First(x=>x.Id==student.GenderId).Value)
            {
                radioButtonFemale.Checked = true;
            }
            else if (EnumGender.Male.ToString() == genderList.First(x => x.Id == student.GenderId).Value)
            {
                radioButtonMale.Checked = true;
            }
            else
            {
                radioButtonOther.Checked = true;
            }
            checkBoxIsActive.Checked = student.IsActive;
            comboBoxClass.SelectedValue = student.ClassId;
            comboBoxSection.SelectedValue = student.SectionId;
            textBoxRollNumber.Text = Convert.ToString(student.RollNumber);
            comboBoxStatus.SelectedValue = student.StatusId;
            comboBoxStatus.Enabled = true;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
            if (string.IsNullOrEmpty(gridViewSelectedId)) return;
            DataGridViewRow row = dataGridView1.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["Id"].Value.ToString().Equals(gridViewSelectedId)).First();
            dataGridView1.Rows[row.Index].Selected = true;
            gridViewSelectedId = "";
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //textBoxEmail.Enabled = true;
            buttonAdd.Enabled = true;
            buttonAdd.BackColor = SystemColors.ActiveCaption;
            buttonUpdateStudent.Enabled = false;
            buttonUpdateStudent.BackColor = SystemColors.ControlLight;
            comboBoxStatus.Enabled = false;
            dataGridView1.ClearSelection();
            ClearFields();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Search...") return;
            ClearFields();
            LoadDataStudent(_studentService.SearchStudentList(textBoxSearch.Text, (int)comboBoxLoadSection.SelectedValue));
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ClearFields();
            if (dataGridView1.SelectedRows.Count < 1) return;
            var data = (StudentListViewModel)dataGridView1.SelectedRows[0].DataBoundItem;
            StudentViewModel student = _studentService.GetStudentById(data.Id);
            LoadStudent(student);
            //textBoxEmail.Enabled = true;
            buttonAdd.Enabled = false;
            buttonAdd.BackColor = SystemColors.ControlLight;
            buttonUpdateStudent.Enabled = true;
            buttonUpdateStudent.BackColor = SystemColors.ActiveCaption;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {
            dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            LoadDataStudent(_studentService.GetStudentListByClassSection((int)comboBoxLoadSection.SelectedValue));
            textBoxSearch.Text = "Search...";
        }

    }
}
