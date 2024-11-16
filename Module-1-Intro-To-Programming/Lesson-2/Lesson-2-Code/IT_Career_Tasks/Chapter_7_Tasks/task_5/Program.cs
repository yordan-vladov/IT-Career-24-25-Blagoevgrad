/*
Дадено число е валидно, ако е в диапазона [100…200] или е 0. Да се напише
програма, която чете цяло число, въведено от потребителя, и печата “invalid”
ако въведеното число не е валидно.
*/

public class Program
{
    static void Main()
    {
        var num = int.Parse(Console.ReadLine());
        var inRange = num == 0 || (num >= 100 && num <= 200);
        if (!inRange)
        {
            Console.WriteLine("Invalid");
        }

    }
}
