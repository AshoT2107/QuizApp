using Microsoft.Data.Sqlite;
using QuizApp.Services;

namespace QuizApp
{
    public partial class Registration : Form
    {
        ClientService data;
        public Registration()
        {
            InitializeComponent();
            data = new ClientService();
            data.CreateTable();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (txbUserName.Text is null || txbPhone.Text is null || txbPassword.Text is null)
            {
                MessageBox.Show("Bad Info");
                txbUserName.Text = "";
                txbPassword.Text = "";
                txbPhone.Text = "";
            }

            this.Hide();

            data.AddInfo(txbUserName.Text, txbPassword.Text, txbPhone.Text);

            MessageBox.Show("Info Added");

            LoginForm login = new LoginForm();

            login.Show();
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }
    }
}
