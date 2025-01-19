public class Program
{
    static void Main()
    {
        Console.Write("Enter a: ");
        var a = double.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        var b = double.Parse(Console.ReadLine());

        Console.WriteLine($"a + b = {a + b}");
        Console.WriteLine($"a - b = {a - b}");
        Console.WriteLine($"a * b = {a * b}");
        Console.WriteLine($"a / b = {a / b}");
    }
}
