using GardenService;
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




namespace Garden_Group
{
    
    public partial class Login : Form
    {       
        private string username;
        private string password;
        
        public Login()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user;

            if (txtBoxUserName.Text != null && txtBoxUserName.Text != string.Empty && txtBoxPassword.Text != null && txtBoxPassword.Text != string.Empty)
            {
                password = txtBoxPassword.Text;
                username = txtBoxUserName.Text;
                try
                {
                    UserService userService = new UserService();
                    user = userService.ValidateLogin(username, password);
                }
                catch
                {
                    user = null;
                }

                
                if(user == null)
                {
                    labelDisplayError.Visible = true;
                    labelDisplayError.Text = "Password or username incorrect";
                    txtBoxPassword.Clear();
                    txtBoxUserName.Clear();
                }
                else if (user.GetJob() == Job.ServiceDeskEmployee)
                {
                    label1.Text = "well done regular employeee";
                    ServiceDesk serviceDesk = new ServiceDesk(user);
                    serviceDesk.Show();
                    this.Hide();
                }
                else
                {
                    RegularEmployeeView regularEmployeeView = new RegularEmployeeView(user);
                    regularEmployeeView.Show();
                    this.Hide();
                }

            }
               
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
