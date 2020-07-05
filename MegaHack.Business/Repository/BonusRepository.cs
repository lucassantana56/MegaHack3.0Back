using MegaHack.Business.Context;
using MegaHack.Business.ViewModel;
using MegaHack.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MegaHack.Business.Repository
{
    public class BonusRepository
    {
        private readonly MegaHackContext _context;

        public BonusRepository(MegaHackContext context)
        {
            _context = context;
        }

        public void CreateBonus(AddBonusViewModel addBonusViewModel)
        {
            Bonus bonus = new Bonus()
            {
                CreatedOn = DateTime.Now,
                Description = addBonusViewModel.description,
                ExpirationDateTime = addBonusViewModel.expirationDate,
                ImageUrl = addBonusViewModel.imageUrl,
                Name = addBonusViewModel.name,
                QuantBonus = addBonusViewModel.quantBonus,
                CompanyId = addBonusViewModel.companyId
            };

            _context.Bonus.Add(bonus);
            _context.SaveChanges();
        }

    }
}
