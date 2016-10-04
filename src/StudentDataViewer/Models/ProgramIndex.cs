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

        public List<CourseGrade> FindCoursesForStudent(Student student)
        {
            List<CourseGrade> list = new List<CourseGrade>();
            // Loop through CourseStudents
            // Very silly
            foreach (CourseStudent courseStudent in CourseStudents)
            {
                if (courseStudent.StudentID == student.StudentID)
                {
                    var grade = courseStudent.Grade;
                    var courseID = courseStudent.CourseID;
                    var course = FindCourseByID(courseID);
                    var courseGrade = new CourseGrade
                    {
                    Course = course,
                    Grade = grade,
                    };
                    list.Add(courseGrade);
                }
            }
            return list;
        }

        public Course FindCourseByID(int courseID)
        {
            foreach (Course course in Courses)
            {
                if (course.CourseID == courseID)
                {
                    return course;
                }
            }
            return null;
        }

        public Student FindStudentByID(int studentID)
        {
            foreach (Student student in Students)
            {
                if (student.StudentID == studentID)
                {
                    return student;
                }
            }
        }
    }
}
