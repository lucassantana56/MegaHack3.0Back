using System;
using System.Collections.Generic;
using System.Text;

namespace MegaHack.Business.ViewModel
{
    public class AddBonusViewModel
    {
        public string name { get; set; }
        public string imageUrl { get; set; }
        public string description { get; set; }
        public int quantBonus { get; set; }
        public DateTime expirationDate { get; set; }
        public string companyToken { get; set; }
    }
}
