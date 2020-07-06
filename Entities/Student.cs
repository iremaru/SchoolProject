using System;
using System.Collections.Generic;
using CoreSchool.Entities.Evaluation;

namespace CoreSchool.Entities
{
    public class Student
    {
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public Term[] RegistratedTerms { get; set; }
        public SubjectReport SubjectReport { get; set; }
        /// <summary>
        /// List with each exam that the student has taken.
        /// </summary>
        public List<TakenExam> TakenExams { get; set; }

    }
}