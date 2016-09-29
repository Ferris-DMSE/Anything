using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace StudentDataViewer.Models
{
    [DataContract]
    public class Course
    {

        [DataMember()]
        public string CourseName;

    }
}