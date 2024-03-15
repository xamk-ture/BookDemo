using BookDemo.Interface;
using BookDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDemo.Services
{
    public class MovieLoanService : ILoanService
    {
        public bool Loan(LoanInfo loan)
        {
            throw new NotImplementedException();
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
