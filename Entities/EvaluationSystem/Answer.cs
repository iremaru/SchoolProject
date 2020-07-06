using CoreSchool.Locations;

namespace CoreSchool.Entities.EvaluationSystem
{
    public class Answer
    {
        public LocatedTextData Argument { get; set; }
        public bool IsTrue { get; set; }
    }
}