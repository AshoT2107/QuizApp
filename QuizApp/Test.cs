using Newtonsoft.Json.Linq;
using QuizApp.Helper;
using QuizApp.Model;
using QuizApp.Services;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class TestForm : Form
    {
        private Menu _menu;
        private QuestionService _service = new QuestionService();
        private List<int> Ids = new List<int>();
        private List<QuestionEntity> TicketQuestions = new List<QuestionEntity>();
        private int TicketId = 0;
        private string correctAnswer = "A";
        private int correctAnswersCount = 0;

        private bool _back;
        private bool _next;
        private int _questionIndex;

        private Dictionary<int, string> LocalQuestions = new Dictionary<int, string>();
        public TestForm(Menu menu)
        {
            InitializeComponent();
            _menu = menu;
        }
        public TestForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var question = _service.GetQuestionById(--_questionIndex);

            txtQuestion.Text = question.Question.ToString();
            txtAnswerA.Text = question.AnswerA.ToString();
            txtAnswerB.Text = question.AnswerB.ToString();
            txtAnswerC.Text = question.AnswerC.ToString();

            _questionIndex = question.QuestionIndex;
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            txtQuestionNumber.Text = "1";
            txtQuestion.Text = TicketQuestions.First().Question.ToString();
            txtAnswerA.Text = TicketQuestions.First().AnswerA.ToString();
            txtAnswerB.Text = TicketQuestions.First().AnswerB.ToString();
            txtAnswerC.Text = TicketQuestions.First().AnswerC.ToString();
        }

        public void SetTicketQuestions(List<QuestionEntity> entity,int ticketId )
        {
            TicketQuestions = entity;
            TicketId = ticketId;
        }

        private void button(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int buttonNumber = int.Parse(button.Text);//button number

            if(LocalQuestions.Count > 0)
            {

                LocalQuestions.TryGetValue(buttonNumber, out var value);

                if(value != null)
                {
                    if (value == "A")
                    {
                        chbA.CheckedChanged -= chbA_CheckedChanged!;
                        chbA.Checked = true;
                        chbA.CheckedChanged += chbA_CheckedChanged!;

                        chbB.CheckedChanged -= chbB_CheckedChanged!;
                        chbB.Checked = false;
                        chbB.CheckedChanged += chbB_CheckedChanged!;

                        chbC.CheckedChanged -= chbC_CheckedChanged!;
                        chbC.Checked = false;
                        chbC.CheckedChanged += chbC_CheckedChanged!;

                        chbA.Enabled = true;
                        chbB.Enabled = false;
                        chbC.Enabled = false;
                    }

                    if (value == "B")
                    {
                        chbA.CheckedChanged -= chbA_CheckedChanged!;
                        chbA.Checked = false;
                        chbA.CheckedChanged += chbA_CheckedChanged!;

                        chbB.CheckedChanged -= chbB_CheckedChanged!;
                        chbB.Checked = true;
                        chbB.CheckedChanged += chbB_CheckedChanged!;

                        chbC.CheckedChanged -= chbC_CheckedChanged!;
                        chbC.Checked = false;
                        chbC.CheckedChanged += chbC_CheckedChanged!;

                        chbA.Enabled = false;
                        chbB.Enabled = true;
                        chbC.Enabled = false;
                    }

                    if (value == "C")
                    {
                        chbA.CheckedChanged -= chbA_CheckedChanged!;
                        chbA.Checked = false;
                        chbA.CheckedChanged += chbA_CheckedChanged!;

                        chbB.CheckedChanged -= chbB_CheckedChanged!;
                        chbB.Checked = false;
                        chbB.CheckedChanged += chbB_CheckedChanged!;

                        chbC.CheckedChanged -= chbC_CheckedChanged!;
                        chbC.Checked = true;
                        chbC.CheckedChanged += chbC_CheckedChanged!;

                        chbA.Enabled = false;
                        chbB.Enabled = false;
                        chbC.Enabled = true;
                    }

                    var question = TicketQuestions[buttonNumber - 1];
                    txtQuestionNumber.Text = button.Text;
                    txtQuestion.Text = question.Question.ToString();
                    txtAnswerA.Text = question.AnswerA.ToString();
                    txtAnswerB.Text = question.AnswerB.ToString();
                    txtAnswerC.Text = question.AnswerC.ToString();
                }
                else
                {
                    var question = TicketQuestions[buttonNumber - 1];
                    txtQuestionNumber.Text = button.Text;
                    txtQuestion.Text = question.Question.ToString();
                    txtAnswerA.Text = question.AnswerA.ToString();
                    txtAnswerB.Text = question.AnswerB.ToString();
                    txtAnswerC.Text = question.AnswerC.ToString();
                    chbA.Checked = false;
                    chbB.Checked = false;
                    chbC.Checked = false;
                }
                
            }
            else
            {
                var question = TicketQuestions[buttonNumber - 1];
                txtQuestionNumber.Text = button.Text;
                txtQuestion.Text = question.Question.ToString();
                txtAnswerA.Text = question.AnswerA.ToString();
                txtAnswerB.Text = question.AnswerB.ToString();
                txtAnswerC.Text = question.AnswerC.ToString();
                chbA.Checked = false;
                chbB.Checked = false;
                chbC.Checked = false;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int questionCount = LocalQuestions.Count;
            if(questionCount != 10) 
            {
                MessageBox.Show("any questions is unmarked");
                return;
            }

            foreach(var localQuestion in LocalQuestions)
            {
                var key = localQuestion.Key;// question indexsi yani button nomeri

                var value = localQuestion.Value;// savolning tanlangan javobi

                var question =  TicketQuestions[key-1];

                if(question.CorrectAnswer == value)
                {
                    ChangeGreenButtonColor(key);
                    correctAnswersCount++;
                }
                else
                {
                    ChangeRedButtonColor(key);
                }

            }


            _service.InsertStatistiks( UserDetail.UserId, TicketId, correctAnswersCount, questionCount);

            MessageBox.Show($"Javoblaringiz: {correctAnswersCount}/{questionCount}");

        }

        private void ChangeGreenButtonColor(int key)
        {
            switch (key)
            {
                case 1: button1.BackColor = Color.Green;button1.ForeColor = Color.White; break; 
                case 2: button2.BackColor = Color.Green;button2.ForeColor = Color.White; break; 
                case 3: button3.BackColor = Color.Green;button3.ForeColor = Color.White; break; 
                case 4: button4.BackColor = Color.Green;button4.ForeColor = Color.White; break; 
                case 5: button5.BackColor = Color.Green;button5.ForeColor = Color.White; break; 
                case 6: button6.BackColor = Color.Green;button6.ForeColor = Color.White; break; 
                case 7: button7.BackColor = Color.Green;button7.ForeColor = Color.White; break; 
                case 8: button8.BackColor = Color.Green;button8.ForeColor = Color.White; break; 
                case 9: button9.BackColor = Color.Green;button9.ForeColor = Color.White; break; 
                case 10: button10.BackColor = Color.Green;button10.ForeColor = Color.White; break; 
            }
        }


        private void ChangeRedButtonColor(int key)
        {
            switch (key)
            {
                case 1: button1.BackColor = Color.Red; button1.ForeColor = Color.White; break;
                case 2: button2.BackColor = Color.Red;button2.ForeColor = Color.White;  break;
                case 3: button3.BackColor = Color.Red;button3.ForeColor = Color.White;  break;
                case 4: button4.BackColor = Color.Red;button4.ForeColor = Color.White;  break;
                case 5: button5.BackColor = Color.Red;button5.ForeColor = Color.White;  break;
                case 6: button6.BackColor = Color.Red;button6.ForeColor = Color.White;  break;
                case 7: button7.BackColor = Color.Red;button7.ForeColor = Color.White;  break;
                case 8: button8.BackColor = Color.Red;button8.ForeColor = Color.White;  break;
                case 9: button9.BackColor = Color.Red;button9.ForeColor = Color.White;  break;
                case 10: button10.BackColor =Color.Red;button10.ForeColor = Color.White; break;
            }
        }
        private void chbA_CheckedChanged(object sender, EventArgs e)
        {
            int key = int.Parse(txtQuestionNumber.Text);
            
            if (chbA.Checked)
            {
                chbB.Enabled = false;
                chbC.Enabled = false;
                correctAnswer = chbA.Text;
                string value = correctAnswer;

                if (!LocalQuestions.ContainsKey(key))
                    LocalQuestions.Add(key,value);

                else
                {
                    LocalQuestions.Remove(key);
                    LocalQuestions.Add(key, value);
                }
            }
            else
            {
                chbB.Enabled = true;
                chbC.Enabled = true;
            }
        }

        private void chbB_CheckedChanged(object sender, EventArgs e)
        {
            int key = int.Parse(txtQuestionNumber.Text);
            

            if (chbB.Checked)
            {
                chbA.Enabled = false;
                chbC.Enabled = false;
                correctAnswer = chbB.Text;

                string value = correctAnswer;

                if(!LocalQuestions.ContainsKey(key))
                    LocalQuestions.Add(key, value);

                else
                {
                    LocalQuestions.Remove(key);
                    LocalQuestions.Add(key, value);
                }
            }
            else
            {
                chbA.Enabled = true;
                chbC.Enabled = true;
            }
        }

        private void chbC_CheckedChanged(object sender, EventArgs e)
        {
            int key = int.Parse(txtQuestionNumber.Text);

            if (chbC.Checked == true)
            {
                chbA.Enabled = false;
                chbB.Enabled = false;
                correctAnswer = chbC.Text;

                string value = correctAnswer;
                if (!LocalQuestions.ContainsKey(key))
                    LocalQuestions.Add(key, value);

                else
                {
                    LocalQuestions.Remove(key);
                    LocalQuestions.Add(key, value);
                }
            }
            else
            {
                chbA.Enabled = true;
                chbB.Enabled = true;
            }
        }

        private void button10_MouseHover(object sender, EventArgs e)
        {
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
        }
    }
}
