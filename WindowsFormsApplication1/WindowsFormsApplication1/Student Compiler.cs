using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{

    class Students
    {
        public List<student> StudentList = new List<student>();
    }

    class student
    {
        public string ID_Name
        {
            get;
            set;
        }
        public List<Courses> Courses = new List<Courses>();


    }
    class Courses
    {
        public string CourseName
        {
            get;
            set;
        }
        public string CourseID
        {
            get;
            set;
        }
        public string CourseNumber
        {
            get;
            set;
        }
        public string Credits
        {
            get;
            set;
        }
        public string Semester
        {
            get;
            set;
        }
        public string Year
        {
            get;
            set;
        }
        public string CourseType
        {
            get;
            set;
        }
    }
}
