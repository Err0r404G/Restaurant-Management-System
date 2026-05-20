using System;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
            this.AcceptButton = btn_login;
            this.FormClosed += form_login_FormClosed;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = field_username.Text.Trim();
            string password = field_password.Text.Trim();

            string role;
            string fullName;
            int userId;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            try
            {
                DataAccess dataAccess = new DataAccess();

                bool isValid = dataAccess.ValidateUser(username, password, out role, out userId, out fullName);

                if (isValid)
                {
                    LoggedInUser.UserID = userId;
                    LoggedInUser.Username = username;
                    LoggedInUser.FullName = fullName;
                    LoggedInUser.Role = role;

                    this.Hide();

                    if (role == "Admin")
                    {
                        AdminDashboard admin = new AdminDashboard();
                        admin.Show();
                    }
                    else if (role == "Staff")
                    {
                        StaffDashboard staff = new StaffDashboard();
                        staff.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error:\n" + ex.Message);
            }
        }

        private void form_login_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
