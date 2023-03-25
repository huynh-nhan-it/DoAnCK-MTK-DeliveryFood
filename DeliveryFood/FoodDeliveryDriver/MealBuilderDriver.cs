using DeliveryFood.FoodBuilding;
using DeliveryFood.FoodCostTaxCalculation;
using DeliveryFood.FoodDeliveryAppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFood.FoodDeliveryDriver
{
    public class MealBuilderDriver
    {
        public void BuildMealForUser(List<CartModel> selectedMealItems, int rating, Cart cart, string location, UserModel userModel)
        {
            MealBuilder mealBuilder = new MealBuilder();
            mealBuilder.PrepareMeal(selectedMealItems);
            var orders = mealBuilder.meal.ShowItems();
            var foodCost = mealBuilder.meal.GetCost();
            TaxCalculationContext taxCalculationContext;

            if (rating == 1)
            {
                 taxCalculationContext = new TaxCalculationContext(new OneStarTaxCalculator());
            }
            else if(rating == 2)
            {
                 taxCalculationContext = new TaxCalculationContext(new TwoStarTaxCalculator());
            }
            else
            {
                taxCalculationContext = new TaxCalculationContext(new ThreeStarTaxCalculator());
            }
            var taxAmount = taxCalculationContext.GetCalculatedTax(foodCost, 0.05, false);
            var totalCostofFood = foodCost + taxAmount;

            cart.Hide();
            new Payment(location, orders, totalCostofFood.ToString(), taxAmount.ToString(), userModel).Show();
        }
    }
}
