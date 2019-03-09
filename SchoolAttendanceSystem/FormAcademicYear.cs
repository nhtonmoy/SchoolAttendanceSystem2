
using Core;
using Core.Data.DB;
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
    public partial class FormAcademicYear : Form
    {
        private readonly SettingService _settingService = new SettingService();
        public FormAcademicYear()
        {
            InitializeComponent();
            LoadData();
        }
        private static FormAcademicYear _instance;
        public static FormAcademicYear Instance
        {
            get { return _instance ?? (_instance = new FormAcademicYear()); }
        }

        private void FormAcademicYear_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instance = null;
        }
        private void LoadData()
        {
            List<AcademicYear> list = _settingService.GetAcademicYears();
            list.Insert(0, new AcademicYear { YearId = -1, Year = "--Select--" });
            comboBoxAcademicYear.DataSource = list;
            comboBoxAcademicYear.DisplayMember = "Year";
            comboBoxAcademicYear.ValueMember = "YearId";
            dateTimePicker1.MinDate = new DateTime((int)(DateTime.Now.AddYears(-2).Year), 1, 1);
            dateTimePicker1.MaxDate = new DateTime((int)(DateTime.Now.AddYears(2).Year), 12, 31);

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if((int)comboBoxAcademicYear.SelectedValue == -1)
            {
                AcademicYear year = new AcademicYear { Year = dateTimePicker1.Value.ToString("yyyy"), IsCurrent = checkBoxIsCurrent.Checked };
                if(CheckAcademicYearExists(year.Year))
                {
                    ProcessInvalid(labelAcademicYear);
                    MessageBox.Show("Academic year already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (_settingService.AddAcademicYear(year))
                {
                    LoadData();
                    ProcessValid(labelAcademicYear);
                    comboBoxAcademicYear.SelectedValue = year.YearId;
                    MessageBox.Show("Data Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            else
            {
                AcademicYear year = new AcademicYear { YearId=(int)comboBoxAcademicYear.SelectedValue, Year = dateTimePicker1.Value.ToString("yyyy"), IsCurrent = checkBoxIsCurrent.Checked };
                if (CheckAcademicYearExistsForUpdate())
                {
                    ProcessInvalid(labelAcademicYear);
                    MessageBox.Show("Academic year already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (!year.IsCurrent && _settingService.CheckAtLeastOneCurrentYear(year.YearId))
                {
                    ProcessInvalid(labelCurrent);
                    MessageBox.Show("System must have at least one current academic year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (_settingService.UpdateAcademicYear(year))
                {
                    LoadData();
                    ProcessValid(labelAcademicYear);
                    ProcessValid(labelCurrent);
                    comboBoxAcademicYear.SelectedValue = year.YearId;
                    MessageBox.Show("Data Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
        }

        private bool CheckAcademicYearExistsForUpdate()
        {
            if (((AcademicYear)comboBoxAcademicYear.SelectedItem).Year == dateTimePicker1.Value.ToString("yyyy"))
            {
                return false;
            }
            else return CheckAcademicYearExists(dateTimePicker1.Value.ToString("yyyy"));
        }

        private void ProcessValid(Control control)
        {
            control.ResetForeColor();
        }

        void ProcessInvalid(Control control)
        {
            control.ForeColor = Color.Red;
        }

        private bool CheckAcademicYearExists(string year)
        {
            return _settingService.CheckAcademicYearExists(year);
        }

        private void comboBoxAcademicYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAcademicYear.SelectedIndex == 0) return;
            var year = (AcademicYear)comboBoxAcademicYear.SelectedItem;
            dateTimePicker1.Value = new DateTime(int.Parse(year.Year),1,1);
            checkBoxIsCurrent.Checked = year.IsCurrent;
        }
    }
}
