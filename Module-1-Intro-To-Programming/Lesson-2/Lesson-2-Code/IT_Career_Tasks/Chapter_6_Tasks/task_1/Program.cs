/*
    Да се напише програма, която чете цяло число в диапазона [1…9], въведено от
    потребителя, и го изписва с думи на английски език. Ако числото е извън
    диапазона, изписва “number too big”. Примери:
*/

public class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        if (num <= 0)
        {
            Console.WriteLine("number too small");
        }
        else if (num == 1)
        {
            Console.WriteLine("one");
        }
        else if (num == 2)
        {
            Console.WriteLine("two");
        }
        else if (num == 3)
        {
            Console.WriteLine("three");
        }
        else if (num == 4)
        {
            Console.WriteLine("four");
        }
        else if (num == 5)
        {
            Console.WriteLine("five");
        }
        else if (num == 6)
        {
            Console.WriteLine("six");
        }
        else if (num == 7)
        {
            Console.WriteLine("seven");
        }
        else if (num == 8)
        {
            Console.WriteLine("eight");
        }
        else if (num == 9)
        {
            Console.WriteLine("nine");
        }
        else
        {
            Console.WriteLine("number too big");
        }
    }
}
