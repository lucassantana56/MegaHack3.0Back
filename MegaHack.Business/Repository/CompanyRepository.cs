using MegaHack.Business.Context;
using MegaHack.Business.ViewModel;
using MegaHack.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MegaHack.Business.Repository
{
    public class CompanyRepository
    {
        private readonly MegaHackContext _context;

        public CompanyRepository(MegaHackContext context)
        {
            _context = context;
        }

        public void AddNewCompany(AddComanyViewModel addComanyViewModel)
        {
            if (addComanyViewModel is null)
            {
                throw new ArgumentNullException("Object Null");
            }
            try
            {
                Company company = new Company()
                {
                    Email = addComanyViewModel.Email,
                    Name = addComanyViewModel.Name,
                    Description = addComanyViewModel.Description,
                    NickName = addComanyViewModel.NickName
                };

                _context.Company.Add(company);
                _context.SaveChanges();
            }
            catch (Exception e)
            {

                throw e;
            }
       
        }

        public void UpdateCompany(AddComanyViewModel addComanyViewModel)
        {
            if (addComanyViewModel is null)
            {
                throw new ArgumentNullException("Object Null");
            }
            try
            {
                var company = _context.Company.Where(c => c.FiscalId == addComanyViewModel.FiscalId).ToList();

              
              //  company.Description = "nova des";
               // company.Email = "novo email";


                _context.SaveChanges();
            }
            catch (Exception e)
            {

                throw e;
            }

        }

    }
}
