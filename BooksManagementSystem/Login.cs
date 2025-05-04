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
            var dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
