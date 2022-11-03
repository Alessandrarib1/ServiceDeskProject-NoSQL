using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GardenModel;
using GardenService;

namespace Garden_Group
{
    public partial class RegularEmployeeView : Form
    {
        public User user;
        public RegularEmployeeView(User user)
        {
            InitializeComponent();

            this.user = user;
        }

        private void viewReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewReportsTicketsPanel.Show();
            reportIncidentPanel.Hide();
        }

        private void reportIncidentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportIncidentPanel.Show();
        }
    }
}
