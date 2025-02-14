
var input = Console.ReadLine();
string[] times = input.Split(' ');
var sortedTimes = times.OrderBy(time => TimeSpan.Parse(time)).ToArray();

Console.WriteLine(string.Join(", ", sortedTimes));
