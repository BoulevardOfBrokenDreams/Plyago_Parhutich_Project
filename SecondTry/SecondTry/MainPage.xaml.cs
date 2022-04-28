using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

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
            this.BackgroundColor = Color.Blue;
            label1.Text = "Залупа";
        }

        private void OnButton2Clicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = "ЖМИ";
            button.BackgroundColor = Color.Yellow;
            this.BackgroundColor = Color.Red;
        }
    }
}
