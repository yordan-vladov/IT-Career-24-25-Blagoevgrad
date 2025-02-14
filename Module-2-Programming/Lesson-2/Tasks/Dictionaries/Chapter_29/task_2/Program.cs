
var numbers = Console.ReadLine().Split(' ').Select(int.Parse)
.OrderByDescending(n => n).Take(3).ToList();

Console.WriteLine(String.Join(' ', numbers));
