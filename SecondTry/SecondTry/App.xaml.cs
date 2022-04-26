using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SecondTry
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NewPage();
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
