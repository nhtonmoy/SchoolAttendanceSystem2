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
    public partial class FormLogin : Form
    {
        private readonly CommonService _commonService = new CommonService();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            if (_commonService.CheckCredential(textBoxUserName.Text, textBoxPassword.Text))
            {
                new FormMain().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }


        }



        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
