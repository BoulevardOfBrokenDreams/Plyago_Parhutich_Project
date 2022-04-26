using Xamarin.Forms;

namespace SecondTry
{
    class NewPage : ContentPage
    {
        public NewPage()
        {
            Label label = new Label() { Text = "Сколько лет пройдет все о том же гудят провода,  все того же ждут самолеты. Девочка с глазами из самого синего льда тает под огнем пулемета!" +
                "\n\nЗдесь типо демократия на самом деле царство. я так люблю свою страну и ненавижу государство..." };
            label.BackgroundColor = Color.Yellow;
            label.TextColor = Color.Red;
            label.FontSize = 48;
            this.Content = label;
        }
    }
}
