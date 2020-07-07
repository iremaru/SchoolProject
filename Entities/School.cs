using System;
using System.Collections.Generic;

namespace CoreSchool.Entities
{
    class School : Entitie
    {
        #region ATTRIBUTES
            public String Name {get; set;}
            public int FoundationYear { get; set; }
            public String City { get; set; }
            public SchoolType SchoolType { get; set; }

            public List<SchoolGrade> Courses {get; set;}

        #endregion


        #region METHODS

            public void PrintCourses()
            {
                foreach (SchoolGrade course in Courses)
                {
                    System.Console.WriteLine($"Course name: {course.Title} \nCourse ID: {course.UniqueID}");
                }
            }

            public void AddCourse(SchoolGrade course)
            {
                if (Courses == null)
                    Courses = new List<SchoolGrade>();

                Courses.Add(course);
            }

            public void RemoveCourseByName(String courseName)
            {
                Courses.RemoveAll((course) => course.Title == courseName);
            }

            public T Test<T>(Predicate<T> predicate, List<T> collection){
                foreach (var item in collection)
                {
                    if(predicate(item))
                    return item;
                }
                
                return default(T);
            }


        #endregion

        #region CONSTRUCTORS

            /// <summary>
        /// Instanciate the class School
        /// </summary>
        /// <param name="_name">The name of the school</param>
            public School(String name) => Name = name;

            /// <summary>
            /// Instatiate the class School with only twho parameters
            /// </summary>
            /// <param name="name">The name of the school</param>
            /// <param name="city">The city where the school is located</param>
            /// <returns></returns>
            public School(String name, String city) => (Name, City) = (name, city);

            /// <summary>
            /// Instanciate the class School with all its properties
            /// </summary>
            /// <param name="name">The name of the school</param>
            /// <param name="city">The city where the school is stablished</param>
            /// <param name="foundationYear">The year the school was founded</param>
            /// <param name="SchoolType">What type of education does thies school offer?</param>
            public School(string name, int foundationYear, string city, SchoolType schoolType) : base("ENT-Tit-School")
            {
                Name = name;
                City = city;
                FoundationYear = foundationYear;
                SchoolType = schoolType;
            }
        
        #endregion

    }
}

