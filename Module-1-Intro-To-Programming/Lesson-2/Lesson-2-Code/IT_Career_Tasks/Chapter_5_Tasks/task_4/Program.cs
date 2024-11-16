/*
    Да се напише програма, която чете две цели числа, въведени от потребителя,
    и отпечатва по-голямото от двете.
*/

public class Program
{
    static void Main()
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine(a);
        }
        else
        {
            Console.WriteLine(b);
        }
    }
}
