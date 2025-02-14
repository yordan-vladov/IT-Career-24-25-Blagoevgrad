var input = Console.ReadLine();

var userLogs = new Dictionary<string, Dictionary<string, int>>();

while (!input.Equals("end"))
{
    var inputArgs = input.Split(' ');
    var ipAddress = inputArgs[0][3..];
    var user = inputArgs[2][5..];

    if (!userLogs.ContainsKey(user))
        userLogs[user] = new Dictionary<string, int>();

    if (!userLogs[user].ContainsKey(ipAddress))
        userLogs[user][ipAddress] = 0;

    userLogs[user][ipAddress] += 1;

    input = Console.ReadLine();
}

foreach (var userLog in userLogs)
{
    var user = userLog.Key;
    var logs = userLog.Value;

    Console.WriteLine(user);

    foreach (var log in logs)
    {
        Console.WriteLine($"{log.Key} => {log.Value}.");
    }
}
