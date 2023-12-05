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
	public partial class Direccionamiento : ContentPage
	{
		public Direccionamiento ()
		{
			InitializeComponent ();
		}

        private void btnConfiguracion_Clicked(object sender, EventArgs e)
        {
			Navigation.PushAsync(new Configuracion());
        }

        private void btnMapa_Clicked(object sender, EventArgs e)
        {
			Navigation.PushAsync(new Mapa());
        }

        private void btnStats_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Stats());
        }
    }
}