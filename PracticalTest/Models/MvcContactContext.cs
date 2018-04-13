using System;
using Microsoft.EntityFrameworkCore;
namespace PracticalTest.Models
{
    public class MvcContactContext : DbContext
    {
        public MvcContactContext (DbContextOptions<MvcContactContext> options)
            : base(options)
        {
        }

        public DbSet<PracticalTest.Models.Contact> Contact{ get; set; }
    }
}
