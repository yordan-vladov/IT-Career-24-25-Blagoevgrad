
var text = Console.ReadLine();

Console.WriteLine(String.Join(", ", text
    .Split(new char[] { '.', ',', ';', ':', '(', ')', '[', ']', ' ', '!', '?', '\"' })
    .Select(word => word.ToLower())
    .Distinct()
    .Where(word => word.Length > 0 && word.Length < 5)
    .OrderBy(word => word)
    .ToList()));
