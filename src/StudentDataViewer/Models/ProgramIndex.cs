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
        [DataMember(Order = 0)]
        public List<Student> Students;

        [DataMember(Order = 1)]
        public List<Course> Courses;

        [DataMember(Order = 2)]
        public List<CourseStudent> CourseStudents;
    }

}
