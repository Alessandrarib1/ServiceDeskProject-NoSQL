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
    public partial class changeEmployeeDialog : Form
    {
        Ticket ticket;
        ServiceDesk serviceDesk;

        public changeEmployeeDialog(Ticket ticket, ServiceDesk serviceDesk)
        {
            this.ticket = ticket;
            this.serviceDesk = serviceDesk;
            InitializeComponent();
            FillComboBox();
        }

        public void FillComboBox()
        {
            UserService userService = new UserService();
            List<User> users = userService.GetUsers();

            foreach (User user in users)
            {
                employeeComboBox.Items.Add(user.GetUsername());
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            transferTicketService transferService = new transferTicketService();
            TicketService ticketService = new TicketService();

            User user = transferService.GetUserByUsername(employeeComboBox.Text);

            ticketService.UpdateTicket(ticket.objectId, new Ticket(user.GetEmployeeId(), (int) ticket.ticketCategory, (int) ticket.ticketStatus, (int) ticket.ticketPriority, ticket.description, ticket.date));
            serviceDesk.DisplayTicketsByPriority();
            this.Close();
        }
    }
}
