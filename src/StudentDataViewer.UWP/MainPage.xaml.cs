using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;
using StudentDataViewer.Models;
using StudentDataViewer.Services;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace StudentDataViewer.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        DataStore dataStore = new DataStore();

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void MainPage_OnLoaded(object sender, RoutedEventArgs e)
        {
            //Mobile customization
            if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.StatusBar"))
            {
                var statusBar = StatusBar.GetForCurrentView();
                if (statusBar != null)
                {
                    statusBar.BackgroundOpacity = 1;
                    statusBar.BackgroundColor = Colors.Violet;
                    statusBar.ForegroundColor = Colors.White;
                }
            }

            var programData = dataStore.LoadData();
            StudentsListView.ItemsSource = programData.Students;
        }

        private void StudentsListView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedStudent = (Student) StudentsListView.SelectedItem;
            if (selectedStudent != null)
            {
                Frame.Navigate(typeof(StudentCourse), selectedStudent.StudentID, new DrillInNavigationTransitionInfo());
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
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
