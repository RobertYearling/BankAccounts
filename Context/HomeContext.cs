using Microsoft.EntityFrameworkCore;
using BankAcoounts.Models;

namespace BankAcoounts.Context
{
    public class HomeContext : DbContext
    {
        public HomeContext(DbContextOptions options) : base(options){}

        public DbSet<User> Users { get; set;}

        public DbSet<Transaction> Transactions { get; set; }
    }
}