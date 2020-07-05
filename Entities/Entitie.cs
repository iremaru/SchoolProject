using System;

namespace CoreSchool.Entities
{
    public class Entitie
    {
        public String Title { get; set; }
        public Guid UniqueID { get; set; }

        public Entitie(string locatedText = "ENT-Tit")
        {
            Title = locatedText;
            UniqueID = Guid.NewGuid();
        }

    }
}