using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Stats : ContentPage
    {
        public Stats()
        {
            InitializeComponent();
            
            }



        private void btnDireccionamiento_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Direccionamiento());
        }

        private void btnMapa_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Mapa());
        }
    }
}