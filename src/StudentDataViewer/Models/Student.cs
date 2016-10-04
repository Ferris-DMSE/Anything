using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace StudentDataViewer.Models
{
    /// <summary>
    /// Defines a model that represents a student.
    /// </summary>
    /// <remarks>
    /// These records, like <see cref="Course"/>, do not contain direct references to the other data models.
    /// Instead a <see cref="StudentID"/> is used to create decoupled relationships between courses and students,
    /// which enable the data to be normalized. Normalized data means that no duplication exists in the XML file, 
    /// which in turn means that editing it manually will be easy, as only one place needs to be changed.
    /// </remarks>
    [DataContract]
    public class Student
    {
        /// <summary>
        /// The first name of the student.
        /// Appears second in Student XML tags.
        /// </summary>
        [DataMember(Order = 1)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the student.
        /// Appears last in Student XML tags.
        /// </summary>
        [DataMember(Order = 2)]
        public string LastName { get; set; }

        /// <summary>
        /// The ID of the student.
        /// Appears first Student XML tags.
        /// </summary>
        [DataMember(Order = 0)]
        public string StudentID { get; set; }
    }
}