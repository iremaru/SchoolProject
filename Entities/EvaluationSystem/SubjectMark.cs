using CoreSchool.Entities;

namespace CoreSchool.Entities.Evaluation
{
    public class SubjectMark
    {
        public Student Student {get; set;}
        //public Subject Subject { get; set; }
        public float Score { get; set; }
        public string TeacherComment { get; set; }
    }
}