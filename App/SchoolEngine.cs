using CoreSchool.Entities;

namespace CoreSchool
{
    /// <summary>
    /// Manage the App
    /// </summary>
    class SchoolEngine
    {
        public School School { get; set; }
    

        #region METHODS
            
            //Method to initialice School
            public void InitializeSchool()
            {
                //First of all, we initialize the localized texts.
                Locations.LocatedDataPersistence.LoadData();

                //Then we instantialize the School (Wii! School exist!)
                School = new School("Santa Marta");

                //LoadCourses();
                //LoadStudents();
            }

        #endregion
    }
}