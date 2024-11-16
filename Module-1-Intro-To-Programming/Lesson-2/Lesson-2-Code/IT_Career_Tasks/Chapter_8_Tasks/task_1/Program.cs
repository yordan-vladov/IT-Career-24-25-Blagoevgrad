/*
Студент трябва да пропътува n километра. Той има избор измежду три вида
транспорт:
- Такси. Начална такса: 0.70 лв. Дневна тарифа: 0.79 лв. / км. Нощна
тарифа: 0.90 лв. / км.
- Автобус. Дневна / нощна тарифа: 0.09 лв. / км. Може да се използва
за разстояния минимум 20 км.
- Влак. Дневна / нощна тарифа: 0.06 лв. / км. Може да се използва за
разстояния минимум 100 км.

Напишете програма, която чете броя километри n и период от деня (ден или
нощ), въведени от потребителя, и изчислява цената на най-евтиния
транспорт.
*/

public class Program
{
    static void Main()
    {
        var distance = int.Parse(Console.ReadLine());
        var time_of_day = Console.ReadLine();

        if (distance >= 100)
        {
            Console.WriteLine($"{distance * 0.06:f2}");
        }
        else if (distance >= 20)
        {
            Console.WriteLine($"{distance * 0.09:f2}");
        }
        else if (time_of_day == "day")
        {
            Console.WriteLine($"{0.70 + distance * 0.79:f2}");
        }
        else
        {
            Console.WriteLine($"{0.70 + distance * 0.90:f2}");
        }
    }
}
