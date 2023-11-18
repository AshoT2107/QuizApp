namespace QuizApp
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtQuestion = new RichTextBox();
            lblQuestion = new Label();
            chbA = new CheckBox();
            chbB = new CheckBox();
            chbC = new CheckBox();
            txtAnswerA = new TextBox();
            txtAnswerB = new TextBox();
            txtAnswerC = new TextBox();
            btnCheck = new Button();
            lblDescription = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            txtQuestionNumber = new TextBox();
            SuspendLayout();
            // 
            // txtQuestion
            // 
            txtQuestion.BackColor = Color.FromArgb(224, 224, 224);
            txtQuestion.Enabled = false;
            txtQuestion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtQuestion.ForeColor = Color.Blue;
            txtQuestion.Location = new Point(167, 74);
            txtQuestion.Margin = new Padding(2);
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(435, 118);
            txtQuestion.TabIndex = 0;
            txtQuestion.Text = "";
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuestion.Location = new Point(13, 74);
            lblQuestion.Margin = new Padding(2, 0, 2, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(111, 32);
            lblQuestion.TabIndex = 1;
            lblQuestion.Text = "Question";
            // 
            // chbA
            // 
            chbA.AutoSize = true;
            chbA.Location = new Point(13, 237);
            chbA.Margin = new Padding(2);
            chbA.Name = "chbA";
            chbA.Size = new Size(50, 29);
            chbA.TabIndex = 2;
            chbA.Text = "A";
            chbA.UseVisualStyleBackColor = true;
            chbA.CheckedChanged += chbA_CheckedChanged;
            // 
            // chbB
            // 
            chbB.AutoSize = true;
            chbB.Location = new Point(13, 301);
            chbB.Margin = new Padding(2);
            chbB.Name = "chbB";
            chbB.Size = new Size(48, 29);
            chbB.TabIndex = 2;
            chbB.Text = "B";
            chbB.UseVisualStyleBackColor = true;
            chbB.CheckedChanged += chbB_CheckedChanged;
            // 
            // chbC
            // 
            chbC.AutoSize = true;
            chbC.Location = new Point(13, 368);
            chbC.Margin = new Padding(2);
            chbC.Name = "chbC";
            chbC.Size = new Size(49, 29);
            chbC.TabIndex = 2;
            chbC.Text = "C";
            chbC.UseVisualStyleBackColor = true;
            chbC.CheckedChanged += chbC_CheckedChanged;
            // 
            // txtAnswerA
            // 
            txtAnswerA.BackColor = Color.FromArgb(224, 224, 224);
            txtAnswerA.Enabled = false;
            txtAnswerA.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtAnswerA.ForeColor = Color.Black;
            txtAnswerA.Location = new Point(85, 234);
            txtAnswerA.Margin = new Padding(2);
            txtAnswerA.Name = "txtAnswerA";
            txtAnswerA.Size = new Size(516, 31);
            txtAnswerA.TabIndex = 3;
            // 
            // txtAnswerB
            // 
            txtAnswerB.BackColor = Color.FromArgb(224, 224, 224);
            txtAnswerB.Enabled = false;
            txtAnswerB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtAnswerB.ForeColor = Color.Blue;
            txtAnswerB.Location = new Point(85, 300);
            txtAnswerB.Margin = new Padding(2);
            txtAnswerB.Name = "txtAnswerB";
            txtAnswerB.Size = new Size(516, 31);
            txtAnswerB.TabIndex = 3;
            // 
            // txtAnswerC
            // 
            txtAnswerC.BackColor = Color.FromArgb(224, 224, 224);
            txtAnswerC.Enabled = false;
            txtAnswerC.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtAnswerC.ForeColor = Color.Blue;
            txtAnswerC.Location = new Point(85, 367);
            txtAnswerC.Margin = new Padding(2);
            txtAnswerC.Name = "txtAnswerC";
            txtAnswerC.Size = new Size(516, 31);
            txtAnswerC.TabIndex = 3;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(246, 476);
            btnCheck.Margin = new Padding(2);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(70, 42);
            btnCheck.TabIndex = 4;
            btnCheck.Text = "Check";
            btnCheck.Click += btnCheck_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(111, 10);
            lblDescription.Margin = new Padding(2, 0, 2, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(292, 25);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Please, choose your correct answer!";
            // 
            // button1
            // 
            button1.BackColor = Color.Violet;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(75, 437);
            button1.Name = "button1";
            button1.Size = new Size(41, 34);
            button1.TabIndex = 6;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button;
            button1.MouseLeave += button10_MouseLeave;
            button1.MouseHover += button10_MouseHover;
            // 
            // button2
            // 
            button2.BackColor = Color.Violet;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(122, 437);
            button2.Name = "button2";
            button2.Size = new Size(41, 34);
            button2.TabIndex = 6;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button;
            button2.MouseLeave += button10_MouseLeave;
            button2.MouseHover += button10_MouseHover;
            // 
            // button3
            // 
            button3.BackColor = Color.Violet;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(169, 437);
            button3.Name = "button3";
            button3.Size = new Size(41, 34);
            button3.TabIndex = 6;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button;
            button3.MouseLeave += button10_MouseLeave;
            button3.MouseHover += button10_MouseHover;
            // 
            // button4
            // 
            button4.BackColor = Color.Violet;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Red;
            button4.Location = new Point(216, 437);
            button4.Name = "button4";
            button4.Size = new Size(41, 34);
            button4.TabIndex = 6;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button;
            button4.MouseLeave += button10_MouseLeave;
            button4.MouseHover += button10_MouseHover;
            // 
            // button5
            // 
            button5.BackColor = Color.Violet;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.Red;
            button5.Location = new Point(263, 437);
            button5.Name = "button5";
            button5.Size = new Size(41, 34);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button;
            button5.MouseLeave += button10_MouseLeave;
            button5.MouseHover += button10_MouseHover;
            // 
            // button6
            // 
            button6.BackColor = Color.Violet;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.Red;
            button6.Location = new Point(310, 437);
            button6.Name = "button6";
            button6.Size = new Size(41, 34);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button;
            button6.MouseLeave += button10_MouseLeave;
            button6.MouseHover += button10_MouseHover;
            // 
            // button7
            // 
            button7.BackColor = Color.Violet;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.Red;
            button7.Location = new Point(354, 437);
            button7.Name = "button7";
            button7.Size = new Size(41, 34);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button;
            button7.MouseLeave += button10_MouseLeave;
            button7.MouseHover += button10_MouseHover;
            // 
            // button8
            // 
            button8.BackColor = Color.Violet;
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.Red;
            button8.Location = new Point(404, 437);
            button8.Name = "button8";
            button8.Size = new Size(41, 34);
            button8.TabIndex = 6;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button;
            button8.MouseLeave += button10_MouseLeave;
            button8.MouseHover += button10_MouseHover;
            // 
            // button9
            // 
            button9.BackColor = Color.Violet;
            button9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = Color.Red;
            button9.Location = new Point(451, 437);
            button9.Name = "button9";
            button9.Size = new Size(41, 34);
            button9.TabIndex = 6;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button;
            button9.MouseLeave += button10_MouseLeave;
            button9.MouseHover += button10_MouseHover;
            // 
            // button10
            // 
            button10.BackColor = Color.Violet;
            button10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button10.ForeColor = Color.Red;
            button10.Location = new Point(498, 437);
            button10.Name = "button10";
            button10.Size = new Size(41, 34);
            button10.TabIndex = 6;
            button10.Text = "10";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button;
            button10.MouseLeave += button10_MouseLeave;
            button10.MouseHover += button10_MouseHover;
            // 
            // txtQuestionNumber
            // 
            txtQuestionNumber.BackColor = Color.FromArgb(224, 224, 224);
            txtQuestionNumber.Enabled = false;
            txtQuestionNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtQuestionNumber.ForeColor = Color.Blue;
            txtQuestionNumber.Location = new Point(132, 77);
            txtQuestionNumber.Name = "txtQuestionNumber";
            txtQuestionNumber.Size = new Size(30, 31);
            txtQuestionNumber.TabIndex = 7;
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 528);
            Controls.Add(txtQuestionNumber);
            Controls.Add(button10);
            Controls.Add(button8);
            Controls.Add(button4);
            Controls.Add(button7);
            Controls.Add(button2);
            Controls.Add(button9);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(lblDescription);
            Controls.Add(txtQuestion);
            Controls.Add(lblQuestion);
            Controls.Add(chbA);
            Controls.Add(chbB);
            Controls.Add(chbC);
            Controls.Add(txtAnswerA);
            Controls.Add(btnCheck);
            Controls.Add(txtAnswerB);
            Controls.Add(txtAnswerC);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "TestForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Test";
            Load += TestForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtQuestion;
        private Label lblQuestion;
        private CheckBox chbA;
        private CheckBox chbB;
        private CheckBox chbC;
        private TextBox txtAnswerA;
        private TextBox txtAnswerB;
        private TextBox txtAnswerC;
        private Button btnCheck;
        private Label lblDescription;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private TextBox txtQuestionNumber;
    }
}