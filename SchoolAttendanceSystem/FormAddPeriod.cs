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
    public partial class FormAddPeriod : Form
    {
        public FormAddPeriod()
        {
            InitializeComponent();
        }

        private void buttonAddPeriod_Click(object sender, EventArgs e)
        {

        }
        private static FormAddPeriod _instance;
        public static FormAddPeriod Instance
        {
            get { return _instance ?? (_instance = new FormAddPeriod()); }
        }

        private void FormAddPeriod_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
