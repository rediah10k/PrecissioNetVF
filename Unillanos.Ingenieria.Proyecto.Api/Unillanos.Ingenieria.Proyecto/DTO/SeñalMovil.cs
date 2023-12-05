using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Xamarin.Essentials;

namespace App1.Entities
{
    public class SeñalMovil
    {
        [Key]
        public Guid SeñalMovilId { get; set; }
        public DateTime Fecha { get; set; }
       
        public long DispositivoImei { get; set; }

        public float Intensidad { get; set; }



        [ForeignKey("DispositivoImei")]
        public Dispositivo Dispositivo { get; set; }

        public Guid ZonaId { get; set; }

        [ForeignKey("ZonaId")]
        public Zona Zona { get; set; }

        public SeñalMovil(float intensidad)
        {
            Fecha=DateTime.Now;
            Intensidad=intensidad;
        }
   

        public async Task<Location> GetCurrentLocationAsync()
        {

            var location = await Geolocation.GetLastKnownLocationAsync();
            if (location != null)
            {
                return location;
            }
            else
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Medium);
                return await Geolocation.GetLocationAsync(request);
            }

        }


    }
}
