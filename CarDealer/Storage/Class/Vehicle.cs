using System;
using System.Collections.Generic;
using System.Text;
using Storage.Interface;

namespace Storage.Class
{
    public class Vehicle : IDataSheet
    {
        private long _Id;
        public string Name { set; get; }
        public string Brand { set; get; }
        public long Price { set; get; }
        public string Model { set; get; }
        public Vehicle(long id, string name, string brand, long price, string model)
        {
            _Id = id;
            Name = name;
            Brand = brand;
            Price = price;
            Model = model;
        }
        public long GetId() { return _Id; }
        public void SetId(long id) { _Id = id; }

        public virtual string specification()
        {
            return $"ID: {_Id}, Nombre: {Name}, Marca: {Brand}, Precio: {Price}, Modelo: {Model}";

        }

        public virtual string Information()
        {
            return $"{Name} de la marca {Brand} en el modelo {Model} tiene un precio de {Price}";
        }
        public virtual string TypeOfVehicle()
        {
            return "Vehicle";
        }
    }
}
