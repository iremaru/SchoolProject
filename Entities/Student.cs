using System;

namespace CoreSchool.Entities
{
    class Student
    {
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public Term[] RegistratedTerms { get; set; }
    }
}