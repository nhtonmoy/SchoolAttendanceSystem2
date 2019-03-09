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
    public partial class FormUserInfo : Form
    {
        public FormUserInfo()
        {
            InitializeComponent();
            labelName.Text = CommonService.personInfo.Name;
            labelUsertype.Text = CommonService.isAdmin?"Admin":"Staff";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormUserInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
