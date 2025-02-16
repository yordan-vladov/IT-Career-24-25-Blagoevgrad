
var message = Console.ReadLine();
var userMessages = new Dictionary<string, Dictionary<string, int>>();


while (message != "end")
{
    var messageArgs = message.Split();
    var ipAddress = messageArgs[0][3..];
    var user = messageArgs[2][5..];

    if (userMessages.ContainsKey(user))
    {
        if (userMessages[user].ContainsKey(ipAddress))
            userMessages[user][ipAddress] += 1;
        else
            userMessages[user][ipAddress] = 1;
    }
    else
    {
        userMessages[user] = new Dictionary<string, int>();
        userMessages[user][ipAddress] = 1;
    }
    message = Console.ReadLine();
}


foreach (var userMessage in userMessages)
{
    var user = userMessage.Key;
    var messages = userMessage.Value;

    var messagesStr = String.Join(", ", messages.Select(m => $"{m.Key} => {m.Value}").ToArray());
    Console.WriteLine($"{user}:");
    Console.WriteLine($"{messagesStr}.");
}
