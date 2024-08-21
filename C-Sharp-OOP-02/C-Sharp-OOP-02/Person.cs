using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OOP_02;

public class Person
{
    public string? FirstName { get; set; }
    public required string LastName { get; init; }
    public decimal BasicSalary { get; set; }
}
