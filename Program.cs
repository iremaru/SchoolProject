using System;
using ProyectoEscuela.Entities;
using static System.Console;


namespace ProyectoEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School("Santa Cristina", "Las Palmas de Gran Canaria", 1612);
            Course course1 = new Course("1ºA", ShiftType.Morning);
            Course course2 = new Course("1ºB", ShiftType.Morning);

            school.AddCourse(course1);
            school.AddCourse(course2);

            //Testing how to use a Predicate in my own method.
            //This function must return course1 name = 1ªA
            WriteLine(school.Test((course) => course.UniqueId == course1.UniqueId, school.Courses).Name);
            school.RemoveCourseByName(course1.Name);
            
            //Now course1 has be deleted so...
            Course testResult = school.Test((course) => course.UniqueId == course1.UniqueId, school.Courses);
            WriteLine(testResult == null ? "Course not found" : $"The course name is {testResult.Name}" );

            try
            {
                school.PrintCourses();
            }
            catch (NullReferenceException e)
            {
                
                if (e.Source != null)
                {
                    WriteLine("Error: There are not courses list in " + e.Source);
                    WriteLine("Please, before print the course list, create it.");
                    WriteLine("( ^_^)");
                    return;
                }
                throw;
            }
        }
    }
}


