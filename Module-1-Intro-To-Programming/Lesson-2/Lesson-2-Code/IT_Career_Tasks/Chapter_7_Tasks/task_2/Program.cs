/*
Напишете програма, която чете град (стринг), продукт (стринг) и количество
(десетично число), въведени от потребителя, и пресмята и отпечатва колко
струва съответното количество от избрания продукт в посочения град.
*/

public class Program
{
    static void Main()
    {
        var product = Console.ReadLine().ToLower();
        var town = Console.ReadLine().ToLower();
        var quantity = double.Parse(Console.ReadLine());

        if (town == "sofia")
        {
            if (product == "coffee") Console.WriteLine(0.5 * quantity);
            else if (product == "water") Console.WriteLine(0.8 * quantity);
            else if (product == "beer") Console.WriteLine(1.2 * quantity);
            else if (product == "sweets") Console.WriteLine(1.45 * quantity);
            else if (product == "peanuts") Console.WriteLine(1.60 * quantity);
        }
        else if (town == "plovdiv")
        {
            if (product == "coffee") Console.WriteLine(0.4 * quantity);
            else if (product == "water") Console.WriteLine(0.7 * quantity);
            else if (product == "beer") Console.WriteLine(1.15 * quantity);
            else if (product == "sweets") Console.WriteLine(1.3 * quantity);
            else if (product == "peanuts") Console.WriteLine(1.5 * quantity);
        }
        if (town == "varna")
        {
            if (product == "coffee") Console.WriteLine(0.45 * quantity);
            else if (product == "water") Console.WriteLine(0.7 * quantity);
            else if (product == "beer") Console.WriteLine(1.1 * quantity);
            else if (product == "sweets") Console.WriteLine(1.35 * quantity);
            else if (product == "peanuts") Console.WriteLine(1.55 * quantity);
        }
    }
}
