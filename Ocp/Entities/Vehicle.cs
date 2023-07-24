namespace Ocp.Entities
{
    public class Vehicle
    {
        private string _color;
        private int _year;
        private double _engine;
        private int _seats;
        private int _doors;

        public Vehicle(string color, int year, double engine, int seats, int doors)
        {
            _color = color;
            _year = year;
            _engine = engine;
            _seats = seats;
            _doors = doors;
        }

        public void Car()
        {
            Console.WriteLine($"Criando um carro {_color}, {_year}, {_engine}, {_doors} portas e {_seats} assentos");
            StartVehicle();
        }

        public void Motorcycle()
        {
            Console.WriteLine($"Criando uma moto {_color}, {_year}, {_engine} cilindradas");
            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores!");
        }
    }
}
