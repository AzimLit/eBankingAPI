using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eBankingAPI.Data.Models
{
    public class Customer
    {
		[Key]
		public int CustId { get; set; }
		public string Fname { get; set; }
		public string Mname { get; set; }
		public string Ltname { get; set; }
		public string City { get; set; }
		public string Mobileno { get; set; }
		public string Occupation { get; set; }
		public DateTime Dob { get; set; }

		//public Customer(int custId_, string fname_, string mname_, string ltname_, string city_, string mobileno_, string occupation_, DateTime dob_)
		//{
		//	this.Custid = custId_;
		//	this.Fname = fname_;
		//	this.Mname = mname_;
		//	this.Ltname = ltname_;
		//	this.City = city_;
		//	this.Mobileno = mobileno_;
		//	this.Occupation = occupation_;
		//	this.Dob = dob_;
		//}

	}
}
