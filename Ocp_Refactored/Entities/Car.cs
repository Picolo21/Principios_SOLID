namespace Ocp_Refactored.Entities
{
    public class Car : Vehicle
    {
        public Car(string color, int year, double engine, int seats, int doors) : base(color, year, engine)
        {
            _seats = seats;
            _doors = doors;

            ConfigureCar();
        }

        private int _seats;
        private int _doors;

        public void ConfigureCar()
        {
            Console.WriteLine($"Criando um carro {_color}, {_year}, {_engine}, {_doors} portas e {_seats} assentos");
            StartVehicle();
        }
    }
}
