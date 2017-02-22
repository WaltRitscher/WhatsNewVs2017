using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RouxAcademyWebApp.Models {
	public class Loan {
		public decimal Amount { get; set; }
		public decimal Rate { get; set; }
		public int LengthInMonths { get; set; }
	}
}