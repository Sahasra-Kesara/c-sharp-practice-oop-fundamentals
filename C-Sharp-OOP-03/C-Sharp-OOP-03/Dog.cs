using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OOP_03;

public class Dog : Pet
{
    public override void Walk()
    {
        Console.WriteLine("Dog is walking");
    }
}
