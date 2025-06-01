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
    public partial class Category : UserControl
    {
        public Category()
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

        private void Category_Load(object sender, EventArgs e)
        {
            deleteCategory.Enabled = false;
            var dbManager = new DBManager();
            dataGridCategory.DataSource = dbManager.GetAllCategories();
        }

        private void addCategory_Click(object sender, EventArgs e)
        {
            if (AreTextboxesFilled(categoryTxt))
            {
                var dbManager = new DBManager();
                dbManager.AddCategory(categoryTxt.Text);
                MessageBox.Show("Category Added Successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                categoryTxt.Clear();
                dataGridCategory.DataSource = dbManager.GetAllCategories();
            }
        }

        private void deleteCategory_Click(object sender, EventArgs e)
        {
            var dbManager = new DBManager();
            var id = dataGridCategory.CurrentRow.Cells[0].Value.ToString();
            dbManager.DeleteCategory(id);
            MessageBox.Show("Category Deleted Successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            categoryTxt.Clear();
            dataGridCategory.DataSource = dbManager.GetAllCategories();
            deleteCategory.Enabled = false;
        }

        private void dataGridCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deleteCategory.Enabled = true;
            categoryTxt.Text = dataGridCategory.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
