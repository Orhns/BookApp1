using BookApp1.Concrete;
using BookApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BOOK TRANSACTIONS
             
            var book1 = new Book(){ Id = 1 , Title = "Fi", Author = "Azra Kohen"};
            var book2 = new Book(){ Id = 2, Title = "Çi", Author = "Azra Kohen" };
            var book3 = new Book(){ Id = 3, Title = "Zorba", Author = "Kazancakis" };
            BookManager bookManager = new BookManager();
            bookManager.Add(book1);
            bookManager.Add(book2);
            bookManager.Add(book3);

            Console.WriteLine("---------------------------------------------");
            bookManager.PrintBookList();
            Console.WriteLine("/////////////////////////////////////////////");
            bookManager.Update(new Book { Id = 1, Title = "Yüzüklerin Efendisi", Author = "Tolkien" });
            Console.WriteLine("---------------------------------------------");
            bookManager.PrintBookList();
            Console.WriteLine("/////////////////////////////////////////////");
            bookManager.Delete(book2);
            Console.WriteLine("---------------------------------------------");
            bookManager.PrintBookList();
            
            //USER TRANSACTIONS
            /*   
            User user1 = new User() { Id = 1, NationalityId = "31018148286", Email = "m40agac@gmail.com", Password="1234", FirstName = "Orhun", LastName = "Kırkağaçlıoğlu", BirthDate = new DateTime(1995,4,20)};
            User user2 = new User() { Id = 2, NationalityId = "11111111111", Email = "test@gmail.com", Password = "1111", FirstName = "Sponge", LastName = "Bob", BirthDate = new DateTime(2001, 8, 3) };

            UserManager userManager = new UserManager();
            userManager.Add(user1);
            userManager.Add(user2);
            userManager.PrintUserList();
            Console.WriteLine("---------------------------------------------");
            userManager.Delete(user2);
            userManager.PrintUserList();
            */
        }
    }
}
