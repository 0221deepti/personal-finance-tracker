using Personal_Finance_Tracker.Repositories;

namespace Personal_Finance_Tracker.Services
{
    public class ReportService
    {
        private readonly TransactionRepository repository;

        public ReportService()
        {
            repository = new TransactionRepository();
        }

        public (double income, double expense, double savings) GetMonthlySummary()
        {
            double income = repository.GetTotalIncome();
            double expense = repository.GetTotalExpense();
            double savings = income - expense;

            return (income, expense, savings);
        }
    }
}