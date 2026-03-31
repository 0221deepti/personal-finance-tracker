using System;
using Personal_Finance_Tracker.Services;

namespace Personal_Finance_Tracker.Controllers
{
    public class TransactionController
    {
        private readonly TransactionService service;

        public TransactionController()
        {
            service = new TransactionService();
        }

        public void AddTransaction()
        {
            Console.Write("Enter Transaction Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Type (Income/Expense): ");
            string type = Console.ReadLine();

            Console.Write("Amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Category: ");
            string category = Console.ReadLine();

            service.AddTransaction(id, type, amount, category);

            Console.WriteLine("Transaction added successfully!");
        }

        public void ViewTransactions()
        {
            var transactions = service.GetTransactions();

            foreach (var t in transactions)
            {
                Console.WriteLine($"{t.Id} | {t.Type} | {t.Amount} | {t.Category} | {t.Date}");
            }
        }

        public void DeleteTransaction()
        {
            Console.Write("Enter Transaction Id to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());

            service.DeleteTransaction(id);

            Console.WriteLine("Transaction deleted.");
        }
    }
}