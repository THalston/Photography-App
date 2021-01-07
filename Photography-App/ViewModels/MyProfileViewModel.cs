using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Photography_App.ViewModels
{
    public class MyProfileViewModel : BaseViewModel
    {
        public MyProfileViewModel()
        {
            Title = "My Profile";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}