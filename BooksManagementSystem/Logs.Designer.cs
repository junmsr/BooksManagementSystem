namespace BooksManagementSystem
{
    partial class Logs
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
            comboBox1 = new ComboBox();
            label6 = new Label();
            export = new Button();
            label2 = new Label();
            addBttnLog = new Button();
            searchLog = new TextBox();
            returnedBooks = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)returnedBooks).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PowderBlue;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(export);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(addBttnLog);
            panel1.Controls.Add(searchLog);
            panel1.Controls.Add(returnedBooks);
            panel1.Location = new Point(12, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(915, 627);
            panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Fiction", "Non-Fiction", "Science Fiction (Sci-Fi)", "Fantasy", "Mystery / Thriller", "Romance", "Historical Fiction", "Biography / Autobiography", "Self-Help", "Health & Wellness", "Travel", "Science", "Technology", "Mathematics", "Engineering", "Business / Economics", "Education", "Philosophy", "Psychology", "Religion / Spirituality", "Politics / Government", "Law", "Art & Photography", "Cooking / Food", "Comics / Graphic Novels", "Children’s Books", "Young Adult (YA)", "Poetry", "Drama / Plays", "Language & Linguistics", "True Crime", "Hobbies / Crafts", "Gardening / Nature", "Sports & Recreation", "Parenting & Families", "Music", "Computer & IT", "Journalism / Media", "Short Stories", "Dictionaries / Encyclopedias" });
            comboBox1.Location = new Point(385, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 35;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(330, 61);
            label6.Name = "label6";
            label6.Size = new Size(49, 18);
            label6.TabIndex = 34;
            label6.Text = "Filter";
            // 
            // export
            // 
            export.BackColor = Color.CadetBlue;
            export.Cursor = Cursors.Hand;
            export.FlatStyle = FlatStyle.Flat;
            export.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            export.Location = new Point(342, 546);
            export.Name = "export";
            export.Size = new Size(209, 49);
            export.TabIndex = 32;
            export.Text = "Export to MS Excel";
            export.UseVisualStyleBackColor = false;
            export.Click += export_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label2.Location = new Point(25, 53);
            label2.Name = "label2";
            label2.Size = new Size(265, 29);
            label2.TabIndex = 31;
            label2.Text = "Returned Books Logs";
            label2.Click += label2_Click;
            // 
            // addBttnLog
            // 
            addBttnLog.BackColor = Color.CadetBlue;
            addBttnLog.Cursor = Cursors.Hand;
            addBttnLog.FlatStyle = FlatStyle.Flat;
            addBttnLog.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            addBttnLog.Location = new Point(754, 58);
            addBttnLog.Name = "addBttnLog";
            addBttnLog.Size = new Size(104, 28);
            addBttnLog.TabIndex = 30;
            addBttnLog.Text = "SEARCH";
            addBttnLog.UseVisualStyleBackColor = false;
            addBttnLog.TextChanged += addBttnLog_TextChanged;
            // 
            // searchLog
            // 
            searchLog.Cursor = Cursors.IBeam;
            searchLog.Location = new Point(557, 58);
            searchLog.Name = "searchLog";
            searchLog.Size = new Size(191, 27);
            searchLog.TabIndex = 29;
            searchLog.KeyPress += searchLog_KeyPress;
            // 
            // returnedBooks
            // 
            returnedBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            returnedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            returnedBooks.Location = new Point(44, 121);
            returnedBooks.Name = "returnedBooks";
            returnedBooks.ReadOnly = true;
            returnedBooks.RowHeadersWidth = 51;
            returnedBooks.Size = new Size(819, 405);
            returnedBooks.TabIndex = 0;
            // 
            // Logs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Logs";
            Size = new Size(942, 655);
            Load += Logs_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)returnedBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button addBttnLog;
        private TextBox searchLog;
        private DataGridView returnedBooks;
        private Label label2;
        private Button export;
        private Label label6;
        private ComboBox comboBox1;
    }
}
