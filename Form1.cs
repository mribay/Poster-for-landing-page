using System;
using System.Windows.Forms;

namespace Poster_for_landing_page
{
    public partial class CredentialsForm : Form
    {
        public CredentialsForm()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            CredentialsProgressBar.Show();
            string connectionString = ConnectionString.Text;

            try
            {
               MongoCRUD db = new MongoCRUD(connectionString, "landing-page", "Website");
               DashboardForm dashboardForm = new DashboardForm(db);
               dashboardForm.Show();
               this.Hide();
            } 
            catch
            {
                MessageBox.Show("Invalid credentials make sure the connection string is correct", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CredentialsProgressBar.Hide();
            }

        }

        private void CredentialsForm_Load(object sender, EventArgs e)
        {
            CredentialsProgressBar.Hide();
        }
    }
}
