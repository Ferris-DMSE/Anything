using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using StudentDataViewer.Models;
using StudentDataViewer.Windows.ViewModels;
using Xunit;

namespace StudentDataViewer.Windows.Test.ViewModels
{
    public class StudentViewModelTests
    {
        ProgramIndex data = new ProgramIndex()
        {
            Students = new List<Student>(),
            Courses = new List<Course>(),
            CourseStudents = new List<CourseStudent>()
        };

        private void AddCourseToStudent(Student s, Course c, string grade = "A")
        {
            data.CourseStudents.Add(new CourseStudent()
            {
                CourseID = c.CourseID,
                StudentID = s.StudentID,
                Grade = grade
            });
        }

        private void AddCourse(Course c, Student s = null, string grade = null)
        {
            data.Courses.Add(c);
            if (s != null)
            {
                AddCourseToStudent(s, c, grade);
            }
        }

        [Fact]
        public void Test_FromDataAndId_Returns_ViewModel_With_Student_With_ID_In_Given_Data()
        {
            var student = new Student()
            {
                StudentID = "id"
            };
            data.Students.Add(student);

            var viewModel = StudentViewModel.FromDataAndId(data, "id");

            viewModel.Should().NotBeNull();
            viewModel.Student.Should().Be(student);
        }

        [Fact]
        public void Test_FromDataAndStudent_Returns_ViewModel_With_Student()
        {
            var student = new Student();

            var viewModel = StudentViewModel.FromDataAndStudent(data, student);

            viewModel.Should().NotBeNull();
            viewModel.Student.Should().Be(student);
        }

        [Fact]
        public void Test_FromDataAndStudent_Populates_Courses_With_CourseViewModels()
        {
            var student = new Student()
            {
                StudentID = "id"
            };
            var course = new Course()
            {
                CourseID = 1
            };
            var course2 = new Course()
            {
                CourseID = 2
            };
            var course3 = new Course()
            {
                CourseID = 3
            };
            AddCourse(course, student, "A");
            AddCourse(course2, student, "B");
            AddCourse(course3);

            var viewModel = StudentViewModel.FromDataAndStudent(data, student);

            Assert.Collection(viewModel.Courses,
                c =>
                {
                    c.Model.Course.Should().Be(course);
                    c.Model.Grade.Should().Be("A");
                },
                c =>
                {
                    c.Model.Course.Should().Be(course2);
                    c.Model.Grade.Should().Be("B");
                });
        }

        [Fact]
        public void Test_FullName_Is_Calculated_From_The_First_And_Last_Names()
        {
            var student = new Student()
            {
                StudentID = "id",
                FirstName = "John",
                LastName = "doe"
            };

            var viewModel = StudentViewModel.FromDataAndStudent(data, student);

            viewModel.FullName.Should().Be("John doe");
        }

    }
}
