using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMembers;

public class StudentService
{
    public const int Months = 12; //Constant
    public string StudentRegistrationNo { get; set; }
    /*public readonly string studentRegistrationNo = "2000";  //This is field

    public string GetStudentRegistrationNo()
    {
        return this.studentRegistrationNo;
    }
    */
}
