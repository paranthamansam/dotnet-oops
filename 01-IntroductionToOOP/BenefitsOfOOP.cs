// BenefitsOfOOP.cs
// Shows modularity and reusability

public class Calculator
{
    public int Add(int a, int b) => a + b;
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        Console.WriteLine(calc.Add(2, 3)); // Output: 5
    }
}