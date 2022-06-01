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
    public partial class IncomesPage : ContentPage
    { 
        DateTime Today = DateTime.Today;
        public IncomesPage()
        {
            InitializeComponent();
        }
        
        private void Picker_IncomeRegularity(object sender, EventArgs e)
        {
            DisplayAlert("ВЫбор регулярности дохода", "не нажимай! еще не готово!", "ОK");
        }
        
        private async void GoSettings(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SettingsPage());
        }

        private async void GoMoneySpends(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SpendsPage());
        }

        private async void GoProfileP(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }
        
        private async void GoBack(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            //DisplayAlert("Кнопка назад", "не нажимай! еще не готово!", "ОK");
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }


        private void Add_Income(object sender, EventArgs e)
        {
            DisplayAlert("Save Income", "не нажимай! еще не готово!", "ОK");
        }
    }
}