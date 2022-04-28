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
        }

        private void OnButton2Clicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = "ЖМИ";
            button.BackgroundColor = Color.Yellow;
            this.BackgroundColor = Color.Red;
            
        }

        private void Button2Click(object sender, System.EventArgs e)
        {
            button1.Text = "Чмо";
            button2.Text = "Пидр";
            lb.Text = "писька";
        }
    }
}
