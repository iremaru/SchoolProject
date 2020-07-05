using System.IO;
using System.Xml;
using System.Linq;
using static CoreSchool.Util.Printer;
using static CoreSchool.Locations.LocatedText;
using System.Xml.Linq;

namespace CoreSchool.Locations
{
    public static class LocatedDataPersistence
    {
        //PATH
        const string DATADIRECTORY = "Data";
        const string FILENAME ="LocatedText.xml";
        
        //XML TREE
        public const string XMLROOTNAME ="TextLocatedPool";
        public const string XMLDATANAME = "TextLocated";
        public const string XMLDATAKEY = "Key";
        public const string XMLDATALANG1 = "ES";
        public const string XMLDATALANG2 = "ENG";
        

        
        #region METHODS
            public static bool LoadData()
            {
                XDocument doc = XDocument.Load($"{DATADIRECTORY}\\{FILENAME}");
                textLocatedPool = doc.Descendants(XMLROOTNAME)
                                        .Elements()
                                        .Select(node => 
                                            new LocatedTextData(
                                                node.Value, 
                                                node.Attribute(XMLDATALANG1).Value, 
                                                node.Attribute(XMLDATALANG2).Value))
                                        .ToArray();
                
                return true;
            }

            /// <summary>
            /// Save data. Save lives.
            /// </summary>
            /// <param name="data">You know. That which you want to keep.</param>
            /// <returns></returns>
            public static bool SaveLocatedTextData(LocatedTextData[] data){

                //If the user delete the directory
                if(!Directory.Exists("Data"))
                {
                    //First we complain to user (Bad, bad user ( ¬_¬)o )
                    IfUserHasDeleteProjectData("data directory");
                    //Then we repair the bad, bad user damages.
                    Directory.CreateDirectory("Data");
                }

                XmlWriter savingData = XmlWriter.Create($"{DATADIRECTORY}\\{FILENAME}");            
                savingData.WriteStartDocument();
                savingData.WriteStartElement(XMLROOTNAME);

                foreach (var item in data)
                {
                    savingData.WriteStartElement(XMLDATANAME);
                    savingData.WriteAttributeString(XMLDATALANG1, item.TextES);
                    savingData.WriteAttributeString(XMLDATALANG2, item.TextENG);
                    savingData.WriteString(item.Key);
                    savingData.WriteEndElement();
                }

                savingData.WriteEndDocument();
                savingData.Close();

                return true;
            }
        
        #endregion
    }
}