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
            Util.Printer.Header("INICIO");

            //At the start of the program
            //we instantiate the School
            SchoolEngine engine = new SchoolEngine();
            //TODO: Mirar en el directorio si hay datos almacenados
            //En cuyo caso se instanciaría copiando esos datos.

            
            Util.Printer.Header("THIS IS THE EPIC AND AWESOME", "END FOR A EPIC AND AWESOME APP", 33);
        }
    }
}


