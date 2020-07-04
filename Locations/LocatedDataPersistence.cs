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
        const string DATADIRECTORY = "Data";
        const string FILENAME ="LocatedText.xml";
        const string XMLROOTNAME ="TextLocatedPool";
        const string XMLDATANAME = "TextLocated";
        const string XMLDATAKEY = "Key";
        const string XMLDATALANG1 = "ES";
        const string XMLDATALANG2 = "ENG";
        

        
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