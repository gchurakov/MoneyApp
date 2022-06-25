using System;
using AppData1;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace App1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            //Profile profile = Profile.FromJson("file.json");
            
        }

        protected override void OnStart()
        {
            
            base.OnStart();
        }


        protected override void OnSleep()
        {
            // Handle when your app sleeps
             
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

    }
}