using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentDataViewer.Models;
using static StudentDataViewer.Constants;

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
                AverageCompletionPerCourseType = data.CompletionStatusPerType(courseGrades),
                Courses = courseGrades
                    .Select(CourseViewModel.FromCourseGrade)
                    .OrderBy(c => c.Model.Course.Year)
                    .ThenBy(c => c.Model.Grade)
                    .ToList()
            };
        }

        public Dictionary<string, double> AverageCompletionPerCourseType { get; set; }

        public static StudentViewModel FromDataAndId(ProgramIndex data, string id)
        {
            var student = data.FindStudentByID(id);
            return FromDataAndStudent(data, student);
        }

        public List<CourseViewModel> Courses { get; private set; }
        public Student Student { get; private set; }
        public string FullName => $"{Student.FirstName} {Student.LastName}";
        public string AverageCoreCompletion => 
                AverageCompletionPerCourseType[Core].ToString("P");
        public string AverageElectiveCompletion => 
                AverageCompletionPerCourseType[Elective].ToString("P");
        public string AverageGenEdCompletion => 
                AverageCompletionPerCourseType[GeneralEducation].ToString("P");
        public string AverageTotalCompletion =>
                AverageCompletionPerCourseType[""].ToString("P");
    }
}
