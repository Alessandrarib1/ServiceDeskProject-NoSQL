
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
            this.listViewTickets = new System.Windows.Forms.ListView();
            this.objectId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employeeId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripClosed = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripUnresolved = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAllTickets = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.pnlIncidentManagement.SuspendLayout();
            this.menuStrip2.SuspendLayout();
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
            // 
            // toolStripUserManagement
            // 
            this.toolStripUserManagement.Name = "toolStripUserManagement";
            this.toolStripUserManagement.Size = new System.Drawing.Size(144, 24);
            this.toolStripUserManagement.Text = "User Management";
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Location = new System.Drawing.Point(793, 106);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(200, 100);
            this.pnlDashboard.TabIndex = 1;
            // 
            // pnlUserManagement
            // 
            this.pnlUserManagement.Location = new System.Drawing.Point(793, 0);
            this.pnlUserManagement.Name = "pnlUserManagement";
            this.pnlUserManagement.Size = new System.Drawing.Size(200, 100);
            this.pnlUserManagement.TabIndex = 2;
            // 
            // pnlIncidentManagement
            // 
            this.pnlIncidentManagement.Controls.Add(this.listViewTickets);
            this.pnlIncidentManagement.Controls.Add(this.menuStrip2);
            this.pnlIncidentManagement.Location = new System.Drawing.Point(12, 31);
            this.pnlIncidentManagement.Name = "pnlIncidentManagement";
            this.pnlIncidentManagement.Size = new System.Drawing.Size(775, 407);
            this.pnlIncidentManagement.TabIndex = 2;
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
            this.listViewTickets.Location = new System.Drawing.Point(18, 46);
            this.listViewTickets.Name = "listViewTickets";
            this.listViewTickets.Size = new System.Drawing.Size(754, 345);
            this.listViewTickets.TabIndex = 0;
            this.listViewTickets.UseCompatibleStateImageBehavior = false;
            this.listViewTickets.View = System.Windows.Forms.View.Details;
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
            this.menuStrip2.Size = new System.Drawing.Size(775, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripOpen
            // 
            this.toolStripOpen.Name = "toolStripOpen";
            this.toolStripOpen.Size = new System.Drawing.Size(59, 24);
            this.toolStripOpen.Text = "Open";
            // 
            // toolStripClosed
            // 
            this.toolStripClosed.Name = "toolStripClosed";
            this.toolStripClosed.Size = new System.Drawing.Size(68, 24);
            this.toolStripClosed.Text = "Closed";
            // 
            // toolStripUnresolved
            // 
            this.toolStripUnresolved.Name = "toolStripUnresolved";
            this.toolStripUnresolved.Size = new System.Drawing.Size(97, 24);
            this.toolStripUnresolved.Text = "Unresolved";
            // 
            // toolStripAllTickets
            // 
            this.toolStripAllTickets.Name = "toolStripAllTickets";
            this.toolStripAllTickets.Size = new System.Drawing.Size(41, 24);
            this.toolStripAllTickets.Text = "All";
            this.toolStripAllTickets.Click += new System.EventHandler(this.toolStripAllTickets_Click);
            // 
            // ServiceDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlUserManagement);
            this.Controls.Add(this.pnlIncidentManagement);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ServiceDesk";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlIncidentManagement.ResumeLayout(false);
            this.pnlIncidentManagement.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
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
    }
}