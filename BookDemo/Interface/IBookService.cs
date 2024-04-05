using BookDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDemo.Interface
{
    public interface IBookService
    {
        bool IsBookAvailable(int bookId);

        Book? GetBook(int bookId);

        bool AddBook(Book book);
    }
}
