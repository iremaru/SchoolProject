using System;

namespace ProyectoEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            Entities.School escuela = new Entities.School("Santa Marta");
            escuela.Presentation();
            escuela.Ring();

            Entities.School school = new Entities.School("Santa Cristina", "Las Palmas de Gran Canaria", 1612);
            Entities.School school2 = new Entities.School("María Auxiliadora", "Santa Cruz de Tenerife");

            Console.WriteLine(school2.ToString());
        }
    }
}
