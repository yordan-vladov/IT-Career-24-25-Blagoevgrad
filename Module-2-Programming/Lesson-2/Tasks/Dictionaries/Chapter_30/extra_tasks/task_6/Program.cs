var countries = new Dictionary<string, Dictionary<string, int>>();

var input = Console.ReadLine();

while (!input.Equals("report"))
{
    var inputArgs = input.Split('|');
    var city = inputArgs[0];
    var country = inputArgs[1];
    var population = int.Parse(inputArgs[2]);

    if (!countries.ContainsKey(country))
        countries[country] = new Dictionary<string, int>();

    if (!countries[country].ContainsKey(city))
        countries[country][city] = population;
    else
        countries[country][city] += population;

    input = Console.ReadLine();
}

var sortedCountries = countries
.OrderByDescending(c => c.Value.Values.Sum())
.ToDictionary(x => x.Key, x => x.Value);

foreach (var country in sortedCountries)
{
    var cities = country.Value.OrderByDescending(city => city.Value).ToDictionary(x => x.Key, x => x.Value);
    var totalPop = cities.Values.Sum();

    Console.WriteLine($"{country.Key} (total population: {totalPop})");
    foreach (var city in country.Value)
        Console.WriteLine($"=> {city.Key}: {city.Value}");
}
