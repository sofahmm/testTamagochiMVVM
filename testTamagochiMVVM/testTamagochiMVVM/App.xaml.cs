using System;
using testTamagochiMVVM.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testTamagochiMVVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new TaskListPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
