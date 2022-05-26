using Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;

namespace SecondTry
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BackgroundColor = Color.White;
            InitializeComponent();
        }
        //when the days are cold
        //and the cards all fold
        private async void OnButtonClicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            Page page = new PageFile(button.Text);
            await Navigation.PushModalAsync(page);
            
        }
    }
}
