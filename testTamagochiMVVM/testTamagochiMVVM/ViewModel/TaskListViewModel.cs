using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using testTamagochiMVVM.Model;
using testTamagochiMVVM.View;
using testTamagochiMVVM.ViewModel;

namespace testTamagochiMVVM.ViewModel
{
    public class TaskListViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<TaskViewModel> Tasks { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand SaveTaskCommand { protected set; get; }
        public ICommand BackCommand { protected set; get; }

        TaskViewModel selectedTask;
        public INavigation Navigation { get; set; }
        public TaskListViewModel()
        {
            Tasks = new ObservableCollection<TaskViewModel>();
            SaveTaskCommand = new Command(SaveTask);
            BackCommand = new Command(Back);
        }

        public TaskViewModel SelectedTask
        {
            get { return selectedTask; }
            set
            {
                if(selectedTask != value)
                {
                    TaskViewModel tempTask = value;
                    selectedTask = null;
                    OnPropertyChanged("SelectedTask");
                    Navigation.PushAsync(new View.TaskPage(tempTask));
                }
            }
        }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        private void Back()
        {
            Navigation.PopAsync();
        }

        private void SaveTask(object taskObj)
        {
            TaskViewModel task = taskObj as TaskViewModel;
            if(task != null && task.IsValid && !Tasks.Contains(task))
            {
                Tasks.Add(task);
                Back();
            }
        }
    }
}
