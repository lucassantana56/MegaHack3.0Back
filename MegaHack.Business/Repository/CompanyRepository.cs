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

        public Guid AddNewCompany(AddComanyViewModel addComanyViewModel)
        {
            if (addComanyViewModel is null)
            {
                throw new ArgumentNullException("Object Null");
            }
            try
            {
                Guid companyToken = Guid.NewGuid();
                Company company = new Company()
                {
                    Email = addComanyViewModel.email,
                    Name = addComanyViewModel.name,
                    Description = addComanyViewModel.description,
                    NickName = addComanyViewModel.nickName,
                    BusinessRate = 0,
                    FiscalId = addComanyViewModel.fiscalId,
                    Token = companyToken,
                    Password = addComanyViewModel.password
                };

                _context.Company.Add(company);

                Address address = new Address()
                {
                    AddressNumber = addComanyViewModel.addressNumber,
                    Cep = addComanyViewModel.cep,
                    Street = addComanyViewModel.street,
                    City = addComanyViewModel.city,
                    Geolocation = addComanyViewModel.geolocation,
                    Company = company
                };

                _context.Address.Add(address);

                Contact contact = new Contact()
                {
                    MobilePhone = addComanyViewModel.mobilePhone,
                    Phone = addComanyViewModel.phone,
                    Whatsapp = addComanyViewModel.whatsapp,
                    LocationCode = addComanyViewModel.LocationCode,
                    Company = company
                };

                _context.Contact.Add(contact);

                _context.SaveChanges();

                return companyToken;
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



            }
            catch (Exception e)
            {

                throw e;
            }

        }

        // Receber ClientID 
        // Realizar uma busca - find
        // Atualizar propriedades do objeto

    }
}
