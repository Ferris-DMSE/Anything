using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataViewer.Models
{
    /// <summary>
    /// This is our root data model. It contains everything that the application can load/store.
    /// </summary>
    [DataContract]
    public class ProgramIndex
    {
        /// <summary>
        /// The list of students that this model stores.
        /// </summary>
        [DataMember(Order = 0)]
        public List<Student> Students;

        /// <summary>
        /// The list of courses that this model stores.
        /// </summary>
        [DataMember(Order = 1)]
        public List<Course> Courses;

        /// <summary>
        /// The list of course-student relationships that this model stores.
        /// </summary>
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

        public string OutputGrade(string studentinfo, int courseinfo)
        {
            string grade = "";
            foreach (CourseStudent courseStudent in CourseStudents)
            {
                if (courseStudent.CourseID.Equals(courseinfo))
                {
                    if (courseStudent.StudentID.Equals(studentinfo))
                    {
                        grade = courseStudent.Grade;
                    }
                }

            }
            return grade;
        }

        public List<string> ListAllCoursesByStudent(object student_)
        {
            var PreformatID = student_.ToString().Split(';');
            var Student = FindStudentByID(PreformatID[0]);
            List<string> CourseList = new List<string>(); //Format: CourseName +  ", ID: " + CourseID
            string CourseListViewName = "";
            foreach (CourseStudent courseStudent in CourseStudents)
            {
                if (courseStudent.StudentID == PreformatID[0])
                {
                    var tempcourse = FindCourseByID(courseStudent.CourseID);
                    CourseListViewName = tempcourse.CourseName + ", ID: " + Convert.ToString(tempcourse.CourseID);
                    CourseList.Add(CourseListViewName);

                }
            }
            return CourseList;
        }

        private double AverageCompletion(IEnumerable<CourseGrade> courses)
        {
            return courses.Select(c => CourseGradeCheck(c.Grade) ? 1 : 0).DefaultIfEmpty().Average();
        }

        public double[] CompletionStatusPerType(List<CourseGrade> courses)
        {
            return new double[]
            {
                AverageCompletion(courses.Where(c => c.Course.CourseType == "General Education")),
                AverageCompletion(courses.Where(c => c.Course.CourseType == "Core")),
                AverageCompletion(courses.Where(c => c.Course.CourseType == "Elective")),
                AverageCompletion(courses)
            };
        }

        public bool CourseGradeCheck(string grade)
        {
            switch (grade)
            {
                case "W":
                    return false;
                case "F":
                    return false;
                case "I":
                    return false;
                default:
                    return true;
            }
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

        public Student FindStudentByID(string studentID)
        {
            foreach (Student student in Students)
            {
                if (student.StudentID == studentID)
                {
                    return student;
                }
            }
            return null;
        }
    }
}
