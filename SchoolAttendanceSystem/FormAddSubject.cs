using Core.Data.DB;
using Core.Data.ViewModel;
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

namespace SchoolAttendanceSystem
{
    public partial class FormAddSubject : Form
    {
        private readonly SubjectViewModel _subjectViewModel = new SubjectViewModel();
        private readonly SettingService _settingService = new SettingService();
        string gridViewSelectedId = "";
        Form form;
        public FormAddSubject()
        {
            InitializeComponent();
            LoadData();

        }
        public FormAddSubject(Form form)
        {
            InitializeComponent();
            this.form = form;
            LoadData();

        }

        private void LoadData()
        {
            dataGridViewSubject.SelectionChanged -= dataGridViewSubject_SelectionChanged;
            LoadDataSubject(_settingService.GetSubjectList());
            buttonUpdate.Enabled = false;
            textBoxSubject.Focus();
        }

        private void LoadDataSubject(List<SubjectViewModel> list)
        {
            dataGridViewSubject.DataSource = null;
            dataGridViewSubject.Rows.Clear();
            dataGridViewSubject.AutoGenerateColumns = false;
            dataGridViewSubject.DataSource = list;
        }

        private static FormAddSubject _instance;
        public static FormAddSubject Instance
        {
            get { return _instance ?? (_instance = new FormAddSubject()); }
        }

        private void FormAddSubject_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instance = null;
        }

        private void FormAddSubject_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
            if(form!=null)
            {
                if (form.GetType() == typeof(FormAddNewTeacher))
                {
                    FormAddNewTeacher formTeacher = (FormAddNewTeacher)form;
                    formTeacher.LoadSubjectList();
                }
                else if (form.GetType() == typeof(FormAddClassSubject))
                {
                    FormAddClassSubject formClassSec = (FormAddClassSubject)form;
                    formClassSec.LoadSubjectList();
                }
            }
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (textBoxSubject.Text == "")
            {
                ProcessInvalid(labelSubject);
                MessageBox.Show("Subject name can't be empty", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CheckSubjectExists(textBoxSubject.Text))
            {
                ProcessInvalid(labelSubject);
                MessageBox.Show("Subject already exists", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var sub = new Subject
                {
                    SubjectName = textBoxSubject.Text,
                    IsActive = checkBoxIsActive.Checked
                };
                if (_settingService.AddSubject(sub))
                {

                    MessageBox.Show("Data Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ProcessValid(labelSubject);
                    gridViewSelectedId = sub.SubjectId.ToString();
                    LoadDataSubject(_settingService.GetSubjectList());
                    dataGridViewSubject.Refresh();
                }
                else
                {
                    MessageBox.Show("error","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private bool CheckSubjectExists(string text)
        {
            DataGridViewRow row = dataGridViewSubject.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => r.Cells["SubjectName"].Value.ToString().ToLower().Equals(text.ToLower()));
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



        private void LoadSubject(SubjectViewModel subject)
        {
            textBoxSubject.Text = subject.SubjectName;
            checkBoxIsActive.Checked = subject.IsActive == "Yes" ? true : false;
        }

        private void ClearFields()
        {
            textBoxSubject.Text = "";
            checkBoxIsActive.Checked = true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var data = (SubjectViewModel)dataGridViewSubject.SelectedRows[0].DataBoundItem;
            if (textBoxSubject.Text == "")
            {
                ProcessInvalid(labelSubject);
                MessageBox.Show("Subject field can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (CheckSubjectExistsForUpdate(textBoxSubject.Text, data.SubjectId))
            {
                ProcessInvalid(labelSubject);
                MessageBox.Show("Subject already exists", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var subject = new Subject
                {
                    SubjectId = data.SubjectId,
                    SubjectName = textBoxSubject.Text,
                    IsActive = checkBoxIsActive.Checked
                };
                if (_settingService.UpdateSubject(subject))
                {
                    gridViewSelectedId = subject.SubjectId.ToString();
                    LoadDataSubject(_settingService.GetSubjectList());
                    dataGridViewSubject.Refresh();
                    ProcessValid(labelSubject);
                    MessageBox.Show("Data Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool CheckSubjectExistsForUpdate(string text, int subjectId)
        {
            bool isExists = false;
            foreach (var row in dataGridViewSubject.Rows.Cast<DataGridViewRow>())
            {
                var sub = (SubjectViewModel)row.DataBoundItem;
                if (sub.SubjectId == subjectId && sub.SubjectName.ToLower() == text.ToLower()) return false;
            }
            if (CheckSubjectExists(text)) return true;
            return isExists;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            buttonUpdate.Enabled = false;
            buttonAdd.Enabled = true;
            dataGridViewSubject.ClearSelection();
            ProcessValid(labelSubject);
            ClearFields();
        }

        private void dataGridViewSubject_SelectionChanged(object sender, EventArgs e)
        {
            ClearFields();
            if (dataGridViewSubject.SelectedRows.Count < 1) return;
            var data = (SubjectViewModel)dataGridViewSubject.SelectedRows[0].DataBoundItem;
            LoadSubject(data);
            buttonAdd.Enabled = false;
            buttonUpdate.Enabled = true;


        }

        private void dataGridViewSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
        }

        private void dataGridViewSubject_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewSubject.ClearSelection();
            if (string.IsNullOrEmpty(gridViewSelectedId)) return;
            DataGridViewRow row = dataGridViewSubject.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["Id"].Value.ToString().Equals(gridViewSelectedId)).First();
            dataGridViewSubject.Rows[row.Index].Selected = true;
            gridViewSelectedId = "";
        }

        private void dataGridViewSubject_Enter(object sender, EventArgs e)
        {
            dataGridViewSubject.SelectionChanged += dataGridViewSubject_SelectionChanged;
        }
    }
}
