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
    public partial class Books : UserControl
    {
        public Books()
        {
            InitializeComponent();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            updateBook.Enabled = false;
            deleteBook.Enabled = false;
            var dbManager = new DBManager();
            booksDataGrid.DataSource = dbManager.GetAllBoks();
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

        private void addBook_Click(object sender, EventArgs e)
        {
            if (AreTextboxesFilled(bookTitleTxt, bookIsbnTxt, bookYearTxt) && !string.IsNullOrWhiteSpace(bookCategoryMenu.Text))
            {
                var dbManager = new DBManager();
                dbManager.InsertBooks(bookTitleTxt.Text, bookCategoryMenu.Text, bookIsbnTxt.Text, bookYearTxt.Text);
                MessageBox.Show("Book added successfully!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                booksDataGrid.DataSource = dbManager.GetAllBoks();
                bookTitleTxt.Clear();
                bookCategoryMenu.SelectedIndex = -1;
                bookIsbnTxt.Clear();
                bookYearTxt.Clear();
                bookTitleTxt.Focus();
            }
            else
            {
                MessageBox.Show("Please fill in all fields.", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void booksDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateBook.Enabled = true;
            deleteBook.Enabled = true;
            bookIdTxt.Text = booksDataGrid.CurrentRow.Cells[0].Value.ToString();
            bookTitleTxt.Text = booksDataGrid.CurrentRow.Cells[1].Value.ToString();
            bookIsbnTxt.Text = booksDataGrid.CurrentRow.Cells[3].Value.ToString();
            bookYearTxt.Text = booksDataGrid.CurrentRow.Cells[4].Value.ToString();
            bookCategoryMenu.Text = booksDataGrid.CurrentRow.Cells[2].Value.ToString();
        }

        private void updateBook_Click(object sender, EventArgs e)
        {
            if (AreTextboxesFilled(bookIdTxt, bookTitleTxt, bookIsbnTxt, bookYearTxt) && !string.IsNullOrWhiteSpace(bookCategoryMenu.Text))
            {
                var dbManager = new DBManager();
                dbManager.UpdateBooks(bookIdTxt.Text, bookTitleTxt.Text, bookCategoryMenu.Text, bookIsbnTxt.Text, bookYearTxt.Text);
                MessageBox.Show("Book updated successfully!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                booksDataGrid.DataSource = dbManager.GetAllBoks();
                bookIdTxt.Clear();
                bookTitleTxt.Clear();
                bookCategoryMenu.SelectedIndex = -1;
                bookIsbnTxt.Clear();
                bookYearTxt.Clear();
                bookTitleTxt.Focus();
            }
        }

        private void deleteBook_Click(object sender, EventArgs e)
        {
            if (AreTextboxesFilled(bookIdTxt))
            {
                DialogResult myResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (myResult == DialogResult.Yes)
                {
                    var dbManager = new DBManager();
                    dbManager.DeleteBook(bookIdTxt.Text);
                    MessageBox.Show("Book updated successfully!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    booksDataGrid.DataSource = dbManager.GetAllBoks();
                }
            }
        }

        private void clearBook_Click(object sender, EventArgs e)
        {
            bookIdTxt.Clear();
            bookTitleTxt.Clear();
            bookCategoryMenu.SelectedIndex = -1;
            bookIsbnTxt.Clear();
            bookYearTxt.Clear();
        }

        /*        private void addBook_Click(object sender, EventArgs e)
                {
                    if (AreTextboxesFilled(bookTitleTxt, bookAuthorTxt, bookIsbnTxt, bookYearTxt))
                    {
                        var dbManager = new DBManager();
                        dbManager.InsertBooks(bookTitleTxt.Text, bookCategoryMenu.Items, bookIsbnTxt.Text, bookYearTxt.Text);
                        MessageBox.Show("User added successfully!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBoxes(this);
                        txtUsername.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Please fill in all fields.", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }*/
    }
}
