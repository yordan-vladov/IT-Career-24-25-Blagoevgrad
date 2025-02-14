var logs = new SortedDictionary<string, SortedDictionary<string, int>>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    var log = Console.ReadLine().Split(' ');
    var ipAddress = log[0];
    var user = log[1];
    var length = int.Parse(log[2]);

    if (!logs.ContainsKey(user))
        logs[user] = new SortedDictionary<string, int>();

    if (!logs[user].ContainsKey(ipAddress))
        logs[user][ipAddress] = length;
    else
        logs[user][ipAddress] += length;
}

foreach (var log in logs)
{
    var user = log.Key;
    var totalLength = log.Value.Values.Sum();
    var addresses = $"[{String.Join(", ", log.Value.Keys)}]";

    Console.WriteLine($"{user}: {totalLength}  {addresses}");
}
