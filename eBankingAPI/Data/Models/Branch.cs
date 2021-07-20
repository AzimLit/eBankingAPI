using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eBankingAPI.Data.Models
{
    public class Branch
    {
		[Key]
		public int BId { get; set; }// Branch ID
		public string Bname { get; set; } 
		public string Bcity { get; set; }

		//public Branch(int bId_, string bname_, string bcity_)
		//{
		//	this.Bid = bId_;
		//	this.Bname = bname_;
		//	this.Bcity = bcity_;
		//}

	}
}
