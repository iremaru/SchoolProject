using System.Xml;

namespace CoreSchool.Locations
{
    public class TextLocated
    {
        public (string key, string textES, string textENG)[] textLocatedPool;

        public bool saveData((string key, string textES, string textENG)[] data){

            XmlWriter savingData = XmlWriter.Create("Data\\LocatedText.xml");
            savingData.WriteStartDocument();
            savingData.WriteStartElement("TestLocated");
            
            savingData.WriteStartElement("TextLocatedPool");
            savingData.WriteAttributeString("ES", "Hola");
            savingData.WriteAttributeString("ENG", "Hello");
            savingData.WriteString("001");
            savingData.WriteEndElement();

            savingData.WriteEndDocument();
            savingData.Close();

            return true;
        }

        public static bool SaveData(){

            XmlWriter savingData = XmlWriter.Create("Data\\LocatedText.xml");
            savingData.WriteStartDocument();
            savingData.WriteStartElement("TextLocatedPool");
            
            savingData.WriteStartElement("TextLocated");
            savingData.WriteAttributeString("ES", "Hola");
            savingData.WriteAttributeString("ENG", "Hello");
            savingData.WriteString("001");
            savingData.WriteEndElement();

            savingData.WriteEndDocument();
            savingData.Close();

            return true;
        }
    }

}