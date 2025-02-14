
var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
var k = numbers.Length / 4;

var row1Pt1 = numbers.Take(k).Reverse().ToArray();
var row1Pt2 = numbers.Reverse().Take(k).ToArray();

var row1 = row1Pt1.Concat(row1Pt2).ToArray();
var row2 = numbers.Skip(k).Take(2 * k).ToArray();

var sum = row1.Select((x, index) => x +
row2[index]);

Console.WriteLine(String.Join(' ', sum));
