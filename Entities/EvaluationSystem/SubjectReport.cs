namespace CoreSchool.Entities.Evaluation
{
    public class SubjectReport
    {
        public Student Student { get; set; }
        public SubjectMark[] marks { get; set; }
    }
}