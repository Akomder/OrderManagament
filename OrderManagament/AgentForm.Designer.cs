namespace WinFormUI
{
    partial class AgentForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvAgents;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblHeader;

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
            this.dgvAgents = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgents)).BeginInit();
            this.SuspendLayout();
            // 
            // AgentForm
            // 
            this.Text = "Agents";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(820, 520);
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
            this.lblHeader.Text = "Manage Agents";
            this.lblHeader.Location = new System.Drawing.Point(14, 16);
            // 
            // dgvAgents
            // 
            this.dgvAgents.Location = new System.Drawing.Point(18, 76);
            this.dgvAgents.Size = new System.Drawing.Size(580, 420);
            this.dgvAgents.ReadOnly = true;
            this.dgvAgents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAgents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgents_CellClick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(610, 80);
            this.txtName.Size = new System.Drawing.Size(180, 28);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(610, 120);
            this.txtAddress.Size = new System.Drawing.Size(180, 28);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(610, 210);
            this.btnAdd.Size = new System.Drawing.Size(180, 36);
            this.btnAdd.Text = "Add";
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(610, 260);
            this.btnUpdate.Size = new System.Drawing.Size(180, 36);
            this.btnUpdate.Text = "Update";
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(610, 310);
            this.btnDelete.Size = new System.Drawing.Size(180, 36);
            this.btnDelete.Text = "Delete";
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // add
            // 
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.dgvAgents);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgents)).EndInit();
            this.ResumeLayout(false);
        }
    }
}