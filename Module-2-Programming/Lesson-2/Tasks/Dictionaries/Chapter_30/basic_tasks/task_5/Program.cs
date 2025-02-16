
var input = Console.ReadLine();
var userScores = new Dictionary<string, string[]>();

while (!input.Equals("JOKER"))
{
    var inputArgs = input.Split(": ");
    var user = inputArgs[0];
    var cards = inputArgs[1].Split(", ").Distinct().ToArray();

    if (userScores.ContainsKey(user))
        userScores[user] = userScores[user].Concat(cards).Distinct().ToArray();
    else
        userScores[user] = cards;

    input = Console.ReadLine();
}

foreach (var userScore in userScores)
{

    var GetCardScore = (string card) =>
        {
            var suit = card[^1].ToString();
            var value = card[..^1];

            var suitPower = 0;
            if (suit.Equals("S"))
                suitPower = 4;
            else if (suit.Equals("H"))
                suitPower = 3;
            else if (suit.Equals("D"))
                suitPower = 2;
            else if (suit.Equals("C"))
                suitPower = 1;

            var valuePower = 0;

            if (value == "A")
                valuePower = 14;
            else if (value == "K")
                valuePower = 13;
            else if (value == "Q")
                valuePower = 12;
            else if (value == "J")
                valuePower = 11;
            else
                valuePower = int.Parse(value);

            return suitPower * valuePower;
        };

    var cardSum = userScore.Value.Distinct().Select(GetCardScore).Sum();

    Console.WriteLine($"{userScore.Key}: {cardSum}");
}
