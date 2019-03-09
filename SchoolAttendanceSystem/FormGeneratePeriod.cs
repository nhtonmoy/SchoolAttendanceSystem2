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
    public partial class FormGeneratePeriod : Form
    {
        int breakCol = -1;
        string[] days = { "SAT", "SUN", "MON", "TUE", "WED", "THU" };
        string[] periods = { "1st\r\n08.00-09.00", "2nd\r\n09.00-10.00", "3rd\r\n10.00-11.00", "Break", "4th\r\n11.30-12.30", "5th\r\n12.30-01.30", "6th\r\n01.30-02.30", "7th\r\n02.30-03.30" };
        public FormGeneratePeriod()
        {
            InitializeComponent();
            PopulateTable();
        }

        private void PopulateTable()
        {
            tableLayoutPanel1.RowCount = days.Length + 1;
            tableLayoutPanel1.ColumnCount = periods.Length + 1;
            int count = 1;
            foreach (var day in days)
            {
                GenerateLabel(day, day, 0, count++, true);
            }
            count = 1;
            foreach (var period in periods)
            {
                GenerateLabel("period" + count, period, count++, 0, true);

            }
            for (int i = 1; i <= periods.Length; i++)
            {
                if (i == breakCol) continue;
                for (int j = 1; j <= days.Length; j++)
                {
                    GenerateLabel(days[j - 1] + "P" + i + "_" + j, @"N/A", i, j, false);
                }
            }
        }

        private void GenerateLabel(string name, string text, int colId, int rowId, bool isHeader)
        {
            Label label = new Label();
            label.BackColor = System.Drawing.Color.LightGreen;
            label.Location = new System.Drawing.Point(3, 0);
            label.Name = "label" + name;
            label.Size = new System.Drawing.Size(104, 70);
            label.TabIndex = 61;
            label.Text = text;
            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            if (isHeader) label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tableLayoutPanel1.Controls.Add(label, colId, rowId);
            if (text == "Break")
            {
                tableLayoutPanel1.SetRowSpan(label, days.Length+1);
                label.Size = new Size(104, tableLayoutPanel1.Height);
                label.BackColor = Color.Orange;
                breakCol = colId;
            }
        }

        private void panel42_Paint(object sender, PaintEventArgs e)
        {

        }
        private static FormGeneratePeriod _instance;
        public static FormGeneratePeriod Instance
        {
            get { return _instance ?? (_instance = new FormGeneratePeriod()); }
        }

        private void FormGeneratePeriod_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
