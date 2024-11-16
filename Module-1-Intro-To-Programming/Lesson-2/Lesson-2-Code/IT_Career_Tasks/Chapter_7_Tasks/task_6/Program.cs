/*
Напишете програма, която проверява дали точка {x, y} се намира върху някоя
от страните на правоъгълник {x1, y1} – {x2, y2}. Входните данни се четат от
конзолата и се състоят от 6 реда въведени от потребителя: десетичните
числа x1, y1, x2, y2, x и y (като се гарантира, че x1 < x2 и y1 < y2). Да се отпечата
“Border” (точката лежи на някоя от страните) или “Inside / Outside” (в противен
случай).
*/

public class Program
{
    static void Main()
    {
        var x1 = double.Parse(Console.ReadLine());
        var y1 = double.Parse(Console.ReadLine());
        var x2 = double.Parse(Console.ReadLine());
        var y2 = double.Parse(Console.ReadLine());
        var x = double.Parse(Console.ReadLine());
        var y = double.Parse(Console.ReadLine());

        var x_border = (x == x1 || x == x2) && (y >= y1 && y <= y2);
        var y_border = (x >= x1 && x <= x2) && (y == y1 || y == y2);

        if (x_border || y_border)
        {
            Console.WriteLine("Border");
        }
        else
        {
            Console.WriteLine("Inside/Outside");
        }
    }
}
