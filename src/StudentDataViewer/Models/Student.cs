using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace StudentDataViewer.Models
{
    [DataContract]
    public class student
    {

        [DataMember]
        public string FirstName;

        [DataMember]
        public string LastName;

        [DataMember]
        public int StudentID;

    }
}