using System;
using static CoreSchool.Locations.LocatedDataPersistence;


namespace CoreSchool.Locations
{
    public class LocatedText
    {
        //public static LocatedTextData[] textLocatedPool = new LocatedTextData[0];
        public static LocatedTextData[] textLocatedPool {get; set;}
        
        #region METHODS
            public bool SaveData(){

                return SaveLocatedTextData(textLocatedPool);
            }
        
            public static string PickLocatedText(string key, string langCode)
            {
                foreach (LocatedTextData item in textLocatedPool)
                {
                    if(item.Key == key)
                    {
                        switch (langCode)
                        {
                            case XMLDATALANG1:
                                return item.TextES;
                            case XMLDATALANG2:
                                return item.TextENG;
                            default:
                                break;
                        }
                    }
                }
                
                Console.WriteLine($"WARNING: The key {key} or the language code {langCode}\nis incorrect.");
                //TODO: Log misprints in a document; not printed them in console.
                return " ";
            }
        #endregion

        }

}