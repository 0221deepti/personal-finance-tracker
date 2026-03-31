using System.Collections.Generic;
using Personal_Finance_Tracker.Models;

namespace Personal_Finance_Tracker.Repositories
{
    public class BudgetRepository
    {
        private List<Budget> budgets = new List<Budget>();

        public void SetBudget(Budget budget)
        {
            budgets.RemoveAll(b => b.Category == budget.Category);
            budgets.Add(budget);
        }

        public List<Budget> GetBudgets()
        {
            return budgets;
        }
    }
}