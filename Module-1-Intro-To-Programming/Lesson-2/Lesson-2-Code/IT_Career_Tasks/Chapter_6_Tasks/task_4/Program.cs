using System;

public class Program
{
    static void Main()
    {
        var num = decimal.Parse(Console.ReadLine());
        var source_metric = Console.ReadLine();
        var dest_metric = Console.ReadLine();

        if (source_metric == "mm")
        {
            num /= 1000m;
        }
        else if (source_metric == "cm")
        {
            num /= 100m;
        }
        else if (source_metric == "mi")
        {
            num /= 0.000621371192m;
        }
        else if (source_metric == "in")
        {
            num /= 39.3700787m;
        }
        else if (source_metric == "km")
        {
            num /= 0.001m;
        }
        else if (source_metric == "ft")
        {
            num /= 3.2808399m;
        }
        else if (source_metric == "yd")
        {
            num /= 1.0936133m;
        }

        if (dest_metric == "mm")
        {
            num *= 1000m;
        }
        else if (dest_metric == "cm")
        {
            num *= 100m;
        }
        else if (dest_metric == "mi")
        {
            num *= 0.000621371192m;
        }
        else if (dest_metric == "in")
        {
            num *= 39.3700787m;
        }
        else if (dest_metric == "km")
        {
            num *= 0.001m;
        }
        else if (dest_metric == "ft")
        {
            num *= 3.2808399m;
        }
        else if (dest_metric == "yd")
        {
            num *= 1.0936133m;
        }

        Console.WriteLine($"{num} {dest_metric}");
    }
}
