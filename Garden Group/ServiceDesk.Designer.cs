
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
            this.pnlIncidentManagement = new System.Windows.Forms.Panel();
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
            this.btnCreateTicket = new System.Windows.Forms.Button();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.user_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userJob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ticketsOpen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.pnlUserManagement.SuspendLayout();
            this.pnlIncidentManagement.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.pnlTicketCreation.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripDashboard
            // 
            this.toolStripDashboard.Name = "toolStripDashboard";
            this.toolStripDashboard.Size = new System.Drawing.Size(96, 26);
            this.toolStripDashboard.Text = "Dashboard";
            // 
            // toolStripIncidentManagement
            // 
            this.toolStripIncidentManagement.Name = "toolStripIncidentManagement";
            this.toolStripIncidentManagement.Size = new System.Drawing.Size(168, 26);
            this.toolStripIncidentManagement.Text = "Incident Management";
            this.toolStripIncidentManagement.Click += new System.EventHandler(this.toolStripIncidentManagement_Click);
            // 
            // toolStripUserManagement
            // 
            this.toolStripUserManagement.Name = "toolStripUserManagement";
            this.toolStripUserManagement.Size = new System.Drawing.Size(144, 26);
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
            this.pnlUserManagement.Controls.Add(this.listViewUsers);
            this.pnlUserManagement.Location = new System.Drawing.Point(12, 30);
            this.pnlUserManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlUserManagement.Name = "pnlUserManagement";
            this.pnlUserManagement.Size = new System.Drawing.Size(776, 409);
            this.pnlUserManagement.TabIndex = 2;
            // 
            // pnlIncidentManagement
            // 
            this.pnlIncidentManagement.Controls.Add(this.btnCreateTicket);
            this.pnlIncidentManagement.Controls.Add(this.changeEmployeeButton);
            this.pnlIncidentManagement.Controls.Add(this.menuStrip2);
            this.pnlIncidentManagement.Controls.Add(this.listViewTickets);
            this.pnlIncidentManagement.Location = new System.Drawing.Point(790, 220);
            this.pnlIncidentManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlIncidentManagement.Name = "pnlIncidentManagement";
            this.pnlIncidentManagement.Size = new System.Drawing.Size(96, 67);
            this.pnlIncidentManagement.TabIndex = 2;
            // 
            // changeEmployeeButton
            // 
            this.changeEmployeeButton.Enabled = false;
            this.changeEmployeeButton.Location = new System.Drawing.Point(608, 1);
            this.changeEmployeeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.menuStrip2.Size = new System.Drawing.Size(96, 30);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripOpen
            // 
            this.toolStripOpen.Name = "toolStripOpen";
            this.toolStripOpen.Size = new System.Drawing.Size(59, 26);
            this.toolStripOpen.Text = "Open";
            this.toolStripOpen.Click += new System.EventHandler(this.toolStripOpen_Click);
            // 
            // toolStripClosed
            // 
            this.toolStripClosed.Name = "toolStripClosed";
            this.toolStripClosed.Size = new System.Drawing.Size(68, 26);
            this.toolStripClosed.Text = "Closed";
            this.toolStripClosed.Click += new System.EventHandler(this.toolStripClosed_Click);
            // 
            // toolStripUnresolved
            // 
            this.toolStripUnresolved.Name = "toolStripUnresolved";
            this.toolStripUnresolved.Size = new System.Drawing.Size(97, 26);
            this.toolStripUnresolved.Text = "Unresolved";
            this.toolStripUnresolved.Click += new System.EventHandler(this.toolStripUnresolved_Click);
            // 
            // toolStripAllTickets
            // 
            this.toolStripAllTickets.Name = "toolStripAllTickets";
            this.toolStripAllTickets.Size = new System.Drawing.Size(41, 26);
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
            this.pnlTicketCreation.Location = new System.Drawing.Point(793, 345);
            this.pnlTicketCreation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTicketCreation.Name = "pnlTicketCreation";
            this.pnlTicketCreation.Size = new System.Drawing.Size(146, 94);
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
            this.listViewUsers.Size = new System.Drawing.Size(746, 345);
            this.listViewUsers.TabIndex = 1;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
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
            this.userFirstName.Width = 178;
            // 
            // userJob
            // 
            this.userJob.Text = "Job";
            this.userJob.Width = 122;
            // 
            // ticketsOpen
            // 
            this.ticketsOpen.Text = "Tickets";
            // 
            // ServiceDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}