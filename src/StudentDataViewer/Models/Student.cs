using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace StudentDataViewer.Models
{
    [DataContract]
    public class Student
    {

        [DataMember()]
        public string FirstName;

        [DataMember]
        public string LastName;


    }
}