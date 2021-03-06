﻿using System;
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
            SchoolEngine engine = new SchoolEngine();
            engine.InitializeSchool();

            Header("IDIOMA || LANGUAGE");
            Paragraph("Press \"E\" to set ENGLISH.");
            Paragraph("Pulsa \"Ñ\" para seleccionar ESPAÑOL");
            SetLanguage(WaitForUserInput());

            Test1();
        }

        static void Test1(){
            
            //Load that up!
            //Locations.LocatedDataPersistence.LoadData();

            //Welcome poblated pool!
            if (LocatedText.textLocatedPool.Length > 0)
            {
                Header(Translate("002").ToUpper());
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


