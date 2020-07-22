using System;
using Xunit;
using CoreSchool.Entities;
using CoreSchool.Locations;
using CoreSchool.Entities.Evaluation;
using System.Collections.Generic;

public class TestQuestion
{
    #region TEST DATA

        //SUT = System under test (Good to know)
        private readonly Question _sut;
        LocatedTextData statement = new  LocatedTextData("TEST-EVAL-StandarQuestion-Statement", "¿De qué color es el caballo blanco de Santiago?", "Why did the chicken cross the road?");
        LocatedTextData argumentA = new LocatedTextData("TEST-EVAL-StandarQuestion-AnswerA", "Rojo", "Because I call it.");
        LocatedTextData argumentB = new LocatedTextData("TEST-EVAL-StandarQuestion-AnswerB", "Amarillo", "I don't know");
        LocatedTextData argumentC = new LocatedTextData("TEST-EVAL-StandarQuestion-AnswerC", "Blanco", "Because it wants to get on the other side.");
        Answer[] answers;
        List<Question> questions;
        private TestQuestion()
        {
            answers = new Answer[] {
                new Answer(argumentA),
                new Answer(argumentB),
                new Answer(argumentC, true)};

            questions = new List<Question>()
            {
                new Question(statement, answers, Level.Low, Level.Low ),
                new Question(statement, answers, Level.Low, Level.Low ),
                new Question(statement, answers, Level.Low, Level.Low ),
                new Question(statement, answers, Level.Low, Level.Low ),
                new Question(statement, answers, Level.Low, Level.Low ),
                new Question(statement, answers, Level.Low, Level.Low ),
                new Question(statement, answers, Level.Low, Level.Low ),
                new Question(statement, answers, Level.Low, Level.Low ),
                new Question(statement, answers, Level.Low, Level.Low ),
                new Question(statement, answers, Level.Low, Level.Low ),
            };

            Teacher ProfeMaripi = new Teacher("Maria del Pino", "Santana", DateTime.Now);
            Student puppetStudent = new Student("Idaira", "Rodríguez Santana", new Term(DateTime.Today, DateTime.Today.AddYears(1)));
            Exam exam = new Exam(questions, ProfeMaripi, 10, 8); 
            
        }
    #endregion    
    
    // NO HAY SUFICIENTES RESPUESTAS DISPONIBLES
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    public void TestEachQuestionMustHaveTwoOrMoreAnswer(int answerCount)
    {
        
        answers = new Answer[answerCount];
        //Question question = new Question(statement,answers, Level.Low, Level.Low);

        Assert.True(new Question(statement, answers, Level.Low, Level.Low) == null, "Must be true");
    }

    // DEBE HABER 1 RESPUESTA CORRECTA Y 1 INCORRECTA.
    [Fact]
    public void TestName()
    {
    //Given
    
    //When
    
    //Then
    }
    

    

}