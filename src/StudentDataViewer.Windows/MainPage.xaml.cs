using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace StudentDataViewer.Windows
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private StudentViewModel lastSelectedItem;

        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var items = MasterListView.ItemsSource as List<StudentViewModel>;
            if (items == null)
            {
                var dataStore = new DataStore();
                var data = dataStore.LoadData();
                MasterListView.ItemsSource = items = data.Students.Select(s => StudentViewModel.FromDataAndStudent(data, s)).ToList();
            }

            if (e.Parameter != null)
            {
                var id = (string)e.Parameter;
                lastSelectedItem = items.FirstOrDefault(s => s.Student.StudentID == id);
            }

            UpdateForVisualState(AdaptiveStates.CurrentState);

            DisableContentTransitions();
        }

        private void MasterListView_OnItemClick(object sender, ItemClickEventArgs e)
        {
            var clickedItem = (StudentViewModel)e.ClickedItem;
            lastSelectedItem = clickedItem;
            if (AdaptiveStates.CurrentState == NarrowState)
            {
                NavigateToStudent(clickedItem, new DrillInNavigationTransitionInfo());
            }
            else
            {
                EnableContentTransitions();
            }
        }

        private void NavigateToStudent(StudentViewModel clickedItem, NavigationTransitionInfo transition)
        {
            Frame.Navigate(typeof(StudentDetailPage), clickedItem.Student.StudentID, transition);
        }

        private void EnableContentTransitions()
        {
            DetailContentPresenter.ContentTransitions.Clear();
            DetailContentPresenter.ContentTransitions.Add(new EntranceThemeTransition());
        }

        private void AdaptiveStates_OnCurrentStateChanged(object sender, VisualStateChangedEventArgs e)
        {
            UpdateForVisualState(e.NewState, e.OldState);
        }

        private void UpdateForVisualState(VisualState newState, VisualState oldState = null)
        {
            var isNarrow = newState == NarrowState;
            if (isNarrow && oldState == DefaultState && lastSelectedItem != null)
            {
                NavigateToStudent(lastSelectedItem, new SuppressNavigationTransitionInfo());
            }

            EntranceNavigationTransitionInfo.SetIsTargetElement(MasterListView, isNarrow);
            if (DetailContentPresenter != null)
            {
                EntranceNavigationTransitionInfo.SetIsTargetElement(DetailContentPresenter, !isNarrow);
            }
        }

        private void DisableContentTransitions()
        {
            DetailContentPresenter?.ContentTransitions.Clear();
        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            MasterListView.SelectedItem = lastSelectedItem;
        }
    }
}
