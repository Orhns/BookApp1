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
        IUserCheckService _userCheckService;
        public UserManager(IUserCheckService userCheckService)
        {
            _userCheckService = userCheckService;
        }

        List<User> _users = new List<User>();
        public void Add(User user)
        {
            if (_userCheckService.CheckIfRealPerson(user))
            {
                _users.Add(user);
                Console.WriteLine("User added (" + user.FirstName + ")");
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
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
