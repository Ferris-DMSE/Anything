using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using StudentDataViewer.Models;

namespace WindowsFormsApplication1.Services
{
    /// <summary>
    /// Defines a class that is able to print student information into a PDF file.
    /// </summary>
    public class PrintingService
    {
        public void Print(string fileName, ProgramIndex programData)
        {
            using (var stream = File.Open(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (var document = new Document())
                {
                    var writer = PdfWriter.GetInstance(document, stream);
                    document.Open();
                    var numberOfChapters = 0;
                    foreach (var student in programData.Students)
                    {
                        var c = new Chapter($"{student.LastName}, {student.FirstName} {student.StudentID}",
                            numberOfChapters++);
                        var t = new PdfPTable(8) { HeaderRows = 1 };
                        t.AddCell("Course Name");
                        t.AddCell("Course ID");
                        t.AddCell("Course Number");
                        t.AddCell("Credit");
                        t.AddCell("Semester");
                        t.AddCell("Year");
                        t.AddCell("Course Type");
                        t.AddCell("Grade");
                        var courses = programData.FindCoursesForStudent(student);
                        foreach (var course in courses)
                        {
                            t.AddCell(course.Course.CourseName);
                            t.AddCell(course.Course.CourseID.ToString());
                            t.AddCell(course.Course.CourseNumber);
                            t.AddCell(course.Course.Credit.ToString());
                            t.AddCell(course.Course.Semester);
                            t.AddCell(course.Course.Year.ToString());
                            t.AddCell(course.Course.CourseType);
                            t.AddCell(course.Grade);
                        }
                        c.Add(t);
                        document.Add(c);
                    }
                }
            }
        }
    }
}
