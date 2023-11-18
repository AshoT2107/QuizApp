namespace QuizApp
{
    partial class AddingTest
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
            btnInsertQuestion = new Button();
            lblDescription = new Label();
            lblErrorQuestion = new Label();
            lblErrorA = new Label();
            lblErrorB = new Label();
            lblErrorC = new Label();
            btnClear = new Button();
            btnTestingBack = new Button();
            SuspendLayout();
            // 
            // txtQuestion
            // 
            txtQuestion.Location = new Point(134, 68);
            txtQuestion.Margin = new Padding(2);
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(349, 95);
            txtQuestion.TabIndex = 0;
            txtQuestion.Text = "";
            txtQuestion.TextChanged += txtQuestion_TextChanged;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuestion.Location = new Point(11, 68);
            lblQuestion.Margin = new Padding(2, 0, 2, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(91, 28);
            lblQuestion.TabIndex = 1;
            lblQuestion.Text = "Question";
            // 
            // chbA
            // 
            chbA.AutoSize = true;
            chbA.Location = new Point(11, 198);
            chbA.Margin = new Padding(2);
            chbA.Name = "chbA";
            chbA.Size = new Size(41, 24);
            chbA.TabIndex = 2;
            chbA.Text = "A";
            chbA.UseVisualStyleBackColor = true;
            chbA.CheckedChanged += chbA_CheckedChanged;
            // 
            // chbB
            // 
            chbB.AutoSize = true;
            chbB.Location = new Point(11, 250);
            chbB.Margin = new Padding(2);
            chbB.Name = "chbB";
            chbB.Size = new Size(40, 24);
            chbB.TabIndex = 2;
            chbB.Text = "B";
            chbB.UseVisualStyleBackColor = true;
            chbB.CheckedChanged += chbB_CheckedChanged;
            // 
            // chbC
            // 
            chbC.AutoSize = true;
            chbC.Location = new Point(11, 303);
            chbC.Margin = new Padding(2);
            chbC.Name = "chbC";
            chbC.Size = new Size(40, 24);
            chbC.TabIndex = 2;
            chbC.Text = "C";
            chbC.UseVisualStyleBackColor = true;
            chbC.CheckedChanged += chbC_CheckedChanged;
            // 
            // txtAnswerA
            // 
            txtAnswerA.Location = new Point(69, 196);
            txtAnswerA.Margin = new Padding(2);
            txtAnswerA.Name = "txtAnswerA";
            txtAnswerA.Size = new Size(414, 27);
            txtAnswerA.TabIndex = 3;
            txtAnswerA.TextChanged += txtAnswerA_TextChanged;
            // 
            // txtAnswerB
            // 
            txtAnswerB.Location = new Point(69, 249);
            txtAnswerB.Margin = new Padding(2);
            txtAnswerB.Name = "txtAnswerB";
            txtAnswerB.Size = new Size(414, 27);
            txtAnswerB.TabIndex = 3;
            txtAnswerB.TextChanged += txtAnswerB_TextChanged;
            // 
            // txtAnswerC
            // 
            txtAnswerC.Location = new Point(69, 302);
            txtAnswerC.Margin = new Padding(2);
            txtAnswerC.Name = "txtAnswerC";
            txtAnswerC.Size = new Size(414, 27);
            txtAnswerC.TabIndex = 3;
            txtAnswerC.TextChanged += txtAnswerC_TextChanged;
            // 
            // btnInsertQuestion
            // 
            btnInsertQuestion.Location = new Point(381, 386);
            btnInsertQuestion.Margin = new Padding(2);
            btnInsertQuestion.Name = "btnInsertQuestion";
            btnInsertQuestion.Size = new Size(102, 34);
            btnInsertQuestion.TabIndex = 4;
            btnInsertQuestion.Text = "Insert";
            btnInsertQuestion.UseVisualStyleBackColor = true;
            btnInsertQuestion.Click += btnInsertQuestion_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(90, 16);
            lblDescription.Margin = new Padding(2, 0, 2, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(321, 20);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Please, enter your question with correct format!";
            // 
            // lblErrorQuestion
            // 
            lblErrorQuestion.AutoSize = true;
            lblErrorQuestion.ForeColor = Color.Red;
            lblErrorQuestion.Location = new Point(135, 162);
            lblErrorQuestion.Margin = new Padding(2, 0, 2, 0);
            lblErrorQuestion.Name = "lblErrorQuestion";
            lblErrorQuestion.Size = new Size(0, 20);
            lblErrorQuestion.TabIndex = 6;
            // 
            // lblErrorA
            // 
            lblErrorA.AutoSize = true;
            lblErrorA.ForeColor = Color.Red;
            lblErrorA.Location = new Point(69, 223);
            lblErrorA.Margin = new Padding(2, 0, 2, 0);
            lblErrorA.Name = "lblErrorA";
            lblErrorA.Size = new Size(0, 20);
            lblErrorA.TabIndex = 6;
            // 
            // lblErrorB
            // 
            lblErrorB.AutoSize = true;
            lblErrorB.ForeColor = Color.Red;
            lblErrorB.Location = new Point(69, 276);
            lblErrorB.Margin = new Padding(2, 0, 2, 0);
            lblErrorB.Name = "lblErrorB";
            lblErrorB.Size = new Size(0, 20);
            lblErrorB.TabIndex = 6;
            // 
            // lblErrorC
            // 
            lblErrorC.AutoSize = true;
            lblErrorC.ForeColor = Color.Red;
            lblErrorC.Location = new Point(69, 329);
            lblErrorC.Margin = new Padding(2, 0, 2, 0);
            lblErrorC.Name = "lblErrorC";
            lblErrorC.Size = new Size(0, 20);
            lblErrorC.TabIndex = 6;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(176, 386);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(129, 34);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnTestingBack
            // 
            btnTestingBack.Location = new Point(6, 386);
            btnTestingBack.Margin = new Padding(2);
            btnTestingBack.Name = "btnTestingBack";
            btnTestingBack.Size = new Size(115, 34);
            btnTestingBack.TabIndex = 4;
            btnTestingBack.Text = "Back";
            btnTestingBack.UseVisualStyleBackColor = true;
            btnTestingBack.Click += btnTestingBack_Click;
            // 
            // AddingTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 422);
            Controls.Add(lblErrorC);
            Controls.Add(lblErrorB);
            Controls.Add(lblErrorA);
            Controls.Add(lblErrorQuestion);
            Controls.Add(lblDescription);
            Controls.Add(btnTestingBack);
            Controls.Add(btnClear);
            Controls.Add(btnInsertQuestion);
            Controls.Add(txtAnswerC);
            Controls.Add(txtAnswerB);
            Controls.Add(txtAnswerA);
            Controls.Add(chbC);
            Controls.Add(chbB);
            Controls.Add(chbA);
            Controls.Add(lblQuestion);
            Controls.Add(txtQuestion);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "AddingTest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adding Test";
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
        private Button btnInsertQuestion;
        private Label lblDescription;
        private Label lblErrorQuestion;
        private Label lblErrorA;
        private Label lblErrorB;
        private Label lblErrorC;
        private Button btnClear;
        private Button btnTestingBack;
    }
}