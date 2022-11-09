
namespace Garden_Group
{
    partial class ServiceDesk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripIncidentManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripUserManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.pnlUserManagement = new System.Windows.Forms.Panel();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.user_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userJob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ticketsOpen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlIncidentManagement = new System.Windows.Forms.Panel();
            this.btnCreateTicket = new System.Windows.Forms.Button();
            this.changeEmployeeButton = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripClosed = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripUnresolved = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAllTickets = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewTickets = new System.Windows.Forms.ListView();
            this.objectId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employeeId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlTicketCreation = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxJob = new System.Windows.Forms.ComboBox();
            this.btnUserCreate = new System.Windows.Forms.Button();
            this.btnUserUpdate = new System.Windows.Forms.Button();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxLastName = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.pnlUserCreation = new System.Windows.Forms.Panel();
            this.radioButtonCreateMyOwnPassword = new System.Windows.Forms.RadioButton();
            this.radioButtonGeneratePassword = new System.Windows.Forms.RadioButton();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.confPasswordLabel = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.Location = new System.Windows.Forms.Label();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.pnlUserManagement.SuspendLayout();
            this.pnlIncidentManagement.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.pnlTicketCreation.SuspendLayout();
            this.pnlUserCreation.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDashboard,
            this.toolStripIncidentManagement,
            this.toolStripUserManagement});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripDashboard
            // 
            this.toolStripDashboard.Name = "toolStripDashboard";
            this.toolStripDashboard.Size = new System.Drawing.Size(96, 24);
            this.toolStripDashboard.Text = "Dashboard";
            // 
            // toolStripIncidentManagement
            // 
            this.toolStripIncidentManagement.Name = "toolStripIncidentManagement";
            this.toolStripIncidentManagement.Size = new System.Drawing.Size(168, 24);
            this.toolStripIncidentManagement.Text = "Incident Management";
            this.toolStripIncidentManagement.Click += new System.EventHandler(this.toolStripIncidentManagement_Click);
            // 
            // toolStripUserManagement
            // 
            this.toolStripUserManagement.Name = "toolStripUserManagement";
            this.toolStripUserManagement.Size = new System.Drawing.Size(144, 24);
            this.toolStripUserManagement.Text = "User Management";
            this.toolStripUserManagement.Click += new System.EventHandler(this.toolStripUserManagement_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Location = new System.Drawing.Point(793, 142);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(99, 64);
            this.pnlDashboard.TabIndex = 1;
            // 
            // pnlUserManagement
            // 
            this.pnlUserManagement.Controls.Add(this.btnCreateUser);
            this.pnlUserManagement.Controls.Add(this.listViewUsers);
            this.pnlUserManagement.Location = new System.Drawing.Point(793, 32);
            this.pnlUserManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlUserManagement.Name = "pnlUserManagement";
            this.pnlUserManagement.Size = new System.Drawing.Size(128, 81);
            this.pnlUserManagement.TabIndex = 2;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(623, 18);
            this.btnCreateUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(148, 28);
            this.btnCreateUser.TabIndex = 4;
            this.btnCreateUser.Text = "Create user";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // listViewUsers
            // 
            this.listViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.user_Id,
            this.userName,
            this.userFirstName,
            this.userJob,
            this.ticketsOpen});
            this.listViewUsers.HideSelection = false;
            this.listViewUsers.Location = new System.Drawing.Point(26, 61);
            this.listViewUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(746, 346);
            this.listViewUsers.TabIndex = 1;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            this.listViewUsers.DoubleClick += new System.EventHandler(this.listViewUsers_DoubleClick);
            // 
            // user_Id
            // 
            this.user_Id.Text = "Id";
            this.user_Id.Width = 79;
            // 
            // userName
            // 
            this.userName.Text = "Username";
            this.userName.Width = 216;
            // 
            // userFirstName
            // 
            this.userFirstName.Text = "First name";
            this.userFirstName.Width = 222;
            // 
            // userJob
            // 
            this.userJob.Text = "Job";
            this.userJob.Width = 165;
            // 
            // ticketsOpen
            // 
            this.ticketsOpen.Text = "Tickets";
            // 
            // pnlIncidentManagement
            // 
            this.pnlIncidentManagement.Controls.Add(this.btnCreateTicket);
            this.pnlIncidentManagement.Controls.Add(this.changeEmployeeButton);
            this.pnlIncidentManagement.Controls.Add(this.menuStrip2);
            this.pnlIncidentManagement.Controls.Add(this.listViewTickets);
            this.pnlIncidentManagement.Location = new System.Drawing.Point(793, 225);
            this.pnlIncidentManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlIncidentManagement.Name = "pnlIncidentManagement";
            this.pnlIncidentManagement.Size = new System.Drawing.Size(47, 47);
            this.pnlIncidentManagement.TabIndex = 2;
            // 
            // btnCreateTicket
            // 
            this.btnCreateTicket.Location = new System.Drawing.Point(452, 1);
            this.btnCreateTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateTicket.Name = "btnCreateTicket";
            this.btnCreateTicket.Size = new System.Drawing.Size(148, 28);
            this.btnCreateTicket.TabIndex = 3;
            this.btnCreateTicket.Text = "Create ticket";
            this.btnCreateTicket.UseVisualStyleBackColor = true;
            this.btnCreateTicket.Click += new System.EventHandler(this.btnCreateTicket_Click);
            // 
            // changeEmployeeButton
            // 
            this.changeEmployeeButton.Enabled = false;
            this.changeEmployeeButton.Location = new System.Drawing.Point(608, 1);
            this.changeEmployeeButton.Margin = new System.Windows.Forms.Padding(4);
            this.changeEmployeeButton.Name = "changeEmployeeButton";
            this.changeEmployeeButton.Size = new System.Drawing.Size(148, 28);
            this.changeEmployeeButton.TabIndex = 2;
            this.changeEmployeeButton.Text = "Change Employee";
            this.changeEmployeeButton.UseVisualStyleBackColor = true;
            this.changeEmployeeButton.Click += new System.EventHandler(this.changeEmployeeButton_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripOpen,
            this.toolStripClosed,
            this.toolStripUnresolved,
            this.toolStripAllTickets});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(47, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripOpen
            // 
            this.toolStripOpen.Name = "toolStripOpen";
            this.toolStripOpen.Size = new System.Drawing.Size(59, 24);
            this.toolStripOpen.Text = "Open";
            this.toolStripOpen.Click += new System.EventHandler(this.toolStripOpen_Click);
            // 
            // toolStripClosed
            // 
            this.toolStripClosed.Name = "toolStripClosed";
            this.toolStripClosed.Size = new System.Drawing.Size(68, 24);
            this.toolStripClosed.Text = "Closed";
            this.toolStripClosed.Click += new System.EventHandler(this.toolStripClosed_Click);
            // 
            // toolStripUnresolved
            // 
            this.toolStripUnresolved.Name = "toolStripUnresolved";
            this.toolStripUnresolved.Size = new System.Drawing.Size(97, 24);
            this.toolStripUnresolved.Text = "Unresolved";
            this.toolStripUnresolved.Click += new System.EventHandler(this.toolStripUnresolved_Click);
            // 
            // toolStripAllTickets
            // 
            this.toolStripAllTickets.Name = "toolStripAllTickets";
            this.toolStripAllTickets.Size = new System.Drawing.Size(41, 24);
            this.toolStripAllTickets.Text = "All";
            this.toolStripAllTickets.Click += new System.EventHandler(this.toolStripAllTickets_Click);
            // 
            // listViewTickets
            // 
            this.listViewTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.objectId,
            this.employeeId,
            this.category,
            this.priority,
            this.description});
            this.listViewTickets.HideSelection = false;
            this.listViewTickets.Location = new System.Drawing.Point(19, 46);
            this.listViewTickets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewTickets.Name = "listViewTickets";
            this.listViewTickets.Size = new System.Drawing.Size(753, 345);
            this.listViewTickets.TabIndex = 0;
            this.listViewTickets.UseCompatibleStateImageBehavior = false;
            this.listViewTickets.View = System.Windows.Forms.View.Details;
            this.listViewTickets.SelectedIndexChanged += new System.EventHandler(this.listViewTickets_SelectedIndexChanged);
            this.listViewTickets.DoubleClick += new System.EventHandler(this.listViewTickets_DoubleClick);
            // 
            // objectId
            // 
            this.objectId.Text = "Object Id";
            // 
            // employeeId
            // 
            this.employeeId.Text = "Employee Id";
            this.employeeId.Width = 119;
            // 
            // category
            // 
            this.category.Text = "Category";
            this.category.Width = 104;
            // 
            // priority
            // 
            this.priority.Text = "Priority";
            this.priority.Width = 90;
            // 
            // description
            // 
            this.description.Text = "Description";
            this.description.Width = 341;
            // 
            // pnlTicketCreation
            // 
            this.pnlTicketCreation.Controls.Add(this.btnDelete);
            this.pnlTicketCreation.Controls.Add(this.btnUpdate);
            this.pnlTicketCreation.Controls.Add(this.btnCreate);
            this.pnlTicketCreation.Controls.Add(this.txtDescription);
            this.pnlTicketCreation.Controls.Add(this.comboBoxPriority);
            this.pnlTicketCreation.Controls.Add(this.comboBoxStatus);
            this.pnlTicketCreation.Controls.Add(this.comboBoxCategory);
            this.pnlTicketCreation.Controls.Add(this.label4);
            this.pnlTicketCreation.Controls.Add(this.label3);
            this.pnlTicketCreation.Controls.Add(this.label2);
            this.pnlTicketCreation.Controls.Add(this.label1);
            this.pnlTicketCreation.Location = new System.Drawing.Point(794, 354);
            this.pnlTicketCreation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTicketCreation.Name = "pnlTicketCreation";
            this.pnlTicketCreation.Size = new System.Drawing.Size(73, 47);
            this.pnlTicketCreation.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(313, 327);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 38);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(184, 327);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 38);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(53, 327);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(91, 38);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(171, 191);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(233, 96);
            this.txtDescription.TabIndex = 7;
            this.txtDescription.Text = "";
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High",
            "Critical"});
            this.comboBoxPriority.Location = new System.Drawing.Point(171, 137);
            this.comboBoxPriority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(233, 24);
            this.comboBoxPriority.TabIndex = 6;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Open",
            "Closed",
            "Unresolved"});
            this.comboBoxStatus.Location = new System.Drawing.Point(171, 86);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(233, 24);
            this.comboBoxStatus.TabIndex = 5;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Login",
            "Hardware",
            "Software",
            "Security"});
            this.comboBoxCategory.Location = new System.Drawing.Point(171, 37);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(233, 24);
            this.comboBoxCategory.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Priority";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "What kind of user?";
            // 
            // comboBoxJob
            // 
            this.comboBoxJob.FormattingEnabled = true;
            this.comboBoxJob.Items.AddRange(new object[] {
            "Regular Employee",
            "Service Desk Employee"});
            this.comboBoxJob.Location = new System.Drawing.Point(200, 139);
            this.comboBoxJob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxJob.Name = "comboBoxJob";
            this.comboBoxJob.Size = new System.Drawing.Size(257, 24);
            this.comboBoxJob.TabIndex = 5;
            // 
            // btnUserCreate
            // 
            this.btnUserCreate.Location = new System.Drawing.Point(54, 359);
            this.btnUserCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserCreate.Name = "btnUserCreate";
            this.btnUserCreate.Size = new System.Drawing.Size(91, 38);
            this.btnUserCreate.TabIndex = 8;
            this.btnUserCreate.Text = "Create";
            this.btnUserCreate.UseVisualStyleBackColor = true;
            this.btnUserCreate.Click += new System.EventHandler(this.btnUserCreate_Click);
            // 
            // btnUserUpdate
            // 
            this.btnUserUpdate.Location = new System.Drawing.Point(187, 361);
            this.btnUserUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserUpdate.Name = "btnUserUpdate";
            this.btnUserUpdate.Size = new System.Drawing.Size(91, 38);
            this.btnUserUpdate.TabIndex = 9;
            this.btnUserUpdate.Text = "Update";
            this.btnUserUpdate.UseVisualStyleBackColor = true;
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Location = new System.Drawing.Point(313, 359);
            this.btnUserDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(91, 38);
            this.btnUserDelete.TabIndex = 10;
            this.btnUserDelete.Text = "Delete";
            this.btnUserDelete.UseVisualStyleBackColor = true;
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(200, 220);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(257, 22);
            this.txtUsername.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(200, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(257, 22);
            this.txtName.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Last Name";
            // 
            // TextBoxLastName
            // 
            this.TextBoxLastName.Location = new System.Drawing.Point(200, 66);
            this.TextBoxLastName.Name = "TextBoxLastName";
            this.TextBoxLastName.Size = new System.Drawing.Size(257, 22);
            this.TextBoxLastName.TabIndex = 16;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(52, 105);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(42, 17);
            this.Email.TabIndex = 17;
            this.Email.Text = "Email";
            // 
            // pnlUserCreation
            // 
            this.pnlUserCreation.Controls.Add(this.radioButtonCreateMyOwnPassword);
            this.pnlUserCreation.Controls.Add(this.radioButtonGeneratePassword);
            this.pnlUserCreation.Controls.Add(this.textBoxConfirmPassword);
            this.pnlUserCreation.Controls.Add(this.confPasswordLabel);
            this.pnlUserCreation.Controls.Add(this.textBoxPassword);
            this.pnlUserCreation.Controls.Add(this.label10);
            this.pnlUserCreation.Controls.Add(this.comboBoxLocation);
            this.pnlUserCreation.Controls.Add(this.Location);
            this.pnlUserCreation.Controls.Add(this.TextBoxEmail);
            this.pnlUserCreation.Controls.Add(this.Email);
            this.pnlUserCreation.Controls.Add(this.TextBoxLastName);
            this.pnlUserCreation.Controls.Add(this.label6);
            this.pnlUserCreation.Controls.Add(this.label5);
            this.pnlUserCreation.Controls.Add(this.txtName);
            this.pnlUserCreation.Controls.Add(this.txtUsername);
            this.pnlUserCreation.Controls.Add(this.btnUserDelete);
            this.pnlUserCreation.Controls.Add(this.btnUserUpdate);
            this.pnlUserCreation.Controls.Add(this.btnUserCreate);
            this.pnlUserCreation.Controls.Add(this.comboBoxJob);
            this.pnlUserCreation.Controls.Add(this.label7);
            this.pnlUserCreation.Controls.Add(this.label8);
            this.pnlUserCreation.Location = new System.Drawing.Point(12, 32);
            this.pnlUserCreation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlUserCreation.Name = "pnlUserCreation";
            this.pnlUserCreation.Size = new System.Drawing.Size(776, 407);
            this.pnlUserCreation.TabIndex = 11;
            // 
            // radioButtonCreateMyOwnPassword
            // 
            this.radioButtonCreateMyOwnPassword.AutoSize = true;
            this.radioButtonCreateMyOwnPassword.Location = new System.Drawing.Point(54, 301);
            this.radioButtonCreateMyOwnPassword.Name = "radioButtonCreateMyOwnPassword";
            this.radioButtonCreateMyOwnPassword.Size = new System.Drawing.Size(196, 21);
            this.radioButtonCreateMyOwnPassword.TabIndex = 30;
            this.radioButtonCreateMyOwnPassword.TabStop = true;
            this.radioButtonCreateMyOwnPassword.Text = "Create your own password";
            this.radioButtonCreateMyOwnPassword.UseVisualStyleBackColor = true;
            this.radioButtonCreateMyOwnPassword.CheckedChanged += new System.EventHandler(this.radioButtonCreateMyOwnPassword_CheckedChanged);
            // 
            // radioButtonGeneratePassword
            // 
            this.radioButtonGeneratePassword.AutoSize = true;
            this.radioButtonGeneratePassword.Location = new System.Drawing.Point(200, 261);
            this.radioButtonGeneratePassword.Name = "radioButtonGeneratePassword";
            this.radioButtonGeneratePassword.Size = new System.Drawing.Size(293, 21);
            this.radioButtonGeneratePassword.TabIndex = 29;
            this.radioButtonGeneratePassword.TabStop = true;
            this.radioButtonGeneratePassword.Text = "yes, a password will be send to your email";
            this.radioButtonGeneratePassword.UseVisualStyleBackColor = true;
            this.radioButtonGeneratePassword.CheckedChanged += new System.EventHandler(this.radioButtonGeneratePassword_CheckedChanged);
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Enabled = false;
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(577, 305);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.PasswordChar = '*';
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(184, 22);
            this.textBoxConfirmPassword.TabIndex = 28;
            // 
            // confPasswordLabel
            // 
            this.confPasswordLabel.AutoSize = true;
            this.confPasswordLabel.Location = new System.Drawing.Point(450, 305);
            this.confPasswordLabel.Name = "confPasswordLabel";
            this.confPasswordLabel.Size = new System.Drawing.Size(121, 17);
            this.confPasswordLabel.TabIndex = 27;
            this.confPasswordLabel.Text = "Confirm Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Enabled = false;
            this.textBoxPassword.Location = new System.Drawing.Point(258, 300);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(186, 22);
            this.textBoxPassword.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Generate password?";
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Location = new System.Drawing.Point(200, 177);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(257, 24);
            this.comboBoxLocation.TabIndex = 22;
            // 
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.Location = new System.Drawing.Point(51, 177);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(62, 17);
            this.Location.TabIndex = 21;
            this.Location.Text = "Location";
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(200, 100);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(257, 22);
            this.TextBoxEmail.TabIndex = 18;
            // 
            // ServiceDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlUserCreation);
            this.Controls.Add(this.pnlIncidentManagement);
            this.Controls.Add(this.pnlTicketCreation);
            this.Controls.Add(this.pnlUserManagement);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ServiceDesk";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlUserManagement.ResumeLayout(false);
            this.pnlIncidentManagement.ResumeLayout(false);
            this.pnlIncidentManagement.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.pnlTicketCreation.ResumeLayout(false);
            this.pnlTicketCreation.PerformLayout();
            this.pnlUserCreation.ResumeLayout(false);
            this.pnlUserCreation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripDashboard;
        private System.Windows.Forms.ToolStripMenuItem toolStripIncidentManagement;
        private System.Windows.Forms.ToolStripMenuItem toolStripUserManagement;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Panel pnlUserManagement;
        private System.Windows.Forms.Panel pnlIncidentManagement;
        private System.Windows.Forms.ListView listViewTickets;
        private System.Windows.Forms.ColumnHeader objectId;
        private System.Windows.Forms.ColumnHeader employeeId;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.ColumnHeader priority;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripOpen;
        private System.Windows.Forms.ToolStripMenuItem toolStripClosed;
        private System.Windows.Forms.ToolStripMenuItem toolStripUnresolved;
        private System.Windows.Forms.ToolStripMenuItem toolStripAllTickets;
        private System.Windows.Forms.Panel pnlTicketCreation;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button changeEmployeeButton;
        private System.Windows.Forms.Button btnCreateTicket;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.ColumnHeader user_Id;
        private System.Windows.Forms.ColumnHeader userName;
        private System.Windows.Forms.ColumnHeader userFirstName;
        private System.Windows.Forms.ColumnHeader userJob;
        private System.Windows.Forms.ColumnHeader ticketsOpen;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxJob;
        private System.Windows.Forms.Button btnUserCreate;
        private System.Windows.Forms.Button btnUserUpdate;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxLastName;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Panel pnlUserCreation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.Label Location;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.Label confPasswordLabel;
        private System.Windows.Forms.RadioButton radioButtonCreateMyOwnPassword;
        private System.Windows.Forms.RadioButton radioButtonGeneratePassword;
    }
}