namespace BooksManagementSystem
{
    partial class Create
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create));
            panel1 = new Panel();
            labelClose = new Label();
            labelHeading1 = new Label();
            pictureBox1 = new PictureBox();
            passTxtBox = new Label();
            createPassword = new TextBox();
            createUser = new TextBox();
            userTextBox = new Label();
            label1 = new Label();
            createConfirm = new TextBox();
            createBttn = new Button();
            checkBox1 = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PowderBlue;
            panel1.Controls.Add(labelClose);
            panel1.Controls.Add(labelHeading1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 345);
            panel1.TabIndex = 0;
            // 
            // labelClose
            // 
            labelClose.AutoSize = true;
            labelClose.Cursor = Cursors.Hand;
            labelClose.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelClose.Location = new Point(427, 11);
            labelClose.Name = "labelClose";
            labelClose.Size = new Size(20, 22);
            labelClose.TabIndex = 9;
            labelClose.Text = "X";
            labelClose.Click += labelClose_Click;
            // 
            // labelHeading1
            // 
            labelHeading1.AutoSize = true;
            labelHeading1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHeading1.Location = new Point(115, 43);
            labelHeading1.Name = "labelHeading1";
            labelHeading1.Size = new Size(220, 24);
            labelHeading1.TabIndex = 3;
            labelHeading1.Text = "Create your account.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(124, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // passTxtBox
            // 
            passTxtBox.AutoSize = true;
            passTxtBox.Location = new Point(54, 464);
            passTxtBox.Name = "passTxtBox";
            passTxtBox.Size = new Size(70, 20);
            passTxtBox.TabIndex = 9;
            passTxtBox.Text = "Password";
            // 
            // createPassword
            // 
            createPassword.Cursor = Cursors.IBeam;
            createPassword.Font = new Font("Tahoma", 11F);
            createPassword.Location = new Point(54, 487);
            createPassword.Name = "createPassword";
            createPassword.Size = new Size(359, 30);
            createPassword.TabIndex = 8;
            createPassword.UseSystemPasswordChar = true;
            // 
            // createUser
            // 
            createUser.Cursor = Cursors.IBeam;
            createUser.Font = new Font("Tahoma", 11F);
            createUser.Location = new Point(54, 407);
            createUser.Name = "createUser";
            createUser.Size = new Size(359, 30);
            createUser.TabIndex = 7;
            // 
            // userTextBox
            // 
            userTextBox.AutoSize = true;
            userTextBox.Location = new Point(54, 384);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(75, 20);
            userTextBox.TabIndex = 6;
            userTextBox.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 551);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 11;
            label1.Text = "Confirm Password";
            // 
            // createConfirm
            // 
            createConfirm.Cursor = Cursors.IBeam;
            createConfirm.Font = new Font("Tahoma", 11F);
            createConfirm.Location = new Point(54, 574);
            createConfirm.Name = "createConfirm";
            createConfirm.Size = new Size(359, 30);
            createConfirm.TabIndex = 10;
            createConfirm.UseSystemPasswordChar = true;
            createConfirm.TextChanged += textBox3_TextChanged;
            // 
            // createBttn
            // 
            createBttn.BackColor = Color.PowderBlue;
            createBttn.Cursor = Cursors.Hand;
            createBttn.FlatStyle = FlatStyle.Flat;
            createBttn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createBttn.ForeColor = Color.Black;
            createBttn.Location = new Point(160, 649);
            createBttn.Name = "createBttn";
            createBttn.Size = new Size(126, 38);
            createBttn.TabIndex = 12;
            createBttn.Text = "REGISTER";
            createBttn.UseVisualStyleBackColor = false;
            createBttn.Click += createBttn_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(54, 619);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(186, 24);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Show or Hide Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Create
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 801);
            Controls.Add(checkBox1);
            Controls.Add(createBttn);
            Controls.Add(label1);
            Controls.Add(createConfirm);
            Controls.Add(passTxtBox);
            Controls.Add(createPassword);
            Controls.Add(createUser);
            Controls.Add(userTextBox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Create";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label labelHeading1;
        private Label passTxtBox;
        private TextBox createPassword;
        private TextBox createUser;
        private Label userTextBox;
        private Label label1;
        private TextBox createConfirm;
        private Button createBttn;
        private Label labelClose;
        private CheckBox checkBox1;
    }
}