using System;

namespace CoreSchool.Entities
{
    public class Teacher : Entitie
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public TeacherPosition TeacherPosition { get; set; }
        public DirectivePosition DirectivePosition { get; set; }

        public DateTime HiredDate { get; set; }
        public float Salary { get; private set; }

        #region CONSTRUCTOR
            
            public Teacher(String firstName, String lastName, DateTime hiredDate) : base(name: "Teacher")
            {
                FirstName = firstName;
                LastName = lastName;
                TeacherPosition = TeacherPosition.None;
                DirectivePosition = DirectivePosition.None;
                HiredDate = hiredDate;
            }
        #endregion

        #region METHODS
            
            public float CalculateSalary(float seniorityBonus)
            {
                float yearsOld = (DateTime.Now - HiredDate).Days / 365 ;
                
                //TODO: Include Teacher position and Directive Position bonus.
                //And a class for Salary Management.
                
                return seniorityBonus * yearsOld;
            }

        #endregion
    }
}