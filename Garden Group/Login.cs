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
            panelForgotPassword.Hide();

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

        private void LabelClearFields_Click(object sender, EventArgs e)
        {
            txtBoxPassword.Clear();
            txtBoxUserName.Clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            textBoxForgotEmail.Clear();
            textBoxForgotUsername.Clear();

            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panelLogin.Hide();
            panelForgotPassword.Show();
            labelDisplayForgotPasswordErrors.Text = String.Empty;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGetNewPassword_Click(object sender, EventArgs e)
        {
            if(textBoxForgotUsername.Text != String.Empty && textBoxForgotEmail.Text != String.Empty)
            {
                try
                {
                    UserService userService = new UserService();
                    List<User> users = userService.GetUsers();
                    User selectedUser = null;
                    foreach(User user in users)
                    {
                        if(user.GetEmail() == textBoxForgotEmail.Text && user.GetUsername() == textBoxForgotUsername.Text)
                        {
                            selectedUser = user;
                            break;
                        }
                    }
                    if(selectedUser == null)
                    {
                        labelDisplayForgotPasswordErrors.Visible = true;
                        labelDisplayForgotPasswordErrors.Text = "username or email does not exist in the system";
                        return;
                    }
                    string password = HashPassword.RandomPasswordGenrator();
                    userService.UpdatePassword(selectedUser, password);
                    EmailGenerator.SendLoginDetails(selectedUser.GetFirstName(), selectedUser.GetEmail(), selectedUser.GetUsername(), password);
                    MessageBox.Show("New password was sent to your email");
                    textBoxForgotEmail.Clear();
                    textBoxForgotUsername.Clear();

                }
                catch { }
            }
        }
    }
}
