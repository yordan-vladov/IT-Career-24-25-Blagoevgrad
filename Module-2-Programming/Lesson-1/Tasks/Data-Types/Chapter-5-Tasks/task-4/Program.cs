int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Before: ");
Console.WriteLine($"a = {a}");
Console.WriteLine($"b = {b}");

int temp = a;
a = b;
b = temp;

Console.WriteLine("After: ");
Console.WriteLine($"a = {a}");
Console.WriteLine($"b = {b}");

// Без междинна променлива
a = a + b;
b = a - b;
a = a - b;

Console.WriteLine("Back: ");
Console.WriteLine($"a = {a}");
Console.WriteLine($"b = {b}");
