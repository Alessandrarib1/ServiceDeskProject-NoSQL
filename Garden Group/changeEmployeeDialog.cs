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

        public changeEmployeeDialog(Ticket ticket)
        {
            this.ticket = ticket;
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
    }
}
