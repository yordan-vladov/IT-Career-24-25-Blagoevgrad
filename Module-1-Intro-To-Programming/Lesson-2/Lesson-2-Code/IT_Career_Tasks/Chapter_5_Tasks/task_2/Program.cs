/*
    Следващата задача от тази тема е да се напише конзолна програма, която
    чете оценка (десетично число), въведена от потребителя, и отпечатва
    “Excellent!”, ако оценката е 5.50 или по-висока, или “Not excellent.” в противен
    случай.
*/

public class Program
{
    static void Main()
    {
        var grade = double.Parse(Console.ReadLine());

        if (grade >= 5.5)
        {
            Console.WriteLine("Excellent.");
        }
        else
        {
            Console.WriteLine("Not excellent.");
        }
    }
}
