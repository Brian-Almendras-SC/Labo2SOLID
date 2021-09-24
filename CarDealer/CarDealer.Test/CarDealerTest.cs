using NUnit.Framework;
using People.Class;
using Storage.Class;
using CarDealer.Class;

namespace CarDealer.Test
{
    public class CarDealerTest
    {
        private Employee EmployeeN1;
        private Client ClientN1;
        private Client ClientN2;
        private Vehicle AutomobileN1;
        private Vehicle AirplaneN1;

        private Employee[] ListEmployees;
        private Client[] ListClients;
        private Vehicle[] ListVehicles;
        private Store store ;

        [SetUp]
        public void Setup()
        {

            EmployeeN1 = new Employee(1, "Dante", "Salesman", 500);
            ClientN1 = new Client(1, "Alexios", 7000500);
            ClientN2 = new Client(2, "Romulus", 800500);
            AutomobileN1 = new Automobile(7, "V8", new Vehicle(1, "Lykan", "W-Motors", 500000, "Deportivo"));
            AirplaneN1 = new Airplane(2, "V14", new Vehicle(1, "F-18", "BestAirplanes", 10000, "Caza"));

            ListEmployees = new Employee[] { EmployeeN1 };
            ListClients =new Client[] { ClientN1, ClientN2 };
            ListVehicles = new Vehicle[]{ AutomobileN1, AirplaneN1 };
            store = new Store(ListVehicles, ListClients, ListEmployees);
        }

        [Test]
        public void AverageOfSalary()
        {
            long AuxAverage=store.AverageSalaryEmployees();
            Assert.AreEqual(500,AuxAverage);
        }
        [Test]
        public void VehiclesOnStorage()
        {
            Assert.AreEqual(2, store.TotalVehicles());
        }
        [Test]
        public void CountOfClients()
        {
            Assert.AreEqual(2, store.TotalClients());
        }
        public void CountOfEmployees()
        {
            Assert.AreEqual(1, store.TotalEmployees());
        }
    }
}