using System;
using System.Collections.Generic;
using static CoreSchool.Util.Printer;

namespace CoreSchool.Entities.Evaluation
{
    public class Exam
    {
        /// <summary>
        /// All questions that could be on the generated exam.
        /// </summary>
        public List<Question> QuestionPool { get; set; }
        /// <summary>
        /// How much questions will there be on each exam?
        /// </summary>
        public int QuestionPerExam { get; set; }
        /// <summary>
        /// Minimun mark to pass the exam.
        /// </summary>
        public float MinimunMark { get; set; }
        public Teacher CreatedBy { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public Exam(List<Question> questions, Teacher teacher, int questionPerExam = 10, float minimunMark = 5)
        {
            if (!ValidateExam(questions, questionPerExam))
            {
                return;
            }
            QuestionPool = questions;
            CreatedBy = teacher;
            QuestionPerExam = questionPerExam;
            MinimunMark = minimunMark;
            CreatedAt = DateTime.Now;

        }

        public bool ValidateExam(List<Question> questions, int questionPerExam = 10)
        {
            //Please, not exam with 1 or no questions.
            //We don't approve Students just for comming.
            if (questions.Count <= 1)
            {
                Paragraph(Translate("WAR-MKEval-TooFewQuestions"));
                return false;
            }
            // On the list of worst exams ever: The exam with 100 questions... 100 times the same question
            if (questionPerExam > questions.Count)
            {
                Paragraph(Translate("WAR-MKEval-FewerAvaliableQuestionsThanMinimunQuestions"));
                return false;
            }

            return true;
        }

    }
}