namespace Isp_Refactored.Contracts
{
    public interface IMotorcycle : IVehicle
    {
        void ConfigureMotorcycle(string color, int year, double engine);
    }
}
