/*
- Напишете програма в която потребителят въвежда своите възраст и пол. Програмата определя титлата на потребителя:
    - Mr - Мъж, години >= 16
    - Master - Mъж, години < 16
    - Ms. - Жена, години >= 16
    - Miss - Жена, години < 16
*/

public class Program
{
    static void Main()
    {
        var age = double.Parse(Console.ReadLine());
        var gender = Console.ReadLine();
        if (gender == "f")
        {
            if (age < 16) { Console.WriteLine("Miss"); }
            else { Console.WriteLine("Ms."); }
        }
        else
        {
            if (age < 16) { Console.WriteLine("Master"); }
            else { Console.WriteLine("Mr."); }
        }
    }
}
