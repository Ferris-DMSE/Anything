using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;
using StudentDataViewer.Services;
using StudentDataViewer.Windows.ViewModels;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace StudentDataViewer.Windows
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class StudentDetailPage : Page
    {
        private static readonly DependencyProperty studentProperty = DependencyProperty.Register(nameof(Student), typeof(StudentViewModel), typeof(StudentDetailPage), new PropertyMetadata(null));

        public static DependencyProperty StudentProperty => studentProperty;

        public StudentViewModel Student
        {
            get { return (StudentViewModel)GetValue(studentProperty); }
            set { SetValue(studentProperty, value); }
        }

        public StudentDetailPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            var dataStore = new DataStore();
            var data = dataStore.LoadData();

            Student = StudentViewModel.FromDataAndId(data, (string) e.Parameter);

            var backStack = Frame.BackStack;
            var backStackCount = backStack.Count;

            if (backStackCount > 0)
            {
                var masterPageEntry = backStack[backStackCount - 1];
                backStack.RemoveAt(backStackCount - 1);

                var modifiedEntry = new PageStackEntry(
                    masterPageEntry.SourcePageType,
                    Student.Student.StudentID,
                    masterPageEntry.NavigationTransitionInfo);
                backStack.Add(modifiedEntry);
            }

            var systemNavManager = SystemNavigationManager.GetForCurrentView();
            systemNavManager.BackRequested += StudentDetailPage_BackRequested;
            systemNavManager.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);

            var systemNavManager = SystemNavigationManager.GetForCurrentView();
            systemNavManager.BackRequested -= StudentDetailPage_BackRequested;
            systemNavManager.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
        }

        private void StudentDetailPage_BackRequested(object sender, BackRequestedEventArgs backRequestedEventArgs)
        {
            backRequestedEventArgs.Handled = true;
            OnBackRequested();
        }

        private void OnBackRequested()
        {
            Frame.GoBack(new DrillInNavigationTransitionInfo());
        }

        void NavigateBackForWideState(bool useTransition)
        {
            NavigationCacheMode = NavigationCacheMode.Disabled;
            if (useTransition)
            {
                Frame.GoBack(new EntranceNavigationTransitionInfo());
            }
            else
            {
                Frame.GoBack(new SuppressNavigationTransitionInfo());
            }
        }

        private bool ShouldGoToWideState()
        {
            return Window.Current.Bounds.Width >= 720;
        }

        private void StudentDetailPage_OnLoaded(object sender, RoutedEventArgs e)
        {
            if (ShouldGoToWideState())
            {
                NavigateBackForWideState(useTransition: true);
            }
            else
            {
                FindName("RootPanel");
            }

            Window.Current.SizeChanged += Window_SizeChanged;
        }

        private void Window_SizeChanged(object sender, WindowSizeChangedEventArgs e)
        {
            if (ShouldGoToWideState())
            {
                Window.Current.SizeChanged -= Window_SizeChanged;
                NavigateBackForWideState(useTransition: false);
            }
        }

        private void StudentDetailPage_OnUnloaded(object sender, RoutedEventArgs e)
        {
            Window.Current.SizeChanged -= Window_SizeChanged;
        }
    }
}
