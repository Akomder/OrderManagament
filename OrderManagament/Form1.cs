using System;
using System.Windows.Forms;
using BLL;

namespace WinFormUI
{
    public partial class Form1 : Form
    {
        private UserBLL userBLL = new UserBLL();
        private OrderBLL orderBLL = new OrderBLL();
        private bool isLoggedIn = false;

        public Form1()
        {
            InitializeComponent();
            LoadOrders();
            SetLoginState(false);
        }

        private void SetLoginState(bool loggedIn)
        {
            isLoggedIn = loggedIn;
            panelLogin.Visible = !loggedIn;
            panelOrderManagement.Visible = loggedIn;
            
            if (loggedIn)
            {
                LoadOrders();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter username and password.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (userBLL.Login(username, password))
                {
                    MessageBox.Show("Login successful!", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetLoginState(true);
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login error: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadOrders()
        {
            try
            {
                dgvOrders.DataSource = orderBLL.GetOrders();
                dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading orders: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime orderDate = dtpOrderDate.Value;
                int agentID = Convert.ToInt32(numAgentID.Value);

                int newOrderID = orderBLL.CreateOrder(orderDate, agentID);
                MessageBox.Show($"Order created successfully! Order ID: {newOrderID}", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                LoadOrders();
                ResetOrderForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating order: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrders.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select an order to delete.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int orderID = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["OrderID"].Value);
                
                DialogResult result = MessageBox.Show($"Are you sure you want to delete Order ID: {orderID}?", 
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    orderBLL.DeleteOrder(orderID);
                    MessageBox.Show("Order deleted successfully!", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadOrders();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting order: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrders();
            MessageBox.Show("Orders refreshed successfully!", "Success", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", 
                "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SetLoginState(false);
                ResetOrderForm();
            }
        }

        private void ResetOrderForm()
        {
            dtpOrderDate.Value = DateTime.Now;
            numAgentID.Value = 1;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
