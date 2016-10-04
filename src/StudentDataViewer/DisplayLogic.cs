using StudentDataViewer.Models;
using StudentDataViewer;
using System;
using System.Collections.Generic;

namespace StudentDataViewer
{
    public class DisplayLogic
    {
        public void Display(Student student, List<Course> courses)
        {
            Console.WriteLine("First Name: " + student.FirstName);
            Console.WriteLine("Last Name: " + student.LastName);
            Console.WriteLine("Student ID: " + student.StudentID);
            Console.WriteLine();
            Console.WriteLine("Courses: ");
            Console.WriteLine();
            foreach (Course course in courses)
            {
                Console.WriteLine("Name: " + course.CourseName);
                Console.WriteLine("Id: " + course.CourseID);
                Console.WriteLine("Number: " + course.CourseNumber);
                Console.WriteLine("Type: " + course.CourseType);
                Console.WriteLine("Credit: " + course.Credit);
                Console.WriteLine("Semester: " + course.Semester);
                Console.WriteLine("Year: " + course.Year);
                Console.WriteLine();
            }
        }
    }
}