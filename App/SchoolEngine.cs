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
                //inicializamos la propiedad School

                //LoadCourses();
                //LoadStudents();
            }

        #endregion
    }
}