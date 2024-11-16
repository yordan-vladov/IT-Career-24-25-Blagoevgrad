/*
    - Напишете програма, в която потребителят въвежда цяло число.
    Програмата връща съобщение ако числото е четно:
    ```bash
    Enter a number: 10
    The number is even.
    ```
*/

public class Program
{

    static void Main()
    {
        Console.Write("Enter a number: ");
        var num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("The number is even.");
        }
    }
}
