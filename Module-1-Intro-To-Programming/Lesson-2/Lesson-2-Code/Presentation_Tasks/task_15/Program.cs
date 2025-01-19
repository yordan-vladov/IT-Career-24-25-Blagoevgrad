/*
    - Напишете програма, която иска потребителят да въведе число
    между 1  и 7 и връща съответният ден от седмицата.
    ```txt
    Enter the number of your day: 3
    Wednesday
```


*/
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of your day:");
        int day = int.Parse(Console.ReadLine());
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid input! Please enter a number between 1 and 7.");
                break;
        }
    }
}
