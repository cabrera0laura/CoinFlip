namespace CoinFlip
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        Game jogo = new Game();

        public MainPage()
        {
            InitializeComponent();
        }

        private void FlipButton_Clicked(object sender, EventArgs e)
        {
            Random random = new Random();     //                                                                       pq esta comentado; foi substituido pelo Game, if Boolean?
            int sorteio = random.Next(2);

            //Animação();

            /*
            if (sorteio == 0)
            {
                MoedaImage.Source = "cara.png";
            }
            else
            {
                MoedaImage.Source = "coroa.png";
            }*/


            Coin moeda = new Coin();
            MoedaImage.Source = moeda.Flip() + ".png";

            // LS esta faltando algo
           // sorteio = moeda.LadoSorteado == "cara" ? 0 : 1;

            if (moeda.LadoSorteado == "cara")
                sorteio = 0;
            else sorteio = 1;

            if (jogo.CheckWinner(sorteio,SelecaoPicker.SelectedIndex))
            {
                DisplayAlert("Parabéns", "Você venceu!", "Ok");
            }
            else
            {
                DisplayAlert("Se ferrou", "Você perdeu!", "Ok");
            }


            PlayerPointLabel.Text = $"Você ganho {jogo.PlayerPoint} vezes ao todo. ";
            //na MainPage.xaml => sequencia.
            StreakLabel.Text = $"Você ganhou {jogo.Streak} sequencias ao todo";
        }
    }
}
