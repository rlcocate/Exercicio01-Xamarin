using System;
using Xamarin.Forms;

namespace Exercicio01
{
    public partial class MainPage : ContentPage
    {
        Entry entryTexto;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnEnviar_Clicked(object sender, EventArgs e)
        {
            
        }

        private void btnConfiguracao_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ConfigPage());
        }
    }
}
