using MegaHack.Business.Context;
using MegaHack.Business.ViewModel;
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

        public IList<CompanyInfoConsolidate> GetCompanyInfoConsolidate()
        {
            var companyInfo = (from cp in _context.Company
                               join ad in _context.Address
                               on cp.CompanyId equals ad.CompanyId
                               select new CompanyInfoConsolidate
                               {
                                   CompanyRate = cp.BusinessRate,
                                   Geolocation = ad.Geolocation,
                                   Name = cp.Name
                               }).ToList();

            return companyInfo;
        }

        public Guid VerifyIfCompanyExist(LoginCompanyViewModel lvm)
        {
            var token = _context.Company.Where(c => c.Email == lvm.email && c.Password == lvm.password && c.FiscalId == lvm.fiscalId).FirstOrDefault();

            return token == null ? Guid.Empty : token.Token;

        } 
        
    }
}
