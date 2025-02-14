

var evenNumbers = Console.ReadLine()
.Split(' ').Select(int.Parse).Where(num => num % 2 == 0).ToArray();

var avg = evenNumbers.Average();

var changeNumber = (int num) =>
{
    if (num <= avg)
    {
        return num - 1;
    }

    return num + 1;
};

var oddNumbers = evenNumbers.Select(changeNumber).ToArray();
Console.WriteLine(String.Join(" ", oddNumbers));
