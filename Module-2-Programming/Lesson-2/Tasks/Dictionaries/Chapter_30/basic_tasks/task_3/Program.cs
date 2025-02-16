
var immuneSystem = int.Parse(Console.ReadLine());
var maxHealth = immuneSystem;
var viruses = new HashSet<string>();
var virus = Console.ReadLine();

while (!virus.Equals("end"))
{
    var virusPower = virus.ToCharArray().Select(ch => (int)ch).Sum() / 3;
    var virusTime = virusPower * virus.Length;
    if (viruses.Contains(virus))
        virusTime /= 3;
    else
        viruses.Add(virus);

    var minutes = virusTime / 60;
    var seconds = virusTime % 60;

    Console.WriteLine($"Virus {virus}: {virusPower} => {virusTime} seconds");

    if (virusTime >= immuneSystem)
    {
        Console.WriteLine("Immune System Defeated.");
        return;
    }
    immuneSystem -= virusTime;
    Console.WriteLine($"{virus} defeated in {minutes}m {seconds}s.");
    Console.WriteLine($"Remaining health: {immuneSystem}");

    immuneSystem = (int)(immuneSystem * 1.2);
    if (immuneSystem > maxHealth)
        immuneSystem = maxHealth;

    virus = Console.ReadLine();
}

Console.WriteLine($"Final Health: {immuneSystem}");
