using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaHack.Data.Models
{
    public class Address
    {
        [Key] public int AddressId { get; set; }

        [Required] public int AddressNumber { get; set; }

        [Required] public string City { get; set; }

        [Required] public string Street { get; set; }

        [Required] public string Cep { get; set; }

        [Required] public string Geolocation { get; set; }

        public int CompanyId { get; set; }

        [ForeignKey(nameof(CompanyId))] public virtual Company Company { get; set; }
    }
}