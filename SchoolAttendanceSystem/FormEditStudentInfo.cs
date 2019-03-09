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
    public partial class FormEditStudentInfo : Form
    {
        public FormEditStudentInfo()
        {
            InitializeComponent();
        }
        private static FormEditStudentInfo _instance;
        public static FormEditStudentInfo Instance
        {
            get { return _instance ?? (_instance = new FormEditStudentInfo()); }
        }

        private void FormEditStudentInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
