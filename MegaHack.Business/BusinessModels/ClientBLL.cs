using MegaHack.Business.Context;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public string GetClientName(string Name)
        {
            var client = _context.Client.Where(cli => cli.Name == Name).FirstOrDefault;

            return client == null ? "Cliente não encontrado" : client.Name;
        }
    }
}
