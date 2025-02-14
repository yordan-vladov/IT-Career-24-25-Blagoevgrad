
var text = Console.ReadLine();
var numbers = new Dictionary<string, string>();
while (!text.Equals("END"))
{
    var words = text.Split(' ');
    var command = words[0];
    var contactName = words[1];

    if (command.Equals("A"))
    {
        var contactNumber = words[2];
        numbers[contactName] = contactNumber;
    }
    else if (command.Equals("S"))
    {
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

    text = Console.ReadLine();
}