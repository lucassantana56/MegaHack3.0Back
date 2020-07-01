using MegaHack.Business.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MegaHack.Business.BusinessModels
{
    public class ClientBLL
    {
        private readonly MegaHackContext _context;

        public ClientBLL(MegaHackContext context)
        {
            _context = context;
        }

        public string get()
        {
            return "";
        }
    }
}
