using System;
using System.Collections.Generic;
using Personal_Finance_Tracker.Models;
using Personal_Finance_Tracker.Repositories;

namespace Personal_Finance_Tracker.Services
{
    public class TransactionService
    {
        private readonly TransactionRepository repository;

        public TransactionService()
        {
            repository = new TransactionRepository();
        }

        public void AddTransaction(int id, string type, double amount, string category)
        {
            Transaction transaction = new Transaction
            {
                Id = id,
                Type = type,
                Amount = amount,
                Category = category,
                Date = DateTime.Now
            };

            repository.AddTransaction(transaction);
        }

        public List<Transaction> GetTransactions()
        {
            return repository.GetTransactions();
        }

        public void DeleteTransaction(int id)
        {
            repository.DeleteTransaction(id);
        }
    }
}