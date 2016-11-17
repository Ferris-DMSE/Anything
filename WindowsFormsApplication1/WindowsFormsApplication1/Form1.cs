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
        string[] Completionstringbase = { "Gen Ed: ", "Core: ", "Elective: " };
        string[] courseStringBase = { "Course ID: ", "Course Number: ", "Grade: ", "Credits: ", "Semester: ", "Year: ", "Course Type: " };
        public Form1()
        {
            InitializeComponent();
            var ds = new DataStore();
            ProgramIndex programData = ds.LoadData();
            StudentsListView = programData.FindAllStudents();

            this.StudentListView.Items.Clear();
            this.StudentListView.View = View.Details;
            this.StudentListView.Columns.Add("Name");
            this.StudentListView.Columns[0].Width = this.StudentListView.Width -
            4;
            this.StudentListView.HeaderStyle = ColumnHeaderStyle.None;
            List<string> StudentList = StudentsListView.ListViewStudentNames;

            foreach (string sStudent in StudentList)
            {
                StudentListView.Items.Add(sStudent);
            }
            this.CoursesListView.Items.Clear();
            this.CoursesListView.View = View.Details;
            this.CoursesListView.Columns.Add("Name");
            this.CoursesListView.Columns[0].Width = this.StudentListView.Width -
            4;
            this.CoursesListView.HeaderStyle = ColumnHeaderStyle.None;
        }

        private void StudentListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ListView)sender).SelectedItems.Count == 0)
                return;
            var ds = new DataStore();
            ProgramIndex programData = ds.LoadData();
            CourseList = programData.ListAllCoursesByStudent(((ListView)sender).SelectedItems[0].Text);
            Completioncheck = programData.CompletionStatusPerType(((ListView)sender).SelectedItems[0].Text);
            GenEdCompletion.Text = Completionstringbase[0] + Completioncheck[0] + "%";
            CoreCompletion.Text = Completionstringbase[1] + Completioncheck[1] + "%";
            ElectiveCompletion.Text = Completionstringbase[2] + Completioncheck[2] + "%";
            CoursesListView.Items.Clear();
            CoursesListView.Items.AddRange(CourseList.Select(i => new ListViewItem(i)).ToArray());
            CourseID.Text = courseStringBase[0];
            CourseNumber.Text = courseStringBase[1];
            Credits.Text = courseStringBase[3];
            Semester.Text = courseStringBase[4];
            Year.Text = courseStringBase[5];
            CourseType.Text = courseStringBase[6];
            Grade.Text = courseStringBase[2];
        }

        private void CoursesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ListView)sender).SelectedItems.Count == 0)
                return;
            var ds = new DataStore();
            ProgramIndex programData = ds.LoadData();
            string result = ((ListView)sender).SelectedItems[0].ToString().Split(':')[2].Trim(' ','}');
            Course c = programData.FindCourseByID(int.Parse(result));
            CourseID.Text = courseStringBase[0] + c.CourseID.ToString();
            CourseNumber.Text = courseStringBase[1] + c.CourseNumber;
            Credits.Text = courseStringBase[3] + c.Credit.ToString();
            Semester.Text = courseStringBase[4] + c.Semester.ToString();
            Year.Text = courseStringBase[5] + c.Year.ToString();
            CourseType.Text = courseStringBase[6] + c.CourseType;
            Grade.Text = courseStringBase[2] + programData.OutputGrade(StudentListView.SelectedItems[0].Text.Split(';')[0].Trim('{'), int.Parse(result));

        }
    }
}
