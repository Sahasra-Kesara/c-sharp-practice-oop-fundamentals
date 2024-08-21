using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.Models;

public class LoanGreaterThanBasicException : Exception
{
    public LoanGreaterThanBasicException() : base("Loan installment amount cannot be greater than your basic salary")
    {

    }
}
