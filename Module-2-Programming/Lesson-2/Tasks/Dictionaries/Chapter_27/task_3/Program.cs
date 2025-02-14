

var text = Console.ReadLine();
var quantities = new Dictionary<string, int>();
while (!text.Equals("stop"))
{
    var preciousMetal = text;
    var quantity = int.Parse(Console.ReadLine());

    if (quantities.ContainsKey(preciousMetal))
        quantities[preciousMetal] += quantity;
    else 
        quantities[preciousMetal] = quantity;

    text = Console.ReadLine();
}

foreach (var quantity in quantities)
{
    Console.WriteLine($"{quantity.Key} -> {quantity.Value}");
}