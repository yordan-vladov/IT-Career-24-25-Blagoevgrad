bool isSpecial(int num)
{
    int digits_sum = 0;

    for (int i = num; i > 0; i /= 10)
        digits_sum += i % 10;

    return digits_sum == 7 || digits_sum == 5 || digits_sum == 11;
}

int nums = int.Parse(Console.ReadLine());

for (int i = 1; i <= nums; i++)
    Console.WriteLine($"{i} -> {isSpecial(i)}");
