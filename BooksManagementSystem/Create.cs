using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BooksManagementSystem;

namespace BooksManagementSystem
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            var login = new Login();
            var create = new Create();
            this.Hide();
            login.ShowDialog();
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

        private void createBttn_Click(object sender, EventArgs e)
        {
            var dbManager = new DBManager();

            bool isExists = dbManager.UsernameExists(createUser.Text);
            bool isPasswords = dbManager.PasswordsMatch(createPassword.Text, createConfirm.Text);

            if (AreTextboxesFilled(createUser, createPassword, createConfirm))
            {
                if (!isExists)
                {
                    if (isPasswords)
                    {
                        dbManager.InsertUser(createUser.Text, createPassword.Text);
                        MessageBox.Show("User added successfully!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        createUser.Text = "";
                        createPassword.Text = "";
                        createConfirm.Text = "";
                        /*createUser.Focus();*/
                    }
                    else
                    {
                        MessageBox.Show("Please check your password to confirm.", "Password did not match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please choose another username to proceed.", "Username already exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields.", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Show password
                createPassword.UseSystemPasswordChar = false;
                createConfirm.UseSystemPasswordChar = false;
            }
            else
            {
                // Hide password
                createPassword.UseSystemPasswordChar = true;
                createConfirm.UseSystemPasswordChar = true;
            }
        }
    }
}
