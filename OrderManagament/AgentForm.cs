using System;
using System.Windows.Forms;
using System.Xml.Linq;
using BLL;

namespace WinFormUI
{
    public partial class AgentForm : Form
    {
        AgentBLL bll = new AgentBLL();

        public AgentForm()
        {
            InitializeComponent();
        }

        private void AgentForm_Load(object sender, EventArgs e)
        {
            LoadAgents();
        }

        void LoadAgents()
        {
            dgvAgents.DataSource = bll.GetAgents();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bll.AddAgent(txtName.Text, txtAddress.Text);
            LoadAgents();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvAgents.CurrentRow.Cells["AgentID"].Value);
            bll.UpdateAgent(id, txtName.Text, txtAddress.Text);
            LoadAgents();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvAgents.CurrentRow.Cells["AgentID"].Value);
            bll.DeleteAgent(id);
            LoadAgents();
        }

        private void dgvAgents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvAgents.CurrentRow.Cells["AgentName"].Value.ToString();
            txtAddress.Text = dgvAgents.CurrentRow.Cells["Address"].Value.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}
