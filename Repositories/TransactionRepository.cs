using System.Collections.Generic;
using System.Linq;
using Personal_Finance_Tracker.Models;

namespace Personal_Finance_Tracker.Repositories
{
    public class TransactionRepository
    {
        private List<Transaction> transactions = new List<Transaction>();

        public void AddTransaction(Transaction transaction)
        {
            transactions.Add(transaction);
        }

        public List<Transaction> GetTransactions()
        {
            return transactions;
        }

        public void DeleteTransaction(int id)
        {
            transactions.RemoveAll(t => t.Id == id);
        }

        public double GetTotalIncome()
        {
            return transactions
                .Where(t => t.Type.ToLower() == "income")
                .Sum(t => t.Amount);
        }

        public double GetTotalExpense()
        {
            return transactions
                .Where(t => t.Type.ToLower() == "expense")
                .Sum(t => t.Amount);
        }
    }
}