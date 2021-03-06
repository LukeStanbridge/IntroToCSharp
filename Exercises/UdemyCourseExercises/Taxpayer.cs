using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCourseExercises
{
    internal class Taxpayer
    {
        private string socialSecurityNumber;
        private double yearlyGrossIncome;
        private double taxOwed;

        public string SocialSecurityNumber
        {
            get { return socialSecurityNumber; }
            set { socialSecurityNumber = value; }
        }

        public double YearlyGrossIncome
        {
            get { return yearlyGrossIncome; }
            set { yearlyGrossIncome = value; CalcTax(); }
        }

        public double TaxOwed
        {
            get { return taxOwed; }
        }

        private void CalcTax()
        {
            if (yearlyGrossIncome < 30000)
            {
                taxOwed = 0.15 * yearlyGrossIncome;
            }
            else
            {
                taxOwed = 0.28 * yearlyGrossIncome;
            }
        }
    }
}
