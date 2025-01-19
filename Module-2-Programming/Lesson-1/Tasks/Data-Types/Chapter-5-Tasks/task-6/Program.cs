
int loops = int.Parse(Console.ReadLine());
int loss = 0;

for (int i = 0; i < loops; i++)
{
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    loss += a % b;
}

Console.WriteLine(loss);
