using App1.Entiies;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace App1.Entities
{
    public class Dispositivo
    {
        [Key]
        public long DispositivoImei { get; set; }
        public string BandaMovil { get; set; }
        public string OperadorMovil { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public long NumeroTelefono { get; set; }
        public Guid UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        public Dispositivo(long DispositivoId, string bandaMovil = null, string operadorMovil = null, string marca = null, string modelo = null, long numeroTelefono = 0)
        {
            DispositivoImei= DispositivoId;
            BandaMovil = bandaMovil;
            OperadorMovil = operadorMovil;
            Marca = marca;
            Modelo = modelo;
            NumeroTelefono = numeroTelefono;
        }


    }

}
