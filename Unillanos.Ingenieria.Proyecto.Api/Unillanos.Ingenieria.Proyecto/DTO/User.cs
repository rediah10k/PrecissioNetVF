using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using App1.Entities;

namespace App1.Entiies
{
   public class User
    {
       [Key]
        public Guid UserId { get; set; }

        public string Email { get; set; }
        public string Password{ get; set; }

        public int FrequencyR { get; set; }

        public ICollection<Dispositivo> Dispositivo { get; set; }

        public User( string email, string password) {
            Email = email;
            Password = password;
        }

    }
}
