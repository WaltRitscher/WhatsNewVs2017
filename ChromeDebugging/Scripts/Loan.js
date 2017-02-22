function GetMonthlyLoanPayment(loanAmount, yearlyInterestRate, numberOfPayments) {

	var payment;
	
	var rate = yearlyInterestRate / 100 / 12;
	var denominator = Math.pow((1 + rate), numberOfPayments) - 1;
	payment = (rate + (rate / denominator)) * loanAmount;

	return "<div>Your student loan payment is " + payment.toLocaleString("en-US", { style: "currency", currency: "GBP", minimumFractionDigits: 2 }) + "</div>"


}