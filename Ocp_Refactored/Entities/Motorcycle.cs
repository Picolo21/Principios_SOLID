namespace Ocp_Refactored.Entities
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string color, int year, double engine) : base(color, year, engine)
        {
            ConfigureMotorcycle();
        }

        public void ConfigureMotorcycle()
        {
            Console.WriteLine($"Criando uma moto {_color}, {_year} com {_engine} cilindradas");
            StartVehicle();
        }
    }
}
