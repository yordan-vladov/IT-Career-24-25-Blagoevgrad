/*
Да се напише програма, която чете име на продукт, въведено от
потребителя, и проверява дали е плод или зеленчук.
    • Плодовете "fruit" са banana, apple, kiwi, cherry, lemon и grapes
    • Зеленчуците "vegetable" са tomato, cucumber, pepper и carrot
    • Всички останали са "unknown"
Да се изведе “fruit”, “vegetable” или “unknown” според въведения продукт.
*/

public class Program
{
    static void Main()
    {
        var food = Console.ReadLine().ToLower();


        if (food == "banana" || food == "apple" || food == "kiwi"
        || food == "cherry" || food == "lemon" || food == "grapes")
        {
            Console.WriteLine("fruit");
        }
        else if (food == "tomato" || food == "cucumber"
       || food == "pepper" || food == "carrot")
        {
            Console.WriteLine("vegetable");
        }
        else
        {
            Console.WriteLine("unknown");
        }
    }
}
