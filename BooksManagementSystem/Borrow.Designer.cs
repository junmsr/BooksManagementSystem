namespace BooksManagementSystem
{
    partial class Borrow
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
            clearBorrow = new Button();
            deleteBorrow = new Button();
            updateBorrow = new Button();
            addBorrow = new Button();
            label = new Label();
            label4 = new Label();
            label3 = new Label();
            statusBorrow = new ComboBox();
            dateBorrow = new DateTimePicker();
            label1 = new Label();
            bidBorrow = new TextBox();
            label2 = new Label();
            uidBorrow = new TextBox();
            panel2 = new Panel();
            label6 = new Label();
            filterBorrow = new ComboBox();
            searchBttnBorrow = new Button();
            searchBorrow = new TextBox();
            dataGridBorrow = new DataGridView();
            label5 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridBorrow).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PowderBlue;
            panel1.Controls.Add(clearBorrow);
            panel1.Controls.Add(deleteBorrow);
            panel1.Controls.Add(updateBorrow);
            panel1.Controls.Add(addBorrow);
            panel1.Controls.Add(label);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(statusBorrow);
            panel1.Controls.Add(dateBorrow);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(bidBorrow);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(uidBorrow);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(942, 201);
            panel1.TabIndex = 0;
            // 
            // clearBorrow
            // 
            clearBorrow.BackColor = Color.CadetBlue;
            clearBorrow.Cursor = Cursors.Hand;
            clearBorrow.FlatStyle = FlatStyle.Flat;
            clearBorrow.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            clearBorrow.Location = new Point(534, 145);
            clearBorrow.Name = "clearBorrow";
            clearBorrow.Size = new Size(104, 40);
            clearBorrow.TabIndex = 24;
            clearBorrow.Text = "CLEAR";
            clearBorrow.UseVisualStyleBackColor = false;
            clearBorrow.Click += clearBorrow_Click;
            // 
            // deleteBorrow
            // 
            deleteBorrow.BackColor = Color.CadetBlue;
            deleteBorrow.Cursor = Cursors.Hand;
            deleteBorrow.FlatStyle = FlatStyle.Flat;
            deleteBorrow.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            deleteBorrow.Location = new Point(656, 145);
            deleteBorrow.Name = "deleteBorrow";
            deleteBorrow.Size = new Size(104, 40);
            deleteBorrow.TabIndex = 23;
            deleteBorrow.Text = "DELETE";
            deleteBorrow.UseVisualStyleBackColor = false;
            deleteBorrow.Visible = false;
            deleteBorrow.Click += deleteBorrow_Click;
            // 
            // updateBorrow
            // 
            updateBorrow.BackColor = Color.CadetBlue;
            updateBorrow.Cursor = Cursors.Hand;
            updateBorrow.FlatStyle = FlatStyle.Flat;
            updateBorrow.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            updateBorrow.Location = new Point(410, 145);
            updateBorrow.Name = "updateBorrow";
            updateBorrow.Size = new Size(104, 40);
            updateBorrow.TabIndex = 22;
            updateBorrow.Text = "UPDATE";
            updateBorrow.UseVisualStyleBackColor = false;
            updateBorrow.Click += updateBorrow_Click;
            // 
            // addBorrow
            // 
            addBorrow.BackColor = Color.CadetBlue;
            addBorrow.Cursor = Cursors.Hand;
            addBorrow.FlatStyle = FlatStyle.Flat;
            addBorrow.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            addBorrow.Location = new Point(289, 145);
            addBorrow.Name = "addBorrow";
            addBorrow.Size = new Size(104, 40);
            addBorrow.TabIndex = 21;
            addBorrow.Text = "ADD";
            addBorrow.UseVisualStyleBackColor = false;
            addBorrow.Click += addBorrow_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(27, 26);
            label.Name = "label";
            label.Size = new Size(140, 24);
            label.TabIndex = 20;
            label.Text = "Borrow Book";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(693, 77);
            label4.Name = "label4";
            label4.Size = new Size(56, 18);
            label4.TabIndex = 19;
            label4.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(410, 77);
            label3.Name = "label3";
            label3.Size = new Size(43, 18);
            label3.TabIndex = 18;
            label3.Text = "Date";
            // 
            // statusBorrow
            // 
            statusBorrow.Cursor = Cursors.Hand;
            statusBorrow.FormattingEnabled = true;
            statusBorrow.Items.AddRange(new object[] { "Borrowed", "Returned" });
            statusBorrow.Location = new Point(693, 97);
            statusBorrow.Name = "statusBorrow";
            statusBorrow.Size = new Size(191, 28);
            statusBorrow.TabIndex = 12;
            statusBorrow.SelectedIndexChanged += statusBorrow_SelectedIndexChanged;
            // 
            // dateBorrow
            // 
            dateBorrow.Format = DateTimePickerFormat.Custom;
            dateBorrow.Location = new Point(410, 98);
            dateBorrow.Name = "dateBorrow";
            dateBorrow.Size = new Size(250, 27);
            dateBorrow.TabIndex = 17;
            dateBorrow.Value = new DateTime(2025, 5, 26, 14, 17, 39, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(234, 77);
            label1.Name = "label1";
            label1.Size = new Size(67, 18);
            label1.TabIndex = 16;
            label1.Text = "Book ID";
            // 
            // bidBorrow
            // 
            bidBorrow.Location = new Point(234, 97);
            bidBorrow.Name = "bidBorrow";
            bidBorrow.Size = new Size(153, 27);
            bidBorrow.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 77);
            label2.Name = "label2";
            label2.Size = new Size(65, 18);
            label2.TabIndex = 14;
            label2.Text = "User ID";
            // 
            // uidBorrow
            // 
            uidBorrow.Location = new Point(51, 98);
            uidBorrow.Name = "uidBorrow";
            uidBorrow.Size = new Size(153, 27);
            uidBorrow.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PowderBlue;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(filterBorrow);
            panel2.Controls.Add(searchBttnBorrow);
            panel2.Controls.Add(searchBorrow);
            panel2.Controls.Add(dataGridBorrow);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(15, 223);
            panel2.Name = "panel2";
            panel2.Size = new Size(905, 410);
            panel2.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(323, 21);
            label6.Name = "label6";
            label6.Size = new Size(49, 18);
            label6.TabIndex = 30;
            label6.Text = "Filter";
            label6.Visible = false;
            // 
            // filterBorrow
            // 
            filterBorrow.Cursor = Cursors.Hand;
            filterBorrow.FormattingEnabled = true;
            filterBorrow.Items.AddRange(new object[] { "Returned", "Borrowed" });
            filterBorrow.Location = new Point(378, 17);
            filterBorrow.Name = "filterBorrow";
            filterBorrow.Size = new Size(151, 28);
            filterBorrow.TabIndex = 29;
            filterBorrow.Visible = false;
            // 
            // searchBttnBorrow
            // 
            searchBttnBorrow.BackColor = Color.CadetBlue;
            searchBttnBorrow.Cursor = Cursors.Hand;
            searchBttnBorrow.FlatStyle = FlatStyle.Flat;
            searchBttnBorrow.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            searchBttnBorrow.Location = new Point(765, 17);
            searchBttnBorrow.Name = "searchBttnBorrow";
            searchBttnBorrow.Size = new Size(104, 28);
            searchBttnBorrow.TabIndex = 28;
            searchBttnBorrow.Text = "SEARCH";
            searchBttnBorrow.UseVisualStyleBackColor = false;
            searchBttnBorrow.Visible = false;
            // 
            // searchBorrow
            // 
            searchBorrow.Cursor = Cursors.IBeam;
            searchBorrow.Location = new Point(563, 17);
            searchBorrow.Name = "searchBorrow";
            searchBorrow.Size = new Size(191, 27);
            searchBorrow.TabIndex = 27;
            searchBorrow.Visible = false;
            // 
            // dataGridBorrow
            // 
            dataGridBorrow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridBorrow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridBorrow.Location = new Point(27, 61);
            dataGridBorrow.Name = "dataGridBorrow";
            dataGridBorrow.RowHeadersWidth = 51;
            dataGridBorrow.Size = new Size(853, 324);
            dataGridBorrow.TabIndex = 26;
            dataGridBorrow.CellClick += dataGridBorrow_CellClick;
            dataGridBorrow.CellContentClick += dataGridBorrow_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 20);
            label5.Name = "label5";
            label5.Size = new Size(79, 24);
            label5.TabIndex = 25;
            label5.Text = "Details";
            // 
            // Borrow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Borrow";
            Size = new Size(942, 655);
            Load += Borrow_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridBorrow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox uidBorrow;
        private DateTimePicker dateBorrow;
        private Label label1;
        private TextBox bidBorrow;
        private Label label2;
        private Label label4;
        private Label label3;
        private ComboBox statusBorrow;
        private Label label;
        private Button clearBorrow;
        private Button deleteBorrow;
        private Button updateBorrow;
        private Button addBorrow;
        private Panel panel2;
        private DataGridView dataGridBorrow;
        private Label label5;
        private TextBox searchBorrow;
        private Button searchBttnBorrow;
        private ComboBox filterBorrow;
        private Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
