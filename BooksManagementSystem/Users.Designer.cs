namespace BooksManagementSystem
{
    partial class Users
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
            label3 = new Label();
            emailTxt = new TextBox();
            label1 = new Label();
            contactTxt = new TextBox();
            dataGridUser = new DataGridView();
            userClear = new Button();
            userDelete = new Button();
            userUpdate = new Button();
            userAdd = new Button();
            email = new Label();
            lnameTxt = new TextBox();
            label2 = new Label();
            fnameTxt = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUser).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(emailTxt);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(contactTxt);
            panel1.Controls.Add(dataGridUser);
            panel1.Controls.Add(userClear);
            panel1.Controls.Add(userDelete);
            panel1.Controls.Add(userUpdate);
            panel1.Controls.Add(userAdd);
            panel1.Controls.Add(email);
            panel1.Controls.Add(lnameTxt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(fnameTxt);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(15, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(912, 638);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(672, 45);
            label3.Name = "label3";
            label3.Size = new Size(53, 18);
            label3.TabIndex = 45;
            label3.Text = "E mail";
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(672, 65);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(153, 27);
            emailTxt.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(488, 45);
            label1.Name = "label1";
            label1.Size = new Size(128, 18);
            label1.TabIndex = 43;
            label1.Text = "Contact Number";
            // 
            // contactTxt
            // 
            contactTxt.Location = new Point(488, 65);
            contactTxt.Name = "contactTxt";
            contactTxt.Size = new Size(153, 27);
            contactTxt.TabIndex = 42;
            // 
            // dataGridUser
            // 
            dataGridUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUser.Location = new Point(32, 188);
            dataGridUser.Name = "dataGridUser";
            dataGridUser.RowHeadersWidth = 51;
            dataGridUser.Size = new Size(854, 416);
            dataGridUser.TabIndex = 37;
            dataGridUser.CellClick += dataGridUser_CellClick;
            // 
            // userClear
            // 
            userClear.BackColor = Color.CadetBlue;
            userClear.Cursor = Cursors.Hand;
            userClear.FlatStyle = FlatStyle.Flat;
            userClear.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            userClear.Location = new Point(601, 117);
            userClear.Name = "userClear";
            userClear.Size = new Size(104, 40);
            userClear.TabIndex = 36;
            userClear.Text = "CLEAR";
            userClear.UseVisualStyleBackColor = false;
            // 
            // userDelete
            // 
            userDelete.BackColor = Color.CadetBlue;
            userDelete.Cursor = Cursors.Hand;
            userDelete.FlatStyle = FlatStyle.Flat;
            userDelete.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            userDelete.Location = new Point(481, 117);
            userDelete.Name = "userDelete";
            userDelete.Size = new Size(104, 40);
            userDelete.TabIndex = 35;
            userDelete.Text = "DELETE";
            userDelete.UseVisualStyleBackColor = false;
            userDelete.Click += userDelete_Click;
            // 
            // userUpdate
            // 
            userUpdate.BackColor = Color.CadetBlue;
            userUpdate.Cursor = Cursors.Hand;
            userUpdate.FlatStyle = FlatStyle.Flat;
            userUpdate.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            userUpdate.Location = new Point(362, 117);
            userUpdate.Name = "userUpdate";
            userUpdate.Size = new Size(104, 40);
            userUpdate.TabIndex = 34;
            userUpdate.Text = "UPDATE";
            userUpdate.UseVisualStyleBackColor = false;
            userUpdate.Click += userUpdate_Click;
            // 
            // userAdd
            // 
            userAdd.BackColor = Color.CadetBlue;
            userAdd.Cursor = Cursors.Hand;
            userAdd.FlatStyle = FlatStyle.Flat;
            userAdd.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            userAdd.Location = new Point(241, 117);
            userAdd.Name = "userAdd";
            userAdd.Size = new Size(104, 40);
            userAdd.TabIndex = 33;
            userAdd.Text = "ADD";
            userAdd.UseVisualStyleBackColor = false;
            userAdd.Click += userAdd_Click;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email.Location = new Point(304, 45);
            email.Name = "email";
            email.Size = new Size(87, 18);
            email.TabIndex = 29;
            email.Text = "Last Name";
            // 
            // lnameTxt
            // 
            lnameTxt.Location = new Point(304, 65);
            lnameTxt.Name = "lnameTxt";
            lnameTxt.Size = new Size(153, 27);
            lnameTxt.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(121, 45);
            label2.Name = "label2";
            label2.Size = new Size(90, 18);
            label2.TabIndex = 27;
            label2.Text = "First Name";
            // 
            // fnameTxt
            // 
            fnameTxt.Location = new Point(121, 66);
            fnameTxt.Name = "fnameTxt";
            fnameTxt.Size = new Size(153, 27);
            fnameTxt.TabIndex = 26;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Users";
            Size = new Size(947, 660);
            Load += Users_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button userClear;
        private Button userDelete;
        private Button userUpdate;
        private Button userAdd;
        private Label email;
        private TextBox lnameTxt;
        private Label label2;
        private TextBox fnameTxt;
        private DataGridView dataGridUser;
        private Label label3;
        private TextBox emailTxt;
        private Label label1;
        private TextBox contactTxt;
    }
}
