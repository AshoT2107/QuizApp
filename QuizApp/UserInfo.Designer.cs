namespace QuizApp
{
    partial class UserInfoForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txbName = new TextBox();
            txbParol = new TextBox();
            txbPhone = new TextBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Location = new Point(248, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 0;
            label1.Text = "User Info";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 99);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 190);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 284);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 3;
            label4.Text = "Phone";
            // 
            // txbName
            // 
            txbName.Enabled = false;
            txbName.Location = new Point(190, 99);
            txbName.Margin = new Padding(4);
            txbName.Name = "txbName";
            txbName.Size = new Size(286, 31);
            txbName.TabIndex = 4;
            txbName.TextChanged += txbName_TextChanged;
            // 
            // txbParol
            // 
            txbParol.Enabled = false;
            txbParol.Location = new Point(190, 190);
            txbParol.Margin = new Padding(4);
            txbParol.Name = "txbParol";
            txbParol.Size = new Size(286, 31);
            txbParol.TabIndex = 5;
            // 
            // txbPhone
            // 
            txbPhone.Enabled = false;
            txbPhone.Location = new Point(190, 284);
            txbPhone.Margin = new Padding(4);
            txbPhone.Name = "txbPhone";
            txbPhone.Size = new Size(286, 31);
            txbPhone.TabIndex = 6;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Red;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(50, 48);
            btnBack.TabIndex = 7;
            btnBack.Text = "<<";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // UserInfoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(549, 381);
            Controls.Add(btnBack);
            Controls.Add(txbPhone);
            Controls.Add(txbParol);
            Controls.Add(txbName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "UserInfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txbName;
        private TextBox txbParol;
        private TextBox txbPhone;
        private Button btnBack;
    }
}