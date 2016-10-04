using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace StudentDataViewer.Models
{
    [DataContract]
    public class CourseStudent
    {

        [DataMember(Order = 0)]
        public string Grade { get; set; }

        [DataMember(Order = 1)]
        public string StudentID { get; set; }

        [DataMember(Order = 2)]
        public int CourseID { get; set; }

    }
}