using Core.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Data.ViewModel;
using Core.Data.DB;

namespace SchoolAttendanceSystem
{
    public partial class FormAssignClassSection : Form
    {
        private readonly SettingService _settingService = new SettingService();
        private readonly EmployeeService _employeeService = new EmployeeService();
        string gridViewSelectedId = "";
        int selectClassId;
        public FormAssignClassSection()
        {
            
            InitializeComponent();
            dataGridViewSection.SelectionChanged -= dataGridViewSection_SelectionChanged;
            LoadData();
        }

        private void LoadData()
        {
            buttonUpdate.Enabled = false;
            LoadClassList(_settingService.GetClassList());
            LoadTeacherComboBox(_employeeService.GetTeacherListForClassSection());
        }

        private void LoadTeacherComboBox(List<ClassSectionViewModel> list)
        {
            list.Insert(0, new ClassSectionViewModel { ClassTeacherId = -1, TeacherName = "--Select--" });
            comboBoxTeacher.DataSource = list;
            comboBoxTeacher.DisplayMember = "TeacherName";
            comboBoxTeacher.ValueMember = "ClassTeacherId";
        }

        private void LoadClassList(List<ClassViewModel> list)
        {
            dataGridViewClassList.AutoGenerateColumns = false;
            dataGridViewClassList.DataSource = list;
        }

        private static FormAssignClassSection _instance;
        public static FormAssignClassSection Instance
        {
            get { return _instance ?? (_instance = new FormAssignClassSection()); }
        }
        
        private void FormAssignClassSection_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void ClearFields()
        {
            textBoxSection.Text = "";
            labelClass.Text = "";
            checkBoxIsActive.Checked = true;
        }

        private void dataGridViewClassList_SelectionChanged(object sender, EventArgs e)
        {
            ClearFields();
            if (dataGridViewClassList.SelectedRows.Count < 1) return;
            var data = (ClassViewModel)dataGridViewClassList.SelectedRows[0].DataBoundItem;
            LoadSectionInfo(data);
        }

        private void LoadSectionInfo(ClassViewModel data)
        {
            selectClassId = data.ClassId;
            labelClass.Text = data.ClassName;
            List<ClassSectionViewModel> list = _settingService.GetClassSectionList(data.ClassId);
            LoadSectionList(list);
        }

        private void LoadSectionList(List<ClassSectionViewModel> list)
        {
            dataGridViewSection.DataSource = null;
            dataGridViewSection.Rows.Clear();
            dataGridViewSection.AutoGenerateColumns = false;
            dataGridViewSection.DataSource = list;
        }

