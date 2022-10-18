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
    public partial class ServiceDesk : Form
    {
        public TicketService ticketService = new TicketService();
        List<Ticket> tickets;

        public ServiceDesk()
        {
            InitializeComponent();

            ShowPanel(pnlIncidentManagement);
        }

        private void ServiceDesk_Load()
        {
            
        }


        //general method for ease of panel switching
        private void ShowPanel(Panel panel) //i tried making a function that would fit all three, but since each panel displays different things i couldnt do it as general as i wanted

        {
            if (panel == pnlDashboard)
            {
                pnlIncidentManagement.Hide();
                pnlUserManagement.Hide();

                pnlDashboard.Show();
                pnlDashboard.Dock = DockStyle.Fill;
            }
            else if (panel == pnlIncidentManagement)
            {
                pnlDashboard.Hide();
                pnlUserManagement.Hide();

                pnlIncidentManagement.Show();
                pnlIncidentManagement.Dock = DockStyle.Fill;

                DisplayAllTickets();
            }
            else if (panel == pnlUserManagement)
            {
                pnlDashboard.Hide();
                pnlIncidentManagement.Hide();

                pnlUserManagement.Show();
                pnlUserManagement.Dock = DockStyle.Fill;
            }

            /* i had a lovely little code of
             * 
             * foreach (Panel p in this.Controls){
             *  if (p != panel)
             *      p.Hide();
             * }
             * 
             * but then each panel has to display different stuff so it would not work
            */
        }


        //TICKET INCIDENT PANEL

        //filling in the listview with the ticket list
        private void DisplayTickets()
        {
            try
            {
                listViewTickets.Clear();
                listViewTickets.View = View.Details;
                listViewTickets.FullRowSelect = true;

                listViewTickets.Columns.Add("Object Id", 50);
                listViewTickets.Columns.Add("Employee Id", 100);
                listViewTickets.Columns.Add("Category", 70);
                listViewTickets.Columns.Add("Priority", 90);
                listViewTickets.Columns.Add("Description", 300);

                foreach (Ticket t in tickets)
                {
                    ListViewItem ti = new ListViewItem(t.objectId.ToString());
                    ti.SubItems.Add(t.employeeId.ToString());
                    ti.SubItems.Add(t.ticketCategory.ToString());
                    ti.SubItems.Add(t.ticketPriority.ToString());
                    ti.SubItems.Add(t.description.ToString());

                    listViewTickets.Items.Add(ti);
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }


        //different ticket displays
        private void DisplayAllTickets()
        {
            tickets = ticketService.GetTickets();
            DisplayTickets();
        }


        //Button presses for different ticket displays
        private void toolStripAllTickets_Click(object sender, EventArgs e)
        {
            DisplayAllTickets();
        }

        
        //USER MANAGEMENT PANEL


    }
}
