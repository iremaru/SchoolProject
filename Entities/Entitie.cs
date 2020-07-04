using System;

namespace CoreSchool.Entities
{
    public class Entitie
    {
        public String Title { get; set; }
        public Guid UniqueID { get; set; }

        public Entitie(string name = "NoName")
        {
            Title = name;
            UniqueID = Guid.NewGuid();
        }

    }
}