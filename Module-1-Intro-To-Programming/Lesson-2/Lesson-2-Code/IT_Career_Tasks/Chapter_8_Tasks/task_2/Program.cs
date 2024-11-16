/*
Басейн с обем V има две тръби от които се пълни. Всяка тръба има определен
дебит (литрите вода минаващи през една тръба за един час). Работникът
пуска тръбите едновременно и излиза за N часа. Напишете програма, която
изкарва състоянието на басейна, в момента, когато работникът се върне.
*/

public class Program
{
    static void Main()
    {
        int volume = int.Parse(Console.ReadLine());
        double p1 = int.Parse(Console.ReadLine());
        double p2 = int.Parse(Console.ReadLine());
        double hours = double.Parse(Console.ReadLine());

        var p1_fill = p1 * hours;
        var p2_fill = p2 * hours;

        var total_fill = p1_fill + p2_fill;

        if (total_fill > volume)
        {
            Console.WriteLine($"For {hours} hours overflows with {total_fill - volume} liters.");
        }
        else
        {
            var total_percent = total_fill / volume * 100;
            var p1_percent = p1_fill / total_fill * 100;
            var p2_percent = p2_fill / total_fill * 100;

            Console.WriteLine($"The pool is {(int)total_percent}% full. Pipe 1: {(int)p1_percent}%. Pipe 2: {(int)p2_percent}%.");
        }
    }
}
