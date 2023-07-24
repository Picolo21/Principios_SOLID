using Ocp.Entities;
using Ocp.Enums;

public class Program
{
    private static void Main(string[] args)
    {
        TypeVehicle type = TypeVehicle.MOTORCYCLE;

        if (type is TypeVehicle.CAR)
        {
            Vehicle vehicle = new Vehicle("Azul", 2022, 2.0, 5, 4);
            vehicle.Car();
        }
        else
        {
            Vehicle vehicle = new Vehicle("Branca", 2023, 250, 1, 0);
            vehicle.Motorcycle();
        }

        Console.ReadKey();
    }
}