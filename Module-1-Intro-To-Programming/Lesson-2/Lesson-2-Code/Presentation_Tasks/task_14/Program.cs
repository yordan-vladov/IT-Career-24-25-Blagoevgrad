/*
- Дадено число е валидно, ако е в диапазона \[100…200\] или е 0
- Напишете програма, в която потребителят въвежда число.
Програмата принтира съобщение ако числото е невалидно.
*/

public class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        var num = int.Parse(Console.ReadLine());

        var inRange = (num >= 100 && num <= 200) || num == 0;
        if (!inRange) { Console.WriteLine("invalid"); }
    }
}
