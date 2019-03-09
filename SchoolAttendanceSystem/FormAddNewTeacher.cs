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
    public partial class FormAddNewTeacher : Form
    {
        private readonly EmployeeService _employeeService = new EmployeeService();
        private List<BaseData> genderList;
        private readonly CommonService _commonService = new CommonService();
        private readonly SettingService _settingService = new SettingService();
        
        string gridViewSelectedId = "";

        private String ErrorMessage = "";
        private List<String> ErrorList = new List<String>();



        private static FormAddNewTeacher _instance;
        public static FormAddNewTeacher Instance
        {
            get { return _instance ?? (_instance = new FormAddNewTeacher()); }
        }
        private void FormAddEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instance = null;
        }
        private void FormAddNewTeacher_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        public FormAddNewTeacher()
        {
            InitializeComponent();
            dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged;
            LoadData();
            
        }

        private void LoadData()
        {
            textBoxSearch.Text = "Search...";
            var bloodGroupList = _commonService.GetBaseDataByCatagory(EnumBaseData.BloodGroup.ToString());
            bloodGroupList.Insert(0, new BaseData { Value = "--Select--", Id = -1 });
            comboBoxBloodGroup.DataSource = bloodGroupList;
            comboBoxBloodGroup.DisplayMember = "Value";
            comboBoxBloodGroup.ValueMember = "Id";

            buttonUpdate.Enabled = false;
            buttonUpdate.BackColor = SystemColors.ControlLight;

            genderList = _commonService.GetBaseDataByCatagory(EnumBaseData.Gender.ToString());

            dateTimePickerBirthDate.MaxDate = DateTime.Now.AddYears(-18);
            dateTimePickerBirthDate.MinDate = DateTime.Now.AddYears(-70);
            dateTimePickerJoinDate.MaxDate = DateTime.Now;
            dateTimePickerJoinDate.MinDate = dateTimePickerBirthDate.MinDate.AddYears(22);

            var designationList = _employeeService.GetDesignations();
            designationList.Insert(0, new EmployeeViewModel { DesignationId = -1, DesignationName = "--Select--" });
            comboBoxDesignation.DataSource = designationList;
            comboBoxDesignation.ValueMember = "DesignationId";
            comboBoxDesignation.DisplayMember = "DesignationName";

            LoadSubjectList();

            LoadDataTeacher(_employeeService.GetTeacherList());
        }

        public void LoadSubjectList()
        {
            listBoxExpertise.DataSource = _settingService.GetActiveSubjectList();
            listBoxExpertise.DisplayMember = "SubjectName";
            //listBoxExpertise.ValueMember = "Id";
            listBoxExpertise.ClearSelected();
            if(dataGridView1.SelectedRows.Count>0)
            {
                var id = ((EmployeeListViewModel)dataGridView1.SelectedRows[0].DataBoundItem).Id;

                List<SubjectViewModel> selectedList = _settingService.GetActiveSubjectListByTeacherId(id);
                for (int index = 0; index < listBoxExpertise.Items.Count; index++)
                {
                    var item = (SubjectViewModel)listBoxExpertise.Items[index];
                    var data = selectedList.FirstOrDefault(x => x.SubjectId == item.SubjectId);
                    if (data != null) listBoxExpertise.SelectedIndex = index;

                }
            }

            //var selectedList = services.GetActiveStudentList();

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
                List<Subject> subjects = new List<Subject>();
                foreach (var item in listBoxExpertise.SelectedItems)
                {
                    var data = (SubjectViewModel)item;
                    Subject sub = new Subject { SubjectId = data.SubjectId, SubjectName = data.SubjectName, IsActive = data.IsActive == "Yes" ? true : false };
                    subjects.Add(sub);
                }
                var teacher = new EmployeeViewModel
                {
                    Name = textBoxTeacherName.Text,
                    Email = textBoxEmail.Text,
                    DateOfBirth = DateTime.Parse(dateTimePickerBirthDate.Text),
                    GenderId = GetSelectedGenderId(),
                    Religion = textBoxReligion.Text,
                    Phone = textBoxPhone.Text,
                    JoinDate = DateTime.Parse(dateTimePickerJoinDate.Text),
                    Address = richTextBoxAddress.Text,
                    BloodGroupId = (int)comboBoxBloodGroup.SelectedValue == -1 ? (int?)null : (int)comboBoxBloodGroup.SelectedValue,
                    IsActive = checkBoxIsActive.Checked,
                    DesignationId = (int)comboBoxDesignation.SelectedValue,
                    ExpertiseList = subjects
                };
                Console.WriteLine(comboBoxDesignation.SelectedValue);

                if (_employeeService.AddNewTeacher(teacher))
                {

                    gridViewSelectedId = teacher.Id.ToString();
                    LoadDataTeacher(_employeeService.GetTeacherList());
                    dataGridView1.Refresh();
                    //ClearFields();
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            List<Subject> subjects = new List<Subject>();
            foreach (var item in listBoxExpertise.SelectedItems)
            {
                var data = (SubjectViewModel)item;
                Subject sub = new Subject { SubjectId = data.SubjectId, SubjectName = data.SubjectName, IsActive = data.IsActive == "Yes" ? true : false };
                subjects.Add(sub);
            }
            if (EmptyCheck())
            {
                MessageBox.Show("All fields should be filled properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DoValidation())
            {
                var data = (EmployeeListViewModel)dataGridView1.SelectedRows[0].DataBoundItem;
                var teacher = new EmployeeViewModel
                {
                    Id = data.Id,
                    Name = textBoxTeacherName.Text,
                    Email = textBoxEmail.Text,
                    DateOfBirth = DateTime.Parse(dateTimePickerBirthDate.Text),
                    GenderId = GetSelectedGenderId(),
                    Religion = textBoxReligion.Text,
                    Phone = textBoxPhone.Text,
                    JoinDate = DateTime.Parse(dateTimePickerJoinDate.Text),
                    Address = richTextBoxAddress.Text,
                    BloodGroupId = (int)comboBoxBloodGroup.SelectedValue == -1 ? (int?)null : (int)comboBoxBloodGroup.SelectedValue,
                    IsActive = checkBoxIsActive.Checked,
                    DesignationId = (int)comboBoxDesignation.SelectedValue,
                    ExpertiseList = subjects
                };
                if (_employeeService.UpdateTeacher(teacher))
                {

                    gridViewSelectedId = teacher.Id.ToString();
                    LoadDataTeacher(_employeeService.GetTeacherList());
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
        


        private void LoadTeacher(EmployeeViewModel teacher)
        {
            List<Subject> subjects = new List<Subject>();
            foreach (var item in listBoxExpertise.SelectedItems)
            {
                var data = (SubjectViewModel)item;
                Subject sub = new Subject { SubjectId = data.SubjectId, SubjectName = data.SubjectName, IsActive = data.IsActive == "Yes" ? true : false };
                subjects.Add(sub);
            }
            textBoxTeacherName.Text = teacher.Name;
            textBoxEmail.Text = teacher.Email;
            textBoxReligion.Text = teacher.Religion;
            dateTimePickerBirthDate.Value = teacher.DateOfBirth;
            comboBoxBloodGroup.SelectedValue = teacher.BloodGroupId == null ? -1 : teacher.BloodGroupId;
            textBoxPhone.Text = teacher.Phone;
            richTextBoxAddress.Text = teacher.Address;
            dateTimePickerJoinDate.Value = teacher.JoinDate;
            if (EnumGender.Female.ToString() == genderList.First(x => x.Id == teacher.GenderId).Value)
            {
                radioButtonFemale.Checked = true;
            }
            else if (EnumGender.Male.ToString() == genderList.First(x => x.Id == teacher.GenderId).Value)
            {
                radioButtonMale.Checked = true;
            }
            else
            {
                radioButtonOther.Checked = true;
            }
            checkBoxIsActive.Checked = teacher.IsActive;
            comboBoxDesignation.SelectedIndex = teacher.DesignationId;
            LoadSubjectList();

            //listBoxExpertise.ValueMember = "Id";
            //listBoxExpertise.ClearSelected();
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
            textBoxTeacherName.Validating += TextBoxTeacher_Validating;
            textBoxEmail.Validating += TextBoxEmail_Validating;
            radioButtonFemale.Validating += RadioButtonGender_Validating;
            radioButtonMale.Validating += RadioButtonGender_Validating;
            radioButtonOther.Validating += RadioButtonGender_Validating;

            textBoxPhone.Validating += TextBoxPhone_Validating;
        }
        private void DetachValidation()
        {
            textBoxTeacherName.Validating -= TextBoxTeacher_Validating;
            textBoxEmail.Validating -= TextBoxEmail_Validating;
            radioButtonFemale.Validating -= RadioButtonGender_Validating;
            radioButtonMale.Validating -= RadioButtonGender_Validating;
            radioButtonOther.Validating -= RadioButtonGender_Validating;

            textBoxPhone.Validating -= TextBoxPhone_Validating;
        }

        private void LoadDataTeacher(List<EmployeeListViewModel> list)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = list;
        }

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
            listBoxExpertise.ClearSelected();
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            radioButtonOther.Checked = false;
            richTextBoxAddress.Text = "";
        }
        private bool EmptyCheck()
        {
            int emptyCount = 0;

            if (textBoxTeacherName.Text.Length <= 0)
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

            if (comboBoxDesignation.SelectedIndex <= 0)
            {
                ProcessInvalid(labelDesignation);
                emptyCount++;
            }
            else ProcessValid(labelDesignation);

            if (emptyCount > 0)
                return true;

            return false;
        }



        void TextBoxTeacher_Validating(object sender, CancelEventArgs e)
        {
            string regularExpression = _commonService.NameRegex;
            if (Regex.IsMatch(textBoxTeacherName.Text, regularExpression))
            {
                ProcessValid(labelName);
            }
            else
            {
                ProcessInvalid(labelName);
                if (textBoxTeacherName.Text != string.Empty)
                {
                    ErrorMessage = "Name: Enter Valid Name.\n";
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
        

        private void ProcessValid(Control control)
        {
            control.ResetForeColor();
        }

        void ProcessInvalid(Control control)
        {
            control.ForeColor = Color.Red;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ClearFields();
            if (dataGridView1.SelectedRows.Count < 1) return;
            var data = (EmployeeListViewModel)dataGridView1.SelectedRows[0].DataBoundItem;
            EmployeeViewModel teacher = _employeeService.GetTeacherById(data.Id);
            
            LoadTeacher(teacher);
            
            
            buttonAdd.Enabled = false;
            buttonAdd.BackColor = SystemColors.ControlLight;
            buttonUpdate.Enabled = true;
            buttonUpdate.BackColor = SystemColors.ActiveCaption;
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
            
            buttonAdd.Enabled = true;
            buttonAdd.BackColor = SystemColors.ActiveCaption;
            buttonUpdate.Enabled = false;
            buttonUpdate.BackColor = SystemColors.ControlLight;
            dataGridView1.ClearSelection();
            ClearFields();
            
        }

        private void buttonAddSubject_Click(object sender, EventArgs e)
        {
            new FormAddSubject(this).ShowDialog(); 
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

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Search...") return;
            ClearFields();
            LoadDataTeacher(_employeeService.SearchTeacherList(textBoxSearch.Text));
        }
    }
}
