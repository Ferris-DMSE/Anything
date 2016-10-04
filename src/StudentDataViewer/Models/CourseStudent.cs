using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace StudentDataViewer.Models
{
    /// <summary>
    /// Defines a model that represents the course-student relationship.
    /// </summary>
    /// <remarks>
    /// These objects are how we know the list of courses that a student has.
    /// Because neither <see cref="Student"/> or <see cref="Course"/> have direct references to each other,
    /// we need another model that is able to relate them both.
    /// In our scenario, we can simply find all of the <see cref="CourseStudent"/> objects that have the 
    /// same <see cref="StudentID"/> as a <see cref="Student"/> model in order to find all of the course IDs that
    /// the student has. From there, we just lookup the courses and we're done.
    /// 
    /// It's a little more work than just embeding a list of course objects in <see cref="Student"/>, but in terms of file managability,
    /// this pays off in a large way. Additionally, this data structure plays well with almost any potential data storage format, from XML,
    /// to JSON, to SQL Databases.
    /// 
    /// In SQL terms, this type of object is called a join table.
    /// </remarks>
    [DataContract]
    public class CourseStudent
    {
        /// <summary>
        /// The grade that the student got for the course.
        /// Appears first in CourseStudent XML tags.
        /// </summary>
        [DataMember(Order = 0)]
        public string Grade { get; set; }

        /// <summary>
        /// The ID of the student that this relationship references.
        /// Appears second in CourseStudent XML tags.
        /// </summary>
        [DataMember(Order = 1)]
        public string StudentID { get; set; }

        /// <summary>
        /// The ID of the course that this relationship references.
        /// Appears third in CourseStudent XML tags.
        /// </summary>
        [DataMember(Order = 2)]
        public int CourseID { get; set; }
    }
}