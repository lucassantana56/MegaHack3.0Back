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

        [Required] public int Cep { get; set; }

    
        [InverseProperty(nameof(Company.Address))]
        public virtual ICollection<Company> Businesses { get; set; }
    }
}