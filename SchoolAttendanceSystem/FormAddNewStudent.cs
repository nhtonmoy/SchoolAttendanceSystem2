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
    public partial class FormAddNewStudent : Form
    {
        public FormAddNewStudent()
        {
            InitializeComponent();
        }

        private static FormAddNewStudent _instance;
        public static FormAddNewStudent Instance
        {
            get { return _instance ?? (_instance = new FormAddNewStudent()); }
        }

        private void FormAddNewStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instance = null;
        }

        private void FormAddNewStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
