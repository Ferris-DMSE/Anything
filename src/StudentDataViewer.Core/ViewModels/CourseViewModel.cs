using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;
using StudentDataViewer.Models;

namespace StudentDataViewer.Windows.ViewModels
{
    public class CourseViewModel
    {
        public static CourseViewModel FromCourseGrade(CourseGrade course)
        {
            return new CourseViewModel()
            {
                Model = course
            };
        }

        public CourseGrade Model { get; private set; }

        public string NumberAndNameAndType => $"{Model.Course.CourseType} {Model.Course.CourseNumber} {Model.Course.CourseName}";
        public string SemesterAndYear => $"{Model.Course.Semester} {Model.Course.Year}";
        public string Credit => $"Credits: {Model.Course.Credit}";
        public Color GradeColor => 
            Model.Grade == "A" ? Colors.Green :
            Model.Grade == "B" ? Colors.LightGreen :
            Model.Grade == "C" ? Colors.DodgerBlue :
            Model.Grade == "D" ? Colors.DarkOrange :
            Model.Grade == "F" ? Colors.Red :
            Model.Grade == "W" ? Colors.SlateGray :
            Colors.White;
        public Brush GradeFill => new SolidColorBrush(GradeColor);
    }
}
