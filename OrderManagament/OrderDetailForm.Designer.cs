namespace WinFormUI
{
    partial class OrderDetailForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ComboBox cboItem;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.DataGridView dgvDetails;

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
            this.cboItem = new System.Windows.Forms.ComboBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderDetailForm
            // 
            this.Text = "Order Detail";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(860, 520);
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
            this.lblHeader.Text = "Order Details";
            this.lblHeader.Location = new System.Drawing.Point(14, 16);
            // 
            // cboItem
            // 
            this.cboItem.Location = new System.Drawing.Point(20, 80);
            this.cboItem.Size = new System.Drawing.Size(360, 28);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(400, 80);
            this.txtQty.Size = new System.Drawing.Size(100, 28);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(520, 80);
            this.txtPrice.Size = new System.Drawing.Size(140, 28);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(680, 76);
            this.btnAddItem.Size = new System.Drawing.Size(100, 32);
            this.btnAddItem.Text = "Add";
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(680, 120);
            this.btnDeleteItem.Size = new System.Drawing.Size(100, 32);
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // dgvDetails
            // 
            this.dgvDetails.Location = new System.Drawing.Point(20, 160);
            this.dgvDetails.Size = new System.Drawing.Size(760, 340);
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            // 
            // add
            // 
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.cboItem);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.dgvDetails);
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);
        }
    }
}