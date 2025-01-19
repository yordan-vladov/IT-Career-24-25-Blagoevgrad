int limit = int.Parse(Console.ReadLine());


for (int i = 0; i < limit; i++)
{
    char l1 = (char)('a' + i);
    for (int j = 0; j < limit; j++)
    {
        char l2 = (char)('a' + j);
        for (int k = 0; k < limit; k++)
        {
            char l3 = (char)('a' + k);
            Console.WriteLine($"{l1}{l2}{l3}");
        }
    }
}
