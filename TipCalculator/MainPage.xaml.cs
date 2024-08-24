namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void SetLowTip_Clicked(object sender, EventArgs e)
        {
            TipSlider.Value = 15;
            TipPercentLabel.Text = TipSlider.Value.ToString() + "%";
        }

        private void SetHighTip_Clicked(object sender, EventArgs e)
        {
            TipSlider.Value = 20;
            TipPercentLabel.Text = TipSlider.Value.ToString() + "%";
        }

        private void RoundUpButton_Clicked(object sender, EventArgs e)
        {
            
        }

        private void RoundDownButton_Clicked(object sender, EventArgs e)
        {
            
        }

        private void TipSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            TipPercentLabel.Text = TipSlider.Value.ToString("#.##") + "%";
        }

        private void AmountEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            double Valor = Convert.ToDouble(TipSlider.Value.ToString());
            double ValorDaGorjeta = Valor * (TipSlider.Value/100);
            double ValorTotal = ValorDaGorjeta + Valor;

            TotalLabel.Text = ValorTotal.ToString("C");
            TipLabel.Text = ValorDaGorjeta.ToString("C");

        }
    }

}
