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

        public string OutputGrade(string studentinfo)
        {
            string ID = studentinfo.Split(';')[0];
            string grade = "";
            foreach (CourseStudent courseStudent in CourseStudents)
            {
                if (courseStudent.StudentID == ID)
                {
                    grade = courseStudent.Grade;
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
        public int[] CompletionStatusPerType(object student_)
        {
            var PreformatID = student_.ToString().Split(';');
            Student student = new Student();
            student.StudentID = PreformatID[0];
            int[] CompletionList = { 0, 0, 0 }; //GenEd, Core, Elective
            List<CourseGrade> Grades = FindCoursesForStudent(student);
            foreach (var course in Grades)
            {
                switch(course.Course.CourseType)
                {
                    case "General Education":
                        if (CourseGradeCheck(course.Grade))
                            CompletionList[0]++;
                        break;
                    case "core":
                        if (CourseGradeCheck(course.Grade))
                            CompletionList[1]++;
                        break;
                    case "Elective":
                        if (CourseGradeCheck(course.Grade))
                            CompletionList[2]++;
                        break;
                }
            }
            return CompletionList;
        }

        public bool CourseGradeCheck(string grade)
        {
            if (grade != "W" && grade != "I" && grade != "F")
            {
                return true;
            }
            return false;
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
            string StudentFormatCompiler = "";
            Students compiler = new Students();
            foreach (Student student in Students)
            {
                StudentFormatCompiler = student.StudentID + "; " + student.LastName + ", " + student.FirstName;
                StudentList.Add(StudentFormatCompiler);
            }
            compiler.ListViewStudentNames = StudentList;
            return compiler;
        }
    }
}
