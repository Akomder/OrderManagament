namespace WinFormUI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnAgents;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnAgents = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.Text = "";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.BackColor = System.Drawing.Color.FromArgb(34, 34, 34);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Height = 56;
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Controls.Add(this.btnClose);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Text = "Order Management - Dashboard";
            this.lblTitle.Location = new System.Drawing.Point(14, 12);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Text = "✕";
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Size = new System.Drawing.Size(36, 28);
            this.btnClose.Location = new System.Drawing.Point(848, 14);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnItems
            // 
            this.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItems.FlatAppearance.BorderSize = 0;
            this.btnItems.Text = "Manage Items";
            this.btnItems.Size = new System.Drawing.Size(160, 44);
            this.btnItems.Location = new System.Drawing.Point(40, 100);
            this.btnItems.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnItems.ForeColor = System.Drawing.Color.White;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnAgents
            // 
            this.btnAgents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgents.FlatAppearance.BorderSize = 0;
            this.btnAgents.Text = "Manage Agents";
            this.btnAgents.Size = new System.Drawing.Size(160, 44);
            this.btnAgents.Location = new System.Drawing.Point(220, 100);
            this.btnAgents.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnAgents.ForeColor = System.Drawing.Color.White;
            this.btnAgents.Click += new System.EventHandler(this.btnAgents_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.Text = "Create Order";
            this.btnOrders.Size = new System.Drawing.Size(160, 44);
            this.btnOrders.Location = new System.Drawing.Point(400, 100);
            this.btnOrders.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.Size = new System.Drawing.Size(100, 36);
            this.btnExit.Location = new System.Drawing.Point(40, 520);
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(220, 20, 60);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // add controls
            // 
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnAgents);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnExit);
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}