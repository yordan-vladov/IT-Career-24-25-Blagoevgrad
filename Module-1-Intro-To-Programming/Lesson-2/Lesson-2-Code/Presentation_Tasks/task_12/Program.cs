/*
- Напишете програма, в която потребителят въвежда цяло число.
Програмата пише дали числото е между 1 и 100 включ.
    ```bash
    Enter a number: 50
    50 is between 1 and 100.
    Enter a number: 123
    123 is not between 1 and 100.
```
*/

public class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        var number = int.Parse(Console.ReadLine());

        if (number >= 1 && number <= 100)
        {
            Console.WriteLine($"{number} is between 1 and 100.");
        }
        else
        {
            Console.WriteLine($"{number} is not between 1 and 100.");
        }
    }
}
