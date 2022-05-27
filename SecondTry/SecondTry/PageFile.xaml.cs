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
                    prepName1.Text = "";
                    prepName2.Text = "Короткевич В.А.";
                    prepName3.Text = "Писпанен М.А.";
                    prepName4.Text = "Писпанен М.А.";
                    break;
                case "Вторник":
                    DayOfWeek.Text = "Вторник";
                    first.Text = "Криптографические методы";
                    second.Text = "Криптографические методы";
                    third.Text = "Физическая культура";
                    fourth.Text = "Основы идеологии белорусского государства";
                    prepName1.Text = "Мурашко В.И.";
                    prepName2.Text = "Мурашко В.И.";
                    prepName3.Text = "Корпус №7";
                    prepName4.Text = "Денисенко Н.В.";
                    break;
                case "Среда":
                    DayOfWeek.Text = "Среда";
                    first.Text = "Менеджмент ПО";
                    second.Text = "Компьютерные сети";
                    third.Text = "Операционные системы";
                    fourth.Text = "Политология";
                    prepName1.Text = "Марченко Л.Н.";
                    prepName2.Text = "Демуськов А.Б.";
                    prepName3.Text = "Клименко А.В.";
                    prepName4.Text = "Курбатов В.Н.";
                    break;
                case "Четверг":
                    DayOfWeek.Text = "Четверг";
                    first.Text = "Основы Web-разработки";
                    second.Text = "Физическая культура";
                    third.Text = "";
                    fourth.Text = "";
                    prepName1.Text = "Маслович С.Ф.";
                    prepName2.Text = "Корпус №7";
                    prepName3.Text = "";
                    prepName4.Text = "";
                    break;
                case "Пятница":
                    DayOfWeek.Text = "Пятница";
                    first.Text = "Компьюторные сети";
                    second.Text = "МД и СУБД";
                    third.Text = "Технологии программирования";
                    fourth.Text = "Технологии программирования";
                    prepName1.Text = "Демуськов А.Б.";
                    prepName2.Text = "Короткевич Л.И.";
                    prepName3.Text = "Прохоренко В.А.";
                    prepName4.Text = "Прохоренко В.А.";
                    break;
                case "Суббота":
                    DayOfWeek.Text = "Суббота";
                    first.Text = "Основы идеологии белорусского гос-ва";
                    second.Text = "Проектирование программных систем";
                    third.Text = "Проектирование программных систем";
                    fourth.Text = "Иностранный язык (ф)";
                    prepName1.Text = "Караваева Е.М.";
                    prepName2.Text = "Осипенко Н.Б.";
                    prepName3.Text = "Гурский Д.С.";
                    prepName4.Text = "Чернякова Е.А";
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