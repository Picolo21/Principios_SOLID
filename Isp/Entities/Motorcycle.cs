using Isp.Contracts;

namespace Isp.Entities
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle(string color, int year, double engine)
        {
            ConfigureMotorcycle(color, year, engine);
        }

        private string _color;
        private int _year;
        private double _engine;

        public void ConfigureCar(string color, int year, double engine, int seats, int doors)
        {
            
        }

        public void ConfigureMotorcycle(string color, int year, double engine)
        {
            _color = color;
            _year = year;
            _engine = engine;

            Console.WriteLine($"Criando uma moto ano {year}, {_engine} cilindradas e da cor {_color}.");
            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores.");
        }
    }
}
