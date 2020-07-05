using MegaHack.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace MegaHack.Business.Context
{
    public class MegaHackContext : DbContext
    {
        public MegaHackContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Address> Address { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Client> Client { get; set; }

        public DbSet<Bonus> Bonus { get; set; }
        public DbSet<BonusClient> BonusClient { get; set; }
    }
}