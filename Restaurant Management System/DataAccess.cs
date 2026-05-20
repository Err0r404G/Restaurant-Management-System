using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Restaurant_Management_System
{
    internal class DataAccess
    {
        private readonly string connectionString =
            @"Data Source=VICTUS-24H2\SQLEXPRESS;
              Initial Catalog=RestaurantDataBase;
              Persist Security Info=True;
              User ID=sa;
              Password=@1812;
              TrustServerCertificate=True;";

        // EXECUTE SELECT QUERY
        public DataTable ExecuteQuery(string query)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                return dt;
            }
        }

        // EXECUTE INSERT UPDATE DELETE
        public int ExecuteNonQuery(string query)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                return cmd.ExecuteNonQuery();
            }
        }

        ////////////////////////////////// LOGIN //////////////////////////////////

        public bool ValidateUser(string username, string password, out string role, out int userId, out string fullName)
        {
            role = "";
            userId = 0;
            fullName = "";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query =
                    "SELECT UserID, FullName, Role FROM Users WHERE Username=@username AND Password=@password";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    userId = Convert.ToInt32(reader["UserID"]);

                    fullName = reader["FullName"].ToString()!;

                    role = reader["Role"].ToString()!;

                    return true;
                }

                return false;
            }
        }

        ////////////////////////////////// USER CRUD //////////////////////////////////

        // GET USERS
        public DataTable GetUsers()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query =
                    @"SELECT UserID, FullName, Username, Password, Role
                    FROM Users
                    ORDER BY UserID DESC";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                return dt;
            }
        }

        // SEARCH USERS
        public DataTable SearchUsers(string searchText)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query =
                    @"SELECT UserID, FullName, Username, Password, Role
                    FROM Users
                    WHERE FullName LIKE @SearchText OR Username LIKE @SearchText
                    ORDER BY UserID DESC";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                sda.SelectCommand.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                DataTable dt = new DataTable();

                sda.Fill(dt);

                return dt;
            }
        }

        // INSERT USER
        public int InsertUser(string fullName, string username, string password, string role)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query =
                    @"INSERT INTO Users
                    (FullName, Username, Password, Role)
                    VALUES
                    (@FullName, @Username, @Password, @Role)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Role", role);

                con.Open();

                return cmd.ExecuteNonQuery();
            }
        }

        // UPDATE USER
        public int UpdateUser(int userId, string fullName, string username, string password, string role)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query =
                    @"UPDATE Users SET
                    FullName=@FullName,
                    Username=@Username,
                    Password=@Password,
                    Role=@Role
                    WHERE UserID=@UserID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Role", role);

                con.Open();

                return cmd.ExecuteNonQuery();
            }
        }

        // DELETE USER
        public int DeleteUser(int userId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query =
                    "DELETE FROM Users WHERE UserID=@UserID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@UserID", userId);

                con.Open();

                return cmd.ExecuteNonQuery();
            }
        }

        ////////////////////////////////// MENU ITEM CRUD //////////////////////////////////

        // GET MENU ITEMS
        public DataTable GetMenuItems()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query =
                    @"SELECT ItemID, ItemName, Price, Status
                    FROM MenuItems
                    ORDER BY ItemID DESC";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                return dt;
            }
        }

        // GET AVAILABLE MENU ITEMS
        public DataTable GetAvailableMenuItems()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query =
                    @"SELECT ItemID, ItemName, Price, Status
                    FROM MenuItems
                    WHERE Status='Available'
                    ORDER BY ItemID DESC";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                return dt;
            }
        }

        // SEARCH MENU ITEMS
        public DataTable SearchMenuItems(string searchText)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query =
                    @"SELECT ItemID, ItemName, Price, Status
                    FROM MenuItems
                    WHERE ItemName LIKE @SearchText OR Status LIKE @SearchText
                    ORDER BY ItemID DESC";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                sda.SelectCommand.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                DataTable dt = new DataTable();

                sda.Fill(dt);

                return dt;
            }
        }

        // INSERT MENU ITEM
        public int InsertMenuItem(string itemName, decimal price, string status)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query =
                    @"INSERT INTO MenuItems
                    (ItemName, Price, Status)
                    VALUES
                    (@ItemName, @Price, @Status)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ItemName", itemName);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Status", status);

                con.Open();

                return cmd.ExecuteNonQuery();
            }
        }

        // UPDATE MENU ITEM
        public int UpdateMenuItem(int itemId, string itemName, decimal price, string status)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query =
                    @"UPDATE MenuItems SET
                    ItemName=@ItemName,
                    Price=@Price,
                    Status=@Status
                    WHERE ItemID=@ItemID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ItemID", itemId);
                cmd.Parameters.AddWithValue("@ItemName", itemName);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Status", status);

                con.Open();

                return cmd.ExecuteNonQuery();
            }
        }

        // DELETE MENU ITEM
        public int DeleteMenuItem(int itemId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query =
                    "DELETE FROM MenuItems WHERE ItemID=@ItemID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ItemID", itemId);

                con.Open();

                return cmd.ExecuteNonQuery();
            }
        }

        ////////////////////////////////// SALES //////////////////////////////////

        // ADD ORDER ID COLUMN IF MISSING
        public void EnsureSalesOrderIdColumn()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query =
                    @"IF COL_LENGTH('Sales', 'OrderID') IS NULL
                    BEGIN
                        ALTER TABLE Sales ADD OrderID INT NULL
                    END";

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                cmd.ExecuteNonQuery();
            }
        }

        // GET NEXT ORDER ID
        public int GetNextOrderId()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT ISNULL(MAX(OrderID), 0) + 1 FROM Sales";

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // GET SALES REPORT
        public DataTable GetSalesReport()
        {
            EnsureSalesOrderIdColumn();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query =
                    @"SELECT
                        ISNULL(s.OrderID, s.SaleID) AS OrderID,
                        s.CustomerName,
                        s.CustomerPhone,
                        s.OrderType,
                        u.FullName AS StaffName,
                        m.ItemName,
                        s.Quantity,
                        s.TotalPrice,
                        s.SaleDate
                    FROM Sales s
                    INNER JOIN Users u ON s.StaffID = u.UserID
                    INNER JOIN MenuItems m ON s.ItemID = m.ItemID
                    ORDER BY s.SaleDate DESC";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                return MakeOrderReport(dt, true);
            }
        }

        // SEARCH SALES REPORT
        public DataTable SearchSalesReport(string searchText)
        {
            EnsureSalesOrderIdColumn();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query =
                    @"SELECT
                        ISNULL(s.OrderID, s.SaleID) AS OrderID,
                        s.CustomerName,
                        s.CustomerPhone,
                        s.OrderType,
                        u.FullName AS StaffName,
                        m.ItemName,
                        s.Quantity,
                        s.TotalPrice,
                        s.SaleDate
                    FROM Sales s
                    INNER JOIN Users u ON s.StaffID = u.UserID
                    INNER JOIN MenuItems m ON s.ItemID = m.ItemID
                    WHERE
                        s.CustomerName LIKE @SearchText OR
                        s.CustomerPhone LIKE @SearchText OR
                        s.OrderType LIKE @SearchText OR
                        u.FullName LIKE @SearchText OR
                        m.ItemName LIKE @SearchText
                    ORDER BY s.SaleDate DESC";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                sda.SelectCommand.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                DataTable dt = new DataTable();

                sda.Fill(dt);

                return MakeOrderReport(dt, true);
            }
        }

        // GET STAFF SALES REPORT
        public DataTable GetStaffSalesReport(int staffId)
        {
            EnsureSalesOrderIdColumn();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query =
                    @"SELECT
                        ISNULL(s.OrderID, s.SaleID) AS OrderID,
                        s.CustomerName,
                        s.CustomerPhone,
                        s.OrderType,
                        m.ItemName,
                        s.Quantity,
                        s.TotalPrice,
                        s.SaleDate
                    FROM Sales s
                    INNER JOIN MenuItems m ON s.ItemID = m.ItemID
                    WHERE s.StaffID=@StaffID
                    ORDER BY s.SaleDate DESC";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                sda.SelectCommand.Parameters.AddWithValue("@StaffID", staffId);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                return MakeOrderReport(dt, false);
            }
        }

        // SEARCH STAFF SALES REPORT
        public DataTable SearchStaffSalesReport(int staffId, string searchText)
        {
            EnsureSalesOrderIdColumn();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query =
                    @"SELECT
                        ISNULL(s.OrderID, s.SaleID) AS OrderID,
                        s.CustomerName,
                        s.CustomerPhone,
                        s.OrderType,
                        m.ItemName,
                        s.Quantity,
                        s.TotalPrice,
                        s.SaleDate
                    FROM Sales s
                    INNER JOIN MenuItems m ON s.ItemID = m.ItemID
                    WHERE
                        s.StaffID=@StaffID AND
                        (
                            s.CustomerName LIKE @SearchText OR
                            s.CustomerPhone LIKE @SearchText OR
                            s.OrderType LIKE @SearchText OR
                            m.ItemName LIKE @SearchText
                        )
                    ORDER BY s.SaleDate DESC";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                sda.SelectCommand.Parameters.AddWithValue("@StaffID", staffId);
                sda.SelectCommand.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                DataTable dt = new DataTable();

                sda.Fill(dt);

                return MakeOrderReport(dt, false);
            }
        }

        // MAKE ONE ROW PER ORDER
        private DataTable MakeOrderReport(DataTable salesRows, bool showStaffName)
        {
            DataTable report = new DataTable();

            report.Columns.Add("OrderID", typeof(int));
            report.Columns.Add("CustomerName", typeof(string));
            report.Columns.Add("CustomerPhone", typeof(string));
            report.Columns.Add("OrderType", typeof(string));

            if (showStaffName)
            {
                report.Columns.Add("StaffName", typeof(string));
            }

            report.Columns.Add("Items", typeof(string));
            report.Columns.Add("Quantity", typeof(int));
            report.Columns.Add("TotalPrice", typeof(decimal));
            report.Columns.Add("SaleDate", typeof(DateTime));

            foreach (DataRow saleRow in salesRows.Rows)
            {
                int orderId = Convert.ToInt32(saleRow["OrderID"]);

                DataRow? reportRow = null;

                foreach (DataRow row in report.Rows)
                {
                    if (Convert.ToInt32(row["OrderID"]) == orderId)
                    {
                        reportRow = row;
                        break;
                    }
                }

                string itemText = saleRow["ItemName"].ToString() + " x" + saleRow["Quantity"].ToString();

                if (reportRow == null)
                {
                    reportRow = report.NewRow();
                    reportRow["OrderID"] = orderId;
                    reportRow["CustomerName"] = saleRow["CustomerName"];
                    reportRow["CustomerPhone"] = saleRow["CustomerPhone"];
                    reportRow["OrderType"] = saleRow["OrderType"];

                    if (showStaffName)
                    {
                        reportRow["StaffName"] = saleRow["StaffName"];
                    }

                    reportRow["Items"] = itemText;
                    reportRow["Quantity"] = Convert.ToInt32(saleRow["Quantity"]);
                    reportRow["TotalPrice"] = Convert.ToDecimal(saleRow["TotalPrice"]);
                    reportRow["SaleDate"] = Convert.ToDateTime(saleRow["SaleDate"]);

                    report.Rows.Add(reportRow);
                }
                else
                {
                    reportRow["Items"] = reportRow["Items"].ToString() + ", " + itemText;
                    reportRow["Quantity"] = Convert.ToInt32(reportRow["Quantity"]) + Convert.ToInt32(saleRow["Quantity"]);
                    reportRow["TotalPrice"] = Convert.ToDecimal(reportRow["TotalPrice"]) + Convert.ToDecimal(saleRow["TotalPrice"]);
                }
            }

            return report;
        }

        // INSERT SALE
        public int InsertSale(
            string customerName,
            string customerPhone,
            string orderType,
            int staffId,
            int itemId,
            int quantity,
            decimal unitPrice)
        {
            return InsertSale(customerName, customerPhone, orderType, staffId, itemId, quantity, unitPrice, DateTime.Now);
        }

        // INSERT SALE WITH SAME ORDER DATE
        public int InsertSale(
            string customerName,
            string customerPhone,
            string orderType,
            int staffId,
            int itemId,
            int quantity,
            decimal unitPrice,
            DateTime saleDate)
        {
            int orderId = GetNextOrderId();

            return InsertSale(customerName, customerPhone, orderType, staffId, itemId, quantity, unitPrice, saleDate, orderId);
        }

        // INSERT SALE WITH ORDER ID
        public int InsertSale(
            string customerName,
            string customerPhone,
            string orderType,
            int staffId,
            int itemId,
            int quantity,
            decimal unitPrice,
            DateTime saleDate,
            int orderId)
        {
            decimal totalPrice = quantity * unitPrice;

            EnsureSalesOrderIdColumn();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query =
                    @"INSERT INTO Sales
                    (
                        CustomerName,
                        CustomerPhone,
                        OrderType,
                        StaffID,
                        ItemID,
                        Quantity,
                        UnitPrice,
                        TotalPrice,
                        SaleDate,
                        OrderID
                    )
                    VALUES
                    (
                        @CustomerName,
                        @CustomerPhone,
                        @OrderType,
                        @StaffID,
                        @ItemID,
                        @Quantity,
                        @UnitPrice,
                        @TotalPrice,
                        @SaleDate,
                        @OrderID
                    )";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@CustomerName", customerName);
                cmd.Parameters.AddWithValue("@CustomerPhone", customerPhone);
                cmd.Parameters.AddWithValue("@OrderType", orderType);
                cmd.Parameters.AddWithValue("@StaffID", staffId);
                cmd.Parameters.AddWithValue("@ItemID", itemId);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                cmd.Parameters.AddWithValue("@SaleDate", saleDate);
                cmd.Parameters.AddWithValue("@OrderID", orderId);

                con.Open();

                return cmd.ExecuteNonQuery();
            }
        }
    }
}
