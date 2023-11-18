using QuizApp.Model;
using QuizApp.Services;

namespace QuizApp
{
    public partial class TicketForm : Form
    {
        private Menu _form;
        private QuestionService _service = new QuestionService();
        public TicketForm(Menu form)
        {
            InitializeComponent();
            _form = form;
        }
        public TicketForm()
        {
            InitializeComponent();
        }

        private void btnTicket1_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;

            int ticketId = int.Parse(button.Tag.ToString()!);

            List<QuestionEntity> questions = _service.GetQuestions();

            List<QuestionEntity> TicketQuestions = new List<QuestionEntity>();

            List<int> numbers = new List<int>();

            for (int i = 0; i < 10; i++)
            {
            key:

                int randomNumber = new Random().Next(1, questions.Count);

                if (numbers.Count() == 0 || !numbers.Contains(randomNumber))
                {
                    numbers.Add(randomNumber);
                    var question = questions[randomNumber];
                    TicketQuestions.Add(question);
                }
                else
                {
                    goto key;
                }

            }

            this.Hide();
            TestForm test = new TestForm(_form);
            test.SetTicketQuestions(TicketQuestions, ticketId);
            test.Show();
        }
    }
}
