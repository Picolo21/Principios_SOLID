namespace Isp_Refactored.Contracts
{
    public interface ICar : IVehicle
    {
        void ConfigureCar(string color, int year, double engine, int seats, int doors);
    }
}
