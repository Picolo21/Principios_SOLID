namespace Ocp_Refactored.Entities
{
    public class Vehicle
    {
        public Vehicle(string color, int year, double engine)
        {
            _color = color;
            _year = year;
            _engine = engine;
        }

        protected string _color;
        protected int _year;
        protected double _engine;

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores!");
        }
    }
}
