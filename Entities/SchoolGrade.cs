using System;
using System.Collections.Generic;

namespace CoreSchool.Entities
{
    /// <summary>
    /// A schoolGrade is a group of students who, guided by a tutor,
    /// learn the same compulsory subjects,
    /// leveled for their group according to the age of its members
    /// or their previous knowledge.
    /// </summary>
    public class SchoolGrade : Entitie
    {
        #region PROPERTIES
            
            /// <summary>
            /// The key that link this SchoolGrade with the LocatedTextData
            /// object that contains its name.
            /// </summary>
            public String LocatedSchoolGradeNameKey { get; set; }
            public ShiftType Shift {get; set;}
            public int MaxStudents { get; set; }
            public Teacher Tutor { get; set; }
            public List<Student> Students {get; set;}
            public List<Subject> RequiredSubjects { get; set; }
            public List<Subject> ElectiveSubjects { get; set; }

        #endregion
        
        #region METHODS
            
        #endregion

        #region CONSTRUCTORS
            
            public SchoolGrade(String nameKey, ShiftType shift, int maxStudents) : base ("ENT-Tit-SchoolGrade")
            {
                LocatedSchoolGradeNameKey = nameKey;
                Shift = shift;
                MaxStudents = maxStudents;
            }
        #endregion

    }
}