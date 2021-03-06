using System;
using static System.Console;
using static CoreSchool.Locations.LocatedDataPersistence;
using static CoreSchool.Locations.LocatedText;

namespace CoreSchool.Util
{
    public static class Printer
    {
        #region PROPERTIES
            static public string Language { get; set; }
            const string BEAUTIFIERIN = "*+_";
            const string BEAUTIFIEROUT = "_+*";
            const string MARGINLEFT = "    ";
            const int PARAGRAPHWIDE = 55;

        #endregion

        public static void WaitForUser()
        {

            WriteLine("Press ENTER when you are ready.");
            WaitForUserInput();
        }

        public static string WaitForUserInput()
        {
            string key = ReadKey().KeyChar.ToString();
            Clear();
            return key;
        }

        /// <summary>
        /// Print the title and the subtitle,
        /// if applicable, in the console.
        /// </summary>
        /// <param name="title">Text</param>
        /// <param name="subtitle">Text printed under the title</param>
        /// <param name="width">Header width</param>
        public static void Header(string title, string subtitle = null, int width = PARAGRAPHWIDE)
        {
            //We prepare the sections that will make up the line
            //string line = "".PadLeft(width, '=');

            //Now we calculate the margin to center the title
            int marginHeaderName = title.Length < width ?
                ((width - title.Length) / 2) + BEAUTIFIERIN.Length :
                    BEAUTIFIERIN.Length;
            //And set the spacing that will center the title
            string spaceHeader = "".PadLeft(marginHeaderName, ' ');

            //Finally, the header:
            WriteLine();
            //WriteLine($"{BEAUTIFIERIN}{line}{BEAUTIFIEROUT}");
            LineTop(width);
            WriteLine($"{spaceHeader}{title}");
            if(subtitle != null)
                WriteLine($"{spaceHeader}{subtitle}");
            LineBottom(width);
            //WriteLine($"{BEAUTIFIEROUT}{line}{BEAUTIFIERIN}");
            WriteLine();
        }
    
        public static void Paragraph(string text, int width = PARAGRAPHWIDE){

            string line = MARGINLEFT + text;

            while(line.Length > width)
            {
                //We write this line
                WriteLine(line.Substring(0, width));

                //Now we put the rest of the text in "line" 
                //removing what we have already printed.
                line = line.Substring(width);

                //If first char is " ", we don't want it.
                if(line[0] == ' ')
                {
                    line = line.Substring(1);
                }

                //And now we apply margin left.
                line = MARGINLEFT + line;
            }

            if(line.Length < width)
            {
                WriteLine(line);
            }

            //We end with spacing:
            WriteLine();

        }
        public static void Ring(int hz = 1000, int duration = 500, int times = 1)
        {

            while (times-- >0)
            {
                Beep(hz, duration);
                WriteLine($"{MARGINLEFT}Ring");
            }
            
        }
    
        public static void LineTop(int width = PARAGRAPHWIDE)
        {
            WriteLine(BEAUTIFIERIN + "".PadLeft(width, '=') + BEAUTIFIEROUT);
        }

        public static void LineBottom(int width = PARAGRAPHWIDE)
        {
            WriteLine(BEAUTIFIEROUT + "".PadLeft(width, '=') + BEAUTIFIERIN);
        }

        public static void SetLanguage(string key)
        {
            
            switch (key.ToUpper())
            {
                case "E":
                    Language = XMLDATALANG2;
                    break;
                case "Ñ":
                    Language = XMLDATALANG1;
                    break;
                default:
                    Language = XMLDATALANG2;
                    break;
            }
        }
        public static string Translate(string key)
        {
            return PickLocatedText(key, Language);
        }

        #region WARNING AND COMPLAINTS TO USERS
            
            public static void IfUserHasDeleteProjectData(String dataName)
            {
                Paragraph("Why do you like me too bad? ( T_T)");
                Paragraph($"Why did you delete my {dataName}?");
                Paragraph("Why?");
                Paragraph("Why?");
                Paragraph("Why?");
                Paragraph("( >___<)o ");
            }
        #endregion

    }

}