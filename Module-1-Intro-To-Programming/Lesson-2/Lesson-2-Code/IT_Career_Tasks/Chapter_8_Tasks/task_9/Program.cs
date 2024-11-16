/*
Хотел предлага 2 вида стаи: студио и апартамент. Напишете програма, която
изчислява цената за целия престой за студио и апартамент.
*/

public class Program
{
    static void Main()
    {
        var month = Console.ReadLine();
        var days = int.Parse(Console.ReadLine());
        var studio_price = 0.0;
        var apartment_price = 0.0;

        if (month == "May" || month == "October")
        {
            studio_price = days * 50.0;
            apartment_price = days * 65.0;

            if (days > 14)
            {
                studio_price *= 0.7;
                apartment_price *= 0.9;
            }
            else if (days > 7)
            {
                studio_price *= 0.95;
            }
        }
        else if (month == "June" || month == "September")
        {
            studio_price = days * 75.2;
            apartment_price = days * 68.7;

            if (days > 14)
            {
                studio_price *= 0.8;
                apartment_price *= 0.9;
            }
        }
        else if (month == "July" || month == "August")
        {
            studio_price = days * 76;
            apartment_price = days * 77;

            if (days > 14)
            {
                apartument_price *= 0.9;
            }
        }

        Console.WriteLine($"Apartment: {apartment_price:f2} lv.");
        Console.WriteLine($"Studio: {studio_price:f2} lv.");
    }
}
