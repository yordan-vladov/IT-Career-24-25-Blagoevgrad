/*
    - Напишете програма, в която въвеждате цяло число и проверявате дали това число
    е положително:
    ```bash
    Enter a number: 5
    The number is positive
    ```
*/

public class Program
{

    static void Main()
    {
        Console.Write("Enter a number: ");
        var a = int.Parse(Console.ReadLine());

        if (a > 0)
        {
            Console.WriteLine("The number is positive.");
        }
    }
}
