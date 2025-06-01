using BooksManagementSystem;
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
    public partial class Borrow : UserControl
    {
        public Borrow()
        {
            InitializeComponent();
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

        private void Borrow_Load(object sender, EventArgs e)
        {
            updateBorrow.Enabled = false;
            deleteBorrow.Enabled = false;
            statusBorrow.SelectedIndex = 0;
            var dbManager = new DBManager();
            dataGridBorrow.DataSource = dbManager.GetAllBorrow();
        }

        private void dataGridBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridBorrow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateBorrow.Enabled = true;
            deleteBorrow.Enabled = true;
            uidBorrow.Text = dataGridBorrow.CurrentRow.Cells[1].Value.ToString();
            bidBorrow.Text = dataGridBorrow.CurrentRow.Cells[2].Value.ToString();
            DateTime dateValue;
            if (DateTime.TryParse(dataGridBorrow.CurrentRow.Cells[3].Value.ToString(), out dateValue))
            {
                dateBorrow.Value = dateValue; // 'dateBorrow' should be your DateTimePicker control
            }
            else
            {
                // Optional: Handle parsing error
                MessageBox.Show("Invalid date format in the selected row.");
            }
            /*dateBorrow.Text = dataGridBorrow.CurrentRow.Cells[2].Value.ToString();*/
            statusBorrow.Text = dataGridBorrow.CurrentRow.Cells[5].Value.ToString();
        }

        private void addBorrow_Click(object sender, EventArgs e)
        {
            var dbManager = new DBManager();
            if (AreTextboxesFilled(uidBorrow, bidBorrow) && !string.IsNullOrWhiteSpace(statusBorrow.Text))
            {
                if (dbManager.BookExists(bidBorrow.Text) && dbManager.UserExists(uidBorrow.Text))
                {
                    string formattedDate = dateBorrow.Value.ToString("yyyy-MM-dd");
                    dbManager.BorrowBooks(uidBorrow.Text, bidBorrow.Text, formattedDate, statusBorrow.Text);
                    MessageBox.Show("Borrow successfully!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridBorrow.DataSource = dbManager.GetAllBorrow();
                    uidBorrow.Clear();
                    bidBorrow.Clear();
                    statusBorrow.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("User or Book does not exist.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void updateBorrow_Click(object sender, EventArgs e)
        {
            if (AreTextboxesFilled() && !string.IsNullOrWhiteSpace(statusBorrow.Text) && statusBorrow.Text == "Returned")
            {
                var dbManager = new DBManager();
                var borrowid = dataGridBorrow.CurrentRow.Cells[0].Value.ToString();
                string formattedDate = dateBorrow.Value.ToString("yyyy-MM-dd");
                dbManager.UpdateStatus(statusBorrow.Text, borrowid);
                MessageBox.Show("Status Updated successfully!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                uidBorrow.Clear();
                bidBorrow.Clear();
                statusBorrow.SelectedIndex = -1;
                dataGridBorrow.DataSource = dbManager.GetAllBorrow();
                updateBorrow.Enabled = false;
            }
            else
            {
                MessageBox.Show("Update Failed", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void deleteBorrow_Click(object sender, EventArgs e)
        {

        }

        private void clearBorrow_Click(object sender, EventArgs e)
        {
            uidBorrow.Clear();
            bidBorrow.Clear();
            statusBorrow.SelectedIndex = -1;
        }

        private void statusBorrow_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
