using BookApp1.Abstract;
using BookApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp1.Concrete
{
    internal class BookManager : IBookService
    {
        List<Book> bookList = new List<Book>();
        public void Add(Book book)
        {
            bookList.Add(book);
            Console.WriteLine("Book added." + book.Title);
        }

        public void Delete(Book book)
        {
            bookList.Remove(book);
            Console.WriteLine("Book deleted." + book.Title);
        }

        public void Update(Book book)
        {
            for (int i = 0; i < bookList.Count; i++)
            {
                if (book.Id == bookList[i].Id)
                {
                    bookList[i].Author = book.Author;
                    bookList[i].Title = book.Title;
                    bookList[i].Description = book.Description;
                    bookList[i].Publisher = book.Publisher;
                    Console.WriteLine("Book updated; (ID: " + book.Id + ") ->" + book.Title );
                }
            }
        }

        public List<Book> GetBooksList()
        {
            return bookList;
        }

        public void PrintBookList()
        {
            foreach (var book in bookList)
            {
                Console.WriteLine(book.Title + " - " + book.Author);
            }
        }
    }
}
