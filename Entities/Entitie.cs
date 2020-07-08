using System;
using CoreSchool.Locations;

namespace CoreSchool.Entities
{
    public abstract class Entitie
    {
        /// <summary>
        /// 
        /// </summary>
        public string Title { get; set; }
        public Guid UniqueID { get; set; }

        /// <summary>
        /// Contain the base properties of all classes that inherit from it.
        /// </summary>
        /// <param name="locatedTextKey">The key of the locatedTextData object that stores the class title </param>
        public Entitie(string locatedTextKey = "ENT-Tit")
        {
            Title = locatedTextKey;
            UniqueID = Guid.NewGuid();
        }

    }
}