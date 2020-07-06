using System.Collections.Generic;

namespace CoreSchool.Entities.Evaluation
{
    public class Evaluation
    {
        public Exam exam { get; set; }
        public List<TakenExam> TakenExam { get; set; }
        public TakenExam BestExam { get; set; }
        public float AverageScore { get; set; }
    }
}