        private void dataGridViewSection_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewSection.ClearSelection();
            if (string.IsNullOrEmpty(gridViewSelectedId)) return;
            DataGridViewRow row = dataGridViewSection.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["CSId"].Value.ToString().Equals(gridViewSelectedId)).First();
            dataGridViewSection.Rows[row.Index].Selected = true;
            gridViewSelectedId = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxSection.Text == "")
            {
                ProcessInvalid(labelSection);
                MessageBox.Show("Section name can't be empty", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxTeacher.Text == "--Select--")
            {
                ProcessInvalid(labelTeacher);
                MessageBox.Show("Must Select a Class Teacher", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(CheckSectionExists(textBoxSection.Text))
            {
                ProcessInvalid(labelSection);
                MessageBox.Show("Section already exists", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var classSec = new ClassSection
                {
                    ClassId = selectClassId,
                    SectionName = textBoxSection.Text,
                    IsActive = checkBoxIsActive.Checked,
                    ClassTeacherId = (int)comboBoxTeacher.SelectedValue
                };
                if (_settingService.AddClassSection(classSec))
                {

                    MessageBox.Show("Data Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ProcessValid(labelSection);
                    ProcessValid(labelTeacher);
                    gridViewSelectedId = classSec.ClassSectionId.ToString();
                    LoadDataSection(_settingService.GetClassSectionList(classSec.ClassId));
                    dataGridViewSection.Refresh();
                }
                else
                {
                    MessageBox.Show("error");
                }
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var data = (ClassSectionViewModel)dataGridViewSection.SelectedRows[0].DataBoundItem;
            if (textBoxSection.Text == "")
            {
                ProcessInvalid(labelSection);
                MessageBox.Show("Section field can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(comboBoxTeacher.Text=="--Select--")
            {
                ProcessInvalid(labelTeacher);
                MessageBox.Show("Must Select a Class Teacher", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CheckSectionExistsForUpdate(textBoxSection.Text, data.ClassSectionId))
            {
                ProcessInvalid(labelSection);
                MessageBox.Show("Section already exists", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var section = new ClassSection
                {
                    ClassId = selectClassId,
                    ClassSectionId = data.ClassSectionId,
                    SectionName = textBoxSection.Text,
                    IsActive = checkBoxIsActive.Checked,
                    ClassTeacherId= (int)comboBoxTeacher.SelectedValue
                };
                if (_settingService.UpdateSection(section))
                {
                    gridViewSelectedId = section.ClassSectionId.ToString();
                    LoadDataSection(_settingService.GetClassSectionList(selectClassId));
                    dataGridViewSection.Refresh();
                    ProcessValid(labelSection);
                    ProcessValid(labelTeacher);
                    MessageBox.Show("Data Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void LoadDataSection(List<ClassSectionViewModel> list)
        {
            dataGridViewSection.DataSource = null;
            dataGridViewSection.Rows.Clear();
            dataGridViewSection.AutoGenerateColumns = false;
            dataGridViewSection.DataSource = list;
        }

        private bool CheckSectionExists(string text)
        {
            DataGridViewRow row = dataGridViewSection.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => r.Cells["SectionName"].Value.ToString().ToLower().Equals(text.ToLower()));
            if (row == null) return false;
            return true;
        }

        void ProcessInvalid(Control control)
        {
            control.ForeColor = Color.Red;
        }

        void ProcessValid(Control control)
        {
            control.ResetForeColor();
        }

        private void dataGridViewSection_SelectionChanged(object sender, EventArgs e)
        {
            ClearSectionFields();
            if (dataGridViewSection.SelectedRows.Count < 1) return;
            var data = (ClassSectionViewModel)dataGridViewSection.SelectedRows[0].DataBoundItem;
            LoadSection(data);
            buttonAdd.Enabled = false;
            buttonUpdate.Enabled = true;
        }

        private void ClearSectionFields()
        {
            textBoxSection.Text = "";
            checkBoxIsActive.Checked = true;
        }

        private void LoadSection(ClassSectionViewModel section)
        {
            textBoxSection.Text = section.SectionName;
            checkBoxIsActive.Checked = section.IsActive == "Yes" ? true : false;
            comboBoxTeacher.Text = section.TeacherName;
        }

        private void dataGridViewSection_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
        }

        private void dataGridViewSection_Enter(object sender, EventArgs e)
        {
            dataGridViewSection.SelectionChanged += dataGridViewSection_SelectionChanged;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            buttonUpdate.Enabled = false;
            buttonAdd.Enabled = true;
            dataGridViewSection.ClearSelection();
            comboBoxTeacher.SelectedIndex = 0;
            ProcessValid(labelSection);
            ClearSectionFields();
        }

        

        private bool CheckSectionExistsForUpdate(string text, int classSectionId)
        {
            bool isExists = false;
            foreach (var row in dataGridViewSection.Rows.Cast<DataGridViewRow>())
            {
                var clSec = (ClassSectionViewModel)row.DataBoundItem;
                if (clSec.ClassSectionId == classSectionId && clSec.SectionName.ToLower() == text.ToLower()) return false;
            }
            if (CheckSectionExists(text)) return true;
            return isExists;
        }
    }
}
