/*
    - Напишете програма, която проверява дали едно число е положително,
    отрицателно или нула.
    ```bash
    Enter a number: 0
    The number is zero.
    Enter a number: 6
    The number is positivie.
    Enter a number: -8
    The number is negative.
    ```
*/
public class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        var num = int.Parse(Console.ReadLine());

        if (num == 0)
        {
            Console.WriteLine("The number is zero.");
        }
        else if (num > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else
        {
            Console.WriteLine("The number is negative.");
        }
    }
}
