
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace App1.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Mapa : ContentPage
	{
		public Mapa ()
		{
			InitializeComponent ();
            var localhtml = new HtmlWebViewSource();
            localhtml.Html = @"
<!DOCTYPE html>
<html>
<head>
    <title>Mapa OpenStreetMap</title>
    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no"" />
    <link rel=""stylesheet"" href=""https://unpkg.com/leaflet/dist/leaflet.css"" />
    <link rel=""stylesheet"" href=""https://unpkg.com/leaflet.heat/dist/leaflet-heat.css"" />
    <style>
        body, html {
            margin: 0;
            padding: 0;
        }

        #map {
            height: 100vh;
            margin: 0;
            padding: 0;
        }
    </style>
</head>
<body>
    <div id=""map""></div>
    <script src=""https://unpkg.com/leaflet.heat/dist/leaflet-heat.js"">

</script>
    <script src=""https://unpkg.com/leaflet/dist/leaflet.js""></script>
    <script>

       var latitudMínima = 4.07368;
		var longitudMínima = -73.58743;
		var latitudMáxima = 4.07511;
		var longitudMáxima = -73.57911;
		var centroLatitud = (latitudMínima + latitudMáxima) / 2;
		var centroLongitud = (longitudMínima + longitudMáxima) / 2;

		var bounds = L.latLngBounds([latitudMínima, longitudMínima], [latitudMáxima, longitudMáxima]);

// Crea el mapa y aplica los límites
		var map = L.map('map', {
			maxBounds: bounds,
			maxBoundsViscosity: 1.0,
			minZoom: 16,
		}).setView([centroLatitud, centroLongitud], 16);


//Añadir un mapa base
		L.tileLayer('https://tile.jawg.io/eabffc56-a858-4dfc-a860-6eb1b3d206b6/{z}/{x}/{y}{r}.png?access-token={accessToken}', {
	attribution: '<a href=\""https://www.jawg.io?utm_medium=map&utm_source=attribution\"" target=\""_blank\"">&copy; Jawg</a> - <a href=\""https://www.openstreetmap.org?utm_medium=map-attribution&utm_source=jawg\"" target=\""_blank\"">&copy; OpenStreetMap</a>&nbsp;contributors',
	minZoom: 0,
	maxZoom: 22,
	subdomains: 'abcd',
	accessToken: 'HTfAaFUuf4byLHPJtTAfULiWDo03IWQ8MBzLVbieysWEYyQKTTxlb37w7jijlKC7'
}).addTo(map);
var zonaCoordinates = [
			[4.07582, -73.5849],
			[4.07376, -73.58721],
			[4.07059, -73.58249],
			[4.07097, -73.5798],
			[4.07528, -73.57944],
			[4.07817, -73.58193],
			[4.07765, -73.58221]
		];

		// Crea un polígono para encerrar la zona
		var zonaPolygon = L.polygon(zonaCoordinates, {
			color: '#FFFFFF', // Color del borde del polígono
			fillColor: 'transparent', // Color de relleno del polígono
			fillOpacity: 0.3, // Opacidad del relleno del polígono (0-1)
		}).addTo(map);

		zonaPolygon.bindPopup(""Área de estudio"");
 var coordenadasCalor = [
            [4.076, -73.582],
            [4.075, -73.581],
            [4.074, -73.580],
            // Agrega más coordenadas según tus necesidades
        ];

        // Crea un mapa de calor
        var heatLayer = L.heatLayer(zonaCoordinates, { radius: 25 }).addTo(map);

    </script>
</body>
</html>";
            mapWeb.Source = localhtml;
        }

        private void btnDireccionamiento_Clicked(object sender, EventArgs e)
        {
			Navigation.PushAsync(new Direccionamiento());
        }

        private void btnStats_Clicked(object sender, EventArgs e)
        {
			Navigation.PushAsync(new Stats());
        }
    }
}