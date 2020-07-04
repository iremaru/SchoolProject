namespace CoreSchool.Entities
{
    public class TermPool
    {
        Term[] terms;

        #region METHODS
            
            public void LoadTerms(){
                
                
                
            }

            public (bool, string) AddNewTerm(Term newTerm)
            {
                if(terms == null) {
                    return (false, "TermPoll is not instantied.");
                }
                
                if(SearchTerm(newTerm) != null) {
                    return (false, "That term already exists in the pool.");
                }
                
                return (true, "All right");
            }

            public Term SearchTerm(Term watedTerm)
            {
                foreach (var term in terms)
                {
                    if(term == watedTerm) return term;
                }

                return default;
            }

        #endregion
    }
}