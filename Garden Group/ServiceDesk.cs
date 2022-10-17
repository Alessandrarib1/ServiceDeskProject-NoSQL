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
        public ServiceDeskService serviceDeskService = new ServiceDeskService();
        List<Ticket> tickets;

        public ServiceDesk()
        {
            InitializeComponent();
            tickets = serviceDeskService.GetTickets();

            ShowPanel(pnlIncidentManagement);
        }

        private void ServiceDesk_Load()
        {
            
        }

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

                DisplayTickets();
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

        private void DisplayTickets()
        {
            try
            {
                listViewTickets.Clear();
                listViewTickets.View = View.Details;
                listViewTickets.FullRowSelect = true;

                listViewTickets.Columns.Add("Object Id", 0);
                listViewTickets.Columns.Add("Employee Id", 100);
                listViewTickets.Columns.Add("Category", 70);
                listViewTickets.Columns.Add("Priority", 90);
                listViewTickets.Columns.Add("Description", 300);

                foreach (Ticket t in tickets)
                {
                    ListViewItem ti = new ListViewItem(t.GetObjectId().ToString());
                    ti.SubItems.Add(t.GetEmployeeId().ToString());
                    ti.SubItems.Add(t.GetCategory().ToString());
                    ti.SubItems.Add(t.GetPriority().ToString());
                    ti.SubItems.Add(t.GetDescription().ToString());

                    listViewTickets.Items.Add(ti);
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }
    }
}
