using System;
using static CoreSchool.Util.Printer;
using CoreSchool.Entities.EvaluationSystem;


namespace CoreSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolEngine engine = new SchoolEngine();
            engine.InitializeSchool();

            Test1();
        }

        static void Test1(){
            
            Locations.LocatedTextData statement = new Locations.LocatedTextData("TEST-EVAL-StandarQuestion-Statement", "¿De qué color es el caballo blanco de Santiago?", "Why did the chicken cross the road?");
            Locations.LocatedTextData argumentA = new Locations.LocatedTextData("TEST-EVAL-StandarQuestion-AnswerA", "Rojo", "Because I call it.");
            Locations.LocatedTextData argumentB = new Locations.LocatedTextData("TEST-EVAL-StandarQuestion-AnswerB", "Amarillo", "I don't know");
            Locations.LocatedTextData argumentC = new Locations.LocatedTextData("TEST-EVAL-StandarQuestion-AnswerC", "Blanco", "Because it wants to get on the other side.");
            
            Answer[] answers = {
                new Answer(argumentA),
                new Answer(argumentB),
                new Answer(argumentC, true)
            };

            Question[] questions = {
                new Question(statement, answers, Level.Low, Level.Low ),
            };

            Paragraph(questions[0].Value.ToString());
            
        }

        static void Test2 ()
        {
            //SCREEN 0
            Header("IDIOMA || LANGUAGE");
            Paragraph("Press \"E\" to set ENGLISH.");
            Paragraph("Pulsa \"Ñ\" para seleccionar ESPAÑOL");
            SetLanguage(WaitForUserInput());

            //SCREEN 1
            Paragraph("Todai is:");
            Paragraph(DateTime.Now.ToString());
            WaitForUser();

            //SCREEN 2
            Paragraph("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");
            WaitForUser();

            //SCREEN 3
            Header("THIS IS THE EPIC AND AWESOME", "END FOR A EPIC AND AWESOME APP");
            WaitForUser(); 
        }
    }
}


