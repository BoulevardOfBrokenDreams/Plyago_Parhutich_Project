﻿using System;
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
                case "Monday": 

            }
        }

        private void OpenFileButtonClick(object sender, EventArgs e)
        {
            LabelWithText.Text = "Снова в жизни чёрная полоска\n" +
                "Мне нужен донор мозга\n" +
                "А то я перестал\n" +
                "Зреть потусторонние видения\n" +
                "Ну где же вы, приведения?\n" +
                "Я так без вас устал\n" +
                "Психотерапевты, восхищайтесь!\n" +
                "Вот ваша мечта, ваше счастье\n" +
                "Психотерапевты, восхищайтесь!\n" +
                "Я – ваша мечта, ваше счастье\n" +
                "Психотерапевты, восхищайтесь!\n" +
                "Вот ваша мечта, ваше счастье\n" +
                "Психотерапевты, восхищайтесь!\n" +
                "Я – ваша мечта, ваше счастье\n" +
                "Вот он я – незримая когорта\n" +
                "Человек второго сорта\n" +
                "В наушниках музло\n" +
                "Двигаюсь к финалу тихой сапой\n" +
                "С поломанным носом и лапой\n" +
                "С улыбкой на табло\n" +
                "Психотерапевты, восхищайтесь!\n" +
                "Вот ваша мечта, ваше счастье\n" +
                "Психотерапевты, восхищайтесь!\n" +
                "Я – ваша мечта, ваше счастье\n" +
                "Психотерапевты, восхищайтесь!\n" +
                "Вот ваша мечта, ваше счастье\n" +
                "Психотерапевты, восхищайтесь!\n" +
                "Я – ваша мечта, ваше счастье\n" +
                "Закрывая морду, за очками\n" +
                "Безумными зрачками\n" +
                "Я, кажется, опять\n" +
                "Вижу на стенах знакомые тени\n" +
                "Сколько же прошло времени?\n" +
                "Скорей бы вас обнять\n" +
                "Психотерапевты, восхищайтесь!\n" +
                "Вот ваша мечта, ваше счастье\n" +
                "Психотерапевты, восхищайтесь!\n" +
                "Я – ваша мечта, ваше счастье\n" +
                "Психотерапевты, восхищайтесь!\n" +
                "Вот ваша мечта, ваше счастье\n" +
                "Психотерапевты, восхищайтесь!\n" +
                "Я – ваша мечта, ваше счастье\n";
        }

        private async void BackButtonClick(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}