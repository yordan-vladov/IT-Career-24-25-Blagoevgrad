public class Person
{
    private string name;
    private int age;
    private double salary;

    public Person(string name, int age, double salary)
    {
        this.name = name;
        this.age = age;
        this.salary = salary;
    }

    public override string ToString()
    {
        return $"{this.name} gets {this.salary} leva";
    }

    public void IncreaseSalary(double percent)
    {
        if (this.age > 30)
        {
            this.salary += this.salary * percent / 100;
        }
        else
        {
            this.salary += this.salary * percent / 200;
        }
    }
}
