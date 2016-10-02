using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataViewer.Models
{
    /// <summary>
    /// This is our root data model. It contains everything that the application can load/store.
    /// </summary>
    [DataContract]
    public class ProgramIndex
    {
        /// <summary>
        /// The list of students that this model stores.
        /// </summary>
        [DataMember(Order = 0)]
        public List<Student> Students;

        /// <summary>
        /// The list of courses that this model stores.
        /// </summary>
        [DataMember(Order = 1)]
        public List<Course> Courses;

        /// <summary>
        /// The list of course-student relationships that this model stores.
        /// </summary>
        [DataMember(Order = 2)]
        public List<CourseStudent> CourseStudents;
    }
}
