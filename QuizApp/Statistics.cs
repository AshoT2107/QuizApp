using QuizApp.Model;
using QuizApp.Services;
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
    public partial class StatisticsForm : Form
    {
        private Menu _menu = new Menu();
        private QuestionService _service = new QuestionService();
        private AccountService _accountService = new AccountService();
        public StatisticsForm()
        {
            InitializeComponent();
        }
        public StatisticsForm(Menu menu)
        {
            InitializeComponent();
            _menu = menu;
        }
        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            var statistics = _service.GetStatistics();

            List<Statistics> StatisticsView = new List<Statistics>();

            foreach (var statistika in statistics)
            {
                var userId = statistika.UserId;

                var user = _accountService.GetUser(userId);

                Statistics view = new Statistics()
                {
                    Id = statistika.Id,
                    UserName = user.UserName,
                    CorrectAnswer = statistika.CorrectAnswerCount,
                    QuestionCount = statistika.TicketQuestionCount
                };

                StatisticsView.Add(view);
            }

            dgvStatistics.DataSource = StatisticsView;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            _menu.Show();
        }
    }
}
