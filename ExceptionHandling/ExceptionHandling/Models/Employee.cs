using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.Models;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public decimal BasicSalary { get; set; }
    public decimal LoanInstallAmount { get; set; }

    public decimal CalculateNetSalary()
    {
        if(this.LoanInstallAmount > this.BasicSalary)
        {
            throw new LoanGreaterThanBasicException();
        
            return this.BasicSalary - this.LoanInstallAmount;
    }
}
