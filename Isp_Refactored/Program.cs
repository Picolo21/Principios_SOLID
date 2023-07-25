using Isp_Refactored.Entities;

public class Program
{
    private static void Main(string[] args)
    {
        Car car = new Car("Azul", 2022, 4.0, 2, 2);
        Motorcycle motorcycle = new Motorcycle("Branca", 2023, 600);

        Console.ReadKey();
    }
}