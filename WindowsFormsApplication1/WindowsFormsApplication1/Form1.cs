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
        int[] Completioncheck = { 0, 0, 0 };
        string[] Completionstringbase = { "Gen Ed: ", "Core: ", "Elective: " };
        public Form1()
        {
            InitializeComponent();
            var ds = new DataStore();
            ProgramIndex programData = ds.LoadData();
            StudentsListView = programData.FindAllStudents();
        }

        private void StudentListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ds = new DataStore();
            ProgramIndex programData = ds.LoadData();
            CourseList = programData.ListAllCoursesByStudent(sender);
            Completioncheck = programData.CompletionStatusPerType(sender);
            GenEdCompletion.Text = Completionstringbase[0] + Completioncheck[0];
            CoreCompletion.Text = Completionstringbase[1] + Completioncheck[1];
            ElectiveCompletion.Text = Completionstringbase[2] + Completioncheck[2];
        }

        private void CoursesListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
