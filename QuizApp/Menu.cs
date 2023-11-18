using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class Menu : Form
    {
        public UserInfoForm? UserInfoForm;
        public Menu()
        {
            InitializeComponent();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (UserInfoForm == null)
            {
                UserInfoForm = new UserInfoForm();
            }
            UserInfoForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddingTest(this).Show();
        }

        public void SetUserInfo(UserInfoForm infoForm)
        {
            UserInfoForm = infoForm;
        }

        private void btnQuestions_Click(object sender, EventArgs e)
        {
            this.Hide();
            new QuestionsForm(this).Show();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TicketForm(this).Show();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StatisticsForm(this).Show();
        }
    }
}
