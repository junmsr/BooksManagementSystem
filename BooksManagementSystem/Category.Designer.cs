namespace BooksManagementSystem
{
    partial class Category
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            textBox1 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label = new Label();
            panel3 = new Panel();
            textBox2 = new TextBox();
            button6 = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PowderBlue;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(583, 244);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 388);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(35, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 27);
            textBox1.TabIndex = 12;
            // 
            // button3
            // 
            button3.BackColor = Color.CadetBlue;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            button3.Location = new Point(116, 196);
            button3.Name = "button3";
            button3.Size = new Size(104, 40);
            button3.TabIndex = 11;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.CadetBlue;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            button2.Location = new Point(180, 139);
            button2.Name = "button2";
            button2.Size = new Size(104, 40);
            button2.TabIndex = 10;
            button2.Text = "UPDATE";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            button1.Location = new Point(54, 139);
            button1.Name = "button1";
            button1.Size = new Size(104, 40);
            button1.TabIndex = 9;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 36);
            label1.Name = "label1";
            label1.Size = new Size(123, 18);
            label1.TabIndex = 0;
            label1.Text = "Category Name";
            // 
            // panel2
            // 
            panel2.BackColor = Color.PowderBlue;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label);
            panel2.Location = new Point(14, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(542, 614);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(468, 473);
            dataGridView1.TabIndex = 1;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(31, 31);
            label.Name = "label";
            label.Size = new Size(117, 24);
            label.TabIndex = 0;
            label.Text = "Categories";
            // 
            // panel3
            // 
            panel3.BackColor = Color.PowderBlue;
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(583, 18);
            panel3.Name = "panel3";
            panel3.Size = new Size(346, 218);
            panel3.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(35, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(262, 27);
            textBox2.TabIndex = 12;
            // 
            // button6
            // 
            button6.BackColor = Color.CadetBlue;
            button6.Cursor = Cursors.Hand;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            button6.Location = new Point(35, 127);
            button6.Name = "button6";
            button6.Size = new Size(262, 39);
            button6.TabIndex = 9;
            button6.Text = "SEARCH";
            button6.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 36);
            label2.Name = "label2";
            label2.Size = new Size(132, 18);
            label2.TabIndex = 0;
            label2.Text = "Search Category";
            // 
            // Category
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Category";
            Size = new Size(942, 655);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Panel panel3;
        private TextBox textBox2;
        private Button button6;
        private Label label2;
    }
}
