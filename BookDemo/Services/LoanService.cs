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
        private readonly BookService bookService;
        private List<LoanInfo> loans = new List<LoanInfo>();

        public BookLoanService(BookService service)
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
            throw new NotImplementedException();
        }

        public bool UpdateLoan(LoanInfo loan)
        {
            throw new NotImplementedException();
        }
    }
}
