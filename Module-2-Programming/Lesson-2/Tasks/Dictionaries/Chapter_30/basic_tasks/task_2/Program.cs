

var evenNumbers = Console.ReadLine()
.Split(' ').Select(int.Parse).Where(num => num % 2 == 0).ToArray();

var avg = evenNumbers.Average();

var oddNumbers = evenNumbers.Select(num => num <= avg ? num - 1 : num + 1).ToArray();
Console.WriteLine(String.Join(" ", oddNumbers));
