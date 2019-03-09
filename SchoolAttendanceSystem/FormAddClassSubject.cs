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
    public partial class FormAddClassSubject : Form
    {
        private readonly SettingService _settingService = new SettingService();
        public FormAddClassSubject()
        {

            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            LoadClassList(_settingService.GetClassList());
            LoadSubjectList();

        }

        private void LoadClassList(List<ClassViewModel> list)
        {
            comboBoxClass.DataSource = list;
            comboBoxClass.DisplayMember = "ClassName";
            comboBoxClass.ValueMember = "ClassId";
        }

        private static FormAddClassSubject _instance;
        public static FormAddClassSubject Instance
        {
            get { return _instance ?? (_instance = new FormAddClassSubject()); }
        }

        private void FormAddClassSubject_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
        private void FormAddClassSubject_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instance = null;
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBoxAllSection.Checked = false;
            var data = (ClassViewModel)comboBoxClass.SelectedItem;
            LoadSectionList(_settingService.GetActiveClassSectionList(data.ClassId));

        }
        private void LoadSectionList(List<ClassSectionViewModel> list)
        {
            comboBoxSection.DataSource = list;
            comboBoxSection.DisplayMember = "SectionName";
        }

        public void LoadSubjectList()
        {
            listBoxSubject.ClearSelected();
            listBoxSubject.DataSource = _settingService.GetActiveSubjectList();
            listBoxSubject.DisplayMember = "SubjectName";
            listBoxSubject.ClearSelected();
                var id = ((ClassSectionViewModel)comboBoxSection.SelectedItem).ClassSectionId;

                List<SubjectViewModel> selectedList = _settingService.GetActiveSubjectListByClassSectionId(id);
                for (int index = 0; index < listBoxSubject.Items.Count; index++)
                {
                    var item = (SubjectViewModel)listBoxSubject.Items[index];
                    var data = selectedList.FirstOrDefault(x => x.SubjectId == item.SubjectId);
                    if (data != null) listBoxSubject.SelectedIndex = index;

                }
        }

        private void buttonAddSubject_Click(object sender, EventArgs e)
        {
            new FormAddSubject(this).ShowDialog();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            List<Subject> subjects = new List<Subject>();
            foreach (var item in listBoxSubject.SelectedItems)
            {
                var data = (SubjectViewModel)item;
                Subject sub = new Subject { SubjectId = data.SubjectId, SubjectName = data.SubjectName };
                subjects.Add(sub);
            }
            List<ClassSectionSubjectViewModel> csSubjectList = new List<ClassSectionSubjectViewModel>();
            if (checkBoxAllSection.Checked == true)
            {
                var csList = _settingService.GetClassSectionId(((ClassViewModel)comboBoxClass.SelectedItem).ClassId);
                foreach (var item in csList)
                {
                    var clssub = new ClassSectionSubjectViewModel
                    {
                        ClassSectionId = item.ClassSectionId,
                        SubjectList = subjects
                    };
                    csSubjectList.Add(clssub);
                }
            }
            else
            {
                var clssub = new ClassSectionSubjectViewModel
                {
                    ClassSectionId = ((ClassSectionViewModel)comboBoxSection.SelectedItem).ClassSectionId,
                    SubjectList = subjects
                };
                csSubjectList.Add(clssub);
            }
            if (_settingService.AssigningSubjetToClassSection(csSubjectList))
            {
                MessageBox.Show("Data Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void checkBoxAllSection_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAllSection.Checked == true)
            {
                comboBoxSection.Enabled = false;
            }
            else if (checkBoxAllSection.Checked == false)
            {
                comboBoxSection.Enabled = true;
                var data = (ClassViewModel)comboBoxClass.SelectedItem;
            }
            else { }
        }

        private void comboBoxSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSubjectList();
        }
    }
}