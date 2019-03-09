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
    public partial class FormPromoteStudent : Form
    {
        private readonly SettingService _settingService = new SettingService();
        public bool isViewClicked = false;
        public FormPromoteStudent()
        {
            InitializeComponent();
//            buttonLoad.Enabled = false;
//            buttonLoad.BackColor = SystemColors.ControlLight;
            LoadData();
        }

        private void LoadData()
        {
            LoadClassList(_settingService.GetClassList());
        }

        private void LoadClassList(List<ClassViewModel> list)
        {
            comboBoxClass.DataSource = list;
            comboBoxClass.DisplayMember = "ClassName";
            comboBoxClass.ValueMember = "ClassId";
        }

        private static FormPromoteStudent _instance;
        public static FormPromoteStudent Instance
        {
            get { return _instance ?? (_instance = new FormPromoteStudent()); }
        }

        private void FormPromoteStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            List<PromoteStudentViewModel> promotionList = _settingService.GetStudentListForPromotion((int)comboBoxClass.SelectedValue);
            LoadGridViewPromotion(promotionList);
        }

        public void LoadDataFromPromoteView(int classId)
        {
            List<PromoteStudentViewModel> promotionList = _settingService.GetStudentListForPromotion(classId);
            LoadGridViewPromotion(promotionList);
        }
        private void LoadGridViewPromotion(List<PromoteStudentViewModel> promotionList)
        {
            dataGridView1.ClearSelection();
            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = promotionList;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                e.RowIndex >= 0)
            {
                new FormViewStudentMarks(this, (PromoteStudentViewModel)dataGridView1.Rows[e.RowIndex].DataBoundItem).ShowDialog();
            }

        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            var data = (ClassViewModel)comboBoxClass.SelectedItem;
            //LoadSectionList(_settingService.GetActiveClassSectionList(data.ClassId));
            dataGridView1.DataSource = null;
        }

//        private void LoadSectionList(List<ClassSectionViewModel> list)
//        {
//            comboBoxSection.DataSource = list;
//            comboBoxSection.DisplayMember = "SectionName";
//            comboBoxSection.ValueMember = "ClassSectionId";
//            buttonLoad.Enabled = true;
//            buttonLoad.BackColor = SystemColors.ActiveCaption;
//        }

        private void comboBoxSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void buttonPromote_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1) return;
            List<PromoteStudentViewModel> promotionList = new List<PromoteStudentViewModel>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                promotionList.Add((PromoteStudentViewModel)row.DataBoundItem);
            }
            if (promotionList.Any(x => x.IsProcessed.ToLower() == "no"))
            {
                MessageBox.Show("All student promotion must be processed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_settingService.ExecutePromotionOfStudents(promotionList))
            {
                LoadDataFromPromoteView((int) comboBoxClass.SelectedValue);
                MessageBox.Show("Data Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
