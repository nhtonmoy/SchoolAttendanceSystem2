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
    public partial class FormEmployeeInfo : Form
    {
        public FormEmployeeInfo()
        {
            InitializeComponent();
        }
        private static FormEmployeeInfo _instance;
        public static FormEmployeeInfo Instance
        {
            get { return _instance ?? (_instance = new FormEmployeeInfo()); }
        }

        private void FormEmployeeInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
