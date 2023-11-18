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
    public partial class UserInfoForm : Form
    {
        public Menu? Menu;
        public UserInfoForm()
        {
            InitializeComponent();
        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {

        }

        public void SetInfo(string username, string password, string phone)
        {   //Bu esa ma'lumotlarni tashlaydi
            txbName.Text = username;
            txbParol.Text = password;
            txbPhone.Text = phone;
        }

        public void SetMenu(Menu menu)
        {
            Menu = menu;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   //Bu link orqali biz Login qayta ulana olamiz
            this.Hide();
            LoginForm form = new LoginForm();
            form.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (Menu == null)
            {
                Menu = new Menu();
            }

            Menu.Show();
        }
    }
}
