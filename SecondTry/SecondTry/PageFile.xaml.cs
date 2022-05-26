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
            this.BackgroundColor = Color.White;

            switch (dayOfWeek)
            {
                case "Понедельник":
                    DayOfWeek.Text = "Понедельник";
                    first.Text = "-";
                    second.Text = "МД и СУБД";
                    third.Text = "Операционные системы";
                    fourth.Text = "Основы Web-разработки";
                    break;
                case "Вторник":
                    DayOfWeek.Text = "Вторник";
                    first.Text = "Криптографические методы";
                    second.Text = "Криптографические методы";
                    third.Text = "Физическая культура";
                    fourth.Text = "Основы идеологии белорусского государства";
                    break;
                case "Среда":
                    DayOfWeek.Text = "Среда";
                    first.Text = "Менеджмент ПО";
                    second.Text = "Компьютерные сети";
                    third.Text = "Операционные системы";
                    fourth.Text = "Политология";
                    break;
                case "Четверг":
                    DayOfWeek.Text = "Четверг";
                    first.Text = "Основы Web-разработки";
                    second.Text = "Физическая культура";
                    third.Text = "";
                    fourth.Text = "";
                    break;
                case "Пятница":
                    DayOfWeek.Text = "Пятница";
                    first.Text = "Компьюторные сети";
                    second.Text = "МД и СУБД";
                    third.Text = "Технологии программирования";
                    fourth.Text = "Технологии программирования";
                    break;
                case "Суббота":
                    DayOfWeek.Text = "Суббота";
                    first.Text = "Основы идеологии белорусского гос-ва";
                    second.Text = "Проектирование программных систем";
                    third.Text = "Проектирование программных систем";
                    fourth.Text = "Иностранный язык (ф)";
                    break;
            }
            backButton.Text = "Назад";
        }

        

        private async void BackButtonClick(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}