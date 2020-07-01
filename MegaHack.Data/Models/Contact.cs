using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaHack.Data.Models
{
    public class Contact
    {
        [Key] public int ContactId { get; set; }

        public int Whatsapp { get; set; }

        public int MobilePhone { get; set; }
        public int Phone { get; set; }

        [Required] public int CompanyId { get; set; }

        [ForeignKey(nameof(CompanyId))] public virtual Company Company { get; set; } //cada contacto pode ou não ter um bar/pub 

    }
}