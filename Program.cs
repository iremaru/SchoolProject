using System;
using System.Xml;
using CoreSchool;
using CoreSchool.Locations;
using CoreSchool.Util;
using static CoreSchool.Util.Printer;
using System.IO;


namespace CoreSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1();
        }

        static void Test1(){

            //First we manually enter the data
            LocatedTextData[] data = new LocatedTextData[4]{
                new LocatedTextData("001", "Hola", "Hello"),
                new LocatedTextData("002", "Bienvenido", "Welcome"),
                new LocatedTextData("003", "Un placer conocerle", "Nice to meet you"),
                new LocatedTextData("004", "Adios", "Bye")
            };
            
            //Then we saved it
            if (Locations.LocatedText.SaveLocatedTextData(data))
            {
                Paragraph("Located text saved. Hurrah!!");
            }
            
            //And load it.
            Locations.LocatedText.LoadData();

            //Welcome poblated pool!
            if (LocatedText.textLocatedPool.Length > 0)
            {
                Header(LocatedText.textLocatedPool[0].TextENG);
            }
            
        }

        static void Test2 ()
        {
            //SCREEN 0
            Header("WELCOME");
            WaitForUser();

            //SCREEN 1
            Paragraph("Todai is:");
            Paragraph(DateTime.Now.ToString());
            WaitForUser();

            //SCREEN 2
            Paragraph("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");
            WaitForUser();

            //SCREEN 3
            Header("THIS IS THE EPIC AND AWESOME", "END FOR A EPIC AND AWESOME APP");
            WaitForUser(); 
        }
    }
}


