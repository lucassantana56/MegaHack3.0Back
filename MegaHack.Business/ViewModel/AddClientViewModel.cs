using System;
using System.Collections.Generic;
using System.Text;

namespace MegaHack.Business.ViewModel
{
    public class AddClientViewModel
    {

        public int ClientID { get; set; }

        public string ClientName { get; set; }

        public string ClientNickName { get; set; }

        public string ClientLogin { get; set; }

        public string ClientPassword { get; set; }

        public string ClientEmail { get; set; }

        public DateTime ClientDateBirth { get; set; }

        public int ClientAge { get; set; }

    }
}