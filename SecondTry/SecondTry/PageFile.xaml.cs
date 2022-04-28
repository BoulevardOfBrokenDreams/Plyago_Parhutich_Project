using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SecondTry
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageFile : ContentPage
    {
        public PageFile()
        {
            InitializeComponent();
        }

        private async void BackButtonClick(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}