using DeliveryFood.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFood.FoodCostTaxCalculation
{
    public class OneStarTaxCalculator : ITaxCalculator
    {
        public double CalculateTax(double price, double localTax, bool imported)
        {
            double tax = price * localTax;

            if (imported)
                tax += (price * 0.5);

            //rounds off to nearest 0.05;
            tax = TaxUtil.RoundOff(tax);

            return tax;
        }
    }
}
