using System;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            new ItemForm().ShowDialog();
        }

        private void btnAgents_Click(object sender, EventArgs e)
        {
            new AgentForm().ShowDialog();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            new OrderForm().ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
