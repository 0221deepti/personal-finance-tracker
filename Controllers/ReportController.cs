using System;
using Personal_Finance_Tracker.Services;

namespace Personal_Finance_Tracker.Controllers
{
    public class ReportController
    {
        private readonly ReportService service;

        public ReportController()
        {
            service = new ReportService();
        }

        public void ShowMonthlySummary()
        {
            var summary = service.GetMonthlySummary();

            Console.WriteLine("\n=== Monthly Financial Summary ===");
            Console.WriteLine($"Total Income: {summary.income}");
            Console.WriteLine($"Total Expense: {summary.expense}");
            Console.WriteLine($"Savings: {summary.savings}");
        }
    }
}