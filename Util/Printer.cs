using static System.Console;

namespace CoreSchool.Util
{
    public static class Printer
    {
        /// <summary>
        /// Print the title and the subtitle,
        /// if applicable, in the console.
        /// </summary>
        /// <param name="title">Text</param>
        /// <param name="subtitle">Text printed under the title</param>
        /// <param name="width">Header width</param>
        public static void Header(string title, string subtitle = null, int width = 20)
        {
            //We prepare the sections that will make up the line
            string BEAUTIFIERIN = "*+_";
            string BEAUTIFIEROUT = "_+*";
            string line = "".PadLeft(width, '=');

            //Now we calculate the margin to center the title
            int marginHeaderName = title.Length < width ?
                ((width - title.Length) / 2) + BEAUTIFIERIN.Length :
                    BEAUTIFIERIN.Length;
            //And set the spacing that will center the title
            string spaceHeader = "".PadLeft(marginHeaderName, ' ');

            //Finally, the header:
            WriteLine($"{BEAUTIFIERIN}{line}{BEAUTIFIEROUT}");

            WriteLine($"{spaceHeader}{title}");
            if(subtitle != null)
                WriteLine($"{spaceHeader}{subtitle}");
            
            WriteLine($"{BEAUTIFIEROUT}{line}{BEAUTIFIERIN}");
        }
    }
}