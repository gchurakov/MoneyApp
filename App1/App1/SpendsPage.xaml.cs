using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SpendsPage : ContentPage
    {
        public SpendsPage()
        {
            InitializeComponent();
        }

        private void Picker_IncomeRegularity(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        
        private async void GoSettings(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SettingsPage());
        }
        

        private async void GoProfile(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }
        
        private async void GoBack(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            //DisplayAlert("Кнопка назад", "не нажимай! еще не готово!", "ОK");
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }

        private async void GoMoneyIncomes(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new IncomesPage());
        }

        

        
    }
}