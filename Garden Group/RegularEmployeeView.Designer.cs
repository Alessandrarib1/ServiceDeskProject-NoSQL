
namespace Garden_Group
{
    partial class RegularEmployeeView
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
            this.viewReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportIncidentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportIncidentsPanel = new System.Windows.Forms.Panel();
            this.viewReportsTicketsPanel = new System.Windows.Forms.Panel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.incidentsListView = new System.Windows.Forms.ListView();
            this.reportDescriptionCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.ticketsListView = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.ticketCategoryCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ticketPriorityCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ticketDescriptionCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.viewReportsTicketsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewReportsToolStripMenuItem,
            this.reportIncidentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewReportsToolStripMenuItem
            // 
            this.viewReportsToolStripMenuItem.Name = "viewReportsToolStripMenuItem";
            this.viewReportsToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.viewReportsToolStripMenuItem.Text = "View Reports & Tickets";
            this.viewReportsToolStripMenuItem.Click += new System.EventHandler(this.viewReportsToolStripMenuItem_Click);
            // 
            // reportIncidentToolStripMenuItem
            // 
            this.reportIncidentToolStripMenuItem.Name = "reportIncidentToolStripMenuItem";
            this.reportIncidentToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.reportIncidentToolStripMenuItem.Text = "Report Incident";
            this.reportIncidentToolStripMenuItem.Click += new System.EventHandler(this.reportIncidentToolStripMenuItem_Click);
            // 
            // reportIncidentsPanel
            // 
            this.reportIncidentsPanel.Location = new System.Drawing.Point(12, 72);
            this.reportIncidentsPanel.Name = "reportIncidentsPanel";
            this.reportIncidentsPanel.Size = new System.Drawing.Size(576, 282);
            this.reportIncidentsPanel.TabIndex = 1;
            // 
            // viewReportsTicketsPanel
            // 
            this.viewReportsTicketsPanel.Controls.Add(this.ticketsListView);
            this.viewReportsTicketsPanel.Controls.Add(this.label2);
            this.viewReportsTicketsPanel.Controls.Add(this.label1);
            this.viewReportsTicketsPanel.Controls.Add(this.incidentsListView);
            this.viewReportsTicketsPanel.Location = new System.Drawing.Point(11, 72);
            this.viewReportsTicketsPanel.Name = "viewReportsTicketsPanel";
            this.viewReportsTicketsPanel.Size = new System.Drawing.Size(576, 283);
            this.viewReportsTicketsPanel.TabIndex = 1;
            this.viewReportsTicketsPanel.Visible = false;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(13, 28);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(220, 29);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Welcome message";
            // 
            // incidentsListView
            // 
            this.incidentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.reportDescriptionCol});
            this.incidentsListView.HideSelection = false;
            this.incidentsListView.Location = new System.Drawing.Point(7, 60);
            this.incidentsListView.Name = "incidentsListView";
            this.incidentsListView.Size = new System.Drawing.Size(249, 219);
            this.incidentsListView.TabIndex = 0;
            this.incidentsListView.UseCompatibleStateImageBehavior = false;
            // 
            // reportDescriptionCol
            // 
            this.reportDescriptionCol.Text = "Report Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reported Incidents";
            // 
            // ticketsListView
            // 
            this.ticketsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ticketCategoryCol,
            this.ticketPriorityCol,
            this.ticketDescriptionCol});
            this.ticketsListView.HideSelection = false;
            this.ticketsListView.Location = new System.Drawing.Point(310, 60);
            this.ticketsListView.Name = "ticketsListView";
            this.ticketsListView.Size = new System.Drawing.Size(244, 219);
            this.ticketsListView.TabIndex = 2;
            this.ticketsListView.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ongoing Tickets";
            // 
            // ticketCategoryCol
            // 
            this.ticketCategoryCol.Text = "Category";
            // 
            // ticketPriorityCol
            // 
            this.ticketPriorityCol.Text = "Priority";
            // 
            // ticketDescriptionCol
            // 
            this.ticketDescriptionCol.Text = "Description";
            // 
            // RegularEmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.viewReportsTicketsPanel);
            this.Controls.Add(this.reportIncidentsPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RegularEmployeeView";
            this.Text = "RegularEmployeeView";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.viewReportsTicketsPanel.ResumeLayout(false);
            this.viewReportsTicketsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportIncidentToolStripMenuItem;
        private System.Windows.Forms.Panel reportIncidentsPanel;
        private System.Windows.Forms.Panel viewReportsTicketsPanel;
        private System.Windows.Forms.ListView incidentsListView;
        private System.Windows.Forms.ColumnHeader reportDescriptionCol;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ticketsListView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader ticketCategoryCol;
        private System.Windows.Forms.ColumnHeader ticketPriorityCol;
        private System.Windows.Forms.ColumnHeader ticketDescriptionCol;
    }
}