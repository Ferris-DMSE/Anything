using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace StudentDataViewer.Models
{
    /// <summary>
    /// Defines a model that represents a course.
    /// </summary>
    /// <remarks>
    /// This course contains no direct relationships to <see cref="Student"/>, which
    /// enables us to store a single course for many students, without duplicating information.
    /// In turn, this makes manual editing of the file much easier, because only one edit is needed to 
    /// update the course record for all the students that use it.
    /// </remarks>
    [DataContract]
    public class Course
    {
        /// <summary>
        /// The name of the course.
        /// Appears first in Course XML tags.
        /// </summary>
        [DataMember(Order = 0)]
        public string CourseName { get; set; }

        /// <summary>
        /// The ID of the course.
        /// Appears second in Course XML tags.
        /// </summary>
        [DataMember(Order = 1)]
        public int CourseID { get; set; }

        /// <summary>
        /// The number of the course.
        /// Appears third in Course XML tags.
        /// </summary>
        [DataMember(Order = 2)]
        public int CourseNumber { get; set; }

        /// <summary>
        /// The number of credits that the course is worth.
        /// Appears fourth in Course XML tags.
        /// </summary>
        [DataMember(Order = 3)]
        public double Credit { get; set; }

        /// <summary>
        /// The semester that the course was on.
        /// One of ("Spring", "Summer", "Fall", "Winter").
        /// Appears fifth in Course XML tags.
        /// </summary>
        [DataMember(Order = 4)]
        public string Semester { get; set; }

        /// <summary>
        /// The school year that the course was for.
        /// Appears sixth in Course XML tags.
        /// </summary>
        [DataMember(Order = 5)]
        public int Year { get; set; }

        /// <summary>
        /// The type of the course.
        /// One of ("Core", "GeneralEducation", "Elective").
        /// Appears seventh in Course XML tags.
        /// </summary>
        [DataMember(Order = 6)]
        public string CourseType { get; set; }
    }
}