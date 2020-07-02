using System;
using System.Collections.Generic;

namespace CoreSchool.Entities
{
    class School
    {
        #region ATTRIBUTES
            String name;
            public String Name
            { 
                get{ return name + " Academy";} 
                set{ name = value.ToLower();} 
            }
            public int FoundationYear { get; set; }
            public String City { get; set; }
            public int MyProperty { get; private set; }
            public SchoolTypes SchoolType { get; set; }

            public List<Course> Courses {get; set;}

        #endregion

        #region METHODS

            public void PrintCourses()
            {
                foreach (Course course in Courses)
                {
                    System.Console.WriteLine($"Course name: {course.Name} \nCourse ID: {course.UniqueId}");
                }
            }

            public void AddCourse(Course course)
            {
                if (Courses == null)
                    Courses = new List<Course>();

                Courses.Add(course);
            }

            public void RemoveCourseByName(String courseName)
            {
                //RemoveAll elimina todos los elementos que cumplan
                //los requisitos marcados por el predicado.

                //Una forma es mediante predicado.
                //bool Predicate(Course course) => (course.Name == courseName);
                //Courses.RemoveAll(Predicate);

                //Otra forma es mediante una expresión Lambda
                Courses.RemoveAll((course) => course.Name == courseName);
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
            public School(String name, String city, int foundationYear)
            {
                this.name = name;
                City = city + " city";
                FoundationYear = foundationYear;
            }
        
        #endregion

    }
}

