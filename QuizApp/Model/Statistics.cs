namespace QuizApp.Model;

public class Statistics
{
    public int Id { get; set; } 

    public string UserName { get; set; }
    public int CorrectAnswer { get; set; }

    public int QuestionCount { get; set; }
}

public class StatisticsEntity
{
    public int Id { get; set; }

    public int UserId { get; set; }
    public int CorrectAnswerCount { get; set; }
    public int TicketQuestionCount { get; set; }

    public int TicketId {  get; set; }  
}
