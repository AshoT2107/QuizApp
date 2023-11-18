using QuizApp.Services;

namespace QuizApp
{
    public partial class QuestionsForm : Form
    {
        private Menu _menu = new Menu();
        private QuestionService _service = new QuestionService();
        public QuestionsForm()
        {
            InitializeComponent();
        }
        public QuestionsForm(Menu menu)
        {
            InitializeComponent();
            _menu = menu;
        }
        private void QuestionsForm_Load(object sender, EventArgs e)
        {
            var questions = _service.GetQuestions();

            QuestionsDataGrid.DataSource = questions;
        }

        private void btnQuestionBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            _menu.Show();
        }
    }
}
