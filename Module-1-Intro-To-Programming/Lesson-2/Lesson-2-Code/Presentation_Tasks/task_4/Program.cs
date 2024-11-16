/*
    - Напишете програма, в която въвеждате текстов низ.
    Програмата ще принтира съобщение ако този текстов низ е празен.
*/

public class Program
{

    static void Main()
    {
        Console.Write("Enter a string: ");
        var msg = Console.ReadLine();

        if (msg == "")
        {
            Console.WriteLine("The string is empty.");
        }
    }
}
