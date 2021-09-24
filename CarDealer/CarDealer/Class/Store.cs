using People.Class;
using Storage.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealer.Class
{
    public class Store
    {
        private Vehicle[] _vehicles;
        private long _numberVehicles;
        private Client[] _clients;
        private long _numberClients;
        private Employee[] _employees;
        private long _numberEmployees;

        public Store(Vehicle[] vehicles,Client[] clients,Employee[] employees) 
        {
            _vehicles = vehicles;
            _clients = clients;
            _employees = employees;
            _numberEmployees = CountUsers(_employees);
            _numberClients = CountUsers(_clients);
            _numberVehicles = CountVehicles(_vehicles);
        }

        public long AverageSalaryEmployees() 
        {
            long SumSalaries=0;
            foreach (var item in _employees)
            {
                SumSalaries += item.GetSalary();
            }

            return SumSalaries/_numberEmployees;
        }
        public long CountUsers(User[] users) 
        {
            return users.Length;
        }
        
        public long CountVehicles(Vehicle[] vehicles) 
        {
            return vehicles.Length;
        }

        public long TotalVehicles() 
        {
            return _numberVehicles;
        }
        public long TotalClients()
        {
            return _numberClients;
        }
        public long TotalEmployees()
        {
            return _numberEmployees;
        }
    }
}
