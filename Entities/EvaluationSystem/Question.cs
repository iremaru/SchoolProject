using CoreSchool.Locations;
using static CoreSchool.Util.Printer;

namespace CoreSchool.Entities.EvaluationSystem
{
    public class Question
    {
        /// <summary>
        /// The statement of the question
        /// </summary>
        public LocatedTextData Statement { get; set; }
        
        /// <summary>
        /// All the answers with their truth value
        /// </summary>
        public Answer[] Answers { get; set; }
        
        /// <summary>
        /// How difficult is this question?
        /// Null: The statement is self-expalantory
        /// Low: All the answers are absurd except the correct one
        /// Middle: Is a average question
        /// Normal: The student has to think to find the most optimal solution.
        /// High: Is a trick question
        /// Insane: Only an expert in the matter would understand the problem
        /// </summary>
        public Level QuestionComplexity { get; set; }

        /// <summary>
        /// How important is this mater when using the practical knowledge of the subject?
        /// Null: Is only an anecdote or general culture. The student never need it in a proyect.
        /// Low: The student will rarely need it in a real proyect.
        /// Middle: They will need it frequently in a proyect.
        /// High: They will always need it.
        /// Insane: They will not be able to do anything without this.
        /// </summary>
        public Level QuestionRelevance { get; set; }
        /// <summary>
        /// The teacher never will be able to set this parameter.
        /// It is the question weight in the exam.
        /// </summary>
        /// <value></value>
        public float Value { get; set; }
        private const int MINIMUNVALUE = 1;
        
        public Question(LocatedTextData statement, Answer[] answers, Level complexity, Level relevance)
        {
            if(!IsAnswersValid(answers)) return;

            Statement = statement;
            Answers = answers;
            QuestionComplexity = complexity;
            QuestionRelevance = relevance;

        }

        public bool IsAnswersValid(Answer[] answers = null)
        {
            if (answers == null)
            {
                answers = Answers;
            }

            //Not enought answers
            if (answers.Length < 3)
            {
                Paragraph(Translate("WAR-MKEval-NotEnoughtAnswers"));
                return false;
            }

            //There must be at least one correct question and, at least, one incorrect question.
            if (GetAnswerByVeracity(true) != null && GetAnswerByVeracity(false) != null)
            {
                Paragraph(Translate("WAR-MKEval-CorrectOrIncorrectAnswersAreMissing"));
                return false;
            }

            return true;
        }

        /// <summary>
        /// Returns the first answer that matches the given truth value. 
        /// </summary>
        /// <param name="isCorrect">Are you looking for a correct or incorrect answer?</param>
        /// <param name="answers">The group of answers you want to snoop on</param>
        /// <returns>The Answer</returns>
        public Answer GetAnswerByVeracity(bool isCorrect, Answer[] answers = null)
        {
            if (answers == null)
            {
                answers = Answers;
            }

            foreach (Answer answer in answers)
            {
                if (answer.IsTrue == isCorrect)
                    return answer;
            }

            return default;
        }

        /// <summary>
        /// The value of the question will depend on how difficult
        /// it is to know the correct answer, but more importantly,
        /// how necessary that knowledge is for the student.
        /// </summary>
        /// <param name="complexity">How difficult is to know the correct answer?</param>
        /// <param name="relevance">How necessary is this knowledge to carry out a real project?</param>
        /// <returns>The question value</returns>
        public float CalculateValue(Level complexity, Level relevance)
        {
            //How important is the relevance?
            float relevanceValue = (int)relevance * 1.5f;

            switch (complexity)
            {
                case Level.Null:
                    // No matter the relevance. Answering correctly only means that you can read.
                    return 0.3f;
                case Level.Low:
                    // You may know the correct answers, but much more likely you can discard the wrong answers.
                    return  (relevanceValue * 0.3f)/6;
                default:
                    return  (relevanceValue * (int)relevance) / (int)complexity;
            }
            
        }

    }
}