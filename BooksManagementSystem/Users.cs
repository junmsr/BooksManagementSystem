using BooksManagementSystem;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksManagementSystem
{
    public partial class Users : UserControl
    {
        public Users()
        {
            InitializeComponent();
        }
        private void Users_Load(object sender, EventArgs e)
        {
            userUpdate.Enabled = false;
            userDelete.Enabled = false;
            var dbManager = new DBManager();
            dataGridUser.DataSource = dbManager.GetAllUsers();
        }

        private bool AreTextboxesFilled(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Focus();
                    return false;
                }
            }
            return true;
        }

        private void userAdd_Click(object sender, EventArgs e)
        {
            var dbManager = new DBManager();
            if (AreTextboxesFilled(fnameTxt, lnameTxt, emailTxt, contactTxt))
            {
                if (!dbManager.EmailExists(emailTxt.Text))
                {
                    dbManager.AddUser(fnameTxt.Text, lnameTxt.Text, emailTxt.Text, contactTxt.Text);
                    MessageBox.Show("User added successfully!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridUser.DataSource = dbManager.GetAllUsers();
                    fnameTxt.Clear();
                    lnameTxt.Clear();
                    emailTxt.Clear();
                    contactTxt.Clear();
                }
                else
                {
                    MessageBox.Show("Failed to add user, email already exists.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void userUpdate_Click(object sender, EventArgs e)
        {
            var dbManager = new DBManager();
            if (AreTextboxesFilled(fnameTxt, lnameTxt, emailTxt, contactTxt))
            {
                if (!dbManager.EmailExists(emailTxt.Text))
                {
                    var user_id = dataGridUser.CurrentRow.Cells[0].Value.ToString();
                    dbManager.UpdateUser(user_id, fnameTxt.Text, lnameTxt.Text, emailTxt.Text, contactTxt.Text);
                    dataGridUser.DataSource = dbManager.GetAllUsers();
                    MessageBox.Show("User info updated successfully!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fnameTxt.Clear();
                    lnameTxt.Clear();
                    emailTxt.Clear();
                    contactTxt.Clear();
                }
                else
                {
                    MessageBox.Show("User info failed to Update.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fnameTxt.Text = dataGridUser.CurrentRow.Cells[1].Value.ToString();
            lnameTxt.Text = dataGridUser.CurrentRow.Cells[2].Value.ToString();
            emailTxt.Text = dataGridUser.CurrentRow.Cells[3].Value.ToString();
            contactTxt.Text = dataGridUser.CurrentRow.Cells[4].Value.ToString();
            userUpdate.Enabled = true;
            userDelete.Enabled = true;
        }

        private void userDelete_Click(object sender, EventArgs e)
        {
            var dbManager = new DBManager();
            if(AreTextboxesFilled(fnameTxt, lnameTxt, emailTxt, contactTxt))
            {
                var uid = dataGridUser.CurrentRow.Cells[0].Value.ToString();
                if (dbManager.CanDeleteUser(uid))
                {
                    dbManager.DeleteUser(uid);
                    dataGridUser.DataSource = dbManager.GetAllUsers();
                    MessageBox.Show("Successfully deleted a user", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fnameTxt.Clear();
                    lnameTxt.Clear();
                    contactTxt.Clear();
                    emailTxt.Clear();
                }
                else
                {
                    MessageBox.Show("Cannot delete User with borrowed book", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
