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
        var max = a;
        if (max < b)
        {
            max = b;
        }

        if (max < c)
        {
            max = c;
        }

        Console.WriteLine(max);
    }
}
