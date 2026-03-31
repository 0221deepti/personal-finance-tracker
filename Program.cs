using System;
using Personal_Finance_Tracker.Controllers;

namespace Personal_Finance_Tracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserController userController = new UserController();
            ReportController reportController = new ReportController();
            BudgetController budgetController = new BudgetController();
            TransactionController transactionController = new TransactionController();

            while (true)
            {
                Console.WriteLine("\n=== Personal Finance Tracker ===");
                Console.WriteLine("1. Create User");
                Console.WriteLine("2. Add Transaction");
                Console.WriteLine("3. View Transactions");
                Console.WriteLine("4. Delete Transaction");
                Console.WriteLine("5. Set Budget");
                Console.WriteLine("6. Monthly Report");
                Console.WriteLine("7. Exit");

                Console.Write("Select option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                

                switch (option)
                {
                    case 1:
                        userController.CreateUser();
                        break;

                    case 2:
                        transactionController.AddTransaction();
                        break;

                    case 3:
                        transactionController.ViewTransactions();
                        break;

                    case 4:
                        transactionController.DeleteTransaction();
                        break;

                    case 5:
                        budgetController.SetBudget();
                        break;

                    case 6:
                        reportController.ShowMonthlySummary();
                        break;

                    case 7:
                        return;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}