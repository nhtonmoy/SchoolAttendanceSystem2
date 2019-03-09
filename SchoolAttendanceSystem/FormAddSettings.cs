using Core.Data.DB;
using Core.Data.ViewModel;
using Core.Enum;
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
    public partial class FormAddSettings : Form
    {
        private readonly CommonService _commonService = new CommonService();
        private List<BaseData> genderList;
        public FormAddSettings()
        {
            InitializeComponent();
            genderList = _commonService.GetBaseDataByCatagory(EnumBaseData.Gender.ToString());

        }

        private void buttonAddInfo_Click(object sender, EventArgs e)
        {
            var settings = new Setting
            {
                SchoolName = textBoxSchoolName.Text,
                SchoolAddress = richTextBoxAddress.Text,
                MobileNo = textBoxMobile.Text,
                TNT = textBoxTelephone.Text,

            };
            var admin = new EmployeeViewModel
            {
                Name = textBoxEmployeeName.Text,
                Username = textBoxUsername.Text,
                Password = textBoxPassword.Text,
                Email = textBoxEmail.Text,
                DateOfBirth = DateTime.Parse(dateTimePickerBirthDate.Text),
                GenderId = GetSelectedGenderId(),
                Phone = textBoxPhone.Text,
                JoinDate= DateTime.Parse(dateTimePickerJoinDate.Text)
            };

            bool res = _commonService.SaveFirstRunInfo(settings,admin);
            if (res)
            {
                MessageBox.Show("Information saved successfully!\n\rPlease log in to the system.");
                new FormLogin().Show();
                Hide();
            }
        }

        private int GetSelectedGenderId()
        {
            string gender="";
            if (radioButtonFemale.Checked)
            {
                gender = EnumGender.Female.ToString();
            }
            else if (radioButtonMale.Checked)
            {
                gender = EnumGender.Male.ToString();
            }
            else 
            {
                gender = EnumGender.Other.ToString();
            }
            return genderList.First(x => x.Value == gender).Id;
        }
    }
}
