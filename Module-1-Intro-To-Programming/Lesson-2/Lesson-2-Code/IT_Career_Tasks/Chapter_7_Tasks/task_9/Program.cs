/*
В една кинозала столовете са наредени в правоъгълна форма в r реда и c
колони. Има три вида прожекции с билети на различни цени:
    • Premiere – премиерна прожекция, на цена 12.00 лева.
    • Normal – стандартна прожекция, на цена 7.50 лева.
    • Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.
Напишете програма, която чете тип прожекция (стринг), брой редове и брой
колони в залата (цели числа), въведени от потребителя, и изчислява общите
приходи от билети при пълна зала. Резултатът да се отпечата във формат
като в примерите по-долу, с 2 знака след десетичната точка.
*/

public class Program
{
    static void Main()
    {
        var type = Console.ReadLine();
        var rows = int.Parse(Console.ReadLine());
        var cols = int.Parse(Console.ReadLine());
        var price = 0.0;

        if (type == "Premiere") price = 12;
        else if (type == "Normal") price = 7.5;
        else if (type == "Discount") price = 5;

        Console.WriteLine($"{rows * cols * price:f2} leva");
    }
}
