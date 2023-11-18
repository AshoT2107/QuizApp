using Microsoft.Data.Sqlite;
using QuizApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Services
{
    public class QuestionService
    {
        private SqliteConnection _connection;
        private SqliteCommand _command;
        private SqliteParameter _parameter;
        public QuestionService()
        {
            _connection = new SqliteConnection($"Data Source = data.db");
            _command = _connection.CreateCommand();
            _parameter = _command.CreateParameter();
            CreateTable();
        }

        private void CreateTable()
        {
            _command.CommandText = @"CREATE TABLE IF NOT EXISTS questions( 
id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
question Text, 
answer_a Text, 
answer_b Text,
answer_c Text,
correct_answer Text);";
            Execute();
        }

        private void Execute()
        {
            _connection.Open();
            _command.ExecuteNonQuery();
            _connection.Close();
        }

        public void InsertQuestion(QuestionEntity entity)
        {
            _command.CommandText = @$"INSERT INTO questions 
(question, answer_a, answer_b, answer_c, correct_answer) VALUES 
(@question, @answerA, @answerB, @answerC, @correctAnswer)";
            
            _command.Parameters.AddWithValue("@question", entity.Question);
            _command.Parameters.AddWithValue("@answerA", entity.AnswerA);
            _command.Parameters.AddWithValue("@answerB", entity.AnswerB);
            _command.Parameters.AddWithValue("@answerC", entity.AnswerC);
            _command.Parameters.AddWithValue("@correctAnswer", entity.CorrectAnswer);
            Execute();
        }

        public List<QuestionEntity> GetQuestions()
        {
            _command.CommandText = @"SELECT * FROM questions";
            _connection.Open();
            var data = _command.ExecuteReader();

            List<QuestionEntity> entities = new List<QuestionEntity>();

            while (data.Read())
            {
                QuestionEntity entity = new QuestionEntity()
                {
                    Id = data.GetInt32(0),
                    Question = data.GetString(1),
                    AnswerA = data.GetString(2),
                    AnswerB = data.GetString(3),
                    AnswerC = data.GetString(4),
                    CorrectAnswer = data.GetString(5)
                };

                entities.Add(entity);
            }
            data.Close();
            _connection.Close();

            return entities;
        }


        public List<int> GetQuestionIds()
        {
            _command.CommandText = @"SELECT id FROM questions order by id asc";
            _connection.Open();
            var data = _command.ExecuteReader();

            List<int> entityIds = new List<int>();

            while (data.Read())
            {
                int id = data.GetInt32(0);

                entityIds.Add(id);
            }
            data.Close();
            _connection.Close();

            return entityIds;
        }

        public QuestionEntity GetQuestionById(int Id)
        {
            _command.CommandText = @$"SELECT * FROM questions WHERE question_index = {Id}";
            _connection.Open();
            var data = _command.ExecuteReader();

            QuestionEntity entity = new QuestionEntity();

            while (data.Read())
            {
                entity = new QuestionEntity()
                {
                    Id = data.GetInt32(0),
                    Question = data.GetString(1),
                    AnswerA = data.GetString(2),
                    AnswerB = data.GetString(3),
                    AnswerC = data.GetString(4),
                    CorrectAnswer = data.GetString(5),
                    QuestionIndex = data.GetInt32(8),
                };
            }
            data.Close();
            _connection.Close();

            return entity;
        }

        public void InsertStatistiks(int userId, int ticketId, int correctAnswersCount, int questionCount)
        {
            _command.CommandText = @$"insert into 
user_statistics (user_id, ticket_id, correct_answer_count, ticket_question_count)
values ({userId}, {ticketId}, {correctAnswersCount}, {questionCount})";

            Execute();
        }

        public List<StatisticsEntity> GetStatistics()
        {
            _command.CommandText = @"SELECT * FROM user_statistics";
            _connection.Open();
            var data = _command.ExecuteReader();

            List<StatisticsEntity> entities = new List<StatisticsEntity>();

            while (data.Read())
            {
                StatisticsEntity entity = new StatisticsEntity()
                {
                    Id = data.GetInt32(0),
                    UserId = data.GetInt32(1),
                    CorrectAnswerCount = data.GetInt32(2),
                    TicketQuestionCount = data.GetInt32(3),
                    TicketId = data.GetInt32(4),
                };

                entities.Add(entity);
            }
            data.Close();
            _connection.Close();

            return entities;
        }
    }
}
