using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace StudentDataViewer.Models
{
    [DataContract]
    public class Student
    {

        [DataMember(Order = 1)]
        public string FirstName { get; set; }

        [DataMember(Order = 2)]
        public string LastName { get; set; }

        [DataMember(Order = 0)]
        public string StudentID { get; set; }

    }
}