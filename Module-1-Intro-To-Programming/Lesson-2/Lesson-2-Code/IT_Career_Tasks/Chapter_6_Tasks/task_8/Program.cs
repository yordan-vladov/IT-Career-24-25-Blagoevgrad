/*
Да се напише програма, която превръща число [0…100] в текст.
*/

public class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        var result = "";

        if (number == 100)
        {
            result = "one hundred";
        }


        // For numbers 1 to 19
        if (number < 20)
        {
            if (number == 1) result = "one";
            else if (number == 2) result = "two";
            else if (number == 3) result = "three";
            else if (number == 4) result = "four";
            else if (number == 5) result = "five";
            else if (number == 6) result = "six";
            else if (number == 7) result = "seven";
            else if (number == 8) result = "eight";
            else if (number == 9) result = "nine";
            else if (number == 10) result = "ten";
            else if (number == 11) result = "eleven";
            else if (number == 12) result = "twelve";
            else if (number == 13) result = "thirteen";
            else if (number == 14) result = "fourteen";
            else if (number == 15) result = "fifteen";
            else if (number == 16) result = "sixteen";
            else if (number == 17) result = "seventeen";
            else if (number == 18) result = "eighteen";
            else if (number == 19) result = "nineteen";
        }
        else
        {
            // For tens (20, 30, ..., 90)
            int tens = number / 10;
            int unit = number % 10;

            if (tens == 2) result = "twenty";
            else if (tens == 3) result = "thirty";
            else if (tens == 4) result = "forty";
            else if (tens == 5) result = "fifty";
            else if (tens == 6) result = "sixty";
            else if (tens == 7) result = "seventy";
            else if (tens == 8) result = "eighty";
            else if (tens == 9) result = "ninety";

            // For numbers like 21, 22, ..., 99
            if (unit > 0)
            {
                result += "-";

                if (unit == 1) result += "one";
                else if (unit == 2) result += "two";
                else if (unit == 3) result += "three";
                else if (unit == 4) result += "four";
                else if (unit == 5) result += "five";
                else if (unit == 6) result += "six";
                else if (unit == 7) result += "seven";
                else if (unit == 8) result += "eight";
                else if (unit == 9) result += "nine";
            }
        }

        Console.WriteLine(result);
    }
}
