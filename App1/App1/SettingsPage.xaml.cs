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
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
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
        private async void GoMoneyIncomes(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new IncomesPage());
        }

        protected void ChoseLanguage(object sender, EventArgs eventArgs)
        {
            DisplayAlert("Выбор языка системы", "не нажимай! еще не готово!", "ОK");
        }
    }
}