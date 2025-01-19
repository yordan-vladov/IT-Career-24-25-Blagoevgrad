
float distance = float.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());
int seconds = int.Parse(Console.ReadLine());

int time = hours * 3600 + minutes * 60 + seconds;

float speed_ms = distance / time;
Console.WriteLine(speed_ms);

float speed_kmh = speed_ms * 3.6F;
Console.WriteLine(speed_kmh);

float speed_mph = speed_kmh / 1.609F;
Console.WriteLine(speed_mph);
