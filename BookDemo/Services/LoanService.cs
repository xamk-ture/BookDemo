using BookDemo.Interface;
using BookDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDemo.Services
{
    internal class BookLoanService : Interface.ILoanService
    {
        private readonly IBookService bookService;
        private List<LoanInfo> loans = new List<LoanInfo>();

        public BookLoanService(IBookService service)
        {
            bookService = service;
        }

        public bool Loan(LoanInfo loan)
        {
            if (bookService.IsBookAvailable(loan.BookId) == false)
                return false;

            loans.Add(loan);

            return true;
        }

        public bool ReturnLoan(int loanId)
        {
            var loan = loans.FirstOrDefault(l => l.Id == loanId);

            if(loan == null)
            {
                return false;
            }

            var book = bookService.GetBook(loan.BookId);
            loan.ReturnDate = DateTime.Now;

            book.AvailableCopies++;


            return true;
        }

        public bool UpdateLoan(LoanInfo loan)
        {
            throw new NotImplementedException();
        }
    }
}
