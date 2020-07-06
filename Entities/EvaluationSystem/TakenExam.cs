using System;
using System.Collections.Generic;

namespace CoreSchool.Entities.Evaluation
{
    public class TakenExam
    {
        public List<AnsweredQuestion> AnsweredQuestions { get; set; }
        public Student Student { get; set; }
        public DateTime Date { get; set; }
        public float Score { get; set; }

        public TakenExam(Student student, List<AnsweredQuestion> answeredQuestion, float score)
        {
            Student = student;
            AnsweredQuestions = answeredQuestion;
            Score = score;
            Date = DateTime.Now;
        }
    }
}