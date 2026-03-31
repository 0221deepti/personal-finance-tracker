using System.Collections.Generic;
using Personal_Finance_Tracker.Models;

namespace Personal_Finance_Tracker.Repositories
{
    public class UserRepository
    {
        private List<User> users = new List<User>();

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public List<User> GetUsers()
        {
            return users;
        }
    }
}