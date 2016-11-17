using StudentDataViewer.Models;
using StudentDataViewer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Students StudentsListView = new Students();
        List<string> CourseList = new List<string>();
        double[] Completioncheck = { 0, 0, 0 };
        private const string GenEd = "Gen Ed: ";
        private const string Core = "Core: ";
        private const string Elective = "Elective: ";
        private const string CourseIDLabel = "Course ID: ";
        private const string CourseNumberLabel = "Course Number: ";
        private const string GradeLabel = "Grade: ";
        private const string CreditsLabel = "Credits: ";
        private const string SemesterLabel = "Semester: ";
        private const string YearLabel = "Year: ";
        private const string CourseTypeLabel = "Course Type: ";
        public Form1()
        {
            InitializeComponent();
            var ds = new DataStore();
            ProgramIndex programData = ds.LoadData();
            StudentsListView = programData.FindAllStudents();

            this.StudentsListBox.DataSource = programData.Students;
            this.CoursesListBox.DataSource = new CourseGrade[0];
        }

        private void StudentListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentsListBox.SelectedItems.Count == 0)
                return;
            var ds = new DataStore();
            ProgramIndex programData = ds.LoadData();
            var student = (Student)StudentsListBox.SelectedItem;
            if (student != null)
            {
                var courses = programData.FindCoursesForStudent(student);
                CoursesListBox.DataSource = courses;
                Completioncheck = programData.CompletionStatusPerType(courses);
                GenEdCompletion.Text = GenEd + Completioncheck[0] + "%";
                CoreCompletion.Text = Core + Completioncheck[1] + "%";
                ElectiveCompletion.Text = Elective + Completioncheck[2] + "%";
            }
        }

        private void CoursesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CoursesListBox.SelectedItems.Count == 0)
                return;
            var course = (CourseGrade)CoursesListBox.SelectedItem;
            if (course != null)
            {
                Course c = course.Course;
                CourseID.Text = CourseIDLabel + c.CourseID.ToString();
                CourseNumber.Text = CourseNumberLabel + c.CourseNumber;
                Credits.Text = CreditsLabel + c.Credit.ToString();
                Semester.Text = SemesterLabel + c.Semester.ToString();
                Year.Text = YearLabel + c.Year.ToString();
                CourseType.Text = CourseTypeLabel + c.CourseType;
                Grade.Text = GradeLabel + course.Grade;
            }

        }
    }
}
