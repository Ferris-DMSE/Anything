using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace StudentDataViewer.Models
{
    [DataContract]
    public class CourseStudent
    {

        [DataMember()]
        public string Grade;

        [DataMember]
        public int StudentID;

        [DataMember]
        public int CourseID;

    }
}