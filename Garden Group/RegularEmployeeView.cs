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

            welcomeLabel.Text = "Welcome, " + user.GetUsername() + "!";

            ShowPanel(reportIncidentsPanel);
            DisplayUserIncidents(user);
        }

        private void ShowPanel(Panel panel)
        {
            panel.Show();

            if(panel == reportIncidentsPanel)
            {
                viewReportsTicketsPanel.Hide();
            }
            else
            {
                reportIncidentsPanel.Hide();
            }
        }

        private void DisplayUserIncidents(User user)
        {
            incidentsListView.Clear();
            incidentsListView.View = View.Details;

            incidentsListView.Columns.Add("Description", 500);

            ReportService reportService = new ReportService();

            List<Report> reports = reportService.GetAllReportsOfUser(user);

            foreach(Report report in reports)
            {
                ListViewItem reportItem = new ListViewItem(report.description);
                incidentsListView.Items.Add(reportItem);
            }
        }

        private void viewReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel(viewReportsTicketsPanel);
            DisplayUserIncidents(user);
        }

        private void reportIncidentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel(reportIncidentsPanel);
        }
    }
}
