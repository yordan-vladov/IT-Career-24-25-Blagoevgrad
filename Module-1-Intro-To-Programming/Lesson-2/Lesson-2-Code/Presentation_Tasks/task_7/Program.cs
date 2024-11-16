/*
    - Напишете програма, в която въвеждате цяло - възраст на човек.
    Програмата връща дали този човек е пълнолетен или непълнолетен.

    ```bash
    Enter your age: 25
    You are an adult.
    Enter your age: 15
    You are an adolescent.
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
        else
        {
            Console.WriteLine("You are an adolescent.");
        }
    }
}
