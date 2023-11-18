namespace QuizApp
{
    partial class QuestionsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            QuestionsDataGrid = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            questionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            answerADataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            answerBDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            answerCDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            correctAnswerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            questionEntityBindingSource = new BindingSource(components);
            panel1 = new Panel();
            btnQuestionBack = new Button();
            ((System.ComponentModel.ISupportInitialize)QuestionsDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)questionEntityBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // QuestionsDataGrid
            // 
            QuestionsDataGrid.AllowUserToAddRows = false;
            QuestionsDataGrid.AllowUserToDeleteRows = false;
            QuestionsDataGrid.AutoGenerateColumns = false;
            QuestionsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            QuestionsDataGrid.BackgroundColor = Color.White;
            QuestionsDataGrid.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 0, 192);
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            QuestionsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            QuestionsDataGrid.ColumnHeadersHeight = 40;
            QuestionsDataGrid.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, questionDataGridViewTextBoxColumn, answerADataGridViewTextBoxColumn, answerBDataGridViewTextBoxColumn, answerCDataGridViewTextBoxColumn, correctAnswerDataGridViewTextBoxColumn });
            QuestionsDataGrid.DataSource = questionEntityBindingSource;
            QuestionsDataGrid.Location = new Point(0, 0);
            QuestionsDataGrid.Margin = new Padding(4, 4, 4, 4);
            QuestionsDataGrid.Name = "QuestionsDataGrid";
            QuestionsDataGrid.ReadOnly = true;
            QuestionsDataGrid.RowHeadersWidth = 51;
            QuestionsDataGrid.RowTemplate.Height = 29;
            QuestionsDataGrid.Size = new Size(1158, 839);
            QuestionsDataGrid.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // questionDataGridViewTextBoxColumn
            // 
            questionDataGridViewTextBoxColumn.DataPropertyName = "Question";
            questionDataGridViewTextBoxColumn.HeaderText = "Question";
            questionDataGridViewTextBoxColumn.MinimumWidth = 6;
            questionDataGridViewTextBoxColumn.Name = "questionDataGridViewTextBoxColumn";
            questionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // answerADataGridViewTextBoxColumn
            // 
            answerADataGridViewTextBoxColumn.DataPropertyName = "AnswerA";
            answerADataGridViewTextBoxColumn.HeaderText = "AnswerA";
            answerADataGridViewTextBoxColumn.MinimumWidth = 6;
            answerADataGridViewTextBoxColumn.Name = "answerADataGridViewTextBoxColumn";
            answerADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // answerBDataGridViewTextBoxColumn
            // 
            answerBDataGridViewTextBoxColumn.DataPropertyName = "AnswerB";
            answerBDataGridViewTextBoxColumn.HeaderText = "AnswerB";
            answerBDataGridViewTextBoxColumn.MinimumWidth = 6;
            answerBDataGridViewTextBoxColumn.Name = "answerBDataGridViewTextBoxColumn";
            answerBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // answerCDataGridViewTextBoxColumn
            // 
            answerCDataGridViewTextBoxColumn.DataPropertyName = "AnswerC";
            answerCDataGridViewTextBoxColumn.HeaderText = "AnswerC";
            answerCDataGridViewTextBoxColumn.MinimumWidth = 6;
            answerCDataGridViewTextBoxColumn.Name = "answerCDataGridViewTextBoxColumn";
            answerCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correctAnswerDataGridViewTextBoxColumn
            // 
            correctAnswerDataGridViewTextBoxColumn.DataPropertyName = "CorrectAnswer";
            correctAnswerDataGridViewTextBoxColumn.HeaderText = "CorrectAnswer";
            correctAnswerDataGridViewTextBoxColumn.MinimumWidth = 6;
            correctAnswerDataGridViewTextBoxColumn.Name = "correctAnswerDataGridViewTextBoxColumn";
            correctAnswerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // questionEntityBindingSource
            // 
            questionEntityBindingSource.DataSource = typeof(Model.QuestionEntity);
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnQuestionBack);
            panel1.Location = new Point(0, 836);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1158, 64);
            panel1.TabIndex = 1;
            // 
            // btnQuestionBack
            // 
            btnQuestionBack.BackColor = Color.FromArgb(128, 128, 255);
            btnQuestionBack.ForeColor = Color.White;
            btnQuestionBack.Location = new Point(4, 4);
            btnQuestionBack.Margin = new Padding(4, 4, 4, 4);
            btnQuestionBack.Name = "btnQuestionBack";
            btnQuestionBack.Size = new Size(208, 56);
            btnQuestionBack.TabIndex = 0;
            btnQuestionBack.Text = "Back";
            btnQuestionBack.UseVisualStyleBackColor = false;
            btnQuestionBack.Click += btnQuestionBack_Click;
            // 
            // QuestionsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 904);
            Controls.Add(panel1);
            Controls.Add(QuestionsDataGrid);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 4, 4, 4);
            Name = "QuestionsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Questions";
            Load += QuestionsForm_Load;
            ((System.ComponentModel.ISupportInitialize)QuestionsDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)questionEntityBindingSource).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView QuestionsDataGrid;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn answerADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn answerBDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn answerCDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correctAnswerDataGridViewTextBoxColumn;
        private BindingSource questionEntityBindingSource;
        private Panel panel1;
        private Button btnQuestionBack;
    }
}