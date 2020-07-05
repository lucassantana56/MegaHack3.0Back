using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaHack.Data.Models
{
    public class Bonus
    {
        [Key] public int BonusId { get; set; }

        [Required] public string Name { get; set; }

        [Required] public string ImageUrl { get; set; }

        [Required] public string Description { get; set; }

        [Required] public int QuantBonus { get; set; }

        [Required] public DateTime CreatedOn { get; set; }

        [Required] public DateTime ExpirationDateTime { get; set; }

        [Required] public int CompanyId { get; set; }

        [ForeignKey(nameof(CompanyId))] public virtual Company Company { get; set; }

        [InverseProperty(nameof(BonusClient.Bonus))]
        public virtual ICollection<BonusClient> BonusClients { get; set; }
    }
}