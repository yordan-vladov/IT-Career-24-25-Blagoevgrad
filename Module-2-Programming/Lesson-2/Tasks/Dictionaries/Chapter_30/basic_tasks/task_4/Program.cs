
var user = Console.ReadLine();
var userEmails = new Dictionary<string, string>();

while (user != "stop")
{
    var email = Console.ReadLine();
    userEmails[user] = email;
    user = Console.ReadLine();
}

var isUsOrUkEmail = (string email) =>
{
    var emailLower = email.ToLower();
    return emailLower.EndsWith("us") || emailLower.EndsWith("uk");
};

var results = userEmails
.Select(userEmail => $"{userEmail.Key} -> {userEmail.Value}")
.Where(email => !isUsOrUkEmail(email))
.ToArray();

Console.WriteLine(String.Join("\n", results));
