using static CoreSchool.Locations.LocatedDataPersistence;

namespace CoreSchool.Locations
{
    public class LocatedText
    {
        public static LocatedTextData[] textLocatedPool = new LocatedTextData[0];
        
        #region METHODS
            public bool SaveData(){

                return SaveLocatedTextData(textLocatedPool);
            }
        
        #endregion

        }

}