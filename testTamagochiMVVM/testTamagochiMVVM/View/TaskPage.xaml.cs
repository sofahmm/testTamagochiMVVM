using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using testTamagochiMVVM.ViewModel;

namespace testTamagochiMVVM.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaskPage : ContentPage
    {
        public TaskViewModel ViewModel { get; private set; }
        public TaskPage(TaskViewModel taskViewModel)
        {
            InitializeComponent();
            ViewModel = taskViewModel;
            this.BindingContext = ViewModel;
        }
    }
}