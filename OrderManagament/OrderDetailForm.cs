using System;
using System.Windows.Forms;
using BLL;

namespace WinFormUI
{
    public partial class OrderDetailForm : Form
    {
        int orderId;
        OrderDetailBLL bll = new OrderDetailBLL();
        ItemBLL itemBLL = new ItemBLL();

        public OrderDetailForm(int oid)
        {
            InitializeComponent();
            orderId = oid;
        }

        private void OrderDetailForm_Load(object sender, EventArgs e)
        {
            LoadItems();
            LoadDetails();
        }

        void LoadItems()
        {
            cboItem.DataSource = itemBLL.GetItems();
            cboItem.DisplayMember = "ItemName";
            cboItem.ValueMember = "ItemID";
        }

        void LoadDetails()
        {
            dgvDetails.DataSource = bll.GetOrderDetails(orderId);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            int itemID = Convert.ToInt32(cboItem.SelectedValue);
            int qty = int.Parse(txtQty.Text);
            decimal price = decimal.Parse(txtPrice.Text);

            bll.AddDetail(orderId, itemID, qty, price);

            LoadDetails();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvDetails.CurrentRow.Cells["ID"].Value);
            bll.DeleteDetail(id);

            LoadDetails();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderDetailForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}
