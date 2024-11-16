/*
Да се напише програма, която чете две думи, въведени от потребителя, и
проверява дали са еднакви. Да не се прави разлика между главни и малки думи.
Да се изведе “yes” или “no”.
*/

public class Program
{
    static void Main()
    {
        var word_1 = Console.ReadLine();
        var word_2 = Console.ReadLine();

        if (word_1.ToLower() == word_2.ToLower())
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
