using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MegaHack.Data.Models
{
    public class Client
    {
        [Key] public int ClientID { get; set; }

        [Required] public string Name { get; set; }

        public string NickName { get; set; }

        [Required] public string Login { get; set; }

        [Required] public string Password { get; set; }

        [Required] public string Email { get; set; }

        [Required] public ICollection<Contact> Contacts { get; set; }

        [Required] public DateTime DateBirth { get; set; }

        [Required] public int Age { get; set; }

    }
}
