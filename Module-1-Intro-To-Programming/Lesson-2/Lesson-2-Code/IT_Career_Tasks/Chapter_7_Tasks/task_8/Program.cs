/*
Напишете програма, която отпечатва класа на животното според неговото
име, въведено от потребителя.
    • dog -> mammal
    • crocodile, tortoise, snake -> reptile
    • others -> unknown
*/

public class Program
{
    static void Main()
    {
        var animal = Console.ReadLine();

        if (animal == "dog")
            Console.WriteLine("mammal");
        else if (animal == "snake"
        || animal == "crocodile" || animal == "tortoise")
            Console.WriteLine("mammal");
        else Console.WriteLine("unknown");
    }
}
