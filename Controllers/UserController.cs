using System;
using Personal_Finance_Tracker.Services;

namespace Personal_Finance_Tracker.Controllers
{
    public class UserController
    {
        private readonly UserService service;

        public UserController()
        {
            service = new UserService();
        }

        public void CreateUser()
        {
            Console.Write("Enter User Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            service.CreateUser(id, name, email);

            Console.WriteLine("User Created Successfully!");
        }
    }
}