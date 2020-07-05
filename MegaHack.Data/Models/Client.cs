using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaHack.Data.Models
{
    public class Client
    {
        [Key] public int ClientID { get; set; }

        [Required] public string Name { get; set; }

        [Required] public Guid Token { get; set; }

        public string Gender { get; set; }

        [Required] public string Password { get; set; }

        [Required] public string Email { get; set; }

        public int Age { get; set; }

        public int MyBonus { get; set; }

        [InverseProperty(nameof(BonusClient.Client))]
        public virtual ICollection<BonusClient> BonusClients { get; set; }
    }
}