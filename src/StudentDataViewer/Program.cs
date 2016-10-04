using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using StudentDataViewer.Models;

namespace StudentDataViewer
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var ds = new DataStore();
            //ProgramIndex programData = ds.LoadData();

            var displayLogic = new DisplayLogic();


            displayLogic.Display(new Student
            {
                FirstName = "Kirk",
                LastName = "Novitsky",
                StudentID = "12345",
            }, new List<CourseGrade>()
                    {
                       new CourseGrade ()
                       {

                              Course = new Course
                            {
                                CourseName = "Programming",
                                CourseID = 123,
                                CourseNumber = "321",
                                Credit = 10,
                                Semester = "Fall",
                                Year = 2016,
                                CourseType = "type", 
                              //  CourseGrade = 'A',
                            }

                              , Grade = "A"
                              
                           }
                        });



            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}