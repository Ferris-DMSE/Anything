using StudentDataViewer.Models;
using StudentDataViewer;
using System;
using System.Collections.Generic;

namespace StudentDataViewer
{
    public class DisplayLogic
    {
        public void Display(Student student, List<CourseGrade> courses)
        {
            Console.WriteLine("First Name: " + student.FirstName);
            Console.WriteLine("Last Name: " + student.LastName);
            Console.WriteLine("Student ID: " + student.StudentID);
            Console.WriteLine();
            Console.WriteLine("Courses: ");
            Console.WriteLine();
            foreach (CourseGrade course in courses)
            {
                Console.WriteLine("Name: " + course.Course.CourseName);
                Console.WriteLine("Id: " + course.Course.CourseID);
                Console.WriteLine("Number: " + course.Course.CourseNumber);
                Console.WriteLine("Type: " + course.Course.CourseType);
                Console.WriteLine("Credit: " + course.Course.Credit);
                Console.WriteLine("Semester: " + course.Course.Semester);
                Console.WriteLine("Year: " + course.Course.Year);
                Console.WriteLine("Grade: " + course.Grade); 
                Console.WriteLine();
            }
        }
    }
}