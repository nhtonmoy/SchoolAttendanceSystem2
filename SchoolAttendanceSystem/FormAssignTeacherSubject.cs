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
    public partial class FormAssignTeacherSubject : Form
    {
        public FormAssignTeacherSubject()
        {
            InitializeComponent();
        }
        private static FormAssignTeacherSubject _instance;
        public static FormAssignTeacherSubject Instance
        {
            get { return _instance ?? (_instance = new FormAssignTeacherSubject()); }
        }

        private void FormAssignTeacherSubject_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
