namespace WinFormUI
{
    partial class OrderForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ComboBox cboAgent;
        private System.Windows.Forms.DateTimePicker dtOrderDate;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.DataGridView dgvOrders;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.cboAgent = new System.Windows.Forms.ComboBox();
            this.dtOrderDate = new System.Windows.Forms.DateTimePicker();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderForm
            // 
            this.Text = "Orders";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(900, 560);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.BackColor = System.Drawing.Color.FromArgb(34, 34, 34);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Height = 56;
            this.headerPanel.Controls.Add(this.lblHeader);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Text = "Orders";
            this.lblHeader.Location = new System.Drawing.Point(14, 16);
            // 
            // cboAgent
            // 
            this.cboAgent.Location = new System.Drawing.Point(20, 80);
            this.cboAgent.Size = new System.Drawing.Size(300, 28);
            // 
            // dtOrderDate
            // 
            this.dtOrderDate.Location = new System.Drawing.Point(340, 80);
            this.dtOrderDate.Size = new System.Drawing.Size(220, 28);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(580, 76);
            this.btnNewOrder.Size = new System.Drawing.Size(160, 32);
            this.btnNewOrder.Text = "Create Order";
            this.btnNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Location = new System.Drawing.Point(760, 76);
            this.btnViewDetails.Size = new System.Drawing.Size(120, 32);
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // dgvOrders
            // 
            this.dgvOrders.Location = new System.Drawing.Point(20, 120);
            this.dgvOrders.Size = new System.Drawing.Size(860, 400);
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            // 
            // add
            // 
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.cboAgent);
            this.Controls.Add(this.dtOrderDate);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.dgvOrders);
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
        }
    }
}