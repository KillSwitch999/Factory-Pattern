using System;
namespace FactoryPattern;

public class VehicleFactory
{
    public static IVehicle GetVehicle(int tireCount)
    {
        return tireCount switch
        {
            2 => new Motorcycle(),
            4 => new Car(),
            _ => null
        };
    }
}