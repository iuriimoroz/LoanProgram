# LoanProgram
This is solution for Loan Program task
Loan Program

This application is designed to be used by a loan officer to calculate information about Loans.  They offer both home loans and auto loans.

Class Creation

Create a base class to store the basic characteristics of a loan. These are:

·         Loan number

·         Customer First Name

·         Customer Last Name

·         Interest Rate

·         Loan Amount

·         Number of Years in the loan’s term

Create a constructor that is designed to take on all of this information but do not allow instances of the Loan class to be created.

Create two derived classes from Loan:

HomeLoan should contain properties for Address, Year Built, and Square Footage

AutoLoan should contain properties for YearBuilt, Model, Make, and Color

Use good class design with public properties and override ToString methods.  Each class should have a constructor that takes in all properties in order to be created.

CalculateInterest Method – returns decimal

Each class will have an implementation for the CalculateInterest method. Enforce this by adding an abstract method to the base class. However, the formula used in calculating the interest is different for Auto and Home loans.

HomeLoan should use the formula: (interest rate / number of payments (in months) X loan principal (the total amount they are borrowing + an admin fee of $5000)

AutoLoan should use the formula: (interest rate / number of payments (in months) X loan principal (the total amount they are borrowing + an admin fee of $1000)

The calculated interest should be in your ToString() output

Unit Test

Create two unit test methods with the following specifications:

In the first test, create an auto loan for $12,000 with an interest rate of 7.5% over 4 years. Call the CalculateInterest method for the object and create an assertion for $2,925. Use the console to write out the ToString for your object.

In the second test, create a home loan for $210,000 with an interest rate of 3.5% over 30 years. Call the CalculateInterest method for the object and create an assertion for $30,100. Use the console to write out the ToString for your object.
