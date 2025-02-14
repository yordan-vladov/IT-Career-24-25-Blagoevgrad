var input = Console.ReadLine();

var numbers = input.Split(' ');

var counts = new SortedDictionary<double, int>();

foreach (var number in numbers)
{
    var numberDouble = double.Parse(number);
    if (counts.ContainsKey(numberDouble))
        counts[numberDouble] += 1;
    else
        counts[numberDouble] = 1;
}

foreach (var count in counts)
{
    Console.WriteLine($"{count.Key} -> {count.Value}");
}
