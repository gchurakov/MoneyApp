using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using AppData1;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public partial class MainPage : ContentPage
    { 
        //public static Profile profile { get; set; } = Profile.FromJson("file.json");

        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = this;
        }
        

        private async void GoBack(object sender, EventArgs e)
        {
            //await Application.Current.MainPage.Navigation.PopModalAsync();
            DisplayAlert("Кнопка назад", "не нажимай! еще не готово!", "ОK");
            
        }

        private async void GoMoneySpends(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SpendsPage());
        }

        private async void GoMoneyIncomes(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new IncomesPage());
        }


        private async void AddAcc_OnClicked(object sender, EventArgs e)
        {
            //await Navigation.PushModalAsync(new AddGoalPage());
        }
    }
}