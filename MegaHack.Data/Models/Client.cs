using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MegaHack.Data.Models
{
    public class Client
    {
        [Key]
        public int ClientID { get; set; }

        [Required]
        public string ClientName { get; set; }



    }
}
