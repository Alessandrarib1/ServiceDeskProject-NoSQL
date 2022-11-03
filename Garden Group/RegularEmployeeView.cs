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

            ShowPanel(viewReportsTicketsPanel);
            DisplayUserIncidents(user);
            DisplayUserTickets(user);
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

        private void DisplayUserTickets(User user)
        {
            ticketsListView.Clear();
            ticketsListView.View = View.Details;

            TicketService ticketService = new TicketService();
            List<Ticket> tickets = ticketService.GetTicketsOfUser(user);

            ticketsListView.Columns.Add("Category", 60);
            ticketsListView.Columns.Add("Status", 60);
            ticketsListView.Columns.Add("Priority", 60);
            ticketsListView.Columns.Add("Description", 60);

            foreach(Ticket ticket in tickets)
            {
                ListViewItem ticketItem = new ListViewItem(ticket.ticketCategory.ToString());
                ticketItem.SubItems.Add(ticket.ticketStatus.ToString());
                ticketItem.SubItems.Add(ticket.ticketPriority.ToString());
                ticketItem.SubItems.Add(ticket.description.ToString());

                ticketsListView.Items.Add(ticketItem);
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

        private void submitIncidentButton_Click(object sender, EventArgs e)
        {
            try
            {
                ReportService reportService = new ReportService();
                reportService.CreateReport(new Report(user.GetEmployeeId(), descriptionTextField.Text));
                descriptionTextField.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void RegularEmployeeView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
