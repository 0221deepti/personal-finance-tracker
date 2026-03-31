using System;
using Personal_Finance_Tracker.Services;

namespace Personal_Finance_Tracker.Controllers
{
    public class BudgetController
    {
        private readonly BudgetService service;

        public BudgetController()
        {
            service = new BudgetService();
        }

        public void SetBudget()
        {
            Console.Write("Enter Category: ");
            string category = Console.ReadLine();

            Console.Write("Enter Monthly Limit: ");
            double limit = Convert.ToDouble(Console.ReadLine());

            service.SetBudget(category, limit);

            Console.WriteLine("Budget set successfully!");
        }
    }
}