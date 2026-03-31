using Personal_Finance_Tracker.Models;
using Personal_Finance_Tracker.Repositories;

namespace Personal_Finance_Tracker.Services
{
    public class UserService
    {
        private readonly UserRepository repository;

        public UserService()
        {
            repository = new UserRepository();
        }

        public void CreateUser(int id, string name, string email)
        {
            User user = new User
            {
                Id = id,
                Name = name,
                Email = email
            };

            repository.AddUser(user);
        }
    }
}