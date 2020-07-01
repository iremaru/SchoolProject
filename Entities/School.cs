using System;
using System.Collections.Generic;

namespace ProyectoEscuela.Entities
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
            public void Ring()
            {
                Console.Beep(2000, 300);
            }

            public void Presentation()
            {
                Console.WriteLine("Bienvenidos a la escuela " + name);
            }

            public override String ToString() {
                
                return base.ToString() + $"\nSchool name: {name}. \nSchool city: {City}";
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

