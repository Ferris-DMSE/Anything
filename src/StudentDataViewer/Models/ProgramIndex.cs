using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataViewer.Models
{
    [DataContract]
    public class ProgramIndex
    {
        [DataMember]
        public List<Student> Students;

        [DataMember]
        public List<Course> Courses;

        [DataMember]
        public List<CourseStudent> CourseStudents;
    }
}
