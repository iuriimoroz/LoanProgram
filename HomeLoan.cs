using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram
{
    public class HomeLoan : Loan
    {
        public string Address { get; set; }
        public int YearBuilt { get; set; }
        public decimal SquareFootage { get; set; }

        public HomeLoan(int loanNumber, decimal interestRate, decimal loanAmount, int numberOfYearsForLoan, string customerFirstName, string customerLastName, string address, int yearBuilt, decimal squareFootage) : base(loanNumber, interestRate, loanAmount, numberOfYearsForLoan, customerFirstName, customerLastName)
        {
            Address = address;
            YearBuilt = yearBuilt;
            SquareFootage = squareFootage;
        }

        public override decimal CalculateInterest()
        {
            return InterestRate / (NumberOfYearsForLoan / 12M) * (LoanAmount + 5000);
        }

        public override string ToString()
        {
            return $"Address {Address} \nYear Built {YearBuilt} \nSquare Footage {SquareFootage} \nCalculated interest {CalculateInterest().ToString("C")}";
        }
    }
}
