/* 
Console.WriteLine(DivideNumber(10, 20));
decimal DevideNumber(decimal num1, decimal num2)
{
    decimal answer = 0;
   try
    {
        answer = num1 / num2;
    }
    catch (Exception e)
    {
        Console.WriteLine($"The divisor cannot be zero. {e.Message}");
    }
    return answer;
}
*/

using ExceptionHandling.Models;

var sahasra = new Employee();
sahasra.Name = "Sahasra Kesara";
sahasra.Email = "sahasrakesara@gmail.com";
sahasra.BasicSalary = 1000000;
sahasra.LoanInstallAmount = 25000;

decimal netSalary = sahasra.BasicSalary;

try
{
    sahasra.CalculateNetSalary();
}
catch (LoanGreaterThanBasicException ex)
{
    Console.WriteLine($"Error calculating net salary: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Something went wrong. {ex.message}");
}

Console.WriteLine($"Net salary for {sahasra.Name} is {netSalary}");