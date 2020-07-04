using System;

namespace CoreSchool.Entities
{
    /// <summary>
    /// A course is 
    /// </summary>
    public class SchoolGrade : Entitie
    {
        #region PROPERTIES
            public ShiftType Shift {get; set;}
            public int maxStudents { get; set; }
            //TODO Tutor

        #endregion
        
        #region METHODS
            
        #endregion

        #region CONSTRUCTORS
            
            public SchoolGrade(String name, ShiftType shift) : base (name)
            {
                Shift = shift;
            }
        #endregion

    }
}