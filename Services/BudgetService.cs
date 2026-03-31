using System.Collections.Generic;
using Personal_Finance_Tracker.Models;
using Personal_Finance_Tracker.Repositories;
using Personal_Finance_Tracker.Interfaces;
using Personal_Finance_Tracker.Adapters;

namespace Personal_Finance_Tracker.Services
{
    public class BudgetService
    {
        private readonly BudgetRepository budgetRepository;
        private readonly INotificationService notificationService;

        public BudgetService()
        {
            budgetRepository = new BudgetRepository();
            notificationService = new ConsoleNotificationAdapter();
        }

        public void SetBudget(string category, double limit)
        {
            Budget budget = new Budget
            {
                Category = category,
                MonthlyLimit = limit
            };

            budgetRepository.SetBudget(budget);
        }

        public void CheckBudgetExceeded(string category, double expenseAmount)
        {
            List<Budget> budgets = budgetRepository.GetBudgets();

            foreach (var budget in budgets)
            {
                if (budget.Category == category && expenseAmount > budget.MonthlyLimit)
                {
                    notificationService.SendNotification(
                        $"Budget exceeded for {category}! Limit: {budget.MonthlyLimit}, Expense: {expenseAmount}");
                }
            }
        }
    }
}