namespace WinFormUI
{
    partial class ItemForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnClose;
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
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.inputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemForm
            // 
            this.Text = "Items";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.BackColor = System.Drawing.Color.FromArgb(24, 24, 24);
            this.Load += new System.EventHandler(this.ItemForm_Load);
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
            this.lblHeader.Text = "📦 Manage Items";
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
            this.btnClose.Location = new System.Drawing.Point(843, 13);
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvItems
            // 
            this.dgvItems.BackgroundColor = System.Drawing.Color.FromArgb(32, 32, 32);
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItems.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.dgvItems.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvItems.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvItems.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.dgvItems.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            this.dgvItems.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvItems.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 100, 180);
            this.dgvItems.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvItems.GridColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.dgvItems.Location = new System.Drawing.Point(25, 90);
            this.dgvItems.Size = new System.Drawing.Size(570, 465);
            this.dgvItems.ReadOnly = true;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellClick);
            // 
            // inputPanel
            // 
            this.inputPanel.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            this.inputPanel.Location = new System.Drawing.Point(620, 90);
            this.inputPanel.Size = new System.Drawing.Size(255, 465);
            this.inputPanel.Controls.Add(this.lblName);
            this.inputPanel.Controls.Add(this.txtName);
            this.inputPanel.Controls.Add(this.lblSize);
            this.inputPanel.Controls.Add(this.txtSize);
            this.inputPanel.Controls.Add(this.lblPrice);
            this.inputPanel.Controls.Add(this.txtPrice);
            this.inputPanel.Controls.Add(this.btnAdd);
            this.inputPanel.Controls.Add(this.btnUpdate);
            this.inputPanel.Controls.Add(this.btnDelete);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblName.Text = "Item Name";
            this.lblName.Location = new System.Drawing.Point(20, 25);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.Location = new System.Drawing.Point(20, 55);
            this.txtName.Size = new System.Drawing.Size(215, 30);
            this.txtName.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.ForeColor = System.Drawing.Color.White;
            this.lblSize.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSize.Text = "Size";
            this.lblSize.Location = new System.Drawing.Point(20, 100);
            // 
            // txtSize
            // 
            this.txtSize.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.txtSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSize.ForeColor = System.Drawing.Color.White;
            this.txtSize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSize.Location = new System.Drawing.Point(20, 130);
            this.txtSize.Size = new System.Drawing.Size(215, 30);
            this.txtSize.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Text = "Unit Price";
            this.lblPrice.Location = new System.Drawing.Point(20, 175);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.ForeColor = System.Drawing.Color.White;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrice.Location = new System.Drawing.Point(20, 205);
            this.txtPrice.Size = new System.Drawing.Size(215, 30);
            this.txtPrice.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(56, 142, 60);
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(20, 270);
            this.btnAdd.Size = new System.Drawing.Size(215, 42);
            this.btnAdd.Text = "➕ Add Item";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(255, 152, 0);
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 167, 38);
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(20, 330);
            this.btnUpdate.Size = new System.Drawing.Size(215, 42);
            this.btnUpdate.Text = "✏ Update Item";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(211, 47, 47);
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(229, 57, 53);
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(20, 390);
            this.btnDelete.Size = new System.Drawing.Size(215, 42);
            this.btnDelete.Text = "🗑 Delete Item";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // add
            // 
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.inputPanel);
            this.headerPanel.ResumeLayout(false);
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
        }
    }
}