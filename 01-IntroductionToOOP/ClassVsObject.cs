// ClassVsObject.cs

public class Dog
{
    public string Name;
}

class Program
{
    static void Main()
    {
        Dog dog1 = new Dog();
        dog1.Name = "Buddy";
        Dog dog2 = new Dog();
        dog2.Name = "Charlie";
        Console.WriteLine(dog1.Name); // Buddy
        Console.WriteLine(dog2.Name); // Charlie
    }
}