using BookApp1.Abstract;
using BookApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp1.Concrete
{
    public class UserManager : IUserService
    {
        List<User> _users = new List<User>();
        public void Add(User user)
        {
            _users.Add(user);
            Console.WriteLine("User added (" + user.FirstName + ")");
        }

        public void Delete(User user)
        {
            _users.Remove(user);
            Console.WriteLine("User removed (" + user.FirstName + ")");
        }

        public void Update(User user)
        {
            for (int i = 0; i < _users.Count; i++)
            {
                if (user.Id == _users[i].Id)
                {
                    _users[i].Email = user.Email;
                    _users[i].Password = user.Password;

                    Console.WriteLine("Updated; (ID: " + user.Id + ") ->" + user.FirstName + ", " + user.Password);
                }
            }
        }
        public void PrintUserList()
        {
            foreach (var user in _users)
            {
                Console.WriteLine(user.FirstName + " " + user.LastName);
            }
        }
    }
}
