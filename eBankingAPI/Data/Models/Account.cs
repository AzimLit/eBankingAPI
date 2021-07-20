using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eBankingAPI.Data.Models
{
    public class Account
    {
		[Key]
		public int AcnumberId { get; set; }

		[ForeignKey("Customer")]
		public int CustId { get; set; } // Customer ID

		[ForeignKey("Branch")]
		public int BId { get; set; } // Branch ID
		public decimal Opening_balance { get; set; }
		public DateTime Aod { get; set; } // Account opening date
		public string Atype { get; set; }
		public string Astatus { get; set; }

		//public Account(int acnumberId_, int custId_, int bId_, decimal opening_balance_, DateTime aod_, string atype_, string astatus_)
		//{
		//	this.Acnumber = acnumberId_;
		//	this.Custid = custId_;
		//	this.Bid = bId_;
		//	this.Opening_balance = opening_balance_;
		//	this.Aod = aod_;
		//	this.Atype = atype_;
		//	this.Astatus = astatus_;
		//}
	}
}
