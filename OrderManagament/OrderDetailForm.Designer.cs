namespace WinFormUI
{
    partial class OrderDetailForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cboItem;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.Panel inputPanel;

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
            this.inputPanel = new System.Windows.Forms.Panel();
            this.lblItem = new System.Windows.Forms.Label();
            this.cboItem = new System.Windows.Forms.ComboBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.headerPanel.SuspendLayout();
            this.inputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderDetailForm
            // 
            this.Text = "Order Detail";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.BackColor = System.Drawing.Color.FromArgb(24, 24, 24);
            this.Load += new System.EventHandler(this.OrderDetailForm_Load);
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
            this.lblHeader.Text = "📝 Order Details";
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
            // inputPanel
            // 
            this.inputPanel.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            this.inputPanel.Location = new System.Drawing.Point(25, 90);
            this.inputPanel.Size = new System.Drawing.Size(900, 120);
            this.inputPanel.Controls.Add(this.lblItem);
            this.inputPanel.Controls.Add(this.cboItem);
            this.inputPanel.Controls.Add(this.lblQty);
            this.inputPanel.Controls.Add(this.txtQty);
            this.inputPanel.Controls.Add(this.lblPrice);
            this.inputPanel.Controls.Add(this.txtPrice);
            this.inputPanel.Controls.Add(this.btnAddItem);
            this.inputPanel.Controls.Add(this.btnDeleteItem);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.ForeColor = System.Drawing.Color.White;
            this.lblItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblItem.Text = "Select Item";
            this.lblItem.Location = new System.Drawing.Point(20, 15);
            // 
            // cboItem
            // 
            this.cboItem.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.cboItem.ForeColor = System.Drawing.Color.White;
            this.cboItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItem.Location = new System.Drawing.Point(20, 45);
            this.cboItem.Size = new System.Drawing.Size(340, 31);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.ForeColor = System.Drawing.Color.White;
            this.lblQty.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblQty.Text = "Quantity";
            this.lblQty.Location = new System.Drawing.Point(380, 15);
            // 
            // txtQty
            // 
            this.txtQty.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQty.ForeColor = System.Drawing.Color.White;
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtQty.Location = new System.Drawing.Point(380, 45);
            this.txtQty.Size = new System.Drawing.Size(100, 31);
            this.txtQty.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Text = "Price";
            this.lblPrice.Location = new System.Drawing.Point(500, 15);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.ForeColor = System.Drawing.Color.White;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrice.Location = new System.Drawing.Point(500, 45);
            this.txtPrice.Size = new System.Drawing.Size(130, 31);
            this.txtPrice.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(56, 142, 60);
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddItem.Location = new System.Drawing.Point(655, 40);
            this.btnAddItem.Size = new System.Drawing.Size(110, 40);
            this.btnAddItem.Text = "➕ Add";
            this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackColor = System.Drawing.Color.FromArgb(211, 47, 47);
            this.btnDeleteItem.FlatAppearance.BorderSize = 0;
            this.btnDeleteItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(229, 57, 53);
            this.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteItem.ForeColor = System.Drawing.Color.White;
            this.btnDeleteItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteItem.Location = new System.Drawing.Point(780, 40);
            this.btnDeleteItem.Size = new System.Drawing.Size(110, 40);
            this.btnDeleteItem.Text = "🗑 Delete";
            this.btnDeleteItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // dgvDetails
            // 
            this.dgvDetails.BackgroundColor = System.Drawing.Color.FromArgb(32, 32, 32);
            this.dgvDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetails.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.dgvDetails.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDetails.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvDetails.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.dgvDetails.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            this.dgvDetails.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDetails.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 100, 180);
            this.dgvDetails.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDetails.GridColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.dgvDetails.Location = new System.Drawing.Point(25, 230);
            this.dgvDetails.Size = new System.Drawing.Size(900, 345);
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetails.RowHeadersVisible = false;
            // 
            // add
            // 
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.dgvDetails);
            this.headerPanel.ResumeLayout(false);
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);
        }
    }
}