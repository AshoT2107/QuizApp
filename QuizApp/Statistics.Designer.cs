namespace QuizApp
{
    partial class StatisticsForm
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
            components = new System.ComponentModel.Container();
            pnlStatistics = new Panel();
            dgvStatistics = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            correctAnswerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            questionCountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statisticsBindingSource1 = new BindingSource(components);
            statisticsBindingSource = new BindingSource(components);
            pnlBack = new Panel();
            btnBack = new Button();
            pnlStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStatistics).BeginInit();
            ((System.ComponentModel.ISupportInitialize)statisticsBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)statisticsBindingSource).BeginInit();
            pnlBack.SuspendLayout();
            SuspendLayout();
            // 
            // pnlStatistics
            // 
            pnlStatistics.Controls.Add(dgvStatistics);
            pnlStatistics.Location = new Point(2, 0);
            pnlStatistics.Name = "pnlStatistics";
            pnlStatistics.Size = new Size(992, 627);
            pnlStatistics.TabIndex = 0;
            // 
            // dgvStatistics
            // 
            dgvStatistics.AllowUserToAddRows = false;
            dgvStatistics.AllowUserToDeleteRows = false;
            dgvStatistics.AutoGenerateColumns = false;
            dgvStatistics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStatistics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStatistics.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, userNameDataGridViewTextBoxColumn, correctAnswerDataGridViewTextBoxColumn, questionCountDataGridViewTextBoxColumn });
            dgvStatistics.DataSource = statisticsBindingSource1;
            dgvStatistics.Dock = DockStyle.Fill;
            dgvStatistics.Location = new Point(0, 0);
            dgvStatistics.Name = "dgvStatistics";
            dgvStatistics.ReadOnly = true;
            dgvStatistics.RowHeadersWidth = 62;
            dgvStatistics.RowTemplate.Height = 33;
            dgvStatistics.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvStatistics.Size = new Size(992, 627);
            dgvStatistics.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 8;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            userNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correctAnswerDataGridViewTextBoxColumn
            // 
            correctAnswerDataGridViewTextBoxColumn.DataPropertyName = "CorrectAnswer";
            correctAnswerDataGridViewTextBoxColumn.HeaderText = "CorrectAnswer";
            correctAnswerDataGridViewTextBoxColumn.MinimumWidth = 8;
            correctAnswerDataGridViewTextBoxColumn.Name = "correctAnswerDataGridViewTextBoxColumn";
            correctAnswerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // questionCountDataGridViewTextBoxColumn
            // 
            questionCountDataGridViewTextBoxColumn.DataPropertyName = "QuestionCount";
            questionCountDataGridViewTextBoxColumn.HeaderText = "QuestionCount";
            questionCountDataGridViewTextBoxColumn.MinimumWidth = 8;
            questionCountDataGridViewTextBoxColumn.Name = "questionCountDataGridViewTextBoxColumn";
            questionCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statisticsBindingSource1
            // 
            statisticsBindingSource1.DataSource = typeof(Model.Statistics);
            // 
            // statisticsBindingSource
            // 
            statisticsBindingSource.DataSource = typeof(Model.Statistics);
            // 
            // pnlBack
            // 
            pnlBack.Controls.Add(btnBack);
            pnlBack.Location = new Point(2, 633);
            pnlBack.Name = "pnlBack";
            pnlBack.Size = new Size(992, 40);
            pnlBack.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(3, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 1;
            btnBack.Text = "back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 679);
            Controls.Add(pnlBack);
            Controls.Add(pnlStatistics);
            Name = "StatisticsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Statistics";
            Load += StatisticsForm_Load;
            pnlStatistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStatistics).EndInit();
            ((System.ComponentModel.ISupportInitialize)statisticsBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)statisticsBindingSource).EndInit();
            pnlBack.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlStatistics;
        private DataGridView dgvStatistics;
        private Panel pnlBack;
        private BindingSource statisticsBindingSource;
        private Button btnBack;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correctAnswerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn questionCountDataGridViewTextBoxColumn;
        private BindingSource statisticsBindingSource1;
    }
}