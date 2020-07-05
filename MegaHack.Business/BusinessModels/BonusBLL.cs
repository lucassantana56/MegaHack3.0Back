using MegaHack.Business.Context;
using MegaHack.Business.ViewModel;
using MegaHack.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MegaHack.Business.BusinessModels
{
    public class BonusBLL
    {

        private readonly MegaHackContext _context;

        public BonusBLL(MegaHackContext context)
        {
            _context = context;
        }

        // TODO - Retornar Bonus de um cliente
        public IList<ClientBonusViewModel> GetClientBonus(string tokenID)
        {
            Guid cpID = Guid.Parse(tokenID);

            var company = _context.Company.Where(cp => cp.Token == cpID).FirstOrDefault();

            var bonusClient = (from c in _context.Client
                               join b in _context.BonusClient
                               on c.ClientID equals b.ClientId
                               join bn in _context.Bonus
                               on b.BonusId equals bn.BonusId
                               where b.PendingToActive == true
                               && bn.CompanyId == company.CompanyId
                               select new ClientBonusViewModel()
                               {
                                   ClientID = c.ClientID,
                                   ClientName = c.Name,
                                   qauntPontos = bn.QuantBonus
                               }).ToList();

            return bonusClient;
        }

        // update parametro idClient, qtdPontos
        // bonusClient Pending  = false
        // qtdPontos add aos pontos do cliente
    }
}
