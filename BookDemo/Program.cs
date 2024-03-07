using BookDemo.Interface;
using BookDemo.Models;
using BookDemo.Services;

namespace BookDemo
{
    internal class Program
    {

        private static UserService userService = new UserService();
        private static IUserService IuserService = new UserLocalFileService();

        private static BookService bookService = new BookService();
        private static LoanService loanService = new LoanService(bookService);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            DataPopulator();

        }

        private void AddUser(IUserService userService)
        {
            var user = new User
            {
                Name = "John Doe",
                Email = "test"
            };

            userService.AddUser(user);
        }


        private static void DataPopulator()
        {
            // Create a new book
            var book = new BookDemo.Models.Book
            {
                Title = "The Hobbit",
                Author = "J.R.R. Tolkien",
                Genre = "Fantasy",
                Year = 1937,
                ISBN = "978-0-395-08254-1",
                Id = 1,
                AvailableCopies = 2
            };

            bookService.AddBook(book);

            var user = new BookDemo.Models.User
            {
                Name = "John Doe",
                Email = "test",
                Id = 1
            };

            userService.AddUser(user);

            var loan = new BookDemo.Models.LoanInfo
            {
                BookId = book.Id,
                UserId = user.Id,
                LoanDate = DateTime.Now,
                ReturnDate = DateTime.Now.AddDays(14)
            };

            loanService.LoanBook(loan);
        }
    }

  
}
