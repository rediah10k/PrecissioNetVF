using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace App1.Entities
{
    public class Zona
    {

        [Key]
        public Guid ZonaId { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public string NombreZona { get; set; }


        public Zona(double latitude, double longitude, string zoneName = null)
        {
            Latitud = latitude;
            Longitud = longitude;
            NombreZona = zoneName;
        }
        /*
        public bool VerificarExiste(double lat, double lon)
        {
             if(hay una coordenada en bd)//{
            return true;
             }
             else
             {return false;} 
        */
       

    }

}

