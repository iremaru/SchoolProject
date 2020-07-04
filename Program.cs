using System;
using CoreSchool;
using CoreSchool.Util;
using static System.Console;


namespace CoreSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer.Header("WELCOME");
            

            //At the start of the program
            //we instantiate the School
            SchoolEngine engine = new SchoolEngine();
            //TODO: Mirar en el directorio si hay datos almacenados
            //En cuyo caso se instanciaría copiando esos datos.
            
            //Printer.Ring(times: 2);
            Printer.Paragraph((DateTime.Now - DateTime.Now).ToString());

            Printer.Paragraph("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");

            
            Printer.Header("THIS IS THE EPIC AND AWESOME", "END FOR A EPIC AND AWESOME APP");
        }
    }
}


