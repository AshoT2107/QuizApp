namespace QuizApp
{
    partial class Registration
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
            lblUserName = new Label();
            txbUserName = new TextBox();
            txbPassword = new TextBox();
            lblPassword = new Label();
            txbPhone = new TextBox();
            lblPhone = new Label();
            btnRegistration = new Button();
            lblDescription = new Label();
            lnkLogin = new LinkLabel();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(90, 54);
            lblUserName.Margin = new Padding(2, 0, 2, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(91, 25);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Username";
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(268, 51);
            txbUserName.Margin = new Padding(2);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(406, 31);
            txbUserName.TabIndex = 1;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(268, 109);
            txbPassword.Margin = new Padding(2);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(406, 31);
            txbPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(90, 112);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // txbPhone
            // 
            txbPhone.Location = new Point(268, 175);
            txbPhone.Margin = new Padding(2);
            txbPhone.Name = "txbPhone";
            txbPhone.Size = new Size(406, 31);
            txbPhone.TabIndex = 5;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(90, 178);
            lblPhone.Margin = new Padding(2, 0, 2, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(62, 25);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone";
            // 
            // btnRegistration
            // 
            btnRegistration.FlatAppearance.BorderColor = Color.Blue;
            btnRegistration.FlatAppearance.BorderSize = 3;
            btnRegistration.Location = new Point(248, 256);
            btnRegistration.Margin = new Padding(2);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(268, 34);
            btnRegistration.TabIndex = 6;
            btnRegistration.Text = "Registration";
            btnRegistration.UseVisualStyleBackColor = true;
            btnRegistration.Click += btnRegistration_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(211, 331);
            lblDescription.Margin = new Padding(2, 0, 2, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(261, 25);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "If you have already an account?";
            // 
            // lnkLogin
            // 
            lnkLogin.AutoSize = true;
            lnkLogin.Location = new Point(498, 331);
            lnkLogin.Margin = new Padding(2, 0, 2, 0);
            lnkLogin.Name = "lnkLogin";
            lnkLogin.Size = new Size(67, 25);
            lnkLogin.TabIndex = 7;
            lnkLogin.TabStop = true;
            lnkLogin.Text = "Sign In";
            lnkLogin.LinkClicked += lnkLogin_LinkClicked;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(791, 430);
            Controls.Add(lblDescription);
            Controls.Add(lnkLogin);
            Controls.Add(btnRegistration);
            Controls.Add(txbPhone);
            Controls.Add(lblPhone);
            Controls.Add(txbPassword);
            Controls.Add(lblPassword);
            Controls.Add(txbUserName);
            Controls.Add(lblUserName);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private TextBox txbUserName;
        private TextBox txbPassword;
        private Label lblPassword;
        private TextBox txbPhone;
        private Label lblPhone;
        private Button btnRegistration;
        private Label lblDescription;
        private LinkLabel lnkLogin;
    }
}