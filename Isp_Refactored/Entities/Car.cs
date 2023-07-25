using Isp_Refactored.Contracts;
using System.Globalization;

namespace Isp_Refactored.Entities
{
    public class Car : ICar
    {
        public Car(string color, int year, double engine, int seats, int doors)
        {
            ConfigureCar(color, year, engine, seats, doors);
        }

        private string? _color;
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

            Console.WriteLine($"Criando um carro ano {_year}, motor {_engine.ToString("F1", CultureInfo.InvariantCulture)} da cor {_color}.");
            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores.");
        }
    }
}
