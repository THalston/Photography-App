using Photography_App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Photography_App.Controls
{
    public partial class Menu : StackLayout
    {
        public Menu()
        {
            InitializeComponent();
        }
        async void Menu_HomeButton_OnClicked(object sender, EventArgs e)
        {
            await App.Current.MainPage.DisplayAlert("Test Title", "Test", "OK");
        }

        async void Menu_FavouritesButton_OnClicked(object sender, EventArgs e)
        {
            await App.Current.MainPage.DisplayAlert("Test Title", "Test", "OK");
        }

        async void Menu_SearchButton_OnClicked(object sender, EventArgs e)
        {
            await App.Current.MainPage.DisplayAlert("Test Title", "Test", "OK");
        }

        async void Menu_MyProfileButton_OnClicked(object sender, EventArgs e)
        {
            await App.Current.MainPage.DisplayAlert("Test Title", "Test", "OK");
        }
    }

}