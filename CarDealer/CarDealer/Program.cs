using CarDealer.Class;
using People.Class;
using Storage.Class;
using System;

namespace CarDealer
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee EmployeeN1 = new Employee(1, "Dante", "Salesman", 500);
            Client ClientN1 = new Client(1, "Alexios", 7000500);
            Client ClientN2= new Client(2,"Romulus",800500);
            Vehicle AutomobileN1 = new Automobile(7,"V8",new Vehicle(1, "Lykan", "W-Motors", 500000,"Deportivo"));
            Vehicle AirplaneN1 = new Airplane(2, "V14", new Vehicle(1, "F-18", "BestAirplanes", 10000, "Caza"));

            Employee[] ListEmployees = { EmployeeN1 };
            Client[] ListClients = { ClientN1, ClientN2};
            Vehicle[] ListVehicles = { AutomobileN1, AirplaneN1 };
            Store store=new Store(ListVehicles,ListClients,ListEmployees);

            Console.WriteLine(store.AverageSalaryEmployees());
            Console.WriteLine(store.TotalEmployees());
            Console.WriteLine(store.TotalClients());
            Console.WriteLine(store.TotalVehicles());

        }
    }
}
