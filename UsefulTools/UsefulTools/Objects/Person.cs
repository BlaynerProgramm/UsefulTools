namespace UsefulTools.Objects;

public class Person
{
    public string Name { get; }
    public int Age { get; }

    public Person()
    {
        Name = "Kirill";
        Age = 19;
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"Name: {Name}\nAge: {Age}";
    }
}