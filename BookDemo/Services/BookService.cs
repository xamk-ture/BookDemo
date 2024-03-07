using BookDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDemo.Services
{
    internal class BookService : Interface.IBookService
    {
        private List<Book> books = new List<Book>();

        public bool AddBook(Book book)
        {

            books.Add(book);

            return true;
        }

        public bool IsBookAvailable(int bookId)
        {
            Book book = books.FirstOrDefault(b => b.Id == bookId);

            if(book == null)
            {
                return false;
            }

            if(book.AvailableCopies == 0)
            {
                return false;
            }

            return true;
        }
    }
}
