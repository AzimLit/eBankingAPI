using eBankingAPI.Data.Models;
using eBankingAPI.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBankingAPI.Data.Services
{
    public class CustomersService
    {
        AppDbContext _context;
        public CustomersService(AppDbContext context)
        {
            _context = context;
        }

        public void AddCustomer(CustomerVM customer) 
        {
            var _customer = new Customer()
            {
                Fname = customer.Fname,
                Mname = customer.Mname,
                Ltname = customer.Ltname,
                City = customer.City,
                Mobileno = customer.Mobileno,
                Occupation = customer.Occupation,
                Dob = DateTime.Now
            };
            _context.Customers.Add(_customer);
            _context.SaveChanges();
        }

        public List<Customer> GetAllCustomers() => _context.Customers.ToList();
        public Customer GetCustomerById(int customerId) => _context.Customers.FirstOrDefault(n => n.CustId == customerId);

        public Customer UpdateCustomerId(int customerId, CustomerVM customer) 
        {
            //First retreave Customer
            var _customer = _context.Customers.FirstOrDefault(n => n.CustId == customerId);
            
            if(_customer != null)
            {
                _customer.Fname = customer.Fname;    
                _customer.Mname = customer.Mname;
                _customer.Ltname = customer.Ltname;
                _customer.City = customer.City;
                _customer.Mobileno = customer.Mobileno;
                _customer.Occupation = customer.Occupation;
                _customer.Dob = DateTime.Now;

                _context.SaveChanges();
            }

            return _customer;
        }

        public void DeleteCustomerById(int customerId)
        {
            //First retreave Customer
            var _customer = _context.Customers.FirstOrDefault(n => n.CustId == customerId);
            if (_customer != null)
            {
                _context.Customers.Remove(_customer);
                _context.SaveChanges();
            }
            
        }
    }
}
