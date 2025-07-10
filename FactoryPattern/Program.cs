using System;
namespace FactoryPattern
{
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("How many tires does your vehicle have?");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int tireCount))
                {
                    IVehicle vehicle = VehicleFactory.GetVehicle(tireCount);
                    vehicle?.Drive();
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }

        public interface IVehicle
        {
            void Drive();
        }

        public class Car : IVehicle
        {
            public void Drive()
            {
                Console.WriteLine("Building a new Car!");
            }
        }

        public class Motorcycle : IVehicle
        {
            public void Drive()
            {
                Console.WriteLine("Building a new Motorcycle!");
            }
        }

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

}
