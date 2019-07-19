using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram
{
    public abstract class Loan // Abstract class can not be instantiated and only used as a base class
    {
        private int _loanNumber;
        private decimal _interestRate;
        private decimal _loanAmount;
        private int _numberOfYearsForLoan;

        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public int LoanNumber
        {
            get
            {
                return _loanNumber;
            }
            set
            {
                if (value > 0)
                {
                    _loanNumber = value;
                }
                else
                {
                    Console.WriteLine("Loan number should be greater than 0.");
                }
            }
        }
        public decimal InterestRate
        {
            get
            {
                return _interestRate;
            }
            set
            {
                if (value > 0)
                {
                    _interestRate = value;
                }
                else
                {
                    Console.WriteLine("Interest rate should be greater than 0.");
                }
            }
        }
        public decimal LoanAmount
        {
            get
            {
                return _loanAmount;
            }
            set
            {
                if (value > 0)
                {
                    _loanAmount = value;
                }
                else
                {
                    Console.WriteLine("Loan amount should be greater than 0.");
                }
            }
        }
        public int NumberOfYearsForLoan
        {
            get
            {
                return _numberOfYearsForLoan;
            }
            set
            {
                if (value > 0)
                {
                    _numberOfYearsForLoan = value;
                }
                else
                {
                    Console.WriteLine("Loan can not be taken for the period less than one year.");
                }
            }
        }

        public Loan(int loanNumber, decimal interestRate, decimal loanAmount, int numberOfYearsForLoan, string customerFirstName, string customerLastName)
        {
            CustomerFirstName = customerFirstName;
            CustomerLastName = customerLastName;
            LoanNumber = loanNumber;
            InterestRate = interestRate;
            LoanAmount = loanAmount;
            NumberOfYearsForLoan = numberOfYearsForLoan;
        }

        public abstract decimal CalculateInterest();
    }
}



