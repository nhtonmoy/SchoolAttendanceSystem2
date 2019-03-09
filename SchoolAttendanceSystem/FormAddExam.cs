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
    public partial class FormAddExam : Form
    {
        private readonly ExamViewModel _subjectViewModel = new ExamViewModel();
        private readonly SettingService _settingService = new SettingService();
        string gridViewSelectedId = "";
        Form form;
        public FormAddExam()
        {
            InitializeComponent();
            LoadData();
            
        }
        //public FormAddExam(Form form)
        //{
        //    InitializeComponent();
        //    this.form = form;
        //    LoadData();

        //}

        private void LoadData()
        {
            dataGridViewExam.SelectionChanged -= dataGridViewExam_SelectionChanged;
            LoadDataExam(_settingService.GetExamList());
            buttonUpdate.Enabled = false;
            buttonUpdate.BackColor = SystemColors.ControlLight;
            textBoxExam.Focus();
        }

        private void LoadDataExam(List<ExamViewModel> list)
        {
            dataGridViewExam.DataSource = null;
            dataGridViewExam.Rows.Clear();
            dataGridViewExam.AutoGenerateColumns = false;
            dataGridViewExam.DataSource = list;
        }

        private static FormAddExam _instance;
        public static FormAddExam Instance
        {
            get { return _instance ?? (_instance = new FormAddExam()); }
        }

        private void FormAddExam_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instance = null;
        }

        private void FormAddExam_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;            
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (textBoxExam.Text == "")
            {
                ProcessInvalid(labelExam);
                MessageBox.Show("Exam name can't be empty", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxPercentage.Text == "")
            {
                ProcessInvalid(labelFinalPercentage);
                MessageBox.Show("Exam percentage can't be empty", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CheckExamExists(textBoxExam.Text))
            {
                ProcessInvalid(labelExam);
                MessageBox.Show("Exam already exists", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var exm = new Exam
                {
                    ExamName = textBoxExam.Text,
                    FinalPercentage = Convert.ToDouble(textBoxPercentage.Text),
                    IsActive = checkBoxIsActive.Checked
                };
                if (_settingService.AddExam(exm))
                {

                    MessageBox.Show("Data Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ProcessValid(labelExam);
                    ProcessValid(labelFinalPercentage);
                    gridViewSelectedId = exm.ExamId.ToString();
                    LoadDataExam(_settingService.GetExamList());
                    dataGridViewExam.Refresh();
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
        }

        private bool CheckExamExists(string text)
        {
            DataGridViewRow row = dataGridViewExam.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => r.Cells["ExamName"].Value.ToString().ToLower().Equals(text.ToLower()));
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

        private void LoadExam(ExamViewModel Exam)
        {
            textBoxExam.Text = Exam.ExamName;
            textBoxPercentage.Text = Convert.ToString(Exam.FinalPercentage);
            checkBoxIsActive.Checked = Exam.IsActive == "Yes" ? true : false;
        }

        private void ClearFields()
        {
            textBoxExam.Text = "";
            textBoxPercentage.Text = "";
            checkBoxIsActive.Checked = true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var data = (ExamViewModel)dataGridViewExam.SelectedRows[0].DataBoundItem;
            if (textBoxExam.Text == "")
            {
                ProcessInvalid(labelExam);
                MessageBox.Show("Exam field can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textBoxPercentage.Text == "")
            {
                ProcessInvalid(labelFinalPercentage);
                MessageBox.Show("Exam percentage field can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (CheckExamExistsForUpdate(textBoxExam.Text, data.ExamId))
            {
                ProcessInvalid(labelExam);
                MessageBox.Show("Exam already exists", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var Exam = new Exam
                {
                    ExamId = data.ExamId,
                    ExamName = textBoxExam.Text,
                    FinalPercentage = Convert.ToDouble(textBoxPercentage.Text),
                    IsActive = checkBoxIsActive.Checked
                };
                if (_settingService.UpdateExam(Exam))
                {
                    gridViewSelectedId = Exam.ExamId.ToString();
                    LoadDataExam(_settingService.GetExamList());
                    dataGridViewExam.Refresh();
                    ProcessValid(labelExam);
                    MessageBox.Show("Data Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool CheckExamExistsForUpdate(string text, int examId)
        {
            bool isExists = false;
            foreach (var row in dataGridViewExam.Rows.Cast<DataGridViewRow>())
            {
                var exm = (ExamViewModel)row.DataBoundItem;
                if (exm.ExamId == examId && exm.ExamName.ToLower() == text.ToLower()) return false;
            }
            if (CheckExamExists(text)) return true;
            return isExists;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            buttonUpdate.Enabled = false;
            buttonUpdate.BackColor = SystemColors.ControlLight;
            buttonAdd.Enabled = true;
            buttonAdd.BackColor = SystemColors.ActiveCaption;
            dataGridViewExam.ClearSelection();
            ProcessValid(labelExam);
            ProcessValid(labelFinalPercentage);
            ClearFields();
        }

        private void dataGridViewExam_SelectionChanged(object sender, EventArgs e)
        {
            ClearFields();
            if (dataGridViewExam.SelectedRows.Count < 1) return;
            var data = (ExamViewModel)dataGridViewExam.SelectedRows[0].DataBoundItem;
            LoadExam(data);
            buttonAdd.Enabled = false;
            buttonAdd.BackColor = SystemColors.ControlLight;
            buttonUpdate.Enabled = true;
            buttonUpdate.BackColor = SystemColors.ActiveCaption;
        }

        private void dataGridViewExam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
        }

        private void dataGridViewExam_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewExam.ClearSelection();
            if (string.IsNullOrEmpty(gridViewSelectedId)) return;
            DataGridViewRow row = dataGridViewExam.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["Id"].Value.ToString().Equals(gridViewSelectedId)).First();
            dataGridViewExam.Rows[row.Index].Selected = true;
            gridViewSelectedId = "";
        }

        private void dataGridViewExam_Enter(object sender, EventArgs e)
        {
            dataGridViewExam.SelectionChanged += dataGridViewExam_SelectionChanged;
        }


    }
}
