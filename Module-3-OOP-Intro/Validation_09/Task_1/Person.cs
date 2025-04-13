public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private double salary;

    public Person(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public Person(string firstName, string lastName, int age):this(firstName,lastName)
    {
        this.Age = age;
    }

    public Person(string firstName, string lastName, int age, double salary): this (firstName,lastName,age)
    {
        this.Salary = salary;
    }
    public string FirstName
    {
        get {
            return firstName;
        }
        set {
            if (value.Length < 3)
            {
                throw new
                ArgumentException("First name is too short.");
            }
            firstName = value;
        }
    }

    public string LastName
    {
        get {
            return lastName;
        }
        set {
             if (value.Length < 3)
            {
                throw new
                ArgumentException("Last name is too short.");
            }
            lastName = value;
        }
    }

    public int Age
    {
        get {
            return age;
        }
        set {
            if (value <= 0)
            {
                throw new
                ArgumentException("Invalid age.");
            }
            age = value;
        }
    }

    public double Salary
    {
        get{
            return salary;
        }
        set{
            if (value < 460)
            {
                throw new
                ArgumentException("Salary is below the minimum wage.");
            }
            salary = value;
        }
    }


    public override string ToString()
    {
        return $"Name: {this.firstName} {this.lastName}, Age: {this.age}";
    }

    public string Greet()
    {
        return $"Hello, I am {this.firstName} {this.lastName}.";
    }

}
