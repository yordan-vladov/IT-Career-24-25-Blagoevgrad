
var users = new List<KeyValuePair<string, string>>();
var user = Console.ReadLine();

while (!user.Equals("stop"))
{
    var email = Console.ReadLine();
    var isUkorUS = email.EndsWith("us") || email.EndsWith("uk");
    if (!isUkorUS)
        users.Add(new KeyValuePair<string, string>(user, email));

    user = Console.ReadLine();
}

foreach (var usr in users)
    Console.WriteLine($"{usr.Key} -> {usr.Value}");
