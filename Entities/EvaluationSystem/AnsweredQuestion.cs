namespace CoreSchool.Entities.Evaluation
{
    public class AnsweredQuestion
    {
        public Question Question { get; set; }
        public Answer ChosenAnswer { get; set; }

        public AnsweredQuestion(Question question, Answer answer)
        {
            Question = question;
            ChosenAnswer = answer;
        }
    }
}