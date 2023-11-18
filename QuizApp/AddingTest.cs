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
    public partial class AddingTest : Form
    {
        private Menu _menu = new Menu();
        private QuestionService _service = new QuestionService();
        private string QuestionError = "Please, fill your question!";
        private string ErrorA = "Please, fill your answer A!";
        private string ErrorB = "Please, fill your answer B!";
        private string ErrorC = "Please, fill your answer C!";

        private string correctAnswer = "A";
        
        public AddingTest(Menu menu)
        {
            InitializeComponent();
            _menu = menu;
            lblErrorQuestion.Text = QuestionError;
            lblErrorA.Text = ErrorA;
            lblErrorB.Text = ErrorB;
            lblErrorC.Text = ErrorC;
        }

        public AddingTest()
        {
            InitializeComponent();
            lblErrorQuestion.Text = QuestionError;
            lblErrorA.Text = ErrorA;
            lblErrorB.Text = ErrorB;
            lblErrorC.Text = ErrorC;
        }
        private void btnInsertQuestion_Click(object sender, EventArgs e)
        {
            var entity = new QuestionEntity()
            {
                Question = txtQuestion.Text,
                AnswerA = txtAnswerA.Text,
                AnswerB = txtAnswerB.Text,
                AnswerC = txtAnswerC.Text,
                CorrectAnswer = correctAnswer
            };

            if (string.IsNullOrEmpty(txtQuestion.Text.Trim()) ||
                string.IsNullOrEmpty(txtAnswerA.Text.Trim()) ||
                string.IsNullOrEmpty(txtAnswerB.Text.Trim()) ||
                string.IsNullOrEmpty(txtAnswerC.Text.Trim()))
            {
                MessageBox.Show("Fill required items!");
                return;
            }

            if (!chbA.Checked && !chbB.Checked && !chbC.Checked)
            {
                MessageBox.Show("Select Correct Answer!");
                return;
            }
            _service.InsertQuestion(entity);

            MessageBox.Show("Inserted questions");
            ClearForm();
        }

        private void ClearForm()
        {
            txtQuestion.Text = "";
            txtAnswerA.Text = "";
            txtAnswerB.Text = "";
            txtAnswerC.Text = "";

            chbA.Enabled = true;
            chbA.Checked = false;

            chbB.Enabled = true;
            chbB.Checked = false;

            chbC.Enabled = true;
            chbC.Checked = false;
        }
        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {
            if (txtQuestion.Text.Length > 0)
                lblErrorQuestion.Text = "";
            else
                lblErrorQuestion.Text = QuestionError;
        }

        private void txtAnswerA_TextChanged(object sender, EventArgs e)
        {
            if (txtAnswerA.Text.Length > 0)
                lblErrorA.Text = "";
            else
                lblErrorA.Text = ErrorA;
        }

        private void txtAnswerB_TextChanged(object sender, EventArgs e)
        {
            if (txtAnswerB.Text.Length > 0)
                lblErrorB.Text = "";
            else
                lblErrorB.Text = ErrorB;
        }

        private void txtAnswerC_TextChanged(object sender, EventArgs e)
        {
            if (txtAnswerC.Text.Length > 0)
                lblErrorC.Text = "";
            else
                lblErrorC.Text = ErrorC;
        }
        private void chbA_CheckedChanged(object sender, EventArgs e)
        {
            if (chbA.Checked)
            {
                chbB.Enabled = false;
                chbC.Enabled = false;
                correctAnswer = chbA.Text;
            }
            else
            {
                chbB.Enabled = true;
                chbC.Enabled = true;
            }
        }

        private void chbB_CheckedChanged(object sender, EventArgs e)
        {
            if (chbB.Checked)
            {
                chbA.Enabled = false;
                chbC.Enabled = false;
                correctAnswer = chbB.Text;
            }
            else
            {
                chbA.Enabled = true;
                chbC.Enabled = true;
            }
        }

        private void chbC_CheckedChanged(object sender, EventArgs e)
        {
            if (chbC.Checked == true)
            {
                chbA.Enabled = false;
                chbB.Enabled = false;

                correctAnswer = chbC.Text;
            }
            else
            {
                chbA.Enabled = true;
                chbB.Enabled = true;
            }
        }

        private void btnTestingBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            _menu.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
