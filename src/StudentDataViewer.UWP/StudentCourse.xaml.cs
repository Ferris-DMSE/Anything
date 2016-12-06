using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using StudentDataViewer.Models;
using StudentDataViewer.Services;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace StudentDataViewer
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class StudentCourse : Page
    {
        private static readonly DependencyProperty studentProperty = DependencyProperty.Register(nameof(Student), typeof(Student), typeof(StudentCourse), new PropertyMetadata(null));
        public static DependencyProperty StudentProperty => studentProperty;
        private static readonly DependencyProperty coursesProperty = DependencyProperty.Register(nameof(Courses), typeof(List<CourseGrade>), typeof(StudentCourse), new PropertyMetadata(null));
        public static DependencyProperty CoursesProperty => coursesProperty;

        public Student Student
        {
            get { return (Student)GetValue(StudentProperty); }
            set { SetValue(StudentProperty, value); }
        }

        public List<CourseGrade> Courses
        {
            get { return (List<CourseGrade>) GetValue(CoursesProperty); }
            set { SetValue(CoursesProperty, value); }
        }

        public StudentCourse()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var dataStore = new DataStore();
            var data = dataStore.LoadData();
            var id = (string)e.Parameter;
            var student = data.FindStudentByID(id);
            this.Student = student;
            var courses = data.FindCoursesForStudent(student);
            this.Courses = courses;

            var systemNavigationManager = SystemNavigationManager.GetForCurrentView();
            if (Frame.CanGoBack)
            {
                systemNavigationManager.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
                systemNavigationManager.BackRequested += SystemNavigationManagerOnBackRequested;
            }
            else
            {
                systemNavigationManager.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
            }
        }

        private void SystemNavigationManagerOnBackRequested(object sender, BackRequestedEventArgs backRequestedEventArgs)
        {
            if (!backRequestedEventArgs.Handled)
            {
                SystemNavigationManager.GetForCurrentView().BackRequested -= SystemNavigationManagerOnBackRequested;
                backRequestedEventArgs.Handled = true;
                Frame.GoBack();
            }
        }
    }
}
