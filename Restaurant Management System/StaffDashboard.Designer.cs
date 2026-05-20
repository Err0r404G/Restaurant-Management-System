namespace Restaurant_Management_System
{
    partial class StaffDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel_btn = new Panel();
            lbl_username = new Label();
            btn_viewsales = new Button();
            btn_logout = new Button();
            btn_order = new Button();
            panel_order = new Panel();
            btn_placeorder = new Button();
            btn_minus = new Button();
            btn_plus = new Button();
            combo_ordertype = new ComboBox();
            field_customerphone = new TextBox();
            field_customername = new TextBox();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            lbl_total = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            grid_cart = new DataGridView();
            grid_menuitems = new DataGridView();
            panel_viewsales = new Panel();
            btn_sales_clear = new Button();
            field_sales_search = new TextBox();
            label6 = new Label();
            grid_staffsales = new DataGridView();
            panel_btn.SuspendLayout();
            panel_order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_cart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grid_menuitems).BeginInit();
            panel_viewsales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_staffsales).BeginInit();
            SuspendLayout();
            // 
            // panel_btn
            // 
            panel_btn.BackColor = SystemColors.ButtonShadow;
            panel_btn.Controls.Add(lbl_username);
            panel_btn.Controls.Add(btn_viewsales);
            panel_btn.Controls.Add(btn_logout);
            panel_btn.Controls.Add(btn_order);
            panel_btn.Location = new Point(1, 0);
            panel_btn.Name = "panel_btn";
            panel_btn.Size = new Size(250, 642);
            panel_btn.TabIndex = 0;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_username.Location = new Point(25, 21);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(91, 25);
            lbl_username.TabIndex = 0;
            lbl_username.Text = "Welcome,";
            // 
            // btn_viewsales
            // 
            btn_viewsales.Cursor = Cursors.Hand;
            btn_viewsales.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_viewsales.Location = new Point(36, 276);
            btn_viewsales.Name = "btn_viewsales";
            btn_viewsales.Size = new Size(177, 50);
            btn_viewsales.TabIndex = 2;
            btn_viewsales.Text = "VIEW SALES";
            btn_viewsales.UseVisualStyleBackColor = true;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.Red;
            btn_logout.Cursor = Cursors.Hand;
            btn_logout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_logout.Location = new Point(63, 566);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(105, 50);
            btn_logout.TabIndex = 3;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = false;
            // 
            // btn_order
            // 
            btn_order.Cursor = Cursors.Hand;
            btn_order.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_order.Location = new Point(36, 185);
            btn_order.Name = "btn_order";
            btn_order.Size = new Size(177, 50);
            btn_order.TabIndex = 1;
            btn_order.Text = "ORDER";
            btn_order.UseVisualStyleBackColor = true;
            // 
            // panel_order
            // 
            panel_order.BackColor = SystemColors.Info;
            panel_order.Controls.Add(btn_placeorder);
            panel_order.Controls.Add(btn_minus);
            panel_order.Controls.Add(btn_plus);
            panel_order.Controls.Add(combo_ordertype);
            panel_order.Controls.Add(field_customerphone);
            panel_order.Controls.Add(field_customername);
            panel_order.Controls.Add(label7);
            panel_order.Controls.Add(label4);
            panel_order.Controls.Add(label3);
            panel_order.Controls.Add(lbl_total);
            panel_order.Controls.Add(label5);
            panel_order.Controls.Add(label2);
            panel_order.Controls.Add(label1);
            panel_order.Controls.Add(grid_cart);
            panel_order.Controls.Add(grid_menuitems);
            panel_order.Location = new Point(257, 0);
            panel_order.Name = "panel_order";
            panel_order.Size = new Size(1069, 642);
            panel_order.TabIndex = 1;
            // 
            // btn_placeorder
            // 
            btn_placeorder.BackColor = SystemColors.ActiveCaption;
            btn_placeorder.Cursor = Cursors.Hand;
            btn_placeorder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_placeorder.Location = new Point(832, 546);
            btn_placeorder.Name = "btn_placeorder";
            btn_placeorder.Size = new Size(193, 48);
            btn_placeorder.TabIndex = 12;
            btn_placeorder.Text = "Place Order";
            btn_placeorder.UseVisualStyleBackColor = false;
            // 
            // btn_minus
            // 
            btn_minus.BackColor = SystemColors.ActiveCaptionText;
            btn_minus.Cursor = Cursors.Hand;
            btn_minus.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_minus.ForeColor = SystemColors.ButtonHighlight;
            btn_minus.Location = new Point(914, 306);
            btn_minus.Name = "btn_minus";
            btn_minus.Size = new Size(48, 44);
            btn_minus.TabIndex = 11;
            btn_minus.Text = "-";
            btn_minus.UseVisualStyleBackColor = false;
            // 
            // btn_plus
            // 
            btn_plus.BackColor = SystemColors.ActiveCaptionText;
            btn_plus.Cursor = Cursors.Hand;
            btn_plus.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_plus.ForeColor = SystemColors.ButtonHighlight;
            btn_plus.Location = new Point(977, 306);
            btn_plus.Name = "btn_plus";
            btn_plus.Size = new Size(48, 44);
            btn_plus.TabIndex = 10;
            btn_plus.Text = "+";
            btn_plus.UseVisualStyleBackColor = false;
            // 
            // combo_ordertype
            // 
            combo_ordertype.FormattingEnabled = true;
            combo_ordertype.Items.AddRange(new object[] { "Dine In", "Take Away" });
            combo_ordertype.Location = new Point(192, 586);
            combo_ordertype.Name = "combo_ordertype";
            combo_ordertype.Size = new Size(191, 28);
            combo_ordertype.TabIndex = 9;
            // 
            // field_customerphone
            // 
            field_customerphone.Location = new Point(192, 548);
            field_customerphone.Name = "field_customerphone";
            field_customerphone.Size = new Size(279, 27);
            field_customerphone.TabIndex = 13;
            // 
            // field_customername
            // 
            field_customername.Location = new Point(192, 510);
            field_customername.Name = "field_customername";
            field_customername.Size = new Size(279, 27);
            field_customername.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(56, 551);
            label7.Name = "label7";
            label7.Size = new Size(125, 20);
            label7.TabIndex = 14;
            label7.Text = "Customer Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(95, 589);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 7;
            label4.Text = "Order Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(65, 513);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 6;
            label3.Text = "Customer Name";
            // 
            // lbl_total
            // 
            lbl_total.AutoSize = true;
            lbl_total.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_total.Location = new Point(657, 551);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(77, 41);
            lbl_total.TabIndex = 5;
            lbl_total.Text = "0.00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(554, 559);
            label5.Name = "label5";
            label5.Size = new Size(64, 28);
            label5.TabIndex = 4;
            label5.Text = "Total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 306);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 3;
            label2.Text = "CUSTOMER TAB";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 21);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 2;
            label1.Text = "MENU LIST";
            // 
            // grid_cart
            // 
            grid_cart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_cart.Location = new Point(30, 356);
            grid_cart.Name = "grid_cart";
            grid_cart.RowHeadersWidth = 51;
            grid_cart.Size = new Size(1013, 132);
            grid_cart.TabIndex = 1;
            // 
            // grid_menuitems
            // 
            grid_menuitems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_menuitems.Location = new Point(30, 58);
            grid_menuitems.Name = "grid_menuitems";
            grid_menuitems.RowHeadersWidth = 51;
            grid_menuitems.Size = new Size(1013, 230);
            grid_menuitems.TabIndex = 0;
            // 
            // panel_viewsales
            // 
            panel_viewsales.BackColor = SystemColors.Info;
            panel_viewsales.Controls.Add(btn_sales_clear);
            panel_viewsales.Controls.Add(field_sales_search);
            panel_viewsales.Controls.Add(label6);
            panel_viewsales.Controls.Add(grid_staffsales);
            panel_viewsales.Location = new Point(257, 0);
            panel_viewsales.Name = "panel_viewsales";
            panel_viewsales.Size = new Size(1069, 642);
            panel_viewsales.TabIndex = 2;
            // 
            // btn_sales_clear
            // 
            btn_sales_clear.BackColor = SystemColors.ActiveCaptionText;
            btn_sales_clear.Cursor = Cursors.Hand;
            btn_sales_clear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_sales_clear.ForeColor = SystemColors.ButtonHighlight;
            btn_sales_clear.Location = new Point(914, 19);
            btn_sales_clear.Name = "btn_sales_clear";
            btn_sales_clear.Size = new Size(128, 34);
            btn_sales_clear.TabIndex = 3;
            btn_sales_clear.Text = "Clear";
            btn_sales_clear.UseVisualStyleBackColor = false;
            // 
            // field_sales_search
            // 
            field_sales_search.Location = new Point(589, 23);
            field_sales_search.Name = "field_sales_search";
            field_sales_search.PlaceholderText = "Search Sales";
            field_sales_search.Size = new Size(319, 27);
            field_sales_search.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(31, 21);
            label6.Name = "label6";
            label6.Size = new Size(85, 25);
            label6.TabIndex = 1;
            label6.Text = "MY SALES";
            // 
            // grid_staffsales
            // 
            grid_staffsales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_staffsales.Location = new Point(30, 65);
            grid_staffsales.Name = "grid_staffsales";
            grid_staffsales.RowHeadersWidth = 51;
            grid_staffsales.Size = new Size(1013, 551);
            grid_staffsales.TabIndex = 0;
            // 
            // StaffDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 642);
            Controls.Add(panel_btn);
            Controls.Add(panel_viewsales);
            Controls.Add(panel_order);
            Name = "StaffDashboard";
            Text = "Staff Dashboard";
            panel_btn.ResumeLayout(false);
            panel_btn.PerformLayout();
            panel_order.ResumeLayout(false);
            panel_order.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid_cart).EndInit();
            ((System.ComponentModel.ISupportInitialize)grid_menuitems).EndInit();
            panel_viewsales.ResumeLayout(false);
            panel_viewsales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid_staffsales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_btn;
        private Label lbl_username;
        private Button btn_viewsales;
        private Button btn_logout;
        private Button btn_order;
        private Panel panel_order;
        private Panel panel_viewsales;
        private DataGridView grid_menuitems;
        private DataGridView grid_cart;
        private Label label2;
        private Label label1;
        private Label lbl_total;
        private Label label5;
        private ComboBox combo_ordertype;
        private TextBox field_customerphone;
        private TextBox field_customername;
        private Label label7;
        private Label label4;
        private Label label3;
        private Button btn_placeorder;
        private Button btn_minus;
        private Button btn_plus;
        private Label label6;
        private Button btn_sales_clear;
        private TextBox field_sales_search;
        private DataGridView grid_staffsales;
    }
}
