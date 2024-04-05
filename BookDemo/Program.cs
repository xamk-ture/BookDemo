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
        private static BookLoanService loanService = new BookLoanService(bookService);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            DataPopulator();
        }

        /// <summary>
        /// Function that uses interfaces (abstraction). We can just use one method instead 
        /// creating a new method for each scenario (service).
        /// For example if we would like to extend our software to support loaning cars
        /// we can just use this one method instead creating new ones
        /// </summary>
        /// <param name="loanService"></param>
        /// <param name="baseObject"></param>
        private void GeneralLoaner(ILoanService loanService, BaseObject baseObject)
        {
            var loanInfo = new LoanInfo();
            loanInfo.BookId = baseObject.Id;
            loanService.Loan(loanInfo);
        }

        /// <summary>
        /// Functions that is tied straight to the BookLoanService class
        /// </summary>
        /// <param name="service"></param>
        /// <param name="book"></param>
        private void LoanerFunction(BookLoanService service, Book book)
        {
            var loanInfo = new LoanInfo();
            loanInfo.BookId = book.Id;

            service.Loan(loanInfo);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        /// <param name="movie"></param>
        public void MovieLoaner(MovieLoanService service, Movie movie)
        {
            var loanInfo = new LoanInfo();
            loanInfo.BookId = movie.Id;

            service.Loan(loanInfo);
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

            loanService.Loan(loan);
        }
    }

  
}
