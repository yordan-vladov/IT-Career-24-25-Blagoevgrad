string metric = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());

string res_metric = "";
double res_quantity = 0.0;


if (metric == "miles")
{
    res_quantity = quantity * 1.6;
    res_metric = "kilometers";
}
else if (metric == "inches")
{
    res_quantity = quantity * 2.54;
    res_metric = "centimeters";
}
else if (metric == "feet")
{
    res_quantity = quantity * 30;
    res_metric = "centimeters";
}
else if (metric == "yards")
{
    res_quantity = quantity * 0.91;
    res_metric = "meters";
}
else if (metric == "gallons")
{
    res_quantity = quantity * 3.8;
    res_metric = "liters";
}

Console.WriteLine($@"{quantity} {metric} =
{res_quantity:f2} {res_metric}");
