using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilisationPlannerAddIn
{
    public partial class FileForm : Form
    {
        public string AssignmentsFile { get; private set;}
        public string HolidaysFile { get; private set; }

        public FileForm()
        {
            InitializeComponent();
        }

        private void btnLoadAssignments_Click(object sender, EventArgs e)
        {
            this.ofdAssignments.ShowDialog();
            this.tbAssignments.Text = ofdAssignments.FileName;
        }

        private void btnLoadHolidays_Click(object sender, EventArgs e)
        {
            this.ofdHolidays.ShowDialog();
            this.tbHolidays.Text = ofdHolidays.FileName;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            AssignmentsFile = tbAssignments.Text;
            HolidaysFile = tbHolidays.Text;
        }
    }
}
