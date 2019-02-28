using System;
namespace s10ExeFix.Entities
{
    public class Company : Person
    {
        public int NumberEmployees { get; set; }

        public Company()
        {
        }

        public Company(string name, double annualIncome, int numberEmployees)
            : base(name, annualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        public override double TaxPaid()
        {
            return NumberEmployees > 10 ? (AnnualIncome * 0.14) : (AnnualIncome * 0.16);
        }
    }
}
