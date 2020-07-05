using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaHack.Data.Models
{
    public class BonusClient
    {
        [Key] public int BonusClientId { get; set; }
        public bool PendingToActive { get; set; }
        public bool Actived { get; set; }
        public DateTime ActivationDate { get; set; }

        public int ClientId { get; set; }
        [ForeignKey(nameof(ClientId))] public virtual Client Client { get; set; }

        public int BonusId { get; set; }
        [ForeignKey(nameof(BonusId))] public virtual Bonus Bonus { get; set; }
    }
}