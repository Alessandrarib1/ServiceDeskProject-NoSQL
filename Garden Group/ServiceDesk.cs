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
using MongoDB.Bson;

namespace Garden_Group
{
    public partial class ServiceDesk : Form
    {
        public TicketService ticketService = new TicketService();
        List<Ticket> tickets;
        Ticket tempTicket;
        int userId;

        public ServiceDesk(int employeeId)
        {
            InitializeComponent();
            userId = employeeId;

            ShowPanel(pnlIncidentManagement);
        }

        //general method for ease of panel switching
        private void ShowPanel(Panel panel) //i tried making a function that would fit all three, but since each panel displays different things i couldnt do it as general as i wanted

        {

            if (panel == pnlDashboard)
            {
                pnlIncidentManagement.Hide();
                pnlUserManagement.Hide();
                pnlTicketCreation.Hide();
                
                pnlDashboard.Show();
                pnlDashboard.Dock = DockStyle.Fill;
            }
            else if (panel == pnlIncidentManagement)
            {
                pnlDashboard.Hide();
                pnlUserManagement.Hide();
                pnlTicketCreation.Hide();
                
                pnlIncidentManagement.Show();
                pnlIncidentManagement.Dock = DockStyle.Fill;

                //DisplayAllTickets();
                DisplayTicketsByPriority();
            }
            else if (panel == pnlUserManagement)
            {
                pnlDashboard.Hide();
                pnlIncidentManagement.Hide();
                pnlTicketCreation.Hide();
                
                pnlUserManagement.Show();
                pnlUserManagement.Dock = DockStyle.Fill;
            }
            else if (panel == pnlTicketCreation)
            {
                pnlDashboard.Hide();
                pnlIncidentManagement.Hide();
                pnlUserManagement.Hide();
                
                pnlTicketCreation.Show();
                pnlTicketCreation.Dock = DockStyle.Fill;
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

        private void toolStripIncidentManagement_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlIncidentManagement);
        }

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
                listViewTickets.Columns.Add("Description", 250);

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
            tickets = ticketService.GetAllTickets();
            DisplayTickets();
        }
        private void DisplayTicketsByPriority()
        {
            tickets = ticketService.GetTicketsSortedByPriority();
            DisplayTickets();
        }

        private void DisplayTicketsWithStatus(Status status)
        {
            tickets = ticketService.GetTicketsWithStatus(status);
            DisplayTickets();
        }


        //Button presses for different ticket displays
        private void toolStripAllTickets_Click(object sender, EventArgs e)
        {
            // DisplayAllTickets();
            DisplayTicketsByPriority();
        }

        private void toolStripOpen_Click(object sender, EventArgs e)
        {
            DisplayTicketsWithStatus(Status.Open);
        }

        private void toolStripClosed_Click(object sender, EventArgs e)
        {
            DisplayTicketsWithStatus(Status.Closed);
        }
        private void toolStripUnresolved_Click(object sender, EventArgs e)
        {
            DisplayTicketsWithStatus(Status.Unresolved);
        }

        /*private void listViewTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listViewTickets.SelectedItems.Count == 0)
                    return;

                tempObjId = ObjectId.Parse(listViewTickets.SelectedItems[0].Text);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        } */

        private void listViewTickets_DoubleClick(object sender, EventArgs e)
        {
            if (listViewTickets.SelectedItems.Count == 1)
            {
                ObjectId tempObjId = ObjectId.Parse(listViewTickets.SelectedItems[0].Text);
                tempTicket = ticketService.GetTicket(tempObjId);
                AutoFillFields(tempTicket);
                ShowPanel(pnlTicketCreation);
            }
        }


        //USER MANAGEMENT PANEL


        //TICKET CREATION PANEL

        private void toolStripTicketCreation_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlTicketCreation);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                Ticket ticket = new Ticket(userId, (int)Enum.Parse(typeof(Category), comboBoxCategory.Text), (int)Enum.Parse(typeof(Status), comboBoxStatus.Text), (int)Enum.Parse(typeof(Priority), comboBoxPriority.Text), txtDescription.Text);
                ticketService.CreateTicket(ticket);
                MessageBox.Show("Ticket has been created!");
                EmptyFields();
            }
            else
                MessageBox.Show("Please fill in all fields");
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tempTicket != null && CheckFields())
            {
                Ticket ticket = new Ticket(userId, (int)Enum.Parse(typeof(Category), comboBoxCategory.Text), (int)Enum.Parse(typeof(Status), comboBoxStatus.Text), (int)Enum.Parse(typeof(Priority), comboBoxPriority.Text), txtDescription.Text);
                ticketService.UpdateTicket(tempTicket.objectId, ticket);
                MessageBox.Show("Ticket has been updated!");
                EmptyFields();
            }
            else
                MessageBox.Show("No ticket to update!");
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tempTicket != null)
            {
                ticketService.DeleteTicket(tempTicket.objectId);
                MessageBox.Show("Ticket has been deleted!");
                EmptyFields();
            }
            else
                MessageBox.Show("No ticket to delete");
           
        }

        public void EmptyFields()
        {
            comboBoxCategory.Text = String.Empty;
            comboBoxStatus.Text = String.Empty;
            comboBoxPriority.Text = String.Empty;
            txtDescription.Text = String.Empty;
        }

        public bool CheckFields()
        {
            //if (comboBoxCategory.Text.Length != 0 && comboBoxStatus.Text.Length != 0 && comboBoxPriority.Text.Length != 0 && txtDescription.Text.Length != 0)
            if (comboBoxCategory.Text != String.Empty && comboBoxStatus.Text != String.Empty && comboBoxPriority.Text != String.Empty && txtDescription.Text != String.Empty)
                return true;
            return false;
        }

        public void AutoFillFields(Ticket ticket)
        {
                comboBoxCategory.Text = ticket.ticketCategory.ToString();
                comboBoxStatus.Text = ticket.ticketStatus.ToString();
                comboBoxPriority.Text = ticket.ticketPriority.ToString();
                txtDescription.Text = ticket.description;
        }

        
    }
}
