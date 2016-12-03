using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentDataViewer.Models;

namespace StudentDataViewer.Windows.ViewModels
{
    public class StudentViewModel
    {
        public static StudentViewModel FromDataAndStudent(ProgramIndex data, Student student)
        {
            var courseGrades = data.FindCoursesForStudent(student);
            return new StudentViewModel()
            {
                Student = student,
                Courses = courseGrades
            };
        }

        public static StudentViewModel FromDataAndId(ProgramIndex data, string id)
        {
            var student = data.FindStudentByID(id);
            return FromDataAndStudent(data, student);
        }

        public List<CourseGrade> Courses { get; set; }
        public Student Student { get; set; }
        public string FullName => $"{Student.FirstName} {Student.LastName}";
    }
}
