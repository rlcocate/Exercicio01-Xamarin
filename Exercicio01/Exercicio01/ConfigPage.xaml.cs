using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exercicio01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConfigPage : ContentPage
    {
        public ConfigPage()
        {            
            InitializeComponent();
        }

        private void swcEmail_OnChanged(object sender, ToggledEventArgs e)
        {
            txtTexto.IsEnabled = swcEmail.On;
            if (!swcEmail.On) this.txtTexto.Text = "";
        }
    }
}