using System;
using System.Data;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class StaffDashboard : Form
    {
        DataAccess dataAccess = new DataAccess();
        DataTable cartTable = new DataTable();
        bool isLogout = false;

        public StaffDashboard()
        {
            InitializeComponent();

            btn_order.Click += btn_order_Click;
            btn_viewsales.Click += btn_viewsales_Click;
            btn_logout.Click += btn_logout_Click;
            btn_plus.Click += btn_plus_Click;
            btn_minus.Click += btn_minus_Click;
            btn_placeorder.Click += btn_placeorder_Click;
            grid_menuitems.CellDoubleClick += grid_menuitems_CellDoubleClick;
            field_sales_search.TextChanged += field_sales_search_TextChanged;
            field_sales_search.Click += field_sales_search_Click;
            btn_sales_clear.Click += btn_sales_clear_Click;
            this.FormClosed += StaffDashboard_FormClosed;

            panel_order.Visible = false;
            panel_viewsales.Visible = false;
            lbl_username.Text = "Welcome," + Environment.NewLine + LoggedInUser.FullName;

            combo_ordertype.DropDownStyle = ComboBoxStyle.DropDownList;
            grid_menuitems.ReadOnly = true;
            grid_menuitems.AllowUserToAddRows = false;
            grid_menuitems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_menuitems.MultiSelect = false;
            grid_menuitems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_menuitems.RowHeadersVisible = false;
            grid_cart.ReadOnly = true;
            grid_cart.AllowUserToAddRows = false;
            grid_cart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_cart.MultiSelect = false;
            grid_cart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_cart.RowHeadersVisible = false;
            grid_staffsales.ReadOnly = true;
            grid_staffsales.AllowUserToAddRows = false;
            grid_staffsales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_staffsales.MultiSelect = false;
            grid_staffsales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_staffsales.RowHeadersVisible = false;
            grid_staffsales.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            grid_staffsales.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            CreateCartTable();
            LoadMenuItems();
        }

        private void btn_order_Click(object? sender, EventArgs e)
        {
            panel_order.Visible = true;
            panel_viewsales.Visible = false;
            LoadMenuItems();
            panel_order.Refresh();
        }

        private void btn_viewsales_Click(object? sender, EventArgs e)
        {
            panel_order.Visible = false;
            panel_viewsales.Visible = true;
            LoadStaffSales();
            panel_viewsales.Refresh();
        }

        private void btn_logout_Click(object? sender, EventArgs e)
        {
            isLogout = true;
            this.Hide();

            form_login login = new form_login();
            login.Show();
        }

        private void StaffDashboard_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (!isLogout)
            {
                Application.Exit();
            }
        }

        private void CreateCartTable()
        {
            cartTable.Columns.Add("ItemID", typeof(int));
            cartTable.Columns.Add("ItemName", typeof(string));
            cartTable.Columns.Add("UnitPrice", typeof(decimal));
            cartTable.Columns.Add("Quantity", typeof(int));
            cartTable.Columns.Add("TotalPrice", typeof(decimal));

            grid_cart.DataSource = cartTable;

            if (grid_cart.Columns["ItemID"] != null)
            {
                grid_cart.Columns["ItemID"].Visible = false;
            }
        }

        private void LoadMenuItems()
        {
            try
            {
                grid_menuitems.DataSource = dataAccess.GetAvailableMenuItems();

                if (grid_menuitems.Columns["ItemID"] != null)
                {
                    grid_menuitems.Columns["ItemID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load menu items error:\n" + ex.Message);
            }
        }

        private void LoadStaffSales()
        {
            try
            {
                grid_staffsales.DataSource = dataAccess.GetStaffSalesReport(LoggedInUser.UserID);

                if (grid_staffsales.Columns["OrderID"] != null)
                {
                    grid_staffsales.Columns["OrderID"].Visible = false;
                }

                SetStaffSalesHeaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load sales error:\n" + ex.Message);
            }
        }

        private void SearchStaffSales()
        {
            try
            {
                string searchText = field_sales_search.Text.Trim();

                if (searchText == "" || searchText == "Search Sales")
                {
                    LoadStaffSales();
                }
                else
                {
                    grid_staffsales.DataSource = dataAccess.SearchStaffSalesReport(LoggedInUser.UserID, searchText);

                    if (grid_staffsales.Columns["OrderID"] != null)
                    {
                        grid_staffsales.Columns["OrderID"].Visible = false;
                    }

                    SetStaffSalesHeaders();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search sales error:\n" + ex.Message);
            }
        }

        private void grid_menuitems_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            AddSelectedMenuItem();
        }

        private void SetStaffSalesHeaders()
        {
            if (grid_staffsales.Columns["CustomerPhone"] != null)
            {
                grid_staffsales.Columns["CustomerPhone"].HeaderText = "Phone";
            }

            if (grid_staffsales.Columns["SaleDate"] != null)
            {
                grid_staffsales.Columns["SaleDate"].HeaderText = "Date";
            }

            if (grid_staffsales.Columns["TotalPrice"] != null)
            {
                grid_staffsales.Columns["TotalPrice"].HeaderText = "Total Price";
            }

            if (grid_staffsales.Columns["Items"] != null)
            {
                grid_staffsales.Columns["Items"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }

        private void AddItemToCart(int itemId, string itemName, decimal unitPrice)
        {
            foreach (DataRow row in cartTable.Rows)
            {
                if (Convert.ToInt32(row["ItemID"]) == itemId)
                {
                    int quantity = Convert.ToInt32(row["Quantity"]) + 1;

                    row["Quantity"] = quantity;
                    row["TotalPrice"] = quantity * unitPrice;

                    ShowTotal();
                    return;
                }
            }

            cartTable.Rows.Add(itemId, itemName, unitPrice, 1, unitPrice);
            ShowTotal();
        }

        private void btn_plus_Click(object? sender, EventArgs e)
        {
            if (grid_cart.Focused && grid_cart.CurrentRow != null)
            {
                DataGridViewRow row = grid_cart.CurrentRow;
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value) + 1;
                decimal unitPrice = Convert.ToDecimal(row.Cells["UnitPrice"].Value);

                row.Cells["Quantity"].Value = quantity;
                row.Cells["TotalPrice"].Value = quantity * unitPrice;

                ShowTotal();
                return;
            }

            AddSelectedMenuItem();
        }

        private void btn_minus_Click(object? sender, EventArgs e)
        {
            if (grid_cart.CurrentRow == null)
            {
                MessageBox.Show("Please select an item from customer tab.");
                return;
            }

            DataGridViewRow row = grid_cart.CurrentRow;
            int quantity = Convert.ToInt32(row.Cells["Quantity"].Value) - 1;
            decimal unitPrice = Convert.ToDecimal(row.Cells["UnitPrice"].Value);

            if (quantity <= 0)
            {
                grid_cart.Rows.Remove(row);
            }
            else
            {
                row.Cells["Quantity"].Value = quantity;
                row.Cells["TotalPrice"].Value = quantity * unitPrice;
            }

            ShowTotal();
        }

        private void ShowTotal()
        {
            decimal total = 0;

            foreach (DataRow row in cartTable.Rows)
            {
                total += Convert.ToDecimal(row["TotalPrice"]);
            }

            lbl_total.Text = total.ToString("0.00");
        }

        private void AddSelectedMenuItem()
        {
            if (grid_menuitems.CurrentRow == null)
            {
                MessageBox.Show("Please select an item from menu list.");
                return;
            }

            DataGridViewRow row = grid_menuitems.CurrentRow;

            int itemId = Convert.ToInt32(row.Cells["ItemID"].Value);
            string itemName = row.Cells["ItemName"].Value.ToString()!;
            decimal unitPrice = Convert.ToDecimal(row.Cells["Price"].Value);

            AddItemToCart(itemId, itemName, unitPrice);
        }

        private bool CheckOrderFields()
        {
            if (string.IsNullOrWhiteSpace(field_customername.Text) ||
                string.IsNullOrWhiteSpace(field_customerphone.Text) ||
                combo_ordertype.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter customer name, phone number and order type.");
                return false;
            }

            if (cartTable.Rows.Count == 0)
            {
                MessageBox.Show("Please add at least one item.");
                return false;
            }

            return true;
        }

        private void btn_placeorder_Click(object? sender, EventArgs e)
        {
            if (!CheckOrderFields())
            {
                return;
            }

            try
            {
                DateTime orderDate = DateTime.Now;
                int orderId = dataAccess.GetNextOrderId();

                foreach (DataRow row in cartTable.Rows)
                {
                    dataAccess.InsertSale(
                        field_customername.Text.Trim(),
                        field_customerphone.Text.Trim(),
                        combo_ordertype.Text,
                        LoggedInUser.UserID,
                        Convert.ToInt32(row["ItemID"]),
                        Convert.ToInt32(row["Quantity"]),
                        Convert.ToDecimal(row["UnitPrice"]),
                        orderDate,
                        orderId);
                }

                MessageBox.Show("Order placed successfully.");
                ClearOrder();
                LoadStaffSales();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Place order error:\n" + ex.Message);
            }
        }

        private void ClearOrder()
        {
            field_customername.Clear();
            field_customerphone.Clear();
            combo_ordertype.SelectedIndex = -1;
            cartTable.Clear();
            ShowTotal();
            field_customername.Focus();
        }

        private void field_sales_search_TextChanged(object? sender, EventArgs e)
        {
            SearchStaffSales();
        }

        private void field_sales_search_Click(object? sender, EventArgs e)
        {
            if (field_sales_search.Text == "Search Sales")
            {
                field_sales_search.Clear();
            }
        }

        private void btn_sales_clear_Click(object? sender, EventArgs e)
        {
            field_sales_search.Clear();
            LoadStaffSales();
        }
    }
}
