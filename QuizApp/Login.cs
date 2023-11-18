using Microsoft.Data.Sqlite;
using QuizApp.Helper;
using QuizApp.Model;
using QuizApp.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuizApp
{
    public partial class LoginForm : Form
    {
        bool isExist = false;

        ClientService data;
        public LoginForm()
        {
            InitializeComponent();
            data = new ClientService();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            User user = data.GetUser(txbLogin.Text, txbPassword.Text);

            if (user == null)
            {
                MessageBox.Show("Not Found");
                txbLogin.Text = "";
                txbPassword.Text = "";
            }
            else
            {
                this.Hide();

                UserInfoForm info = new UserInfoForm();
                info.SetInfo(user.UserName, user.Password, user.Phone);


                Menu menu = new Menu();
                menu.SetUserInfo(info);

                info.SetMenu(menu);

                UserDetail.UserId = user.Id;

                menu.Show();
            }

        }

        private void lnkRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Registration().Show();
        }
    }
}