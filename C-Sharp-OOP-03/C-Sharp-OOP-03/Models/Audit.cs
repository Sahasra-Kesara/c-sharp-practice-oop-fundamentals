using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OOP_03.Models;

public class Audit
{
    public DateTime Created { get; set; }
    public int CreatedById { get; set; }
    public DateTime Updated { get; set; }
    public int UpdatedById { get; set; }
}
