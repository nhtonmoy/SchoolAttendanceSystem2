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
    public partial class FormEditTeacherInfo : Form
    {
        public FormEditTeacherInfo()
        {
            InitializeComponent();
        }
        private static FormEditTeacherInfo _instance;
        public static FormEditTeacherInfo Instance
        {
            get { return _instance ?? (_instance = new FormEditTeacherInfo()); }
        }

        private void FormEditeTeacherInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
