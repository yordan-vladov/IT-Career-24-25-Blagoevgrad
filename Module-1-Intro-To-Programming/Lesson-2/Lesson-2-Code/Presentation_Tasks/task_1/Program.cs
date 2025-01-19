/*
    - Напишете програма, в която въвеждате цели числа "а", "b" и "c".
    Програмата ще принтира дали а + b = c
    ```bash
    Enter a: 1
    Enter b: 2
    Enter c: 3
    True
    ```
*/

public class Program
{
    static void Main()
    {
        Console.Write("Enter a: ");
        var a = int.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        var b = int.Parse(Console.ReadLine());

        Console.Write("Enter c: ");
        var c = int.Parse(Console.ReadLine());

        Console.WriteLine(a + b == c);
    }
}
