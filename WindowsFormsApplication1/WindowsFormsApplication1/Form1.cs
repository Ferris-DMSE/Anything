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
using WindowsFormsApplication1.Services;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double[] Completioncheck = { 0, 0, 0 };
        private readonly ProgramIndex programData;
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
            programData = ds.LoadData();

            this.StudentsListBox.DataSource = programData.Students;
            this.CoursesListBox.DataSource = new CourseGrade[0];
        }

        private void StudentListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentsListBox.SelectedItems.Count == 0)
                return;
            var ds = new DataStore();
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
                CourseID.Text = CourseIDLabel + c.CourseID;
                CourseNumber.Text = CourseNumberLabel + c.CourseNumber;
                Credits.Text = CreditsLabel + c.Credit;
                Semester.Text = SemesterLabel + c.Semester;
                Year.Text = YearLabel + c.Year;
                CourseType.Text = CourseTypeLabel + c.CourseType;
                Grade.Text = GradeLabel + course.Grade;
            }

        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            var result = SaveFileDialog.ShowDialog(this);
            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                var service = new PrintingService();
                var fileName = SaveFileDialog.FileName;
                service.Print(fileName, programData);
                MessageBox.Show($"{fileName} has been created.");
            }
        }
    }
}
