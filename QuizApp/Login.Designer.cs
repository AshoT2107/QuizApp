namespace QuizApp
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblLogin = new Label();
            lblPassword = new Label();
            txbLogin = new TextBox();
            txbPassword = new TextBox();
            btnEnter = new Button();
            lnkRegistration = new LinkLabel();
            lblDescription = new Label();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(61, 68);
            lblLogin.Margin = new Padding(2, 0, 2, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(56, 25);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(61, 136);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // txbLogin
            // 
            txbLogin.Location = new Point(218, 65);
            txbLogin.Margin = new Padding(2);
            txbLogin.Name = "txbLogin";
            txbLogin.Size = new Size(200, 31);
            txbLogin.TabIndex = 2;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(218, 132);
            txbPassword.Margin = new Padding(2);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(200, 31);
            txbPassword.TabIndex = 3;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(141, 232);
            btnEnter.Margin = new Padding(2);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(160, 34);
            btnEnter.TabIndex = 4;
            btnEnter.Text = "ENTER";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // lnkRegistration
            // 
            lnkRegistration.AutoSize = true;
            lnkRegistration.Location = new Point(328, 290);
            lnkRegistration.Margin = new Padding(2, 0, 2, 0);
            lnkRegistration.Name = "lnkRegistration";
            lnkRegistration.Size = new Size(73, 25);
            lnkRegistration.TabIndex = 5;
            lnkRegistration.TabStop = true;
            lnkRegistration.Text = "Sign up";
            lnkRegistration.LinkClicked += lnkRegistration_LinkClicked;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(41, 290);
            lblDescription.Margin = new Padding(2, 0, 2, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(231, 25);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "If you have not an account?";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(442, 338);
            Controls.Add(lblDescription);
            Controls.Add(lnkRegistration);
            Controls.Add(btnEnter);
            Controls.Add(txbPassword);
            Controls.Add(txbLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblLogin);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Label lblPassword;
        private TextBox txbLogin;
        private TextBox txbPassword;
        private Button btnEnter;
        private LinkLabel lnkRegistration;
        private Label lblDescription;
    }
}