/*
    - Напишете програма, в която потребителят въвежда ден от седмицата.
    Програмата връща дали този ден е работен или почивен.

    ```txt
    Enter a day of the week: saturday
    It's the weekend.
    Enter a day of the week: monday
    It's a weekday.
    ```
*/

public class Program
{
    static void Main()
    {
        Console.Write("Enter a day of the week: ");
        var day = Console.ReadLine().ToLower();

        if (day == "saturday" || day == "sunday")
        {
            Console.WriteLine("It's the weekend.");
        }
        else
        {
            Console.WriteLine("It's a weekday.");
        }
    }
}
