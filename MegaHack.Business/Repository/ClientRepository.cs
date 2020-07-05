using MegaHack.Business.Context;
using MegaHack.Business.ViewModel;
using MegaHack.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MegaHack.Business.Repository
{
    public class ClientRepository
    {
        private readonly MegaHackContext _context;

        public ClientRepository(MegaHackContext context)
        {
            _context = context;
        }

        public Guid AddClient(AddClientViewModel addClientViewModel)
        {
            var clientondb = _context.Client.Where(c => c.Email == addClientViewModel.Email).FirstOrDefault();

            if (!(clientondb is null))
                return Guid.Empty;

            Guid clientToken = Guid.NewGuid();
            Client client = new Client()
            {
                Age = int.Parse(addClientViewModel.Age),
                Email = addClientViewModel.Email,
                Gender = addClientViewModel.Gender,
                Name = addClientViewModel.Name,
                Password = addClientViewModel.Password,
                Token = clientToken
            };

            _context.Client.Add(client);
            _context.SaveChanges();
            return clientToken;
        }
    }
}