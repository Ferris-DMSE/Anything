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

    
    public List<CourseGrade> FindCoursesForStudent(Student student)
    {
        List<CourseGrade> list = new List<CourseGrade>();
        // Loop through CourseStudents
        // Very silly
        foreach (CourseStudent courseStudent in CourseStudent)
        {
            if (CourseStudent.StudentID == student.StudentID)
            {
                var grade = courseStudent.Grade;
                var courseID = courseStudent.CourseID;
                var course = FindCourseByID(courseID);
                var courseGrade = new CourseGrade
                {
                   Course = course;
                   Grade = grade;
                }
                list.Add(courseGrade);
            }
        }
    }

    public Course FindCourseByID(string courseID)
    {
        foreach (Course course in Programdata)
        {
            if (course.CourseID == courseID)
            {
                return Course;
            }
        }
    }
    public class CourseGrade
    {
        public Course Course { get; set; }
        public string Grade { get; set; }
    }
}
