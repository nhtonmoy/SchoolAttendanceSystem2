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
    public partial class FormAddClass : Form
    {
        string gridViewSelectedId = "";
        private readonly ClassViewModel _ClassViewModel = new ClassViewModel();
        private readonly SettingService _settingService = new SettingService();


        private static FormAddClass _instance;
        public static FormAddClass Instance
        {
            get { return _instance ?? (_instance = new FormAddClass()); }
        }
        private void FormAddClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
        public FormAddClass()
        {
            InitializeComponent();
            dataGridViewClass.SelectionChanged -= dataGridViewClass_SelectionChanged;
            LoadData();
            buttonUpdate.Enabled = false;
            textBoxClass.Focus();
        }

        private void LoadData()
        {
            LoadDataClass(_settingService.GetClassList());
            textBoxOrderBy.Text = _settingService.GetOrderBy();

        }

        private void LoadDataClass(List<ClassViewModel> list)
        {
            dataGridViewClass.DataSource = null;
            dataGridViewClass.Rows.Clear();
            dataGridViewClass.AutoGenerateColumns = false;
            dataGridViewClass.DataSource = list;
        }

        

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(textBoxOrderBy.Text, out parsedValue))
            {
                ProcessInvalid(labelOrderBy);
                MessageBox.Show("OrderBy contains number only", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxClass.Text == "")
            {
                ProcessInvalid(labelClass);
                MessageBox.Show("Class name can't be empty", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CheckClassExists(textBoxClass.Text))
            {
                ProcessInvalid(labelClass);
                MessageBox.Show("Class already exists", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CheckOrderByExists(textBoxOrderBy.Text))
            {
                ProcessInvalid(labelOrderBy);
                MessageBox.Show("Order already exists", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var sec = new Class
                {
                    ClassName = textBoxClass.Text,
                    IsActive = checkBoxIsActive.Checked,
                    OrderBy = int.Parse(textBoxOrderBy.Text)
                };
                if (_settingService.AddClass(sec))
                {

                    MessageBox.Show("Data Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ProcessValid(labelClass);
                    ProcessValid(labelOrderBy);
                    gridViewSelectedId = sec.ClassId.ToString();
                    LoadDataClass(_settingService.GetClassList());
                    dataGridViewClass.Refresh();
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



        private void LoadClass(ClassViewModel Class)
        {
            textBoxClass.Text = Class.ClassName;
            textBoxOrderBy.Text = (Class.OrderBy).ToString();
            checkBoxIsActive.Checked = Class.IsActive == "Yes" ? true : false;
        }

        private void ClearFields()
        {
            textBoxClass.Text = "";
            checkBoxIsActive.Checked = true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var data = (ClassViewModel)dataGridViewClass.SelectedRows[0].DataBoundItem;
            if (textBoxClass.Text == "")
            {
                ProcessInvalid(labelClass);
                MessageBox.Show("Class field can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (CheckClassExistsForUpdate(textBoxClass.Text, data.ClassId))
            {
                ProcessInvalid(labelClass);
                MessageBox.Show("Class already exists", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CheckOrderByExistsForUpdate(textBoxOrderBy.Text, data.ClassId))
            {
                ProcessInvalid(labelClass);
                MessageBox.Show("Order already exists", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var Class = new Class
                {
                    ClassId = data.ClassId,
                    ClassName = textBoxClass.Text,
                    IsActive = checkBoxIsActive.Checked,
                    OrderBy = int.Parse(textBoxOrderBy.Text)
                };
                if (_settingService.UpdateClass(Class))
                {
                    gridViewSelectedId = Class.ClassId.ToString();
                    LoadDataClass(_settingService.GetClassList());
                    dataGridViewClass.Refresh();
                    ProcessValid(labelClass);
                    MessageBox.Show("Data Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool CheckOrderByExistsForUpdate(string text, int classId)
        {
            bool isExists = false;
            foreach (var row in dataGridViewClass.Rows.Cast<DataGridViewRow>())
            {
                var cls = (ClassViewModel)row.DataBoundItem;
                if (cls.ClassId == classId && cls.OrderBy == int.Parse(text.ToString())) return false;
            }
            if (CheckOrderByExists(text)) return true;
            return isExists;
        }

        private bool CheckOrderByExists(string text)
        {
            DataGridViewRow row = dataGridViewClass.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => r.Cells["OrderBy"].Value.ToString().ToLower().Equals(text.ToLower()));
            if (row == null) return false;
            return true;
        }

        private bool CheckClassExists(string text)
        {
            DataGridViewRow row = dataGridViewClass.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => r.Cells["ClassName"].Value.ToString().ToLower().Equals(text.ToLower()));
            if (row == null) return false;
            return true;
        }
        private bool CheckClassExistsForUpdate(string text, int ClassId)
        {
            bool isExists = false;
            foreach (var row in dataGridViewClass.Rows.Cast<DataGridViewRow>())
            {
                var sec = (ClassViewModel)row.DataBoundItem;
                if (sec.ClassId == ClassId && sec.ClassName.ToLower() == text.ToLower()) return false;
            }
            if (CheckClassExists(text)) return true;
            return isExists;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            buttonUpdate.Enabled = false;
            buttonAdd.Enabled = true;
            dataGridViewClass.ClearSelection();
            ProcessValid(labelClass);
            ProcessValid(labelOrderBy);
            textBoxOrderBy.Text = _settingService.GetOrderBy();
            ClearFields();
        }

        private void dataGridViewClass_SelectionChanged(object sender, EventArgs e)
        {
            ClearFields();
            if (dataGridViewClass.SelectedRows.Count < 1) return;
            var data = (ClassViewModel)dataGridViewClass.SelectedRows[0].DataBoundItem;
            LoadClass(data);
            buttonAdd.Enabled = false;
            buttonUpdate.Enabled = true;
        }

        private void dataGridViewClass_Enter(object sender, EventArgs e)
        {
            dataGridViewClass.SelectionChanged += dataGridViewClass_SelectionChanged;
        }

        private void dataGridViewClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
        }

        private void dataGridViewClass_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewClass.ClearSelection();
            if (string.IsNullOrEmpty(gridViewSelectedId)) return;
            DataGridViewRow row = dataGridViewClass.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["Id"].Value.ToString().Equals(gridViewSelectedId)).First();
            dataGridViewClass.Rows[row.Index].Selected = true;
            gridViewSelectedId = "";
        }

        
    }
}
