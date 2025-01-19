/*
    - Напишете програма, в която въвеждате цяло число
    - точки от контролно (0 - 100).
    Програмата връща дали оценката е:
        - "А" - 90-100
        - "B" - 80-89
        - "C" - 70-79
        - "D" - 50-69
        - "F" - 0-49
    ```bash
    Enter your score: 80
    You earned a B. Congratulations!
    Enter your score: 30
    You earned a F. Sorry!
*/
public class Program
{
    static void Main()
    {
        Console.Write("Enter your score: ");
        var score = int.Parse(Console.ReadLine());

        if (score >= 90)
        {
            Console.WriteLine("You earned an A. Pop the champagne!");
        }
        else if (score >= 80)
        {
            Console.WriteLine("You earned a B. Congratulations!");
        }
        else if (score >= 70)
        {
            Console.WriteLine("You earned a C. Decent job.");
        }
        else if (score >= 50)
        {
            Console.WriteLine("You earned a D. Try harder next time.");
        }
        else if (score >= 0)
        {
            Console.WriteLine("You earned a F. Sorry!");
        }
        else
        {
            Console.WriteLine("Invalid score.");
        }
    }
}
