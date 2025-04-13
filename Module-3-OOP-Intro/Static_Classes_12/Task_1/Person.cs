public class Person
{
    private static int count = 0;
    private string name;
    private int age;
    private double salary;

    public Person(string name, int age, double salary)
    {
        Person.count += 1;
        this.Name = name;
        this.age = age;
        this.salary = salary;
    }

    public static int Count
    {
        get => count;
    }

    public string Name
    {
        get => this.name;
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Name is too short");
            }
            this.name = value;
        }
    }

    public int Age
    {
        get => this.age;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Age cannot be negative");
            }
            this.age = value;
        }
    }

    public double Salary
    {
        get => this.salary;
        set
        {
            if (value < 460)
            {
                throw new ArgumentException("Salary cannot be less than the minimum wage");
            }
            this.salary = value;
        }
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
