using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "BMI Calculator";
        while (true)
        {
            Console.Write("Enter your weight in kilograms: ");
            string? weightText = Console.ReadLine();
            if (weightText == null)
                continue;
            float weight = float.Parse(weightText);
            Console.Write("Enter your height in meters: ");
            string? heightText = Console.ReadLine();
            if (heightText == null)
                continue;
            float height = float.Parse(heightText);
            Console.WriteLine($"Your BMI is {BMI.Calculate(weight, height)}");
        }
    }
}