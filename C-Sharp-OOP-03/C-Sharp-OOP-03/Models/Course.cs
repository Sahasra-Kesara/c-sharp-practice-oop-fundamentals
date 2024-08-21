using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OOP_03.Models;

public class Course : Audit
{
    public int Id { get; set; }
    public string Title { get; set; }
    public decimal Fee { get; set; }
    public string Description { get; set; }
}
