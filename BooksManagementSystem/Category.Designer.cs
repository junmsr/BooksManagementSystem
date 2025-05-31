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
            categoryTxt = new TextBox();
            deleteCategory = new Button();
            updateCategory = new Button();
            addCategory = new Button();
            label1 = new Label();
            panel2 = new Panel();
            dataGridCategory = new DataGridView();
            label = new Label();
            panel3 = new Panel();
            searchCategoryTxt = new TextBox();
            searchCategoryBttn = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCategory).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PowderBlue;
            panel1.Controls.Add(categoryTxt);
            panel1.Controls.Add(deleteCategory);
            panel1.Controls.Add(updateCategory);
            panel1.Controls.Add(addCategory);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(583, 244);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 388);
            panel1.TabIndex = 0;
            // 
            // categoryTxt
            // 
            categoryTxt.Location = new Point(35, 71);
            categoryTxt.Name = "categoryTxt";
            categoryTxt.Size = new Size(262, 27);
            categoryTxt.TabIndex = 12;
            // 
            // deleteCategory
            // 
            deleteCategory.BackColor = Color.CadetBlue;
            deleteCategory.Cursor = Cursors.Hand;
            deleteCategory.FlatStyle = FlatStyle.Flat;
            deleteCategory.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            deleteCategory.Location = new Point(175, 139);
            deleteCategory.Name = "deleteCategory";
            deleteCategory.Size = new Size(104, 40);
            deleteCategory.TabIndex = 11;
            deleteCategory.Text = "DELETE";
            deleteCategory.UseVisualStyleBackColor = false;
            deleteCategory.Click += deleteCategory_Click;
            // 
            // updateCategory
            // 
            updateCategory.BackColor = Color.CadetBlue;
            updateCategory.Cursor = Cursors.Hand;
            updateCategory.FlatStyle = FlatStyle.Flat;
            updateCategory.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            updateCategory.Location = new Point(121, 197);
            updateCategory.Name = "updateCategory";
            updateCategory.Size = new Size(104, 40);
            updateCategory.TabIndex = 10;
            updateCategory.Text = "UPDATE";
            updateCategory.UseVisualStyleBackColor = false;
            updateCategory.Visible = false;
            // 
            // addCategory
            // 
            addCategory.BackColor = Color.CadetBlue;
            addCategory.Cursor = Cursors.Hand;
            addCategory.FlatStyle = FlatStyle.Flat;
            addCategory.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            addCategory.Location = new Point(54, 139);
            addCategory.Name = "addCategory";
            addCategory.Size = new Size(104, 40);
            addCategory.TabIndex = 9;
            addCategory.Text = "ADD";
            addCategory.UseVisualStyleBackColor = false;
            addCategory.Click += addCategory_Click;
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
            panel2.Controls.Add(dataGridCategory);
            panel2.Controls.Add(label);
            panel2.Location = new Point(14, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(542, 614);
            panel2.TabIndex = 1;
            // 
            // dataGridCategory
            // 
            dataGridCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCategory.Location = new Point(31, 71);
            dataGridCategory.Name = "dataGridCategory";
            dataGridCategory.ReadOnly = true;
            dataGridCategory.RowHeadersWidth = 51;
            dataGridCategory.Size = new Size(468, 473);
            dataGridCategory.TabIndex = 1;
            dataGridCategory.CellClick += dataGridCategory_CellClick;
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
            panel3.Controls.Add(searchCategoryTxt);
            panel3.Controls.Add(searchCategoryBttn);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(583, 18);
            panel3.Name = "panel3";
            panel3.Size = new Size(346, 218);
            panel3.TabIndex = 13;
            // 
            // searchCategoryTxt
            // 
            searchCategoryTxt.Location = new Point(35, 71);
            searchCategoryTxt.Name = "searchCategoryTxt";
            searchCategoryTxt.Size = new Size(262, 27);
            searchCategoryTxt.TabIndex = 12;
            // 
            // searchCategoryBttn
            // 
            searchCategoryBttn.BackColor = Color.CadetBlue;
            searchCategoryBttn.Cursor = Cursors.Hand;
            searchCategoryBttn.FlatStyle = FlatStyle.Flat;
            searchCategoryBttn.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            searchCategoryBttn.Location = new Point(35, 127);
            searchCategoryBttn.Name = "searchCategoryBttn";
            searchCategoryBttn.Size = new Size(262, 39);
            searchCategoryBttn.TabIndex = 9;
            searchCategoryBttn.Text = "SEARCH";
            searchCategoryBttn.UseVisualStyleBackColor = false;
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
            Load += Category_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCategory).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridCategory;
        private Label label;
        private Label label1;
        private Button deleteCategory;
        private Button updateCategory;
        private Button addCategory;
        private TextBox categoryTxt;
        private Panel panel3;
        private TextBox searchCategoryTxt;
        private Button searchCategoryBttn;
        private Label label2;
    }
}
