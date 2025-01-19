public class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        var name = Console.ReadLine();

        Console.Write("Enter your age: ");
        var age = int.Parse(Console.ReadLine());

        Console.Write("Enter your location: ");
        var location = Console.ReadLine();

        Console.WriteLine($"You are {name}.");
        Console.WriteLine($"You are {age} years old.");
        Console.WriteLine($"You live in {location}.");
    }
}
