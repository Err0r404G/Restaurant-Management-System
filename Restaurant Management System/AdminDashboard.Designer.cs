namespace Restaurant_Management_System
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_usermanagement = new Button();
            panel_btn = new Panel();
            lbl_username = new Label();
            btn_salesreport = new Button();
            btn_logout = new Button();
            btn_menumanagement = new Button();
            panel_usermanagement = new Panel();
            field_search = new TextBox();
            label5 = new Label();
            grid_users = new DataGridView();
            panel_usercrud = new Panel();
            btn_clear = new Button();
            btn_delete = new Button();
            btn_update = new Button();
            btn_create = new Button();
            combo_role = new ComboBox();
            field_password = new TextBox();
            field_usename = new TextBox();
            field_fullname = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel_menumanagement = new Panel();
            field_menu_search = new TextBox();
            label9 = new Label();
            grid_menuitems = new DataGridView();
            panel_menucrud = new Panel();
            btn_menu_clear = new Button();
            btn_menu_delete = new Button();
            btn_menu_update = new Button();
            btn_menu_create = new Button();
            combo_menu_status = new ComboBox();
            field_menu_price = new TextBox();
            field_itemname = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            panel_salesreport = new Panel();
            btn_sales_clear = new Button();
            field_sales_search = new TextBox();
            label10 = new Label();
            grid_salesreport = new DataGridView();
            panel_salessummary = new Panel();
            lbl_total_sales = new Label();
            lbl_total_orders = new Label();
            label12 = new Label();
            label11 = new Label();
            panel_btn.SuspendLayout();
            panel_usermanagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_users).BeginInit();
            panel_usercrud.SuspendLayout();
            panel_menumanagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_menuitems).BeginInit();
            panel_menucrud.SuspendLayout();
            panel_salesreport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_salesreport).BeginInit();
            panel_salessummary.SuspendLayout();
            SuspendLayout();
            // 
            // btn_usermanagement
            // 
            btn_usermanagement.Cursor = Cursors.Hand;
            btn_usermanagement.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_usermanagement.Location = new Point(36, 185);
            btn_usermanagement.Name = "btn_usermanagement";
            btn_usermanagement.Size = new Size(177, 50);
            btn_usermanagement.TabIndex = 0;
            btn_usermanagement.Text = "USER MANAGEMENT";
            btn_usermanagement.UseVisualStyleBackColor = true;
            // 
            // panel_btn
            // 
            panel_btn.BackColor = SystemColors.ButtonShadow;
            panel_btn.Controls.Add(lbl_username);
            panel_btn.Controls.Add(btn_salesreport);
            panel_btn.Controls.Add(btn_logout);
            panel_btn.Controls.Add(btn_menumanagement);
            panel_btn.Controls.Add(btn_usermanagement);
            panel_btn.Location = new Point(1, 0);
            panel_btn.Name = "panel_btn";
            panel_btn.Size = new Size(250, 642);
            panel_btn.TabIndex = 1;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_username.Location = new Point(25, 21);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(91, 25);
            lbl_username.TabIndex = 4;
            lbl_username.Text = "Welcome,";
            // 
            // btn_salesreport
            // 
            btn_salesreport.Cursor = Cursors.Hand;
            btn_salesreport.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_salesreport.Location = new Point(36, 366);
            btn_salesreport.Name = "btn_salesreport";
            btn_salesreport.Size = new Size(177, 50);
            btn_salesreport.TabIndex = 3;
            btn_salesreport.Text = "SALES REPORT";
            btn_salesreport.UseVisualStyleBackColor = true;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.Red;
            btn_logout.Cursor = Cursors.Hand;
            btn_logout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_logout.Location = new Point(63, 566);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(105, 50);
            btn_logout.TabIndex = 2;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = false;
            // 
            // btn_menumanagement
            // 
            btn_menumanagement.Cursor = Cursors.Hand;
            btn_menumanagement.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_menumanagement.Location = new Point(36, 276);
            btn_menumanagement.Name = "btn_menumanagement";
            btn_menumanagement.Size = new Size(177, 50);
            btn_menumanagement.TabIndex = 1;
            btn_menumanagement.Text = "MENU MANAGEMENT";
            btn_menumanagement.UseVisualStyleBackColor = true;
            // 
            // panel_usermanagement
            // 
            panel_usermanagement.BackColor = SystemColors.Info;
            panel_usermanagement.Controls.Add(field_search);
            panel_usermanagement.Controls.Add(label5);
            panel_usermanagement.Controls.Add(grid_users);
            panel_usermanagement.Controls.Add(panel_usercrud);
            panel_usermanagement.Location = new Point(257, 0);
            panel_usermanagement.Name = "panel_usermanagement";
            panel_usermanagement.Size = new Size(1069, 642);
            panel_usermanagement.TabIndex = 2;
            // 
            // field_search
            // 
            field_search.Location = new Point(724, 320);
            field_search.Name = "field_search";
            field_search.PlaceholderText = "Search User By Name";
            field_search.Size = new Size(319, 27);
            field_search.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(31, 322);
            label5.Name = "label5";
            label5.Size = new Size(99, 25);
            label5.TabIndex = 5;
            label5.Text = "USERS LIST";
            // 
            // grid_users
            // 
            grid_users.AllowUserToAddRows = false;
            grid_users.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            grid_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_users.ColumnHeadersVisible = false;
            grid_users.Location = new Point(30, 366);
            grid_users.Name = "grid_users";
            grid_users.RowHeadersWidth = 51;
            grid_users.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_users.Size = new Size(1013, 250);
            grid_users.TabIndex = 4;
            // 
            // panel_usercrud
            // 
            panel_usercrud.BackColor = SystemColors.ActiveBorder;
            panel_usercrud.Controls.Add(btn_clear);
            panel_usercrud.Controls.Add(btn_delete);
            panel_usercrud.Controls.Add(btn_update);
            panel_usercrud.Controls.Add(btn_create);
            panel_usercrud.Controls.Add(combo_role);
            panel_usercrud.Controls.Add(field_password);
            panel_usercrud.Controls.Add(field_usename);
            panel_usercrud.Controls.Add(field_fullname);
            panel_usercrud.Controls.Add(label4);
            panel_usercrud.Controls.Add(label3);
            panel_usercrud.Controls.Add(label2);
            panel_usercrud.Controls.Add(label1);
            panel_usercrud.Location = new Point(30, 21);
            panel_usercrud.Name = "panel_usercrud";
            panel_usercrud.Size = new Size(1013, 272);
            panel_usercrud.TabIndex = 3;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = SystemColors.ActiveCaptionText;
            btn_clear.Cursor = Cursors.Hand;
            btn_clear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_clear.ForeColor = SystemColors.ButtonHighlight;
            btn_clear.Location = new Point(287, 219);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(105, 34);
            btn_clear.TabIndex = 10;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = SystemColors.ActiveCaption;
            btn_delete.Location = new Point(776, 185);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(193, 48);
            btn_delete.TabIndex = 9;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_update
            // 
            btn_update.BackColor = SystemColors.ActiveCaption;
            btn_update.Location = new Point(776, 111);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(193, 48);
            btn_update.TabIndex = 8;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_create
            // 
            btn_create.BackColor = SystemColors.ActiveCaption;
            btn_create.Location = new Point(776, 35);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(193, 48);
            btn_create.TabIndex = 7;
            btn_create.Text = "Create";
            btn_create.UseVisualStyleBackColor = false;
            // 
            // combo_role
            // 
            combo_role.FormattingEnabled = true;
            combo_role.Items.AddRange(new object[] { "Admin", "Staff" });
            combo_role.Location = new Point(113, 223);
            combo_role.Name = "combo_role";
            combo_role.Size = new Size(151, 28);
            combo_role.TabIndex = 7;
            // 
            // field_password
            // 
            field_password.Location = new Point(113, 159);
            field_password.Name = "field_password";
            field_password.PasswordChar = '*';
            field_password.Size = new Size(279, 27);
            field_password.TabIndex = 6;
            field_password.UseSystemPasswordChar = true;
            // 
            // field_usename
            // 
            field_usename.Location = new Point(113, 113);
            field_usename.Name = "field_usename";
            field_usename.Size = new Size(279, 27);
            field_usename.TabIndex = 5;
            // 
            // field_fullname
            // 
            field_fullname.Location = new Point(113, 63);
            field_fullname.Name = "field_fullname";
            field_fullname.Size = new Size(279, 27);
            field_fullname.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(63, 226);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 3;
            label4.Text = "Role";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 63);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 2;
            label3.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 159);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 113);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // panel_menumanagement
            // 
            panel_menumanagement.BackColor = SystemColors.Info;
            panel_menumanagement.Controls.Add(field_menu_search);
            panel_menumanagement.Controls.Add(label9);
            panel_menumanagement.Controls.Add(panel_menucrud);
            panel_menumanagement.Controls.Add(grid_menuitems);
            panel_menumanagement.Location = new Point(257, 0);
            panel_menumanagement.Name = "panel_menumanagement";
            panel_menumanagement.Size = new Size(1069, 642);
            panel_menumanagement.TabIndex = 0;
            // 
            // field_menu_search
            // 
            field_menu_search.Location = new Point(724, 320);
            field_menu_search.Name = "field_menu_search";
            field_menu_search.PlaceholderText = "Search Menu By Name";
            field_menu_search.Size = new Size(319, 27);
            field_menu_search.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(31, 322);
            label9.Name = "label9";
            label9.Size = new Size(93, 25);
            label9.TabIndex = 9;
            label9.Text = "MENU LIST";
            // 
            // grid_menuitems
            // 
            grid_menuitems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_menuitems.Location = new Point(30, 366);
            grid_menuitems.Name = "grid_menuitems";
            grid_menuitems.RowHeadersWidth = 51;
            grid_menuitems.Size = new Size(1013, 250);
            grid_menuitems.TabIndex = 8;
            // 
            // panel_menucrud
            // 
            panel_menucrud.BackColor = SystemColors.ActiveBorder;
            panel_menucrud.Controls.Add(btn_menu_clear);
            panel_menucrud.Controls.Add(btn_menu_delete);
            panel_menucrud.Controls.Add(btn_menu_update);
            panel_menucrud.Controls.Add(btn_menu_create);
            panel_menucrud.Controls.Add(combo_menu_status);
            panel_menucrud.Controls.Add(field_menu_price);
            panel_menucrud.Controls.Add(field_itemname);
            panel_menucrud.Controls.Add(label8);
            panel_menucrud.Controls.Add(label7);
            panel_menucrud.Controls.Add(label6);
            panel_menucrud.Location = new Point(30, 21);
            panel_menucrud.Name = "panel_menucrud";
            panel_menucrud.Size = new Size(1013, 272);
            panel_menucrud.TabIndex = 7;
            // 
            // btn_menu_clear
            // 
            btn_menu_clear.BackColor = SystemColors.ActiveCaptionText;
            btn_menu_clear.Cursor = Cursors.Hand;
            btn_menu_clear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_menu_clear.ForeColor = SystemColors.ButtonHighlight;
            btn_menu_clear.Location = new Point(287, 219);
            btn_menu_clear.Name = "btn_menu_clear";
            btn_menu_clear.Size = new Size(105, 34);
            btn_menu_clear.TabIndex = 10;
            btn_menu_clear.Text = "Clear";
            btn_menu_clear.UseVisualStyleBackColor = false;
            // 
            // btn_menu_delete
            // 
            btn_menu_delete.BackColor = SystemColors.ActiveCaption;
            btn_menu_delete.Location = new Point(776, 185);
            btn_menu_delete.Name = "btn_menu_delete";
            btn_menu_delete.Size = new Size(193, 48);
            btn_menu_delete.TabIndex = 9;
            btn_menu_delete.Text = "Delete";
            btn_menu_delete.UseVisualStyleBackColor = false;
            // 
            // btn_menu_update
            // 
            btn_menu_update.BackColor = SystemColors.ActiveCaption;
            btn_menu_update.Location = new Point(776, 111);
            btn_menu_update.Name = "btn_menu_update";
            btn_menu_update.Size = new Size(193, 48);
            btn_menu_update.TabIndex = 8;
            btn_menu_update.Text = "Update";
            btn_menu_update.UseVisualStyleBackColor = false;
            // 
            // btn_menu_create
            // 
            btn_menu_create.BackColor = SystemColors.ActiveCaption;
            btn_menu_create.Location = new Point(776, 35);
            btn_menu_create.Name = "btn_menu_create";
            btn_menu_create.Size = new Size(193, 48);
            btn_menu_create.TabIndex = 7;
            btn_menu_create.Text = "Create";
            btn_menu_create.UseVisualStyleBackColor = false;
            // 
            // combo_menu_status
            // 
            combo_menu_status.FormattingEnabled = true;
            combo_menu_status.Items.AddRange(new object[] { "Available", "Unavailable" });
            combo_menu_status.Location = new Point(113, 223);
            combo_menu_status.Name = "combo_menu_status";
            combo_menu_status.Size = new Size(151, 28);
            combo_menu_status.TabIndex = 6;
            // 
            // field_menu_price
            // 
            field_menu_price.Location = new Point(113, 136);
            field_menu_price.Name = "field_menu_price";
            field_menu_price.Size = new Size(279, 27);
            field_menu_price.TabIndex = 5;
            // 
            // field_itemname
            // 
            field_itemname.Location = new Point(113, 63);
            field_itemname.Name = "field_itemname";
            field_itemname.Size = new Size(279, 27);
            field_itemname.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(48, 226);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 2;
            label8.Text = "Status";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(59, 136);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 1;
            label7.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 63);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 0;
            label6.Text = "Item Name";
            // 
            // panel_salesreport
            // 
            panel_salesreport.BackColor = SystemColors.Info;
            panel_salesreport.Controls.Add(btn_sales_clear);
            panel_salesreport.Controls.Add(field_sales_search);
            panel_salesreport.Controls.Add(label10);
            panel_salesreport.Controls.Add(grid_salesreport);
            panel_salesreport.Controls.Add(panel_salessummary);
            panel_salesreport.Location = new Point(257, 0);
            panel_salesreport.Name = "panel_salesreport";
            panel_salesreport.Size = new Size(1069, 642);
            panel_salesreport.TabIndex = 0;
            // 
            // btn_sales_clear
            // 
            btn_sales_clear.BackColor = SystemColors.ActiveCaptionText;
            btn_sales_clear.Cursor = Cursors.Hand;
            btn_sales_clear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_sales_clear.ForeColor = SystemColors.ButtonHighlight;
            btn_sales_clear.Location = new Point(912, 180);
            btn_sales_clear.Name = "btn_sales_clear";
            btn_sales_clear.Size = new Size(128, 34);
            btn_sales_clear.TabIndex = 4;
            btn_sales_clear.Text = "Clear";
            btn_sales_clear.UseVisualStyleBackColor = false;
            // 
            // field_sales_search
            // 
            field_sales_search.Location = new Point(559, 182);
            field_sales_search.Multiline = true;
            field_sales_search.Name = "field_sales_search";
            field_sales_search.PlaceholderText = "Search Sales Report";
            field_sales_search.Size = new Size(334, 27);
            field_sales_search.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(31, 182);
            label10.Name = "label10";
            label10.Size = new Size(122, 25);
            label10.TabIndex = 2;
            label10.Text = "SALES REPORT";
            // 
            // grid_salesreport
            // 
            grid_salesreport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_salesreport.Location = new Point(30, 228);
            grid_salesreport.Name = "grid_salesreport";
            grid_salesreport.RowHeadersWidth = 51;
            grid_salesreport.Size = new Size(1013, 388);
            grid_salesreport.TabIndex = 1;
            // 
            // panel_salessummary
            // 
            panel_salessummary.BackColor = SystemColors.ActiveBorder;
            panel_salessummary.Controls.Add(lbl_total_sales);
            panel_salessummary.Controls.Add(lbl_total_orders);
            panel_salessummary.Controls.Add(label12);
            panel_salessummary.Controls.Add(label11);
            panel_salessummary.Location = new Point(30, 21);
            panel_salessummary.Name = "panel_salessummary";
            panel_salessummary.Size = new Size(1013, 130);
            panel_salessummary.TabIndex = 0;
            // 
            // lbl_total_sales
            // 
            lbl_total_sales.AutoSize = true;
            lbl_total_sales.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_total_sales.Location = new Point(652, 62);
            lbl_total_sales.Name = "lbl_total_sales";
            lbl_total_sales.Size = new Size(77, 41);
            lbl_total_sales.TabIndex = 3;
            lbl_total_sales.Text = "0.00";
            // 
            // lbl_total_orders
            // 
            lbl_total_orders.AutoSize = true;
            lbl_total_orders.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_total_orders.Location = new Point(164, 62);
            lbl_total_orders.Name = "lbl_total_orders";
            lbl_total_orders.Size = new Size(35, 41);
            lbl_total_orders.TabIndex = 2;
            lbl_total_orders.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(652, 28);
            label12.Name = "label12";
            label12.Size = new Size(113, 28);
            label12.TabIndex = 1;
            label12.Text = "Total Sales";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(164, 28);
            label11.Name = "label11";
            label11.Size = new Size(128, 28);
            label11.TabIndex = 0;
            label11.Text = "Total Orders";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 642);
            Controls.Add(panel_btn);
            Controls.Add(panel_salesreport);
            Controls.Add(panel_menumanagement);
            Controls.Add(panel_usermanagement);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            panel_btn.ResumeLayout(false);
            panel_btn.PerformLayout();
            panel_usermanagement.ResumeLayout(false);
            panel_usermanagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid_users).EndInit();
            panel_usercrud.ResumeLayout(false);
            panel_usercrud.PerformLayout();
            panel_menumanagement.ResumeLayout(false);
            panel_menumanagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid_menuitems).EndInit();
            panel_menucrud.ResumeLayout(false);
            panel_menucrud.PerformLayout();
            panel_salesreport.ResumeLayout(false);
            panel_salesreport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid_salesreport).EndInit();
            panel_salessummary.ResumeLayout(false);
            panel_salessummary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_usermanagement;
        private Panel panel_btn;
        private Button btn_salesreport;
        private Button btn_logout;
        private Button btn_menumanagement;
        private Panel panel_usermanagement;
        private Panel panel_menumanagement;
        private Panel panel_salesreport;
        private Label lbl_username;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel_usercrud;
        private TextBox field_search;
        private Label label5;
        private DataGridView grid_users;
        private ComboBox combo_role;
        private TextBox field_password;
        private TextBox field_usename;
        private TextBox field_fullname;
        private Label label4;
        private Button btn_clear;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_create;
        private Panel panel_menucrud;
        private Button btn_menu_clear;
        private Button btn_menu_delete;
        private Button btn_menu_update;
        private Button btn_menu_create;
        private ComboBox combo_menu_status;
        private TextBox field_menu_price;
        private TextBox field_itemname;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox field_menu_search;
        private Label label9;
        private DataGridView grid_menuitems;
        private Panel panel_salessummary;
        private Label lbl_total_sales;
        private Label lbl_total_orders;
        private Label label12;
        private Label label11;
        private TextBox field_sales_search;
        private Label label10;
        private DataGridView grid_salesreport;
        private Button btn_sales_clear;
    }
}
