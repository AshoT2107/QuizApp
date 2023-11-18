namespace QuizApp
{
    partial class Menu
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
            btnProfile = new Button();
            btnTest = new Button();
            btnQuestions = new Button();
            btnExit = new Button();
            btnStatistics = new Button();
            btnAddTest = new Button();
            SuspendLayout();
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(78, 24);
            btnProfile.Margin = new Padding(2);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(252, 34);
            btnProfile.TabIndex = 0;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnTest
            // 
            btnTest.Location = new Point(78, 71);
            btnTest.Margin = new Padding(2);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(252, 34);
            btnTest.TabIndex = 0;
            btnTest.Text = "Test";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // btnQuestions
            // 
            btnQuestions.Location = new Point(78, 121);
            btnQuestions.Margin = new Padding(2);
            btnQuestions.Name = "btnQuestions";
            btnQuestions.Size = new Size(252, 34);
            btnQuestions.TabIndex = 0;
            btnQuestions.Text = "Questions";
            btnQuestions.UseVisualStyleBackColor = true;
            btnQuestions.Click += btnQuestions_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(78, 298);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(252, 34);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnStatistics
            // 
            btnStatistics.Location = new Point(78, 171);
            btnStatistics.Margin = new Padding(2);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Size = new Size(252, 34);
            btnStatistics.TabIndex = 0;
            btnStatistics.Text = "Statistics";
            btnStatistics.UseVisualStyleBackColor = true;
            btnStatistics.Click += btnStatistics_Click;
            // 
            // btnAddTest
            // 
            btnAddTest.Location = new Point(78, 222);
            btnAddTest.Margin = new Padding(2);
            btnAddTest.Name = "btnAddTest";
            btnAddTest.Size = new Size(252, 34);
            btnAddTest.TabIndex = 0;
            btnAddTest.Text = "Add Test";
            btnAddTest.UseVisualStyleBackColor = true;
            btnAddTest.Click += btnAddTest_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 352);
            Controls.Add(btnExit);
            Controls.Add(btnAddTest);
            Controls.Add(btnStatistics);
            Controls.Add(btnQuestions);
            Controls.Add(btnTest);
            Controls.Add(btnProfile);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProfile;
        private Button btnTest;
        private Button btnQuestions;
        private Button btnExit;
        private Button btnStatistics;
        private Button btnAddTest;
    }
}