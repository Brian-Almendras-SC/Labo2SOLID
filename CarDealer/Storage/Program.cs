using System;
using Storage.Class;
namespace Storage
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int _IdCar=0;
            Automobile AutoTest = new Automobile(6, "V8", new Vehicle(_IdCar, "lykan", "W-Motors", 1000000, "Deportivo"));
            Vehicle VehicleTest = new Vehicle(1, "lykan", "W-Motors", 1000000, "Deportivo");
            Vehicle MotoTest = new Automobile(6, "V8", new Vehicle(_IdCar, "lykan", "W-Motors", 1000000, "Deportivo"));

            Console.WriteLine(AutoTest.specification());
            Console.WriteLine(VehicleTest.specification());
            Console.WriteLine(MotoTest.specification());
            Console.WriteLine("Hello World!");
        }
    }
}
