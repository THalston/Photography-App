using Photography_App.Services;
using Photography_App.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Photography_App
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
            Sharpnado.Tabs.Initializer.Initialize(true, false);
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
