using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksManagementSystem
{
    public partial class Forgot : Form
    {
        private static MySqlConnection conn;
        private static string connectionString = "SERVER = localhost; DATABASE = library; UID = root; PASSWORD = password;";

        static Forgot()
        {
            conn = new MySqlConnection(connectionString);
        }
        public Forgot()
        {
            InitializeComponent();
        }

        private void label4_Click_4(object sender, EventArgs e)
        {
            var login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string username = userFind.Text.Trim();
            string newPassword = newPass.Text;
            string confirmPassword = confirmPass.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Check if user exists
                string checkQuery = "SELECT COUNT(*) FROM admin WHERE admin_username = @username";
                using (var cmdCheck = new MySqlCommand(checkQuery, conn))
                {
                    cmdCheck.Parameters.AddWithValue("@username", username);
                    long userCount = (long)cmdCheck.ExecuteScalar();

                    if (userCount == 0)
                    {
                        MessageBox.Show("Username not found.");
                        return;
                    }
                }

                // Update password
                string updateQuery = "UPDATE admin SET admin_password = @password WHERE admin_username = @username";
                using (var cmdUpdate = new MySqlCommand(updateQuery, conn))
                {
                    cmdUpdate.Parameters.AddWithValue("@username", username);
                    cmdUpdate.Parameters.AddWithValue("@password", newPassword);

                    int rowsAffected = cmdUpdate.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update password.");
                    }
                }
            }
            userFind.Clear();
            newPass.Clear();
            confirmPass.Clear();
        }
    }
}
