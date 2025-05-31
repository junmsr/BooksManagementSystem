using Microsoft.Office.Interop.Excel;
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
    public partial class Logs : UserControl
    {
        public Logs()
        {
            InitializeComponent();
        }

        private void Logs_Load(object sender, EventArgs e)
        {
            var db = new DBManager();
            returnedBooks.DataSource = db.ReturnedBooks();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void export_Click(object sender, EventArgs e)
        {
            returnedBooks.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            returnedBooks.SelectAll();
            DataObject copydata = returnedBooks.GetClipboardContent();
            if (copydata != null) Clipboard.SetDataObject(copydata);
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlwbook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            object miseddata = System.Reflection.Missing.Value;
            xlwbook = xlapp.Workbooks.Add(miseddata);

            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlwbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];

            xlr.Select();
            xlr.PasteSpecial();
        }

        private void addBttnLog_TextChanged(object sender, EventArgs e)
        {
            /*            DBManager db = new DBManager();
                        returnedBooks.DataSource = db.SearchReturnedBooks(searchLog.Text.Trim());*/
        }

        private void searchLog_KeyPress(object sender, KeyPressEventArgs e)
        {
            DBManager db = new DBManager();
            returnedBooks.DataSource = db.SearchReturnedBooks(searchLog.Text.Trim());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBManager db = new DBManager();
            string selectedCategory = comboBox1.SelectedItem.ToString();
            System.Data.DataTable result = db.Filter(selectedCategory);
            returnedBooks.DataSource = result;
        }
    }
}
