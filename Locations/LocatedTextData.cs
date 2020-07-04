using System;

namespace CoreSchool.Locations
{
    public class LocatedTextData
    {
        public String Key { get; set; }
        public String TextES { get; set; }
        public String TextENG { get; set; }
        
        public LocatedTextData(String key, String textES, String textENG) 
        {
            Key = key;
            TextES = textES;
            TextENG = textENG;
        }
            
        
    }
}