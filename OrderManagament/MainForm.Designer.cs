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
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel contentPanel;

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
            this.contentPanel = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnAgents = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.Text = "";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.BackColor = System.Drawing.Color.FromArgb(24, 24, 24);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Height = 70;
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Controls.Add(this.btnClose);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Text = "Order Management System";
            this.lblTitle.Location = new System.Drawing.Point(20, 18);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(232, 17, 35);
            this.btnClose.Text = "✕";
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnClose.Size = new System.Drawing.Size(45, 40);
            this.btnClose.Location = new System.Drawing.Point(943, 15);
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Location = new System.Drawing.Point(80, 120);
            this.contentPanel.Size = new System.Drawing.Size(840, 480);
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            this.contentPanel.Controls.Add(this.lblWelcome);
            this.contentPanel.Controls.Add(this.btnItems);
            this.contentPanel.Controls.Add(this.btnAgents);
            this.contentPanel.Controls.Add(this.btnOrders);
            this.contentPanel.Controls.Add(this.btnExit);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
            this.lblWelcome.Text = "Welcome to Dashboard";
            this.lblWelcome.Location = new System.Drawing.Point(40, 30);
            // 
            // btnItems
            // 
            this.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItems.FlatAppearance.BorderSize = 0;
            this.btnItems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(0, 140, 255);
            this.btnItems.Text = "📦 Manage Items";
            this.btnItems.Size = new System.Drawing.Size(200, 55);
            this.btnItems.Location = new System.Drawing.Point(120, 120);
            this.btnItems.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnItems.ForeColor = System.Drawing.Color.White;
            this.btnItems.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnAgents
            // 
            this.btnAgents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgents.FlatAppearance.BorderSize = 0;
            this.btnAgents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(0, 140, 255);
            this.btnAgents.Text = "👥 Manage Agents";
            this.btnAgents.Size = new System.Drawing.Size(200, 55);
            this.btnAgents.Location = new System.Drawing.Point(340, 120);
            this.btnAgents.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnAgents.ForeColor = System.Drawing.Color.White;
            this.btnAgents.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAgents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgents.Click += new System.EventHandler(this.btnAgents_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(0, 140, 255);
            this.btnOrders.Text = "🛒 Create Order";
            this.btnOrders.Size = new System.Drawing.Size(200, 55);
            this.btnOrders.Location = new System.Drawing.Point(560, 120);
            this.btnOrders.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(200, 20, 50);
            this.btnExit.Text = "🚪 Exit Application";
            this.btnExit.Size = new System.Drawing.Size(160, 45);
            this.btnExit.Location = new System.Drawing.Point(40, 400);
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // add controls
            // 
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.contentPanel);
            this.headerPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}