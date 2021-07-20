using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eBankingAPI.Data.Models
{
    public class Trandetail
	{
		[Key]
		public int TnumberId { get; set; }
		[ForeignKey("Branch")]
		public int AcnumberId { get; set; }
		public DateTime Dot { get; set; }
		public string Medium_of_transaction { get; set; }
		public string Transaction_type { get; set; }
		public decimal Transaction_amount { get; set; }

		//public Trandetail(int tnumberId_, int acnumberId_, DateTime dot_, string medium_of_transaction_, string transaction_type_, decimal transaction_amount_)
		//{
		//	this.Tnumber = tnumberId_;
		//	this.Acnumber = acnumberId_;
		//	this.Dot = dot_;
		//	this.Medium_of_transaction = medium_of_transaction_;
		//	this.Transaction_type = transaction_type_;
		//	this.Transaction_amount = transaction_amount_;
		//}
	}
}
