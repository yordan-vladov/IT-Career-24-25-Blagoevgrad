/*
    Да се напише програма, която чете 3 числа и отпечатва дали са еднакви (yes /
    no).
*/

public class Program
{
    static void Main()
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        var c = int.Parse(Console.ReadLine());
        var equals = true;

        if (a != b)
        {
            equals = false;
        }

        if (a != c)
        {
            equals = false;
        }

        if (equals)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
