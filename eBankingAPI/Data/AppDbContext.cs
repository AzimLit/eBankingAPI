using eBankingAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBankingAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base (options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Branch> Branchs { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Trandetail> Trandetails { get; set; }
        public DbSet<Loan> Loans { get; set; }

    }
}
