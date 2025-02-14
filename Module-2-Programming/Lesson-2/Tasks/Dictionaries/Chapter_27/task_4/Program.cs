
var quantities = new Dictionary<string, int>();
var prices = new Dictionary<string, double>();

var text = Console.ReadLine();

while(!text.Equals("stocked"))
{
    var arguments = text.Split(' ');
    var product = arguments[0];
    var price = double.Parse(arguments[1]);
    var quantity = int.Parse(arguments[2]);

    prices[product] = price;
    if (quantities.ContainsKey(product))
        quantities[product] += quantity;
    else 
        quantities[product] = quantity;
    
    text = Console.ReadLine();
}
var total = 0.0;
foreach (var item in quantities)
{
    var product = item.Key;
    var quantity = item.Value;
    var price = prices[product];
    total += quantity * price;
    Console.WriteLine($"{product}: ${price:f2} * {quantity} = ${price*quantity:f2}");
}

Console.WriteLine("------------------------------");
Console.WriteLine($"Grand Total: ${total:f2}");