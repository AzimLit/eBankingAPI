using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eBankingAPI.Data.Models
{
	public class Loan
	{
		public string LoanId { get; set; }
		[ForeignKey("Customer")]
		public int Custid { get; set; }// Customer ID
		
		[ForeignKey("Branch")]
		public int Bid { get; set; }  //Branch ID
		public decimal Loan_amount { get; set; }

		//public Loan(int custId_, int bId_, decimal loan_amount_)
		//{
		//	this.Custid = custId_;
		//	this.Bid = bId_;
		//	this.Loan_amount = loan_amount_;
		//}
	}
}
