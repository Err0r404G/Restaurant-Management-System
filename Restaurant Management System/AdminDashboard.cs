using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class AdminDashboard : Form
    {
        DataAccess dataAccess = new DataAccess();
        int selectedUserId = 0;
        int selectedItemId = 0;
        bool isLogout = false;

        public AdminDashboard()
        {
            InitializeComponent();

            btn_usermanagement.Click += btn_usermanagement_Click;
            btn_menumanagement.Click += btn_menumanagement_Click;
            btn_salesreport.Click += btn_salesreport_Click;
            btn_logout.Click += btn_logout_Click;
            btn_create.Click += btn_create_Click;
            btn_update.Click += btn_update_Click;
            btn_delete.Click += btn_delete_Click;
            btn_clear.Click += btn_clear_Click;
            field_search.TextChanged += field_search_TextChanged;
            grid_users.CellClick += grid_users_CellClick;
            btn_menu_create.Click += btn_menu_create_Click;
            btn_menu_update.Click += btn_menu_update_Click;
            btn_menu_delete.Click += btn_menu_delete_Click;
            btn_menu_clear.Click += btn_menu_clear_Click;
            field_menu_search.TextChanged += field_menu_search_TextChanged;
            grid_menuitems.CellClick += grid_menuitems_CellClick;
            field_sales_search.TextChanged += field_sales_search_TextChanged;
            field_sales_search.Click += field_sales_search_Click;
            btn_sales_clear.Click += btn_sales_clear_Click;
            this.FormClosed += AdminDashboard_FormClosed;

            panel_usermanagement.Visible = false;
            panel_menumanagement.Visible = false;
            panel_salesreport.Visible = false;
            lbl_username.Text = "Welcome," + Environment.NewLine + LoggedInUser.FullName;

            combo_role.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_menu_status.DropDownStyle = ComboBoxStyle.DropDownList;
            grid_users.ReadOnly = true;
            grid_users.AllowUserToAddRows = false;
            grid_users.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_users.MultiSelect = false;
            grid_users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_users.RowHeadersVisible = false;
            grid_users.ColumnHeadersVisible = true;
            grid_menuitems.ReadOnly = true;
            grid_menuitems.AllowUserToAddRows = false;
            grid_menuitems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_menuitems.MultiSelect = false;
            grid_menuitems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_menuitems.RowHeadersVisible = false;
            grid_salesreport.ReadOnly = true;
            grid_salesreport.AllowUserToAddRows = false;
            grid_salesreport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_salesreport.MultiSelect = false;
            grid_salesreport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_salesreport.RowHeadersVisible = false;
            grid_salesreport.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            grid_salesreport.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            LoadUsers();
            LoadMenuItems();
            LoadSalesReport();
        }

        private void btn_usermanagement_Click(object? sender, EventArgs e)
        {
            panel_usermanagement.Visible = true;
            panel_menumanagement.Visible = false;
            panel_salesreport.Visible = false;

            RefreshUserManagementPanel();
        }

        private void btn_menumanagement_Click(object? sender, EventArgs e)
        {
            panel_usermanagement.Visible = false;
            panel_menumanagement.Visible = true;
            panel_salesreport.Visible = false;

            RefreshMenuManagementPanel();
        }

        private void btn_salesreport_Click(object? sender, EventArgs e)
        {
            panel_usermanagement.Visible = false;
            panel_menumanagement.Visible = false;
            panel_salesreport.Visible = true;

            RefreshSalesReportPanel();
        }

        private void btn_logout_Click(object? sender, EventArgs e)
        {
            isLogout = true;
            this.Hide();

            form_login login = new form_login();
            login.Show();
        }

        private void AdminDashboard_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (!isLogout)
            {
                Application.Exit();
            }
        }

        private void LoadUsers()
        {
            try
            {
                grid_users.DataSource = dataAccess.GetUsers();

                if (grid_users.Columns["UserID"] != null)
                {
                    grid_users.Columns["UserID"].Visible = false;
                }

                if (grid_users.Columns["Password"] != null)
                {
                    grid_users.Columns["Password"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load users error:\n" + ex.Message);
            }
        }

        private void RefreshUserManagementPanel()
        {
            LoadUsers();
            ClearFields();
            panel_usermanagement.Refresh();
        }

        private void RefreshMenuManagementPanel()
        {
            LoadMenuItems();
            ClearMenuFields();
            panel_menumanagement.Refresh();
        }

        private void RefreshSalesReportPanel()
        {
            LoadSalesReport();
            panel_salesreport.Refresh();
        }

        private void LoadMenuItems()
        {
            try
            {
                grid_menuitems.DataSource = dataAccess.GetMenuItems();

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

        private void LoadSalesReport()
        {
            try
            {
                DataTable dt = dataAccess.GetSalesReport();

                grid_salesreport.DataSource = dt;
                ShowSalesSummary(dt);

                if (grid_salesreport.Columns["SaleID"] != null)
                {
                    grid_salesreport.Columns["SaleID"].Visible = false;
                }

                if (grid_salesreport.Columns["Items"] != null)
                {
                    grid_salesreport.Columns["Items"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }

                SetSalesReportHeaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load sales report error:\n" + ex.Message);
            }
        }

        private void ShowSalesSummary(DataTable dt)
        {
            decimal totalSales = 0;

            foreach (DataRow row in dt.Rows)
            {
                totalSales += Convert.ToDecimal(row["TotalPrice"]);
            }

            lbl_total_orders.Text = dt.Rows.Count.ToString();
            lbl_total_sales.Text = totalSales.ToString("0.00");
        }

        private void SetSalesReportHeaders()
        {
            if (grid_salesreport.Columns["CustomerPhone"] != null)
            {
                grid_salesreport.Columns["CustomerPhone"].HeaderText = "Phone";
            }

            if (grid_salesreport.Columns["StaffName"] != null)
            {
                grid_salesreport.Columns["StaffName"].HeaderText = "Sold By";
            }

            if (grid_salesreport.Columns["SaleDate"] != null)
            {
                grid_salesreport.Columns["SaleDate"].HeaderText = "Date";
            }

            if (grid_salesreport.Columns["TotalPrice"] != null)
            {
                grid_salesreport.Columns["TotalPrice"].HeaderText = "Total Price";
            }
        }

        private void ClearFields()
        {
            selectedUserId = 0;
            field_fullname.Clear();
            field_usename.Clear();
            field_password.Clear();
            combo_role.SelectedIndex = -1;
            field_fullname.Focus();
        }

        private bool CheckFields()
        {
            if (string.IsNullOrWhiteSpace(field_fullname.Text) ||
                string.IsNullOrWhiteSpace(field_usename.Text) ||
                string.IsNullOrWhiteSpace(field_password.Text) ||
                combo_role.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields.");
                return false;
            }

            return true;
        }

        private void ClearMenuFields()
        {
            selectedItemId = 0;
            field_itemname.Clear();
            field_menu_price.Clear();
            combo_menu_status.SelectedIndex = -1;
            field_itemname.Focus();
        }

        private bool CheckMenuFields()
        {
            decimal price;

            if (string.IsNullOrWhiteSpace(field_itemname.Text) ||
                string.IsNullOrWhiteSpace(field_menu_price.Text) ||
                combo_menu_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields.");
                return false;
            }

            if (!decimal.TryParse(field_menu_price.Text.Trim(), out price))
            {
                MessageBox.Show("Please enter a valid price.");
                return false;
            }

            return true;
        }

        private void btn_create_Click(object? sender, EventArgs e)
        {
            if (!CheckFields())
            {
                return;
            }

            try
            {
                dataAccess.InsertUser(
                    field_fullname.Text.Trim(),
                    field_usename.Text.Trim(),
                    field_password.Text.Trim(),
                    combo_role.Text);

                MessageBox.Show("User created successfully.");
                LoadUsers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Create user error:\n" + ex.Message);
            }
        }

        private void btn_update_Click(object? sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Please select a user first.");
                return;
            }

            if (!CheckFields())
            {
                return;
            }

            try
            {
                dataAccess.UpdateUser(
                    selectedUserId,
                    field_fullname.Text.Trim(),
                    field_usename.Text.Trim(),
                    field_password.Text.Trim(),
                    combo_role.Text);

                MessageBox.Show("User updated successfully.");
                LoadUsers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update user error:\n" + ex.Message);
            }
        }

        private void btn_delete_Click(object? sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Please select a user first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this user?",
                "Delete User",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                dataAccess.DeleteUser(selectedUserId);

                MessageBox.Show("User deleted successfully.");
                LoadUsers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete user error:\n" + ex.Message);
            }
        }

        private void btn_clear_Click(object? sender, EventArgs e)
        {
            ClearFields();
        }

        private void field_search_TextChanged(object? sender, EventArgs e)
        {
            try
            {
                string searchText = field_search.Text.Trim();

                if (searchText == "" || searchText == "Search User By Name")
                {
                    LoadUsers();
                }
                else
                {
                    grid_users.DataSource = dataAccess.SearchUsers(searchText);

                    if (grid_users.Columns["UserID"] != null)
                    {
                        grid_users.Columns["UserID"].Visible = false;
                    }

                    if (grid_users.Columns["Password"] != null)
                    {
                        grid_users.Columns["Password"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search user error:\n" + ex.Message);
            }
        }

        private void grid_users_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = grid_users.Rows[e.RowIndex];

            selectedUserId = Convert.ToInt32(row.Cells["UserID"].Value);
            field_fullname.Text = row.Cells["FullName"].Value.ToString();
            field_usename.Text = row.Cells["Username"].Value.ToString();
            field_password.Text = row.Cells["Password"].Value.ToString();
            combo_role.Text = row.Cells["Role"].Value.ToString();
        }

        private void btn_menu_create_Click(object? sender, EventArgs e)
        {
            if (!CheckMenuFields())
            {
                return;
            }

            try
            {
                dataAccess.InsertMenuItem(
                    field_itemname.Text.Trim(),
                    Convert.ToDecimal(field_menu_price.Text.Trim()),
                    combo_menu_status.Text);

                MessageBox.Show("Menu item created successfully.");
                LoadMenuItems();
                ClearMenuFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Create menu item error:\n" + ex.Message);
            }
        }

        private void btn_menu_update_Click(object? sender, EventArgs e)
        {
            if (selectedItemId == 0)
            {
                MessageBox.Show("Please select a menu item first.");
                return;
            }

            if (!CheckMenuFields())
            {
                return;
            }

            try
            {
                dataAccess.UpdateMenuItem(
                    selectedItemId,
                    field_itemname.Text.Trim(),
                    Convert.ToDecimal(field_menu_price.Text.Trim()),
                    combo_menu_status.Text);

                MessageBox.Show("Menu item updated successfully.");
                LoadMenuItems();
                ClearMenuFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update menu item error:\n" + ex.Message);
            }
        }

        private void btn_menu_delete_Click(object? sender, EventArgs e)
        {
            if (selectedItemId == 0)
            {
                MessageBox.Show("Please select a menu item first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this menu item?",
                "Delete Menu Item",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                dataAccess.DeleteMenuItem(selectedItemId);

                MessageBox.Show("Menu item deleted successfully.");
                LoadMenuItems();
                ClearMenuFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete menu item error:\n" + ex.Message);
            }
        }

        private void btn_menu_clear_Click(object? sender, EventArgs e)
        {
            ClearMenuFields();
        }

        private void field_menu_search_TextChanged(object? sender, EventArgs e)
        {
            try
            {
                string searchText = field_menu_search.Text.Trim();

                if (searchText == "" || searchText == "Search Menu By Name")
                {
                    LoadMenuItems();
                }
                else
                {
                    grid_menuitems.DataSource = dataAccess.SearchMenuItems(searchText);

                    if (grid_menuitems.Columns["ItemID"] != null)
                    {
                        grid_menuitems.Columns["ItemID"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search menu item error:\n" + ex.Message);
            }
        }

        private void grid_menuitems_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = grid_menuitems.Rows[e.RowIndex];

            selectedItemId = Convert.ToInt32(row.Cells["ItemID"].Value);
            field_itemname.Text = row.Cells["ItemName"].Value.ToString();
            field_menu_price.Text = row.Cells["Price"].Value.ToString();
            combo_menu_status.Text = row.Cells["Status"].Value.ToString();
        }

        private void field_sales_search_TextChanged(object? sender, EventArgs e)
        {
            try
            {
                string searchText = field_sales_search.Text.Trim();

                if (searchText == "" || searchText == "Search Sales Report")
                {
                    LoadSalesReport();
                }
                else
                {
                    DataTable dt = dataAccess.SearchSalesReport(searchText);

                    grid_salesreport.DataSource = dt;
                    ShowSalesSummary(dt);

                    if (grid_salesreport.Columns["SaleID"] != null)
                    {
                        grid_salesreport.Columns["SaleID"].Visible = false;
                    }

                    if (grid_salesreport.Columns["Items"] != null)
                    {
                        grid_salesreport.Columns["Items"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    }

                    SetSalesReportHeaders();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search sales report error:\n" + ex.Message);
            }
        }

        private void field_sales_search_Click(object? sender, EventArgs e)
        {
            if (field_sales_search.Text == "Search Sales Report")
            {
                field_sales_search.Clear();
            }
        }

        private void btn_sales_clear_Click(object? sender, EventArgs e)
        {
            field_sales_search.Clear();
            LoadSalesReport();
        }


    }
}
