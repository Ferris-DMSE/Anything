using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using StudentDataViewer.Models;
using StudentDataViewer.Services;

namespace StudentDataViewer
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ds = new DataStore();
            ProgramIndex programData = ds.LoadData();
            var displayLogic = new DisplayLogic();
            while (true)
            {
                //Console.WriteLine("Please enter a student ID : ");
                string studentID = Console.ReadLine();
                var student = programData.FindStudentByID(studentID);
                if (student == null)
                {
                    continue;
                }
                else
                {
                    List<CourseGrade> list = programData.FindCoursesForStudent(student);
                    displayLogic.Display(student, list);
                    
                }
            }           
        }
    }
}