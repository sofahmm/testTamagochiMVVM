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
    public partial class TaskListPage : ContentPage
    {
        public TaskListPage()
        {
            InitializeComponent();
            BindingContext = new TaskListViewModel { Navigation = this.Navigation };
        }
    }
}