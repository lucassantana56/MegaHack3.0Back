using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaHack.Data.Models
{
    public class Company
    {
        [Key] public int CompanyId { get; set; }

        [Required] public string Name { get; set; }
        
        [Required] public string Password{ get; set; }

        [Required] public Guid Token { get; set; }

        [Required] public string NickName { get; set; }

        [Required] public string FiscalId { get; set; }

        [Required] public string Description { get; set; }

        [Required] public string Email { get; set; }

        [Required] public int BusinessRate { get; set; }

        [InverseProperty(nameof(Contact.Company))]
        public ICollection<Contact> Contacts { get; set; }

        [InverseProperty(nameof(Address.Company))]
        public ICollection<Address> Addresses { get; set; }

        [InverseProperty(nameof(Bonus.Company))]
        public ICollection<Bonus> Bonuses { get; set; }
    }
}