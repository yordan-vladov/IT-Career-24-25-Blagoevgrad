/*
Напишете програма, която чете цяло число, въведено от потребителя, и
отпечатва ден от седмицата (на английски език), в граници [1...7] или
отпечатва “Error” в случай, че въведеното число е невалидно.
*/

public class Program
{
    static void Main()
    {
        var day = int.Parse(Console.ReadLine());
        if (day < 1 || day > 7)
            Console.WriteLine("Error");
        else if (day == 1)
            Console.WriteLine("Monday");
        else if (day == 2)
            Console.WriteLine("Tuesday");
        else if (day == 3)
            Console.WriteLine("Wednesday");
        else if (day == 4)
            Console.WriteLine("Thursday");
        else if (day == 5)
            Console.WriteLine("Friday");
        else if (day == 6)
            Console.WriteLine("Saturday");
        else if (day == 7)
            Console.WriteLine("Sunday");
    }
}
