

try
{
    Person person = new Person("John Doe", 30, 5000);
    Console.WriteLine(person);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
