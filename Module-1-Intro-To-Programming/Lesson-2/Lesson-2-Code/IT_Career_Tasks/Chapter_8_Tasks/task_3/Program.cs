/*
Втора задача от изпитa на 24 април 2016.
Котката Том обича по цял ден да спи, за негово съжаление стопанинът му си
играе с него винаги когато има свободно време. За да се наспи добре, нормата
за игра на Том е 30 000 минути в година. Времето за игра на Том зависи от
почивните дни на стопанина му:

- Когато е на работа, стопанинът му си играе с него по 63 минути на ден.
- Когато почива, стопанинът му си играе с него по 127 минути на ден.

Напишете програма, която чете броя почивни дни, въведени от потребителя,
и отпечатва дали Том може да се наспи добре и колко е разликата от нормата
за текущата година, като приемем че годината има 365 дни.
Пример: 20 почивни дни -> работните дни са 345 (365 – 20 = 245). Реалното време
за игра е 24 275 минути (345 * 63 + 20 *127). Разликата от нормата е 5 725 минути
(30 000 – 24 275 = 5 725) или 95 часа и 25 минути.
*/

public class Program
{
    static void Main()
    {
        var rest_days = int.Parse(Console.ReadLine());

        var play_minutes_rest_days = rest_days * 127;
        var play_minutes_work_days = (365 - rest_days) * 63;

        var play_minutes = play_minutes_rest_days + play_minutes_work_days;
        var max_play_minutes = 30_000;

        if (play_minutes > max_play_minutes)
        {
            Console.WriteLine("Tom will run away");
            var diff = play_minutes - max_play_minutes;

            Console.WriteLine($"{diff / 60} hours and {diff % 60} minutes more for play");
        }
        else
        {
            Console.WriteLine("Tom sleeps well");
            var diff = max_play_minutes - play_minutes;

            Console.WriteLine($"{diff / 60} hours and {diff % 60} minutes more for play");
        }
    }
}
