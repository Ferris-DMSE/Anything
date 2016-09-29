using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace StudentDataViewer.Models
{
    [DataContract]
    public class Course
    {

        [DataMember]
        public string CourseName;

        [DataMember]
        public int CourseID;

        [DataMember]
        public int CourseNumber;

        [DataMember]
        public double Credit;

        [DataMember]
        public string Semester;

        [DataMember]
        public int Year;

        [DataMember]
        public string CourseType;

    }
}