using Ocp_Refactored.Entities;
using Ocp_Refactored.Enums;

public class Program
{
    private static void Main(string[] args)
    {
        TypeVehicle type = TypeVehicle.MOTORCYCLE;

        if (type is TypeVehicle.CAR)
        {
            Car car = new Car("Azul", 2022, 2.0, 5, 4);
        }
        else
        {
            Motorcycle motorcycle = new Motorcycle("Branca", 2023, 250);
        }

        Console.ReadKey();
    }
}