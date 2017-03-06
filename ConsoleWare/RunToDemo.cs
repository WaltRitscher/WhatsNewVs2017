using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWare {
	class RunToDemo {

		internal static void RunTo() {
			decimal monthlyPayment;
			decimal rate = 5.6M;

			// step into
			monthlyPayment = Financial.CalculateMonthlyPayment(12, rate, 1200);

			// step over
			monthlyPayment = Financial.CalculateMonthlyPayment(24, rate, 2400);

			// step out;
			monthlyPayment = Financial.CalculateMonthlyPayment(12, rate, 1800);

		}

	}
}
