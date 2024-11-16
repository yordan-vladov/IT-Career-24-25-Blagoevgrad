/*
Да се напише конзолна програма, която прочита възраст (десетично число) и
пол (“m” или “f”), въведени от потребителя, и отпечатва обръщение измежду
следните:
• “Mr.” – мъж (пол “m”) на 16 или повече години
• “Master” – момче (пол “m”) под 16 години
• “Ms.” – жена (пол “f”) на 16 или повече години
• “Miss” – момиче (пол “f”) под 16 години
*/

public class Program
{
    static void Main()
    {
        var age = double.Parse(Console.ReadLine());
        var gender = Console.ReadLine();

        if (age < 16)
        {
            if (gender == "m") Console.WriteLine("Master");
            else if (gender == "f") Console.WriteLine("Miss");
        }
        else
        {
            if (gender == "m") Console.WriteLine("Mr.");
            else if (gender == "f") Console.WriteLine("Ms.");
        }
    }
}
