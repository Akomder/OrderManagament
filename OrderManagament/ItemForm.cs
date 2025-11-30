using System;
using System.Windows.Forms;
using System.Xml.Linq;
using BLL;

namespace WinFormUI
{
    public partial class ItemForm : Form
    {
        ItemBLL bll = new ItemBLL();

        public ItemForm()
        {
            InitializeComponent();
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            LoadItems();
        }

        void LoadItems()
        {
            dgvItems.DataSource = bll.GetItems();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bll.AddItem(txtName.Text, txtSize.Text, decimal.Parse(txtPrice.Text));
            LoadItems();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvItems.CurrentRow.Cells["ItemID"].Value);
            bll.UpdateItem(id, txtName.Text, txtSize.Text, decimal.Parse(txtPrice.Text));
            LoadItems();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvItems.CurrentRow.Cells["ItemID"].Value);
            bll.DeleteItem(id);
            LoadItems();
        }

        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvItems.CurrentRow.Cells["ItemName"].Value.ToString();
            txtSize.Text = dgvItems.CurrentRow.Cells["Size"].Value.ToString();
            txtPrice.Text = dgvItems.CurrentRow.Cells["UnitPrice"].Value.ToString();
        }

        private void ItemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}
