using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMembers;

public class MotorCycle 
{
    public MotorCycle() //Constructor
    {
        Console.WriteLine("Constructor");
    }
    public MotorCycle(string name)
    {
        //
    }
    public string StartEngine() //Methods
    {
        return "Engine is Started";
    }
    public string AddGas(int liters) //Methods
    {
        return "Gas Added";
    }

    private void Drive() //Methods
    {
        //
    }
}
