using System;

namespace ProyectoEscuela.Entities
{
    public class Course
    {
        #region PROPERTIES
            public String UniqueId { get; private set; }
            public String Name { get; set; }
            public ShiftType Shift {get; set;}

            //TODO max alumnos
            //TODO Tutor

        #endregion
        
        #region METHODS
            
        #endregion

        #region CONSTRUCTORS
            
            public Course(String name, ShiftType shift)
            {
                UniqueId = Guid.NewGuid().ToString();
                Name = name;
                Shift = shift;
            }
        #endregion

    }
}