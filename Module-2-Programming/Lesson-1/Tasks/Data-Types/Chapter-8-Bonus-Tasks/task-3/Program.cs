int max_capacity = 255;
int capacity = 0;

int fills = int.Parse(Console.ReadLine());

for (int i = 0; i < fills; i++)
{
    int litres = int.Parse(Console.ReadLine());
    if (capacity + litres > max_capacity)
        Console.WriteLine("Insufficient capacity!");
    else
        capacity += litres;
}

Console.WriteLine(capacity);
