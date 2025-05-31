using BooksManagementSystem;

namespace BooksManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bttnLogin_Click(object sender, EventArgs e)
        {
            var dbManager = new DBManager();
            bool isAuthenticate = dbManager.AuthenticateUser(userLogin.Text, passwordLogin.Text);

            if (isAuthenticate)
            {
                MessageBox.Show("Login Successful. Click OK to view Application's Dashboard", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                /*MessageBox.Show("Login Failed. Please check your username and password.", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
                // Show the label
                labelNote.Text = "* Incorrect Username or Password. Please check. *";
                labelNote.Visible = true;

                // Start a 2-second UI-thread timer to hide it
                var timer = new System.Windows.Forms.Timer
                {
                    Interval = 5000   // milliseconds
                };
                timer.Tick += (s, e) =>
                {
                    labelNote.Visible = false;
                    timer.Stop();
                    timer.Dispose();
                };
                timer.Start();
            }

            /*var dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();*/
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var create = new Create();
            this.Hide();
            create.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            var forgot = new Forgot();
            this.Hide();
            forgot.Show();
        }
    }
}
