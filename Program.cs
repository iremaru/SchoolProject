using System;
using ProyectoEscuela.Entities;

namespace ProyectoEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            School school0 = new School("Santa Marta");
            School school1 = new School("María Auxiliadora", "Santa Cruz de Tenerife");
            School school2 = new School("Santa Cristina", "Las Palmas de Gran Canaria", 1612);

            try
            {
                school0.PrintCourses();
            }
            catch (NullReferenceException e)
            {
                
                if (e.Source != null)
                {
                    Console.WriteLine("Error: There are not courses list in " + e.Source);
                    Console.WriteLine("Please, before print the course list, create it.");
                    Console.WriteLine("( ^_^)");
                    return;
                }
                throw;
            }
        }
    }
}


