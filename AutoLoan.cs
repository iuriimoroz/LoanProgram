using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram
{
    public class AutoLoan : Loan
    {
        public int YearBuilt { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public string Color { get; set; }


        public AutoLoan(int loanNumber, decimal interestRate, decimal loanAmount, int numberOfYearsForLoan, string customerFirstName, string customerLastName, string model, int yearBuilt, string make, string color) : base(loanNumber, interestRate, loanAmount, numberOfYearsForLoan, customerFirstName, customerLastName)
        {
            Model = model;
            YearBuilt = yearBuilt;
            Make = make;
            Color = color;
        }

        public override decimal CalculateInterest()
        {
            return InterestRate / (NumberOfYearsForLoan / 12M) * (LoanAmount + 1000);
        }

        public override string ToString()
        {
            return $"Year Built {YearBuilt} \nModel {Model} \nMake {Make} \nColor {Color} \nCalculated interest {CalculateInterest().ToString("C")}";
        }
    }
}
