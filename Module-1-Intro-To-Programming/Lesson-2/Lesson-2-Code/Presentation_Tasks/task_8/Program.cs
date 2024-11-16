/*
    - Напишете програма, в която въвеждате цяло - възраст на човек.
    Програмата връща дали този човек е пълнолетен (>=18),
    непълнолетен (14-18) или малолетен (<=13).

    ```bash
    Enter your age: 25
    You are an adult.
    Enter your age: 16
    You are an adolescent.
    Enter your age: 12
    You are a child.
    ```
*/

public class Program
{

    static void Main()
    {
        Console.Write("Enter your age: ");
        var age = int.Parse(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("You are an adult.");
        }
        else if (age >= 14)
        {
            Console.WriteLine("You are an adolescent.");
        }
        else
        {
            Console.WriteLine("You are a child.");
        }
    }
}
