using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppJogoVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            // Identificando qual botão disparou o evento
            Button btn = (Button)sender;
            
            // Desabilitando o botão
            btn.IsEnabled = false;

            // Trocando texto do botão de acordo com quem é a vez.
            if (vez == "X")
            {
                btn.Text = "X";                
                vez = "O";
            } else
            {
                btn.Text = "O";
                vez = "X";
            }

            // Verificando se a linha 1 teve ganhador.
            if(btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                await DisplayAlert("Parabéns", "O X ganhou!", "OK");
                btn10.IsEnabled = true;
                btn10.Text = "";
                btn11.IsEnabled = true;
                btn11.Text = "";
                btn12.IsEnabled = true;
                btn12.Text = "";

            } else if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
            {
                DisplayAlert("Parabéns", "A O ganhou!", "OK");
            }
        }
    }
}
