using System;

namespace CoreSchool.Entities
{
    public class Term : Entitie
    {
        public DateTime OpeningDate { get; set; }
        public DateTime ClosingDate { get; set; }

        public Term(DateTime openingDate, DateTime closingDate) : base(locatedTextKey: "ENT-Tit-Term")
        {
            OpeningDate = openingDate;
            ClosingDate = closingDate;
            }
        
    }
}