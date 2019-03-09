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
using Core.Service;

namespace SchoolAttendanceSystem
{
    public partial class FormAddMarks : Form
    {
        private readonly SettingService _settingService = new SettingService();
        private readonly StudentService _studentService = new StudentService();
        string gridViewSelectedId = "";
        public FormAddMarks()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var classList = _settingService.GetActiveClassList();
            classList.Insert(0, new ClassViewModel { ClassId = -1, ClassName = "--Select--" });
            comboBoxClass.DataSource = classList;
            comboBoxClass.DisplayMember = "ClassName";
            comboBoxClass.ValueMember = "ClassId";

            var examList = _settingService.GetActiveExamList();
            examList.Insert(0, new ExamViewModel() { ExamId = -1, ExamName = "--Select--" });
            comboBoxExam.DataSource = examList;
            comboBoxExam.DisplayMember = "ExamName";
            comboBoxExam.ValueMember = "ExamId";
        }

        private static FormAddMarks _instance;
        public static FormAddMarks Instance
        {
            get { return _instance ?? (_instance = new FormAddMarks()); }
        }

        private void FormAddMarks_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if ((int)comboBoxClass.SelectedValue == -1)
            {
                ProcessInvalid(labelClass);
                MessageBox.Show("Select a class", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((int)comboBoxSection.SelectedValue == -1)
            {
                ProcessInvalid(labelSection);
                ProcessValid(labelClass);
                MessageBox.Show("Select a section", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ProcessValid(labelSection);
                var data = (ClassViewModel) comboBoxClass.SelectedItem;
                labelClassNameLoad.Text = data.ClassName;
                List<StudentViewModel> studentList;
                if ((int)comboBoxSection.SelectedValue == -1)
                {
                    studentList = _studentService.GetActiveStudentForMarksByClass((int)comboBoxClass.SelectedValue);
                }
                else
                {
                    studentList = _studentService.GetActiveStudentForMarksByClassSection((int)comboBoxSection.SelectedValue);
                }

                LoadStudentGridview(studentList);

            }
        }

        private void LoadStudentGridview(List<StudentViewModel> studentList)
        {
            dataGridViewStudent.DataSource = null;
            dataGridViewStudent.ClearSelection();
            dataGridViewStudent.AutoGenerateColumns = false;
            dataGridViewStudent.DataSource = studentList;

        }
        
        void ProcessInvalid(Control control)
        {
            control.ForeColor = Color.Red;
        }

        void ProcessValid(Control control)
        {
            control.ResetForeColor();
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxClass.SelectedIndex == 0)
            {
                comboBoxSection.Enabled = false;
                return;
            }
            var data = (ClassViewModel)comboBoxClass.SelectedItem;

            comboBoxSection.Enabled = true;
            LoadComboBoxSection(data.ClassId);
        }

        private void LoadComboBoxSection(int classId)
        {
            var classSecList = _settingService.GetClassSectionList(classId);
            classSecList.Insert(0, new ClassSectionViewModel() { ClassSectionId = -1, SectionName = "--Select--" });
            comboBoxSection.DataSource = classSecList;
            comboBoxSection.DisplayMember = "SectionName";
            comboBoxSection.ValueMember = "ClassSectionId";
        }

        private void dataGridViewStudent_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewStudent.ClearSelection();
            ClearFields();

        }

        private void dataGridViewStudent_SelectionChanged(object sender, EventArgs e)
        {
            ClearFields();
            if (dataGridViewStudent.SelectedRows.Count < 1) return;
            var data = (StudentViewModel)dataGridViewStudent.SelectedRows[0].DataBoundItem;
            labelName.Text = data.Name;
            labelRoll.Text = data.RollNumber.ToString();
            labelIdNumber.Text = data.IdNumber;
            labelClassname.Text = labelClassNameLoad.Text;
            labelSectionName.Text = data.SectionName;
            comboBoxExam.Enabled = true;
            comboBoxExam.SelectedIndex = 0;
        }


        private void dataGridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

        }

        private void dataGridViewStudent_Enter(object sender, EventArgs e)
        {
            dataGridViewStudent.SelectionChanged -= dataGridViewStudent_SelectionChanged;
            dataGridViewStudent.SelectionChanged += dataGridViewStudent_SelectionChanged;
        }
        private void ClearFields()
        {
            labelName.Text = "";
            labelRoll.Text = "";
            labelIdNumber.Text = "";
            labelClassname.Text = "";
            labelSectionName.Text = "";
            comboBoxExam.Enabled = false;
            comboBoxExam.SelectedIndex = 0;
//            dataGridViewMarks.Enabled = false;
        }

        private void comboBoxExam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxExam.SelectedIndex == 0)
            {
                dataGridViewMarks.DataSource = null;
                dataGridViewMarks.ClearSelection();
//                dataGridViewMarks.Enabled = false;
                return;
            }
//            dataGridViewMarks.Enabled = true;
            var exam = (ExamViewModel)comboBoxExam.SelectedItem;
            var student = (StudentViewModel)dataGridViewStudent.SelectedRows[0].DataBoundItem;
            var marksList = _settingService.GetListForMarksTable(student.Id, exam.ExamId);
            LoadMarksGridView(marksList);
        }

        private void LoadMarksGridView(List<MarksViewModel> marksList)
        {
            dataGridViewMarks.DataSource = null;
            dataGridViewMarks.ClearSelection();
            dataGridViewMarks.AutoGenerateColumns = false;
            dataGridViewMarks.DataSource = marksList;

        }

        private void dataGridViewMarks_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string headerText =
                dataGridViewMarks.Columns[e.ColumnIndex].HeaderText;

            // Abort validation if cell is not in the CompanyName column.
            if (!headerText.Equals("Marks")) return;
            // Confirm that the cell is not empty.
            if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
            {
                dataGridViewMarks.EditingControl.Text = "0";
                return;

            }
            float data;
            if (!float.TryParse(e.FormattedValue.ToString(), out data))
            {
                dataGridViewMarks.Rows[e.RowIndex].ErrorText =
                    "Enter Valid Marks";
                e.Cancel = true;
                labelMarksGridError.Text = "Enter Valid Marks";

            }
            else if(data>100)
            {
                dataGridViewMarks.Rows[e.RowIndex].ErrorText =
                    "Marks can't be greater than 100";
                e.Cancel = true;
                labelMarksGridError.Text = "Marks can't be greater than 100";
            }
        }

        private void dataGridViewMarks_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewMarks.Rows[e.RowIndex].ErrorText = String.Empty;
            labelMarksGridError.Text = "";
        }

        private void buttonUpdateMarks_Click(object sender, EventArgs e)
        {
            var comboExamIndex = comboBoxExam.SelectedIndex;
            List<MarksViewModel> marksViewModels = new List<MarksViewModel>();
            foreach (DataGridViewRow row in dataGridViewMarks.Rows)
            {
                marksViewModels.Add((MarksViewModel)row.DataBoundItem);
            }

            if (_settingService.UpdateMarksTable(marksViewModels))
            {
                MessageBox.Show("Data Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxExam.SelectedIndex = 0;
                comboBoxExam.SelectedIndex = comboExamIndex;
            }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
