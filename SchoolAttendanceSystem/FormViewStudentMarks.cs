using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Data.DB;
using Core.Data.ViewModel;
using Core.Service;

namespace SchoolAttendanceSystem
{
    public partial class FormViewStudentMarks : Form
    {
        //Todo: PromoteStudentViewModel Changed
        private PromoteStudentViewModel studentInfo;
        private readonly SettingService _settingService = new SettingService();
        private bool isPassed;
        private int nextClassId;
        private int tempPromoteId = -1;
        private FormPromoteStudent form;
        public FormViewStudentMarks()
        {
            InitializeComponent();
        }

        public FormViewStudentMarks(FormPromoteStudent form,PromoteStudentViewModel dataBoundItem)
        {
            InitializeComponent();
            this.studentInfo = dataBoundItem;
            this.form = form;
            LoadData();
        }

        private void LoadData()
        {
            labelName.Text = studentInfo.StudentName;
            labelId.Text = studentInfo.IdNumber;
            labelRoll.Text = studentInfo.Roll.ToString();
            labelSection.Text = studentInfo.SectionName;
            labelClass.Text = studentInfo.ClassName;

            var examList = _settingService.GetActiveExamList();
            examList.Insert(0, new ExamViewModel() { ExamId = -1, ExamName = "--Select--" });
            comboBoxExam.DataSource = examList;
            comboBoxExam.DisplayMember = "ExamName";
            comboBoxExam.ValueMember = "ExamId";

            labelTotalAttendance.Text = _settingService.GetAttendanceRationByStudent(studentInfo.StudentId);
            string nextClassInfo = _settingService.GetNextClassByClassId(studentInfo.ClassId);
            string[] data = nextClassInfo.Split(',');
            labelNextClass.Text = data[0];
            nextClassId = int.Parse(data[1]);

            var classList = _settingService.GetActiveClassSectionList(int.Parse(data[1]));
            comboBoxNextClassSection.DataSource = classList;
            comboBoxNextClassSection.DisplayMember = "SectionName";
            comboBoxNextClassSection.ValueMember = "ClassSectionId";

            var promoteData = _settingService.GetTempPromoteDataByStudent(studentInfo.StudentId);
            if (promoteData!=null)
            {
                tempPromoteId = promoteData.Id;
                if (promoteData.IsPassed)
                {
                    ButtonPassClick();
                }
                else
                {
                    ButtonFailClick();
                }
            }

        }

        private static FormViewStudentMarks _instance;

        public static FormViewStudentMarks Instance
        {
            get { return _instance ?? (_instance = new FormViewStudentMarks()); }
        }

        private void FormViewStudentMarks_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
            form.LoadDataFromPromoteView(studentInfo.ClassId);

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
            var marksList = _settingService.GetListForMarksTable(studentInfo.StudentId, exam.ExamId);
            LoadMarksGridView(marksList);
        }

        private void LoadMarksGridView(List<MarksViewModel> marksList)
        {
            dataGridViewMarks.DataSource = null;
            dataGridViewMarks.ClearSelection();
            dataGridViewMarks.AutoGenerateColumns = false;
            dataGridViewMarks.DataSource = marksList;
        }

        private void buttonFail_Click(object sender, EventArgs e)
        {
            ButtonFailClick();
        }

        private void ButtonFailClick()
        {
            buttonPass.BackColor = SystemColors.Control;
            buttonPass.ForeColor = SystemColors.ControlText;
            buttonFail.BackColor = Color.Red;
            buttonFail.ForeColor = Color.White;
            isPassed = false;
            buttonSubmit.Enabled = true;
            buttonSubmit.BackColor = SystemColors.ActiveCaption;
        }

        private void buttonPass_Click(object sender, EventArgs e)
        {
            ButtonPassClick();
        }

        private void ButtonPassClick()
        {
            buttonPass.BackColor = Color.Green;
            buttonPass.ForeColor = Color.White;
            buttonFail.BackColor = SystemColors.Control;
            buttonFail.ForeColor = SystemColors.ControlText;
            isPassed = true;
            buttonSubmit.Enabled = true;
            buttonSubmit.BackColor = SystemColors.ActiveCaption;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            
            DialogResult result1 = MessageBox.Show("Are you sure, you want to "+(isPassed?"Promote":"Demote")+" this student?",
                "Important Question",
                MessageBoxButtons.OKCancel);
            if (result1 == DialogResult.Cancel)
            {
                return;
            }

            int nextclassSecId = -1;
            if (comboBoxNextClassSection.Items.Count>0)
            {
                nextclassSecId = ((ClassSectionViewModel)comboBoxNextClassSection.SelectedItem).ClassSectionId;
            }
            TempPromotionTable temp = new TempPromotionTable
            {
                Id = tempPromoteId,
                StudentId = studentInfo.StudentId,
                IsPassed = isPassed,
                NextClassId = isPassed ? (nextClassId==-1?(int?)null:nextClassId) : studentInfo.ClassId,
                NextClassSectionId = nextclassSecId==-1?(int?) null:nextclassSecId,
                CurrentYearId = _settingService.GetCurrentYear(),
                AverageMarks = _settingService.CalculateMarksForPromotion(studentInfo.StudentId),
                Remarks = textBoxRemarks.Text
            };

            if (_settingService.UpdateTempPromoteData(temp))
            {
                tempPromoteId = temp.Id;
                MessageBox.Show("Data Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Data Update Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
