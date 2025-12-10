using System;
using System.Windows.Forms;
using BLL;

namespace WinFormUI
{
    public partial class OrderForm : Form
    {
        OrderBLL bll = new OrderBLL();
        AgentBLL agentBLL = new AgentBLL();

        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            LoadAgents();
            LoadOrders();
        }

        void LoadAgents()
        {
            cboAgent.DataSource = agentBLL.GetAgents();
            cboAgent.DisplayMember = "AgentName";
            cboAgent.ValueMember = "AgentID";
        }

        void LoadOrders()
        {
            dgvOrders.DataSource = bll.GetOrders();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            int agentId = Convert.ToInt32(cboAgent.SelectedValue);
            int newOrderID = bll.CreateOrder(dtOrderDate.Value, agentId);

            MessageBox.Show("Order created! ID: " + newOrderID);

            LoadOrders();

            new OrderDetailForm(newOrderID).ShowDialog();
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            int oid = Convert.ToInt32(dgvOrders.CurrentRow.Cells["OrderID"].Value);
            new OrderDetailForm(oid).ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}
