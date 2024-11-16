/*
Напишете програма, която чете две цели числа (N1 и N2) и оператор, с който да
се извърши дадена математическа операция с тях. Възможните операции са:
Събиране(+), Изваждане(-), Умножение(*), Деление(/) и Модулно деление(%). При
събиране, изваждане и умножение на конзолата трябва да се отпечатат
резултата и дали той е четен или нечетен. При обикновеното деление –
резултата. При модулното деление – остатъка. Трябва да се има предвид, че
делителят може да е равен на 0(нула), а на нула не се дели. В този случай трябва
да се отпечата специално съобщениe.
*/

public class Program
{
    static void Main()
    {
        var num_1 = (double)int.Parse(Console.ReadLine());
        var num_2 = (double)int.Parse(Console.ReadLine());
        var operation = Console.ReadLine();

        if (operation == "+")
        {
            var sum = num_1 + num_2;
            var type = "";
            if (sum % 2 == 0)
                type = "even";
            else type = "odd";

            Console.WriteLine($"{num_1} + {num_2} = {sum} - {type}");
        }
        else if (operation == "-")
        {
            var diff = num_1 - num_2;
            var type = "";
            if (diff % 2 == 0)
                type = "even";
            else type = "odd";

            Console.WriteLine($"{num_1} - {num_2} = {diff} - {type}");
        }
        else if (operation == "*")
        {
            var product = num_1 * num_2;
            var type = "";
            if (product % 2 == 0)
                type = "even";
            else type = "odd";

            Console.WriteLine($"{num_1} * {num_2} = {product} - {type}");
        }
        else if (num_2 == 0)
        {
            Console.WriteLine($"Cannot divide {num_1} by zero.");
        }
        else if (operation == "/")
        {
            var division = num_1 / num_2;

            Console.WriteLine($"{num_1} / {num_2} = {division}");
        }
        else if (operation == "%")
        {
            var modulo = num_1 % num_2;

            Console.WriteLine($"{num_1} % {num_2} = {modulo}");
        }
    }
}
