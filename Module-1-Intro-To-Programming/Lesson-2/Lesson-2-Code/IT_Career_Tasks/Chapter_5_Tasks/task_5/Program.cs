/*
    Да се напише програма, която чете парола (един ред с произволен текст),
    въведена от потребителя, и проверява дали въведеното съвпада с фразата
    “s3cr3t!P@ssw0rd”. При съвпадение да се изведе “Welcome”. При несъвпадение да
    се изведе “Wrong password!”.
*/

public class Program
{
    static void Main()
    {
        var pswd = Console.ReadLine();
        if (pswd == "s3cr3t!P@ssw0rd")
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
    }
}
