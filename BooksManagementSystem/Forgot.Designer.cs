namespace BooksManagementSystem
{
    partial class Forgot
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
            panel1 = new Panel();
            label5 = new Label();
            confirmPass = new TextBox();
            label4 = new Label();
            button1 = new Button();
            label3 = new Label();
            newPass = new TextBox();
            label2 = new Label();
            label1 = new Label();
            userFind = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(confirmPass);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(newPass);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(userFind);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(522, 348);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F);
            label5.Location = new Point(28, 205);
            label5.Name = "label5";
            label5.Size = new Size(124, 18);
            label5.TabIndex = 15;
            label5.Text = "Confirm Password";
            // 
            // confirmPass
            // 
            confirmPass.Cursor = Cursors.IBeam;
            confirmPass.Location = new Point(160, 201);
            confirmPass.Name = "confirmPass";
            confirmPass.Size = new Size(256, 27);
            confirmPass.TabIndex = 14;
            confirmPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(483, 12);
            label4.Name = "label4";
            label4.Size = new Size(20, 24);
            label4.TabIndex = 13;
            label4.Text = "x";
            label4.Click += label4_Click_4;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(160, 260);
            button1.Name = "button1";
            button1.Size = new Size(256, 44);
            button1.TabIndex = 12;
            button1.Text = "Change Password";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F);
            label3.Location = new Point(50, 166);
            label3.Name = "label3";
            label3.Size = new Size(102, 18);
            label3.TabIndex = 11;
            label3.Text = "New Password";
            // 
            // newPass
            // 
            newPass.Cursor = Cursors.IBeam;
            newPass.Location = new Point(160, 163);
            newPass.Name = "newPass";
            newPass.Size = new Size(256, 27);
            newPass.TabIndex = 10;
            newPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(135, 53);
            label2.Name = "label2";
            label2.Size = new Size(237, 28);
            label2.TabIndex = 9;
            label2.Text = "Password Recovery";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F);
            label1.Location = new Point(79, 123);
            label1.Name = "label1";
            label1.Size = new Size(75, 18);
            label1.TabIndex = 8;
            label1.Text = "Username";
            // 
            // userFind
            // 
            userFind.Cursor = Cursors.IBeam;
            userFind.Location = new Point(160, 120);
            userFind.Name = "userFind";
            userFind.Size = new Size(256, 27);
            userFind.TabIndex = 7;
            // 
            // Forgot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(520, 346);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Forgot";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Button button1;
        private Label label3;
        private TextBox newPass;
        private Label label2;
        private Label label1;
        private TextBox userFind;
        private Label label5;
        private TextBox confirmPass;
    }
}