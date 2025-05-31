namespace BooksManagementSystem
{
    partial class Books
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
            label6 = new Label();
            filterBooks = new ComboBox();
            searchBttnBooks = new Button();
            searchBooks = new TextBox();
            booksDataGrid = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            bookId = new Label();
            bookIdTxt = new TextBox();
            clearBook = new Button();
            bookCategoryMenu = new ComboBox();
            deleteBook = new Button();
            updateBook = new Button();
            addBook = new Button();
            label5 = new Label();
            bookYearTxt = new TextBox();
            label4 = new Label();
            bookIsbnTxt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            bookTitleTxt = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)booksDataGrid).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PowderBlue;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(filterBooks);
            panel1.Controls.Add(searchBttnBooks);
            panel1.Controls.Add(searchBooks);
            panel1.Controls.Add(booksDataGrid);
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(17, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(910, 388);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(303, 18);
            label6.Name = "label6";
            label6.Size = new Size(49, 18);
            label6.TabIndex = 13;
            label6.Text = "Filter";
            label6.Visible = false;
            // 
            // filterBooks
            // 
            filterBooks.Cursor = Cursors.Hand;
            filterBooks.FormattingEnabled = true;
            filterBooks.Items.AddRange(new object[] { "Publication Year", "Author", "Category" });
            filterBooks.Location = new Point(358, 14);
            filterBooks.Name = "filterBooks";
            filterBooks.Size = new Size(151, 28);
            filterBooks.TabIndex = 13;
            filterBooks.Visible = false;
            // 
            // searchBttnBooks
            // 
            searchBttnBooks.BackColor = Color.CadetBlue;
            searchBttnBooks.Cursor = Cursors.Hand;
            searchBttnBooks.FlatStyle = FlatStyle.Flat;
            searchBttnBooks.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            searchBttnBooks.Location = new Point(750, 14);
            searchBttnBooks.Name = "searchBttnBooks";
            searchBttnBooks.Size = new Size(104, 28);
            searchBttnBooks.TabIndex = 13;
            searchBttnBooks.Text = "SEARCH";
            searchBttnBooks.UseVisualStyleBackColor = false;
            searchBttnBooks.Visible = false;
            // 
            // searchBooks
            // 
            searchBooks.Cursor = Cursors.IBeam;
            searchBooks.Location = new Point(541, 15);
            searchBooks.Name = "searchBooks";
            searchBooks.Size = new Size(191, 27);
            searchBooks.TabIndex = 13;
            searchBooks.Visible = false;
            // 
            // booksDataGrid
            // 
            booksDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            booksDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            booksDataGrid.Location = new Point(75, 62);
            booksDataGrid.Name = "booksDataGrid";
            booksDataGrid.ReadOnly = true;
            booksDataGrid.RowHeadersWidth = 51;
            booksDataGrid.Size = new Size(758, 304);
            booksDataGrid.TabIndex = 1;
            booksDataGrid.CellClick += booksDataGrid_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 18);
            label1.Name = "label1";
            label1.Size = new Size(135, 24);
            label1.TabIndex = 0;
            label1.Text = "Book Details";
            // 
            // panel2
            // 
            panel2.BackColor = Color.PowderBlue;
            panel2.Controls.Add(bookId);
            panel2.Controls.Add(bookIdTxt);
            panel2.Controls.Add(clearBook);
            panel2.Controls.Add(bookCategoryMenu);
            panel2.Controls.Add(deleteBook);
            panel2.Controls.Add(updateBook);
            panel2.Controls.Add(addBook);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(bookYearTxt);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(bookIsbnTxt);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(bookTitleTxt);
            panel2.Location = new Point(17, 431);
            panel2.Name = "panel2";
            panel2.Size = new Size(910, 202);
            panel2.TabIndex = 1;
            // 
            // bookId
            // 
            bookId.AutoSize = true;
            bookId.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookId.Location = new Point(38, 11);
            bookId.Name = "bookId";
            bookId.Size = new Size(26, 18);
            bookId.TabIndex = 14;
            bookId.Text = "ID";
            // 
            // bookIdTxt
            // 
            bookIdTxt.Cursor = Cursors.IBeam;
            bookIdTxt.Location = new Point(38, 39);
            bookIdTxt.Name = "bookIdTxt";
            bookIdTxt.ReadOnly = true;
            bookIdTxt.Size = new Size(56, 27);
            bookIdTxt.TabIndex = 13;
            // 
            // clearBook
            // 
            clearBook.BackColor = Color.CadetBlue;
            clearBook.Cursor = Cursors.Hand;
            clearBook.FlatStyle = FlatStyle.Flat;
            clearBook.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            clearBook.Location = new Point(596, 104);
            clearBook.Name = "clearBook";
            clearBook.Size = new Size(104, 40);
            clearBook.TabIndex = 12;
            clearBook.Text = "CLEAR";
            clearBook.UseVisualStyleBackColor = false;
            clearBook.Click += clearBook_Click;
            // 
            // bookCategoryMenu
            // 
            bookCategoryMenu.Cursor = Cursors.Hand;
            bookCategoryMenu.FormattingEnabled = true;
            bookCategoryMenu.Items.AddRange(new object[] { "Fiction", "Non-Fiction", "Science Fiction (Sci-Fi)", "Fantasy", "Mystery / Thriller", "Romance", "Historical Fiction", "Biography / Autobiography", "Self-Help", "Health & Wellness", "Travel", "Science", "Technology", "Mathematics", "Engineering", "Business / Economics", "Education", "Philosophy", "Psychology", "Religion / Spirituality", "Politics / Government", "Law", "Art & Photography", "Cooking / Food", "Comics / Graphic Novels", "Children’s Books", "Young Adult (YA)", "Poetry", "Drama / Plays", "Language & Linguistics", "True Crime", "Hobbies / Crafts", "Gardening / Nature", "Sports & Recreation", "Parenting & Families", "Music", "Computer & IT", "Journalism / Media", "Short Stories", "Dictionaries / Encyclopedias" });
            bookCategoryMenu.Location = new Point(688, 38);
            bookCategoryMenu.Name = "bookCategoryMenu";
            bookCategoryMenu.Size = new Size(191, 28);
            bookCategoryMenu.TabIndex = 11;
            // 
            // deleteBook
            // 
            deleteBook.BackColor = Color.CadetBlue;
            deleteBook.Cursor = Cursors.Hand;
            deleteBook.FlatStyle = FlatStyle.Flat;
            deleteBook.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            deleteBook.Location = new Point(468, 104);
            deleteBook.Name = "deleteBook";
            deleteBook.Size = new Size(104, 40);
            deleteBook.TabIndex = 10;
            deleteBook.Text = "DELETE";
            deleteBook.UseVisualStyleBackColor = false;
            deleteBook.Click += deleteBook_Click;
            // 
            // updateBook
            // 
            updateBook.BackColor = Color.CadetBlue;
            updateBook.Cursor = Cursors.Hand;
            updateBook.FlatStyle = FlatStyle.Flat;
            updateBook.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            updateBook.Location = new Point(338, 104);
            updateBook.Name = "updateBook";
            updateBook.Size = new Size(104, 40);
            updateBook.TabIndex = 9;
            updateBook.Text = "UPDATE";
            updateBook.UseVisualStyleBackColor = false;
            updateBook.Click += updateBook_Click;
            // 
            // addBook
            // 
            addBook.BackColor = Color.CadetBlue;
            addBook.Cursor = Cursors.Hand;
            addBook.FlatStyle = FlatStyle.Flat;
            addBook.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            addBook.Location = new Point(206, 104);
            addBook.Name = "addBook";
            addBook.Size = new Size(104, 40);
            addBook.TabIndex = 8;
            addBook.Text = "ADD";
            addBook.UseVisualStyleBackColor = false;
            addBook.Click += addBook_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(541, 11);
            label5.Name = "label5";
            label5.Size = new Size(132, 18);
            label5.TabIndex = 7;
            label5.Text = "Publication Year";
            // 
            // bookYearTxt
            // 
            bookYearTxt.Cursor = Cursors.IBeam;
            bookYearTxt.Location = new Point(557, 38);
            bookYearTxt.Name = "bookYearTxt";
            bookYearTxt.Size = new Size(101, 27);
            bookYearTxt.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(338, 12);
            label4.Name = "label4";
            label4.Size = new Size(47, 18);
            label4.TabIndex = 5;
            label4.Text = "ISBN";
            // 
            // bookIsbnTxt
            // 
            bookIsbnTxt.Cursor = Cursors.IBeam;
            bookIsbnTxt.Location = new Point(338, 39);
            bookIsbnTxt.Name = "bookIsbnTxt";
            bookIsbnTxt.Size = new Size(191, 27);
            bookIsbnTxt.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(688, 9);
            label3.Name = "label3";
            label3.Size = new Size(76, 18);
            label3.TabIndex = 3;
            label3.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(119, 11);
            label2.Name = "label2";
            label2.Size = new Size(42, 18);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // bookTitleTxt
            // 
            bookTitleTxt.Cursor = Cursors.IBeam;
            bookTitleTxt.Location = new Point(119, 39);
            bookTitleTxt.Name = "bookTitleTxt";
            bookTitleTxt.Size = new Size(191, 27);
            bookTitleTxt.TabIndex = 0;
            // 
            // Books
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Books";
            Size = new Size(947, 660);
            Load += Books_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)booksDataGrid).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView booksDataGrid;
        private Label label2;
        private TextBox bookTitleTxt;
        private Label label5;
        private Label label4;
        private TextBox bookIsbnTxt;
        private Label label3;
        private Button deleteBook;
        private Button updateBook;
        private Button addBook;
        private ComboBox bookCategoryMenu;
        private TextBox bookYearTxt;
        private Button clearBook;
        private ComboBox filterBooks;
        private Button searchBttnBooks;
        private TextBox searchBooks;
        private Label label6;
        private Label bookId;
        private TextBox bookIdTxt;
    }
}
