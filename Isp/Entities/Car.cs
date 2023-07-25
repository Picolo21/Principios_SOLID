using Isp.Contracts;

namespace Isp.Entities
{
    public class Car : IVehicle
    {
        public Car(string color, int year, double engine, int seats, int doors)
        {
            ConfigureCar(color, year, engine, seats, doors);
        }

        private string _color;
        private int _year;
        private double _engine;
        private int _seats;
        private int _doors;

        public void ConfigureCar(string color, int year, double engine, int seats, int doors)
        {
            _color = color;
            _year = year;
            _engine = engine;
            _seats = seats;
            _doors = doors;

            Console.WriteLine($"Criando um carro ano {_year}, motor {_engine} da cor {_color}.");
            StartVehicle();
        }

        public void ConfigureMotorcycle(string color, int year, double engine)
        {
            
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores.");
        }
    }
}
