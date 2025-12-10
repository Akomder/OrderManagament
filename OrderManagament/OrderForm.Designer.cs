namespace WinFormUI
{
    partial class OrderForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblAgent;
        private System.Windows.Forms.Label lblDate;
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblAgent = new System.Windows.Forms.Label();
            this.cboAgent = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
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
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.BackColor = System.Drawing.Color.FromArgb(24, 24, 24);
            this.Load += new System.EventHandler(this.OrderForm_Load);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Height = 65;
            this.headerPanel.Controls.Add(this.lblHeader);
            this.headerPanel.Controls.Add(this.btnClose);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Text = "📋 Orders Management";
            this.lblHeader.Location = new System.Drawing.Point(18, 18);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(232, 17, 35);
            this.btnClose.Text = "✕";
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnClose.Size = new System.Drawing.Size(45, 38);
            this.btnClose.Location = new System.Drawing.Point(893, 13);
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblAgent
            // 
            this.lblAgent.AutoSize = true;
            this.lblAgent.ForeColor = System.Drawing.Color.White;
            this.lblAgent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAgent.Text = "Select Agent";
            this.lblAgent.Location = new System.Drawing.Point(25, 85);
            // 
            // cboAgent
            // 
            this.cboAgent.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.cboAgent.ForeColor = System.Drawing.Color.White;
            this.cboAgent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAgent.Location = new System.Drawing.Point(25, 110);
            this.cboAgent.Size = new System.Drawing.Size(280, 31);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDate.Text = "Order Date";
            this.lblDate.Location = new System.Drawing.Point(320, 85);
            // 
            // dtOrderDate
            // 
            this.dtOrderDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(50, 50, 50);
            this.dtOrderDate.CalendarForeColor = System.Drawing.Color.White;
            this.dtOrderDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtOrderDate.Location = new System.Drawing.Point(320, 110);
            this.dtOrderDate.Size = new System.Drawing.Size(240, 30);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnNewOrder.FlatAppearance.BorderSize = 0;
            this.btnNewOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(0, 140, 255);
            this.btnNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewOrder.ForeColor = System.Drawing.Color.White;
            this.btnNewOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNewOrder.Location = new System.Drawing.Point(585, 105);
            this.btnNewOrder.Size = new System.Drawing.Size(160, 40);
            this.btnNewOrder.Text = "➕ Create Order";
            this.btnNewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnViewDetails.FlatAppearance.BorderSize = 0;
            this.btnViewDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(56, 142, 60);
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnViewDetails.Location = new System.Drawing.Point(765, 105);
            this.btnViewDetails.Size = new System.Drawing.Size(160, 40);
            this.btnViewDetails.Text = "👁 View Details";
            this.btnViewDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // dgvOrders
            // 
            this.dgvOrders.BackgroundColor = System.Drawing.Color.FromArgb(32, 32, 32);
            this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrders.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.dgvOrders.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOrders.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvOrders.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.dgvOrders.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            this.dgvOrders.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOrders.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 100, 180);
            this.dgvOrders.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvOrders.GridColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.dgvOrders.Location = new System.Drawing.Point(25, 165);
            this.dgvOrders.Size = new System.Drawing.Size(900, 410);
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.RowHeadersVisible = false;
            // 
            // add
            // 
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.lblAgent);
            this.Controls.Add(this.cboAgent);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtOrderDate);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.dgvOrders);
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}