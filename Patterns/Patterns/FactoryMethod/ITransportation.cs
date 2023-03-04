using DesignPatterns.Patterns.FactoryMethod;

namespace DesignPatterns.Patterns.Transportation
{
    public interface ITransportation
    {
        string GetLicensePlate();
        decimal GetLoadCapacity();
        string GetTripInfo();
    }
}