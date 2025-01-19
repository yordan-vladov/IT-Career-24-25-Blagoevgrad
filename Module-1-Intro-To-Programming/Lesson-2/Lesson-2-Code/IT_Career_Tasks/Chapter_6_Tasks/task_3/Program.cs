/*
Трима спортни състезатели финишират за някакъв брой секунди (между 1 и 50).
Да се напише програма, която чете времената на състезателите, въведени от
потребителя, и пресмята сумарното им време във формат "минути:секунди".
Секундите да се изведат с водеща нула (2 → "02", 7 → "07", 35 → "35"). Примери:
*/

public class Program
{
    static void Main()
    {
        var s_1 = int.Parse(Console.ReadLine());
        var s_2 = int.Parse(Console.ReadLine());
        var s_3 = int.Parse(Console.ReadLine());

        int sum = s_1 + s_2 + s_3;

        int minutes = sum / 60;
        int seconds = sum % 60;

        Console.WriteLine($"{minutes}:{seconds:00}");
    }
}
