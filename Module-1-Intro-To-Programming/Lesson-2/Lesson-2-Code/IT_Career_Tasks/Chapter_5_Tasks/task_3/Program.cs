/*
    Да се напише програма, която чете цяло число, въведено от потребителя, и
    печата дали е четно или нечетно.
*/

public class Program
{
    static void Main()
    {
        var num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("even");
        }
        else
        {
            Console.WriteLine("odd");
        }
    }
}
