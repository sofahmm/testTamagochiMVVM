using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using testTamagochiMVVM.Model;

namespace testTamagochiMVVM.ViewModel
{
    public class TaskViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        TaskListViewModel taskLVM;

        public Task Task { get; private set; }

        public TaskViewModel() => Task = new Task();
        public TaskListViewModel ListViewModel
        {
            get { return taskLVM; }
            set
            {
                if (taskLVM != value)
                {
                    taskLVM = value;
                    OnPropertyChanged("ListViewModel");
                }
            }
        }

        public string Name
        {
            get { return Task.Name; }
            set
            {
                if(Task.Name != value)
                {
                    Task.Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        public string Reward
        {
            get { return Task.Reward; }
            set
            {
                if (Task.Reward != value)
                {
                    Task.Reward = value;
                    OnPropertyChanged("Reward");
                }
            }
        }

        public bool IsValid
        {
            get
            {
                return ((!string.IsNullOrEmpty(Name.Trim()))||
                    (!string.IsNullOrEmpty(Reward.Trim())));
            }
        }

        protected void OnPropertyChanged (string propertyname)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
