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
    public partial class FormAddDesignation : Form
    {
        string gridViewSelectedId = "";
        private readonly DesignationViewModel _DesignationViewModel = new DesignationViewModel();
        private readonly SettingService _settingService = new SettingService();

        private static FormAddDesignation _instance;
        public static FormAddDesignation Instance
        {
            get { return _instance ?? (_instance = new FormAddDesignation()); }
        }
        public FormAddDesignation()
        {
            InitializeComponent();
            dataGridViewDesignation.SelectionChanged -= dataGridViewDesignation_SelectionChanged;
            LoadData();
            buttonUpdate.Enabled = false;
            textBoxDesignation.Focus();
        }
        private void LoadData()
        {
            LoadDataDesignation(_settingService.GetDesignationList());
        }

        private void LoadDataDesignation(List<DesignationViewModel> list)
        {
            dataGridViewDesignation.DataSource = null;
            dataGridViewDesignation.Rows.Clear();
            dataGridViewDesignation.AutoGenerateColumns = false;
            dataGridViewDesignation.DataSource = list;
        }

        

        private void FormAddDesignation_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (textBoxDesignation.Text == "")
            {
                ProcessInvalid(labelDesignation);
                MessageBox.Show("Designation name can't be empty", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CheckDesignationExists(textBoxDesignation.Text))
            {
                ProcessInvalid(labelDesignation);
                MessageBox.Show("Designation already exists", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var desig = new Designation
                {
                    DesignationName = textBoxDesignation.Text,
                    IsActive = checkBoxIsActive.Checked
                };
                if (_settingService.AddDesignation(desig))
                {

                    MessageBox.Show("Data Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ProcessValid(labelDesignation);
                    gridViewSelectedId = desig.DesignationId.ToString();
                    LoadDataDesignation(_settingService.GetDesignationList());
                    dataGridViewDesignation.Refresh();
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
        }

        void ProcessInvalid(Control control)
        {
            control.ForeColor = Color.Red;
        }

        void ProcessValid(Control control)
        {
            control.ResetForeColor();
        }



        private void LoadDesignation(DesignationViewModel Designation)
        {
            textBoxDesignation.Text = Designation.DesignationName;
            checkBoxIsActive.Checked = Designation.IsActive == "Yes" ? true : false;
        }

        private void ClearFields()
        {
            textBoxDesignation.Text = "";
            checkBoxIsActive.Checked = true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var data = (DesignationViewModel)dataGridViewDesignation.SelectedRows[0].DataBoundItem;
            if (textBoxDesignation.Text == "")
            {
                ProcessInvalid(labelDesignation);
                MessageBox.Show("Designation field can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (CheckDesignationExistsForUpdate(textBoxDesignation.Text, data.DesignationId))
            {
                ProcessInvalid(labelDesignation);
                MessageBox.Show("Designation already exists", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var Designation = new Designation
                {
                    DesignationId = data.DesignationId,
                    DesignationName = textBoxDesignation.Text,
                    IsActive = checkBoxIsActive.Checked
                };
                if (_settingService.UpdateDesignation(Designation))
                {
                    MessageBox.Show("Data Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    gridViewSelectedId = Designation.DesignationId.ToString();
                    LoadDataDesignation(_settingService.GetDesignationList());
                    dataGridViewDesignation.Refresh();
                    ProcessValid(labelDesignation);
                }
                else
                {
                    MessageBox.Show("Update failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool CheckDesignationExists(string text)
        {
            DataGridViewRow row = dataGridViewDesignation.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => r.Cells["DesignationName"].Value.ToString().ToLower().Equals(text.ToLower()));
            if (row == null) return false;
            return true;
        }
        private bool CheckDesignationExistsForUpdate(string text, int DesignationId)
        {
            bool isExists = false;
            foreach (var row in dataGridViewDesignation.Rows.Cast<DataGridViewRow>())
            {
                var desig = (DesignationViewModel)row.DataBoundItem;
                if (desig.DesignationId == DesignationId && desig.DesignationName.ToLower() == text.ToLower()) return false;
            }
            if (CheckDesignationExists(text)) return true;
            return isExists;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            buttonUpdate.Enabled = false;
            buttonAdd.Enabled = true;
            dataGridViewDesignation.ClearSelection();
            ProcessValid(labelDesignation);
            ClearFields();
        }

        private void dataGridViewDesignation_SelectionChanged(object sender, EventArgs e)
        {
            ClearFields();
            if (dataGridViewDesignation.SelectedRows.Count < 1) return;
            var data = (DesignationViewModel)dataGridViewDesignation.SelectedRows[0].DataBoundItem;
            LoadDesignation(data);
            buttonAdd.Enabled = false;
            buttonUpdate.Enabled = true;
        }

        private void dataGridViewDesignation_Enter(object sender, EventArgs e)
        {
            dataGridViewDesignation.SelectionChanged += dataGridViewDesignation_SelectionChanged;
        }

        private void dataGridViewDesignation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
        }

        private void dataGridViewDesignation_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewDesignation.ClearSelection();
            if (string.IsNullOrEmpty(gridViewSelectedId)) return;
            DataGridViewRow row = dataGridViewDesignation.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["Id"].Value.ToString().Equals(gridViewSelectedId)).First();
            dataGridViewDesignation.Rows[row.Index].Selected = true;
            gridViewSelectedId = "";
        }

        
    }
}
