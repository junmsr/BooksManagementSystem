﻿namespace BooksManagementSystem
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            labelTitle = new Label();
            userTextBox = new Label();
            labelHeading1 = new Label();
            userLogin = new TextBox();
            passwordLogin = new TextBox();
            passTxtBox = new Label();
            bttnLogin = new Button();
            labelNote = new Label();
            labelClose = new Label();
            createBttn = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PowderBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(labelTitle);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 505);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(56, 174);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(47, 74);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(237, 56);
            labelTitle.TabIndex = 8;
            labelTitle.Text = "Book Management \r\n         System";
            // 
            // userTextBox
            // 
            userTextBox.AutoSize = true;
            userTextBox.Location = new Point(366, 165);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(75, 20);
            userTextBox.TabIndex = 1;
            userTextBox.Text = "Username";
            // 
            // labelHeading1
            // 
            labelHeading1.AutoSize = true;
            labelHeading1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHeading1.Location = new Point(366, 76);
            labelHeading1.Name = "labelHeading1";
            labelHeading1.Size = new Size(164, 24);
            labelHeading1.TabIndex = 2;
            labelHeading1.Text = "Login as Admin";
            // 
            // userLogin
            // 
            userLogin.Cursor = Cursors.IBeam;
            userLogin.Font = new Font("Tahoma", 11F);
            userLogin.Location = new Point(366, 188);
            userLogin.Name = "userLogin";
            userLogin.Size = new Size(359, 30);
            userLogin.TabIndex = 3;
            // 
            // passwordLogin
            // 
            passwordLogin.Cursor = Cursors.IBeam;
            passwordLogin.Font = new Font("Tahoma", 11F);
            passwordLogin.Location = new Point(366, 268);
            passwordLogin.Name = "passwordLogin";
            passwordLogin.Size = new Size(359, 30);
            passwordLogin.TabIndex = 4;
            passwordLogin.UseSystemPasswordChar = true;
            // 
            // passTxtBox
            // 
            passTxtBox.AutoSize = true;
            passTxtBox.Location = new Point(366, 245);
            passTxtBox.Name = "passTxtBox";
            passTxtBox.Size = new Size(70, 20);
            passTxtBox.TabIndex = 5;
            passTxtBox.Text = "Password";
            // 
            // bttnLogin
            // 
            bttnLogin.BackColor = Color.PowderBlue;
            bttnLogin.Cursor = Cursors.Hand;
            bttnLogin.FlatStyle = FlatStyle.Flat;
            bttnLogin.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttnLogin.ForeColor = Color.Black;
            bttnLogin.Location = new Point(366, 335);
            bttnLogin.Name = "bttnLogin";
            bttnLogin.Size = new Size(359, 38);
            bttnLogin.TabIndex = 6;
            bttnLogin.Text = "LOGIN";
            bttnLogin.UseVisualStyleBackColor = false;
            bttnLogin.Click += bttnLogin_Click;
            // 
            // labelNote
            // 
            labelNote.AutoSize = true;
            labelNote.BackColor = Color.Transparent;
            labelNote.ForeColor = Color.Red;
            labelNote.Location = new Point(389, 308);
            labelNote.Name = "labelNote";
            labelNote.Size = new Size(243, 20);
            labelNote.TabIndex = 7;
            labelNote.Text = "* Incorrect username or password. *";
            labelNote.Visible = false;
            // 
            // labelClose
            // 
            labelClose.AutoSize = true;
            labelClose.Cursor = Cursors.Hand;
            labelClose.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelClose.Location = new Point(747, 9);
            labelClose.Name = "labelClose";
            labelClose.Size = new Size(20, 22);
            labelClose.TabIndex = 8;
            labelClose.Text = "X";
            labelClose.Click += labelClose_Click;
            // 
            // createBttn
            // 
            createBttn.AutoSize = true;
            createBttn.Cursor = Cursors.Hand;
            createBttn.Location = new Point(487, 387);
            createBttn.Name = "createBttn";
            createBttn.Size = new Size(121, 20);
            createBttn.TabIndex = 9;
            createBttn.Text = "Register Account";
            createBttn.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(487, 432);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 10;
            label1.Text = "Forgot password.";
            label1.Click += label1_Click_1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 504);
            Controls.Add(label1);
            Controls.Add(createBttn);
            Controls.Add(labelClose);
            Controls.Add(labelNote);
            Controls.Add(bttnLogin);
            Controls.Add(passTxtBox);
            Controls.Add(passwordLogin);
            Controls.Add(userLogin);
            Controls.Add(labelHeading1);
            Controls.Add(userTextBox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label userTextBox;
        private Label labelHeading1;
        private TextBox userLogin;
        private TextBox passwordLogin;
        private Label passTxtBox;
        private Button bttnLogin;
        private Label labelNote;
        private Label labelTitle;
        private PictureBox pictureBox1;
        private Label labelClose;
        private Label createBttn;
        private Label label1;
    }
}
