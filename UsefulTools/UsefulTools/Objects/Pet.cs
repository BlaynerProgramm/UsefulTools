namespace UsefulTools.Objects;

public class Pet
{
    public string Name { get; }
    public int Age { get; }
    public Person Owner { get; }

    public Pet()
    {
        Name = "Push";
        Age = 4;
        Owner = new Person();
    }

    public Pet(string name, int age, Person owner)
    {
        Name = name;
        Age = age;
        Owner = owner;
    }

    public override string ToString()
    {
        return $"Name pet - {Name}\nAge - {Age}\nOwner - {Owner}";
    }
}