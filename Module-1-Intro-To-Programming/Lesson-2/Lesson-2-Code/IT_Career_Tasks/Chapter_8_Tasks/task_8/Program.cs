/*
Когато пуснали билетите за Евро 2016, група запалянковци решили да си
закупят. Билетите имат две категории с различни цени:

- VIP – 499.99 лева.
- Normal – 249.99 лева.

Запалянковците имат определен бюджет, a броят на хората в групата
определя какъв процент от бюджета трябва да се задели за транспорт:

- От 1 до 4 – 75% от бюджета.
- От 5 до 9 – 60% от бюджета.
- От 10 до 24 – 50% от бюджета.
- От 25 до 49 – 40% от бюджета.
- 50 или повече – 25% от бюджета.

Напишете програма, която да пресмята дали с останалите пари от бюджета
могат да си купят билети за избраната категория. И колко пари ще им
останат или ще са им нужни.
*/

public class Program
{
    static void Main()
    {
        var budget = double.Parse(Console.ReadLine());
        var category = Console.ReadLine();
        var people = int.Parse(Console.ReadLine());

        var transport_cost = 0.0;

        if (people <= 4)
            transport_cost = budget * 0.75;
        else if (people <= 9)
            transport_cost = budget * 0.75;
        else if (people <= 24)
            transport_cost = budget * 0.5;
        else if (people <= 49)
            transport_cost = budget * 0.4;
        else transport_cost = budget * 0.25;

        var ticket_cost = 0.0;

        if (category == "Normal")
            ticket_cost = people * 249.99;
        else if (category == "VIP")
            ticket_cost = people * 499.99;

        var total_cost = ticket_cost + transport_cost;

        if (total_cost > budget)
        {
            var diff = total_cost - budget;
            Console.WriteLine($"Not enough! You need {diff:f2} leva.");
        }
        else
        {
            var diff = budget - total_cost;
            Console.WriteLine($"Yes! You have {diff:f2} leva left.");
        }
    }
}
