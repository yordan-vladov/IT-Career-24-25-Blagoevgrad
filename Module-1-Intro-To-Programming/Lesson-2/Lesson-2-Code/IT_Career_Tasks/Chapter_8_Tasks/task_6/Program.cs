/*
Странно, но повечето хора си плануват от рано почивката. Млад програмист
разполага с определен бюджет и свободно време в даден сезон. Напишете
програма, която да приема на входа бюджета и сезона, а на изхода да изкарва,
къде ще почива програмиста и колко ще похарчи.
Бюджета определя дестинацията, а сезона определя колко от бюджета ще
изхарчи. Ако е лято ще почива на къмпинг, а зимата в хотел. Ако е в Европа,
независимо от сезона ще почива в хотел. Всеки къмпинг или хотел, според
дестинацията, има собствена цена която отговаря на даден процент от
бюджета:
• При 100лв. или по-малко – някъде в България
    o Лято – 30% от бюджета
    o Зима – 70% от бюджета
• При 1000лв. или по малко – някъде на Балканите
    o Лято – 40% от бюджета
    o Зима – 80% от бюджета
• При повече от 1000лв. – някъде из Европа
    o При пътуване из Европа, независимо от сезона ще похарчи 90% от бюджета.
*/

public class Program
{
    static void Main()
    {
        var budget = double.Parse(Console.ReadLine());
        var season = Console.ReadLine();

        if (budget <= 100)
        {
            Console.WriteLine("Somewhere in Bulgaria.");
            if (season == "summer")
                Console.WriteLine($"Camp - {budget * 0.3:f2}");
            else
                Console.WriteLine($"Hotel - {budget * 0.7:f2}");
        }
        else if (budget <= 1000)
        {
            Console.WriteLine("Somewhere in Balkans.");
            if (season == "summer")
                Console.WriteLine($"Camp - {budget * 0.4:f2}");
            else
                Console.WriteLine($"Hotel - {budget * 0.8:f2}");

        }
        else
        {
            Console.WriteLine("Somewhere in Europe.");
            Console.WriteLine($"Hotel - {budget * 0.9:f2}");
        }
    }
}
