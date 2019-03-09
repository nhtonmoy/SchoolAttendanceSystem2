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
    public partial class FormStudentInfo : Form
    {
        public FormStudentInfo()
        {
            InitializeComponent();
        }
        private static FormStudentInfo _instance;
        public static FormStudentInfo Instance
        {
            get { return _instance ?? (_instance = new FormStudentInfo()); }
        }

        private void FormStudentInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
