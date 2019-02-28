using System;
namespace s10ExeFix.Entities
{
    public class Individual : Person
    {

        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double annualIncome, double healthExpenditures)
            : base (name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TaxPaid()
        {
            double result;
            double descountHeath = HealthExpenditures > 0 ? (HealthExpenditures * 0.5) : 0.0;

            result = AnnualIncome < 20000.00 ? (AnnualIncome * 0.15) : (AnnualIncome * 0.25);

            return result-descountHeath;
        }
    }
}
