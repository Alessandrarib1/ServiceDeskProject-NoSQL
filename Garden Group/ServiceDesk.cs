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
    public partial class ServiceDesk : Form // IDEC
    {
        public TicketService ticketService = new TicketService();
        public UserService userService = new UserService();
        public ReportService reportService = new ReportService();
        public ArchiveService archiveService = new ArchiveService();

        List<Ticket> tickets;
        List<User> users;
        List<Report> reports;

        Ticket tempTicket;
        User tempUser;
        User currentUser;

        Ticket ticketToTransfer;

        public ServiceDesk(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;

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
                pnlUserCreation.Hide();
                pnlReportManagement.Hide();
                
                pnlDashboard.Show();
                pnlDashboard.Dock = DockStyle.Fill;
            }
            else if (panel == pnlIncidentManagement)
            {
                pnlDashboard.Hide();
                pnlUserManagement.Hide();
                pnlTicketCreation.Hide();
                pnlUserCreation.Hide();
                pnlReportManagement.Hide();
                
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
                pnlUserCreation.Hide();
                pnlReportManagement.Hide();
                
                pnlUserManagement.Show();
                pnlUserManagement.Dock = DockStyle.Fill;

                DisplayAllUsers();
            }
            else if (panel == pnlTicketCreation)
            {
                pnlDashboard.Hide();
                pnlIncidentManagement.Hide();
                pnlUserManagement.Hide();
                pnlUserCreation.Hide();
                pnlReportManagement.Hide();
                
                pnlTicketCreation.Show();
                pnlTicketCreation.Dock = DockStyle.Fill;
            }
            else if (panel == pnlUserCreation)
            {
                pnlDashboard.Hide();
                pnlIncidentManagement.Hide();
                pnlUserManagement.Hide();
                pnlTicketCreation.Hide();
                pnlReportManagement.Hide();

                pnlUserCreation.Show();
                pnlUserCreation.Dock = DockStyle.Fill;
            }
            else if (panel == pnlReportManagement)
            {
                pnlDashboard.Hide();
                pnlIncidentManagement.Hide();
                pnlUserManagement.Hide();
                pnlTicketCreation.Hide();
                pnlUserCreation.Hide();

                pnlReportManagement.Show();
                pnlReportManagement.Dock = DockStyle.Fill;
                DisplayAllReports();
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

        //REPORT MANAGEMENT PANEL

        private void toolStripReportManagement_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlReportManagement);
        }

        private void DisplayReports()
        {
            try
            {
                listViewReports.Clear();
                listViewReports.View = View.Details;
                listViewReports.FullRowSelect = true;

                listViewReports.Columns.Add("Object Id", 50);
                listViewReports.Columns.Add("Employee Id", 50);
                listViewReports.Columns.Add("Description", 400);
                

                foreach (Report r in reports)
                {
                    ListViewItem ti = new ListViewItem(r.objectId.ToString());
                    ti.SubItems.Add(r.employeeId.ToString());
                    ti.SubItems.Add(r.description.ToString());

                    listViewReports.Items.Add(ti);
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }

        private void DisplayAllReports()
        {
            reports = reportService.GetAllReports();
            DisplayReports();
        }


        private void listViewReports_DoubleClick(object sender, EventArgs e)
        {
            if (listViewReports.SelectedItems.Count == 1)
            {
                Report tempReport = reportService.GetReportById(ObjectId.Parse(listViewReports.SelectedItems[0].Text));
                FillTicketCreationFieldsReport(tempReport);
                ShowPanel(pnlTicketCreation);
            }
        }

        private void btnDeleteReport_Click(object sender, EventArgs e)
        {
            if (listViewReports.SelectedItems != null)
            {
                ObjectId tempObjId = ObjectId.Parse(listViewReports.SelectedItems[0].Text);
                Report tempReport = reportService.GetReportById(tempObjId);
                reportService.DeleteReport(tempReport);

                MessageBox.Show("Report has been deleted!");
                DisplayAllReports();
            }
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
        public void DisplayTicketsByPriority()
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

        //CODE BELOW IS LEGACY; DONT TAKE OUT JUST YET
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
                AutoFillTicketCreationFields(tempTicket);
                ShowPanel(pnlTicketCreation);
            }
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            foreach (Ticket t in tickets)
            {
                TimeSpan ts = DateTime.Now.Date - t.date;
                int timePassed = ts.Days;
                if (timePassed > 730)
                {
                    archiveService.AddArchive(t);
                    ticketService.DeleteTicket(t.objectId);
                    DisplayTicketsByPriority();
                }
            }
            MessageBox.Show("Archived any tickets older than 2 years old");
        }


        //USER MANAGEMENT PANEL

        private void toolStripUserManagement_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlUserManagement);
        }

        private void DisplayUsers()
        {
            try
            {
                listViewUsers.Clear();
                listViewUsers.View = View.Details;
                listViewUsers.FullRowSelect = true;

                listViewUsers.Columns.Add("Object Id", 50);
                listViewUsers.Columns.Add("User Id", 50);
                listViewUsers.Columns.Add("Username", 100);
                listViewUsers.Columns.Add("Name", 120);
                listViewUsers.Columns.Add("Job", 150);
                listViewUsers.Columns.Add("Tickets");

                foreach (User u in users)
                {
                    ListViewItem ti = new ListViewItem(u.GetObjectId().ToString());
                    ti.SubItems.Add(u.GetEmployeeId().ToString());
                    ti.SubItems.Add(u.GetUsername());
                    ti.SubItems.Add(u.GetName());
                    ti.SubItems.Add(u.GetJob().ToString());
                    ti.SubItems.Add(ticketService.GetUserTicketCount(u).ToString());

                    listViewUsers.Items.Add(ti);
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }

        private void DisplayAllUsers()
        {
            users = userService.GetUsers();
            DisplayUsers();
        }


        //TICKET CREATION PANEL

        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlTicketCreation);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (CheckTicketCreationFields())
            {
                Ticket ticket = new Ticket(currentUser.GetEmployeeId(), (int)Enum.Parse(typeof(Category), comboBoxCategory.Text), (int)Enum.Parse(typeof(Status), comboBoxStatus.Text), (int)Enum.Parse(typeof(Priority), comboBoxPriority.Text), txtDescription.Text, DateTime.Now);
                ticketService.CreateTicket(ticket);
                MessageBox.Show("Ticket has been created!");
                EmptyTicketCreationFields();
            }
            else
                MessageBox.Show("Please fill in all fields");
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tempTicket != null && CheckTicketCreationFields())
            {
                Ticket ticket = new Ticket(currentUser.GetEmployeeId(), (int)Enum.Parse(typeof(Category), comboBoxCategory.Text), (int)Enum.Parse(typeof(Status), comboBoxStatus.Text), (int)Enum.Parse(typeof(Priority), comboBoxPriority.Text), txtDescription.Text, tempTicket.date);
                ticketService.UpdateTicket(tempTicket.objectId, ticket);
                MessageBox.Show("Ticket has been updated!");
                EmptyTicketCreationFields();
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
                EmptyTicketCreationFields();
            }
            else
                MessageBox.Show("No ticket to delete");
           
        }

        private void EmptyTicketCreationFields()
        {
            comboBoxCategory.Text = String.Empty;
            comboBoxStatus.Text = String.Empty;
            comboBoxPriority.Text = String.Empty;
            txtDescription.Text = String.Empty;
        }

        private bool CheckTicketCreationFields()
        {
            //if (comboBoxCategory.Text.Length != 0 && comboBoxStatus.Text.Length != 0 && comboBoxPriority.Text.Length != 0 && txtDescription.Text.Length != 0)
            if (comboBoxCategory.Text != String.Empty && comboBoxStatus.Text != String.Empty && comboBoxPriority.Text != String.Empty && txtDescription.Text != String.Empty)
                return true;
            return false;
        }

        private void AutoFillTicketCreationFields(Ticket ticket)
        {
                comboBoxCategory.Text = ticket.ticketCategory.ToString();
                comboBoxStatus.Text = ticket.ticketStatus.ToString();
                comboBoxPriority.Text = ticket.ticketPriority.ToString();
                txtDescription.Text = ticket.description;
        }

        private void FillTicketCreationFieldsReport(Report report)
        {
            txtDescription.Text = report.description;
        }

        private void listViewTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeEmployeeButton.Enabled = true;

            try
            {
                ticketToTransfer = ticketService.GetTicket(ObjectId.Parse(listViewTickets.SelectedItems[0].Text));

            }catch(Exception ex)
            {

            }
        }

        private void changeEmployeeButton_Click(object sender, EventArgs e)
        {
            try
            {
                changeEmployeeDialog changeEmployeeDialog = new changeEmployeeDialog(ticketToTransfer, this);
                changeEmployeeDialog.ShowDialog();
            }
            catch(Exception ex)
            {

            }
        }

        //USER CREATION PANEL

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlUserCreation);
        }

        /*private void listViewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }*/

        private void listViewUsers_DoubleClick(object sender, EventArgs e)
        {
            if (listViewUsers.SelectedItems.Count == 1)
            {
                ObjectId tempObjId = ObjectId.Parse(listViewUsers.SelectedItems[0].Text);
                tempUser = userService.GetUserByObjectId(tempObjId);

                AutoFillUserCreationFields(tempUser);
                ShowPanel(pnlUserCreation);
            }
        }

        private void AutoFillUserCreationFields(User user)
        {
            txtUsername.Text = user.GetUsername();
            txtName.Text = user.GetName();
            comboBoxJob.Text = user.GetJob().ToString();
            txtPassword.Text = user.GetPassword();
        }

        private void EmptyUserCreationFields()
        {
            txtUsername.Text = String.Empty;
            txtName.Text = String.Empty;
            comboBoxJob.Text = String.Empty;
            txtPassword.Text = String.Empty;
        }

        private bool CheckUserCreationFields()
        {
            if (txtUsername.Text != String.Empty && txtName.Text != String.Empty && comboBoxJob.Text != String.Empty && txtPassword.Text != String.Empty)
                return true;
            return false;
        }

        private void btnUserCreate_Click(object sender, EventArgs e)
        {
            if (CheckUserCreationFields())
            {
                int newUserId = users[users.Count - 1].GetEmployeeId() + 1;
                User user = new User(txtUsername.Text, txtName.Text, txtPassword.Text, newUserId, (Job)Enum.Parse(typeof(Job), comboBoxJob.Text.Replace(" ", String.Empty)));
                userService.CreateUser(user);
                MessageBox.Show("User has been created!");
                EmptyUserCreationFields();
            }
            else
                MessageBox.Show("Please fill in all the fileds");
        }

        private void btnUserUpdate_Click(object sender, EventArgs e)
        {
            if (tempUser != null && CheckUserCreationFields())
            {
                User user = new User(txtUsername.Text, txtName.Text, txtPassword.Text, tempUser.GetEmployeeId(), (Job)Enum.Parse(typeof(Job), comboBoxJob.Text.Replace(" ", String.Empty)));
                userService.UpdateUser(tempUser.objectId, user);
                MessageBox.Show("User has been updated!");
                EmptyUserCreationFields();
            }
            else
                MessageBox.Show("No ticket to update!");
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            if (tempTicket != null)
            {
                userService.DeleteUser(tempUser.objectId);
                MessageBox.Show("User has been deleted!");
                EmptyUserCreationFields();
            }
            else
                MessageBox.Show("No ticket to delete");
        }
    }
}
