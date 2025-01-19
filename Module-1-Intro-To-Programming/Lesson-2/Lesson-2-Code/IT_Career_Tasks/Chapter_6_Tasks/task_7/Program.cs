/*
Да се напише програма, в която потребителят въвежда вида и размерите на
геометрична фигура и пресмята лицето й. Фигурите са четири вида: квадрат
(square), правоъгълник (rectangle), кръг (circle) и триъгълник (triangle). На първия
ред на входа се чете вида на фигурата (square, rectangle, circle или triangle). Ако
фигурата е квадрат, на следващия ред се чете едно число – дължина на
страната му. Ако фигурата е правоъгълник, на следващите два реда четат две
числа – дължините на страните му. Ако фигурата е кръг, на следващия ред чете
едно число – радиусът на кръга. Ако фигурата е триъгълник, на следващите два
реда четат две числа – дължината на страната му и дължината на височината
към нея. Резултатът да се закръгли до 3 цифри след десетичната точка.
*/

public class Program
{

    static void Main()
    {

        var figure = Console.ReadLine();
        var area = 0.0;
        if (figure == "square")
        {
            var side = double.Parse(Console.ReadLine());
            area = side * side;
        }
        else if (figure == "rectangle")
        {
            var side_a = double.Parse(Console.ReadLine());
            var side_b = double.Parse(Console.ReadLine());
            area = side_a * side_b;
        }
        else if (figure == "circle")
        {
            var radius = double.Parse(Console.ReadLine());
            area = radius * radius * Math.PI;
        }
        else
        {
            var side = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            area = side * height;
        }

        Console.WriteLine($"{area:f3}");
    }
}
