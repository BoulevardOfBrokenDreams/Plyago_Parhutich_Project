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
            InitializeComponent();
        }

        private void OnButton1Clicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = "Все пиздец";
            button.BackgroundColor = Color.Green;
            BackgroundColor = Color.Blue;
            label1.Text = "Залупа";
        }

        private void OnButton2Clicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = "ЖМИ";
            button.BackgroundColor = Color.Yellow;
            BackgroundColor = Color.Red;
            button1.Text = "Чмо";
            button2.Text = "Пидр";
            label1.Text = "писька";
        }

        private async void NewPageButtonClick(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new PageFile());
            
        }
    }
}
