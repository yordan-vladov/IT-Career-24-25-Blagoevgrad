

var text = Console.ReadLine();
var numbers = new SortedDictionary<string, string>();
while (!text.Equals("END"))
{
    var words = text.Split(' ');
    var command = words[0];

    if (command.Equals("A"))
    {
        var contactName = words[1];
        var contactNumber = words[2];
        numbers[contactName] = contactNumber;
    }
    else if (command.Equals("S"))
    {
        var contactName = words[1];

        if (numbers.ContainsKey(contactName))
        {
            Console.WriteLine($"{contactName} -> {numbers[contactName]}");
            numbers.Remove(contactName);
        }
        else
        {
            Console.WriteLine($"Contact {contactName} does not exist.");
        }
    }
    else if (command.Equals("ListAll"))
    {
        foreach (var number in numbers)
        {
            Console.WriteLine($"{number.Key} -> {number.Value}");
        }
    }


    text = Console.ReadLine();
}
