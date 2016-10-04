using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace StudentDataViewer.Models
{
    [DataContract]
    public class Course
    {

        [DataMember(Order = 0)]
        public string CourseName { get; set; }

        [DataMember(Order = 1)]
        public int CourseID { get; set; }

        [DataMember(Order = 2)]
        public string CourseNumber { get; set; }

        [DataMember(Order = 3)]
        public double Credit { get; set; }

        [DataMember(Order = 4)]
        public string Semester { get; set; }

        [DataMember(Order = 5)]
        public int Year { get; set; }

        [DataMember(Order = 6)]
        public string CourseType { get; set; }

    }
}