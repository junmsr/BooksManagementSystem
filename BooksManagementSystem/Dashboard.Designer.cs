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
            panel3 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            home1 = new Home();
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
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 660);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Location = new Point(227, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(947, 660);
            panel3.TabIndex = 0;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(3, 565);
            button6.Name = "button6";
            button6.Padding = new Padding(10, 0, 0, 0);
            button6.Size = new Size(221, 49);
            button6.TabIndex = 7;
            button6.Text = "       LOG OUT";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(3, 410);
            button5.Name = "button5";
            button5.Padding = new Padding(10, 0, 0, 0);
            button5.Size = new Size(221, 49);
            button5.TabIndex = 6;
            button5.Text = "       LOGS";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(3, 362);
            button4.Name = "button4";
            button4.Padding = new Padding(10, 0, 0, 0);
            button4.Size = new Size(221, 49);
            button4.TabIndex = 5;
            button4.Text = "       BORROW";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 314);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 0, 0);
            button3.Size = new Size(221, 49);
            button3.TabIndex = 4;
            button3.Text = "       CATEGORY";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 266);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(221, 49);
            button2.TabIndex = 3;
            button2.Text = "       BOOKS";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 218);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(221, 49);
            button1.TabIndex = 2;
            button1.Text = "       HOME";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            home1.Size = new Size(947, 660);
            home1.TabIndex = 8;
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
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button3;
        private Button button5;
        private Button button6;
        private Panel panel3;
        private Panel panel2;
        private Books books1;
        private Category category1;
        private Home home1;
    }
}