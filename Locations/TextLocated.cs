using static System.Console;
using System.IO;
using System.Xml;

namespace CoreSchool.Locations
{
    public class TextLocated
    {
        public (string key, string textES, string textENG)[] textLocatedPool;

        public bool saveData((string key, string textES, string textENG)[] data){

            if(!Directory.Exists("Data"))
            {
                WriteLine("Why do you like me too bad? ( ≧Д≦)");
                WriteLine("Why did you delete my data directory?");
                WriteLine("Why?");
                WriteLine("Why?");
                WriteLine("Why?");
                WriteLine("(੭ ˃̣̣̥ ㅂ˂̣̣̥)੭ु ");

                Directory.CreateDirectory("Data");
            }

            XmlWriter savingData = XmlWriter.Create("Data\\LocatedText.xml");            
            savingData.WriteStartDocument();
            savingData.WriteStartElement("TextLocatedPool");

            foreach (var item in data)
            {
                savingData.WriteStartElement("TextLocated");
                savingData.WriteAttributeString("ES", item.textES);
                savingData.WriteAttributeString("ENG", item.textENG);
                savingData.WriteString(item.key);
                savingData.WriteEndElement();
            }

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