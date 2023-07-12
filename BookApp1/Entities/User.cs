using BookApp1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp1.Entities
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Password { get; set; }
    }
}
