/*
Студент трябва да отиде на изпит в определен час (например в 9:30 часа). Той
идва в изпитната зала в даден час на пристигане (например 9:40). Счита се, че
студентът е дошъл навреме, ако е пристигнал в часа на изпита или до половин
час преди това. Ако е пристигнал по-рано повече от 30 минути, той е подранил.
Ако е дошъл след часа на изпита, той е закъснял. Напишете програма, която
прочита време на изпит и време на пристигане и отпечатва дали студентът
е дошъл навреме, дали е подранил или е закъснял и с колко часа или минути е
подранил или закъснял.
*/

public class Program
{
    static void Main()
    {
        var exam_hour = int.Parse(Console.ReadLine());
        var exam_minute = int.Parse(Console.ReadLine());
        var arrival_hour = int.Parse(Console.ReadLine());
        var arrival_minute = int.Parse(Console.ReadLine());

        var exam_time = exam_hour * 60 + exam_minute;
        var arrival_time = arrival_hour * 60 + arrival_minute;

        var diff = Math.Abs(arrival_time - exam_time);
        var diff_msg = "";

        if (diff >= 60)
        {
            diff_msg = $"{diff / 60}:{diff % 60:00} hours";
        }
        else
        {
            diff_msg = $"{diff} minutes";
        }


        if (arrival_time > exam_time)
        {
            Console.WriteLine("Late");
            Console.WriteLine($"{diff_msg} after the start");
        }
        else if (arrival_time == exam_time)
        {
            Console.WriteLine("On time");
        }
        else if (exam_time - arrival_time <= 30)
        {
            Console.WriteLine("On time");
            Console.WriteLine($"{diff_msg} before the start");
        }
        else
        {
            Console.WriteLine("Eearly");
            Console.WriteLine($"{diff_msg} before the start");
        }

    }
}
