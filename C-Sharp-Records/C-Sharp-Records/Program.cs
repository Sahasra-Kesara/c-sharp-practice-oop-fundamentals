// C# Records


var sahasra = new Person("Sahasra", "Kesara"); //Immutable record type
var kesara = new Person("Kesara", "Cooray");

var sahasraClass = new PersonClass()
{
    FirstName = "Sahasra",
    LastName = "Kesara"
};

var kesaraClass = new PersonClass()
{
    FirstName = "Kesara",
    LastName = "Cooray"
};

Console.WriteLine(sahasra == kesara);
Console.WriteLine(sahasraClass == kesaraClass);

//Console.WriteLine($"The person is {sahasra.FirstName} {sahasra.LastName}");
public record Person(string FirstName, string LastName);


public class PersonClass
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}