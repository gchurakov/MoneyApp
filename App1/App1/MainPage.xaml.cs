using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppData1;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Profile profile = Profile.FromJson("file.json");
        }

        private async void GoBack(object sender, EventArgs e)
        {
            //await Application.Current.MainPage.Navigation.PopModalAsync();
            DisplayAlert("Кнопка назад", "не нажимай! еще не готово!", "ОK");
            
        }

        private async void GoSettings(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SettingsPage());
        }

        private async void GoMoneySpends(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SpendsPage());
        }

        private async void GoMoneyIncomes(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new IncomesPage());
        }

        
    }
}