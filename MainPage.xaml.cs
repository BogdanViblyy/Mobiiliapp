namespace Mobiiliapp
{
    public partial class MainPage : ContentPage
    {
        int count = 4;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
            {
                CounterBtn.Text = $"Real Madrid - 2 || Barcelona - {count}";
            }
            else
            {
                CounterBtn.Text = $"Real Madrid - 2 || Barcelona - {count}";
            }

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
