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
    public partial class FormAttendance : Form
    {
        private readonly SettingService _settingService = new SettingService();
        public FormAttendance()
        {
            InitializeComponent();
            buttonLoad.Enabled = false;
            buttonLoad.BackColor = SystemColors.ControlLight;
            LoadData();
        }
        private static FormAttendance _instance;
        public static FormAttendance Instance
        {
            get { return _instance ?? (_instance = new FormAttendance()); }
        }

        private void FormAttendance_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
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
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            List<AttendanceViewModel> attendanceList = _settingService.GetDailyAttendanceListByClassSection((int)comboBoxSection.SelectedValue, dateTimePicker1.Value.Date);
            LoadAttendanceGridView(attendanceList);
        }

        private void LoadAttendanceGridView(List<AttendanceViewModel> attendanceList)
        {
            dataGridViewAttendance.ClearSelection();
            dataGridViewAttendance.DataSource = null;
            dataGridViewAttendance.AutoGenerateColumns = false;
            dataGridViewAttendance.DataSource = attendanceList;
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            var data = (ClassViewModel)comboBoxClass.SelectedItem;
            LoadSectionList(_settingService.GetActiveClassSectionList(data.ClassId));
            dataGridViewAttendance.DataSource = null;

        }
        private void LoadSectionList(List<ClassSectionViewModel> list)
        {
            comboBoxSection.DataSource = list;
            comboBoxSection.DisplayMember = "SectionName";
            comboBoxSection.ValueMember = "ClassSectionId";
            buttonLoad.Enabled = true;
            buttonLoad.BackColor = SystemColors.ActiveCaption;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            var list = new List<AttendanceViewModel>();
            foreach(DataGridViewRow row in dataGridViewAttendance.Rows)
            {
                list.Add((AttendanceViewModel)row.DataBoundItem);
            }
            if(_settingService.UpdateDailyAttendance(list))
            {
                MessageBox.Show("Data Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonLoad.PerformClick();
            }
            else
            {
                MessageBox.Show("error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewAttendance.DataSource = null;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewAttendance.DataSource = null;
        }
    }
}
