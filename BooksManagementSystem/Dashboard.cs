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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home1.Visible = true;
            category1.Visible = false;
            books1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            home1.Visible = false;
            books1.Visible = true;
            category1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            home1.Visible = false;
            books1.Visible = false;
            category1.Visible = true;
        }
    }
}
