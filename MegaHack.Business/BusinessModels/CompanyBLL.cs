using MegaHack.Business.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MegaHack.Business.BusinessModels
{
    public class CompanyBLL
    {
        private readonly MegaHackContext _context;

        public CompanyBLL(MegaHackContext context)
        {
            _context = context;
        }

        public string GetCompanyName(string FiscalId)
        {
            var company = _context.Company.Where(c => c.FiscalId == FiscalId).FirstOrDefault();

            return company == null ? "Not Found" : company.Name;

        }

        public int GetCompanyContact(string FiscalId)
        {
            var companyContact = (from cp in _context.Company
                                  join ct in _context.Contact
                                  on cp.CompanyId equals ct.CompanyId
                                  where cp.FiscalId == FiscalId
                                  select ct.Phone
                                  ).FirstOrDefault();

            return companyContact;
        }
    }
}
