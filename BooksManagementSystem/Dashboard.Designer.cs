namespace BooksManagementSystem
{
    partial class Dashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panelTopDashboard = new Panel();
            labelDashboardTitle = new Label();
            labelClose = new Label();
            panel1 = new Panel();
            userBttn = new Button();
            panel3 = new Panel();
            logoutBttn = new Button();
            logsBttn = new Button();
            borrowBttn = new Button();
            categoryBttn = new Button();
            booksBttn = new Button();
            homeBttn = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            home1 = new Home();
            users1 = new Users();
            borrow1 = new Borrow();
            logs1 = new Logs();
            category1 = new Category();
            books1 = new Books();
            panelTopDashboard.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelTopDashboard
            // 
            panelTopDashboard.BackColor = Color.PowderBlue;
            panelTopDashboard.BorderStyle = BorderStyle.Fixed3D;
            panelTopDashboard.Controls.Add(labelDashboardTitle);
            panelTopDashboard.Controls.Add(labelClose);
            panelTopDashboard.Dock = DockStyle.Top;
            panelTopDashboard.Location = new Point(0, 0);
            panelTopDashboard.Name = "panelTopDashboard";
            panelTopDashboard.Size = new Size(1174, 46);
            panelTopDashboard.TabIndex = 0;
            // 
            // labelDashboardTitle
            // 
            labelDashboardTitle.AutoSize = true;
            labelDashboardTitle.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDashboardTitle.Location = new Point(24, 11);
            labelDashboardTitle.Name = "labelDashboardTitle";
            labelDashboardTitle.Size = new Size(238, 21);
            labelDashboardTitle.TabIndex = 1;
            labelDashboardTitle.Text = "Book Management System";
            // 
            // labelClose
            // 
            labelClose.AutoSize = true;
            labelClose.Cursor = Cursors.Hand;
            labelClose.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelClose.Location = new Point(1142, 9);
            labelClose.Name = "labelClose";
            labelClose.Size = new Size(20, 22);
            labelClose.TabIndex = 1;
            labelClose.Text = "X";
            labelClose.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PowderBlue;
            panel1.Controls.Add(userBttn);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(logoutBttn);
            panel1.Controls.Add(logsBttn);
            panel1.Controls.Add(borrowBttn);
            panel1.Controls.Add(categoryBttn);
            panel1.Controls.Add(booksBttn);
            panel1.Controls.Add(homeBttn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 660);
            panel1.TabIndex = 1;
            // 
            // userBttn
            // 
            userBttn.FlatAppearance.BorderSize = 0;
            userBttn.FlatStyle = FlatStyle.Flat;
            userBttn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userBttn.Image = (Image)resources.GetObject("userBttn.Image");
            userBttn.ImageAlign = ContentAlignment.MiddleLeft;
            userBttn.Location = new Point(3, 370);
            userBttn.Name = "userBttn";
            userBttn.Padding = new Padding(7, 0, 0, 0);
            userBttn.Size = new Size(221, 49);
            userBttn.TabIndex = 8;
            userBttn.Text = "        USERS";
            userBttn.TextAlign = ContentAlignment.MiddleLeft;
            userBttn.UseVisualStyleBackColor = true;
            userBttn.Click += button7_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(227, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(947, 660);
            panel3.TabIndex = 0;
            // 
            // logoutBttn
            // 
            logoutBttn.FlatAppearance.BorderSize = 0;
            logoutBttn.FlatStyle = FlatStyle.Flat;
            logoutBttn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutBttn.Image = (Image)resources.GetObject("logoutBttn.Image");
            logoutBttn.ImageAlign = ContentAlignment.MiddleLeft;
            logoutBttn.Location = new Point(3, 565);
            logoutBttn.Name = "logoutBttn";
            logoutBttn.Padding = new Padding(10, 0, 0, 0);
            logoutBttn.Size = new Size(221, 49);
            logoutBttn.TabIndex = 7;
            logoutBttn.Text = "       LOG OUT";
            logoutBttn.TextAlign = ContentAlignment.MiddleLeft;
            logoutBttn.UseVisualStyleBackColor = true;
            logoutBttn.Click += button6_Click;
            // 
            // logsBttn
            // 
            logsBttn.FlatAppearance.BorderSize = 0;
            logsBttn.FlatStyle = FlatStyle.Flat;
            logsBttn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logsBttn.Image = (Image)resources.GetObject("logsBttn.Image");
            logsBttn.ImageAlign = ContentAlignment.MiddleLeft;
            logsBttn.Location = new Point(3, 425);
            logsBttn.Name = "logsBttn";
            logsBttn.Padding = new Padding(10, 0, 0, 0);
            logsBttn.Size = new Size(221, 49);
            logsBttn.TabIndex = 6;
            logsBttn.Text = "       LOGS";
            logsBttn.TextAlign = ContentAlignment.MiddleLeft;
            logsBttn.UseVisualStyleBackColor = true;
            logsBttn.Click += button5_Click;
            // 
            // borrowBttn
            // 
            borrowBttn.FlatAppearance.BorderSize = 0;
            borrowBttn.FlatStyle = FlatStyle.Flat;
            borrowBttn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            borrowBttn.Image = (Image)resources.GetObject("borrowBttn.Image");
            borrowBttn.ImageAlign = ContentAlignment.MiddleLeft;
            borrowBttn.Location = new Point(3, 320);
            borrowBttn.Name = "borrowBttn";
            borrowBttn.Padding = new Padding(10, 0, 0, 0);
            borrowBttn.Size = new Size(221, 49);
            borrowBttn.TabIndex = 5;
            borrowBttn.Text = "       BORROW";
            borrowBttn.TextAlign = ContentAlignment.MiddleLeft;
            borrowBttn.UseVisualStyleBackColor = true;
            borrowBttn.Click += button4_Click;
            // 
            // categoryBttn
            // 
            categoryBttn.FlatAppearance.BorderSize = 0;
            categoryBttn.FlatStyle = FlatStyle.Flat;
            categoryBttn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoryBttn.Image = (Image)resources.GetObject("categoryBttn.Image");
            categoryBttn.ImageAlign = ContentAlignment.MiddleLeft;
            categoryBttn.Location = new Point(3, 480);
            categoryBttn.Name = "categoryBttn";
            categoryBttn.Padding = new Padding(10, 0, 0, 0);
            categoryBttn.Size = new Size(221, 49);
            categoryBttn.TabIndex = 4;
            categoryBttn.Text = "       CATEGORY";
            categoryBttn.TextAlign = ContentAlignment.MiddleLeft;
            categoryBttn.UseVisualStyleBackColor = true;
            categoryBttn.Visible = false;
            categoryBttn.Click += button3_Click;
            // 
            // booksBttn
            // 
            booksBttn.FlatAppearance.BorderSize = 0;
            booksBttn.FlatStyle = FlatStyle.Flat;
            booksBttn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            booksBttn.Image = (Image)resources.GetObject("booksBttn.Image");
            booksBttn.ImageAlign = ContentAlignment.MiddleLeft;
            booksBttn.Location = new Point(3, 266);
            booksBttn.Name = "booksBttn";
            booksBttn.Padding = new Padding(10, 0, 0, 0);
            booksBttn.Size = new Size(221, 49);
            booksBttn.TabIndex = 3;
            booksBttn.Text = "       BOOKS";
            booksBttn.TextAlign = ContentAlignment.MiddleLeft;
            booksBttn.UseVisualStyleBackColor = true;
            booksBttn.Click += button2_Click;
            // 
            // homeBttn
            // 
            homeBttn.FlatAppearance.BorderSize = 0;
            homeBttn.FlatStyle = FlatStyle.Flat;
            homeBttn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            homeBttn.Image = (Image)resources.GetObject("homeBttn.Image");
            homeBttn.ImageAlign = ContentAlignment.MiddleLeft;
            homeBttn.Location = new Point(3, 218);
            homeBttn.Name = "homeBttn";
            homeBttn.Padding = new Padding(10, 0, 0, 0);
            homeBttn.Size = new Size(221, 49);
            homeBttn.TabIndex = 2;
            homeBttn.Text = "       HOME";
            homeBttn.TextAlign = ContentAlignment.MiddleLeft;
            homeBttn.UseVisualStyleBackColor = true;
            homeBttn.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 129);
            label1.Name = "label1";
            label1.Size = new Size(190, 24);
            label1.TabIndex = 2;
            label1.Text = "Admin Dashboard";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(63, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(home1);
            panel2.Controls.Add(users1);
            panel2.Controls.Add(borrow1);
            panel2.Controls.Add(logs1);
            panel2.Controls.Add(category1);
            panel2.Controls.Add(books1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(227, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(947, 660);
            panel2.TabIndex = 2;
            // 
            // home1
            // 
            home1.Location = new Point(0, 0);
            home1.Name = "home1";
            home1.Size = new Size(947, 662);
            home1.TabIndex = 2;
            // 
            // users1
            // 
            users1.Location = new Point(0, -3);
            users1.Name = "users1";
            users1.Size = new Size(947, 660);
            users1.TabIndex = 2;
            // 
            // borrow1
            // 
            borrow1.Location = new Point(0, 0);
            borrow1.Name = "borrow1";
            borrow1.Size = new Size(947, 660);
            borrow1.TabIndex = 8;
            // 
            // logs1
            // 
            logs1.Location = new Point(0, 0);
            logs1.Name = "logs1";
            logs1.Size = new Size(947, 662);
            logs1.TabIndex = 8;
            // 
            // category1
            // 
            category1.Location = new Point(0, 0);
            category1.Name = "category1";
            category1.Size = new Size(947, 660);
            category1.TabIndex = 8;
            // 
            // books1
            // 
            books1.BackColor = SystemColors.MenuBar;
            books1.Location = new Point(0, 0);
            books1.Name = "books1";
            books1.Size = new Size(944, 660);
            books1.TabIndex = 0;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1174, 706);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelTopDashboard);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelTopDashboard.ResumeLayout(false);
            panelTopDashboard.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTopDashboard;
        private Label labelClose;
        private Label labelDashboardTitle;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button homeBttn;
        private Button booksBttn;
        private Button borrowBttn;
        private Button categoryBttn;
        private Button logsBttn;
        private Button logoutBttn;
        private Home home1;
        private Panel panel3;
        private Panel panel2;
        private Books books1;
        private Category category1;
        private Borrow borrow1;
        private Logs logs1;
        private Button userBttn;
        private Users users1;
    }
}