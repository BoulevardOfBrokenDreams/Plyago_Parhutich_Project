using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SecondTry
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageFile : ContentPage
    {
        public PageFile(string dayOfWeek)
        {
            string dayName;
            string[] Lessons;

            InitializeComponent();
            switch (dayOfWeek)
            {
                case "Понедельник":


            }
        }

        

        private async void BackButtonClick(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}