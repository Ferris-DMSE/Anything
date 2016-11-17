using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataViewer.Models
{
    public class CourseGrade
    {
        public Course Course { get; set; }
        public string Grade { get; set; }

        public override string ToString()
        {
            return $"{Course} {Grade}";
        }
    }
}