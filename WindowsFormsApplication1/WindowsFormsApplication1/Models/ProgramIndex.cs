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

        public Students FindAllStudents()
        {
            List<string> StudentList = new List<string>();
            string StudentID = "";
            string StudentFName = "";
            string StudentLName = "";
            string StudentFormatCompiler = "";
            Students compiler = new Students();
            foreach (Student student in Students)
            {
                StudentFName = student.FirstName;
                StudentLName = student.LastName;
                StudentFName = ", " + StudentFName;
                StudentID = student.StudentID;
                StudentFormatCompiler = StudentID + "; " + StudentLName + StudentFName;
                StudentList.Add(StudentFormatCompiler);
            }
            compiler.ListViewStudentNames = StudentList;
            return compiler;
        }
    }
}
