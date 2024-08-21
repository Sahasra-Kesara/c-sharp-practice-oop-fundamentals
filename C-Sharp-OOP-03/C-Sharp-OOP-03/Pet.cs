using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OOP_03;

public class Pet
{
    public string Name { get; set; }
    public int Age { get; set; }
    public virtual void Walk()
    {
        Console.WriteLine("Pet is walking");
    }
}
