using eBankingAPI.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBankingAPI.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder) 
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope()) 
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (!context.Customers.Any()) 
                {
                    context.AddRange(new Customer
                    {
                        Fname = "Morizio",
                        Mname = "Adriano",
                        Ltname = "Vecci",
                        City = "Verona",
                        Mobileno = "(944)-553-8556",
                        Occupation = "Novelist",
                        Dob = DateTime.Now.AddDays(-10)
                    }, 
                    new Customer
                    {
                        Fname = "Corado",
                        Mname = "Delpiero",
                        Ltname = "Catani",
                        City = "Venezia",
                        Mobileno = "(578)-444-8975",
                        Occupation = "Movie Actor",
                        Dob = DateTime.Now.AddDays(-10)
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
