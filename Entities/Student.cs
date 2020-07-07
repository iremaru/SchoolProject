using System;
using System.Collections.Generic;

namespace CoreSchool.Entities
{
    public class Student : Entitie
    {
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public List<Term> RegistratedTerms { get; set; } = new List<Term>() ;

        public Student(string firstName, string lastName, Term term) : base("ENT-Tit-Student")
        {
            FirsName = firstName;
            LastName = lastName;
            EnrollmentDate = DateTime.Now;
            RegistratedTerms.Add(term);
        }
    }
}