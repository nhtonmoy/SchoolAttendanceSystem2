using Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolAttendanceSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (new CommonService().CheckFirstRun()) { Application.Run(new FormAddSettings()); }
            else Application.Run(new FormLogin());
        }
    }
}
