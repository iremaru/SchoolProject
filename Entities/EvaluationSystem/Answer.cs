using CoreSchool.Locations;

namespace CoreSchool.Entities.Evaluation
{
    public class Answer
    {
        public LocatedTextData Argument { get; set; }
        public bool IsTrue { get; set; }

        public Answer(LocatedTextData argument, bool isTrue = false)
        {
            Argument = argument;
            IsTrue = isTrue;
        }
    }
}