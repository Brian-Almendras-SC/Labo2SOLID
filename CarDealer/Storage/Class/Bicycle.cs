using System;
using System.Collections.Generic;
using System.Text;
using Storage.Interface;

namespace Storage.Class
{
    public class Bicycle:Vehicle
    {
        public int QuantityWheel;
        public int QuantityGearCase;
        public Bicycle(int QuantityGearcase,Vehicle vehicle)
            : base(vehicle.GetId(), vehicle.Name, vehicle.Brand, vehicle.Price, vehicle.Model)
        {
            QuantityWheel = 2;
            QuantityGearCase = QuantityGearcase;
        }
        public string Information()
        {
            throw new NotImplementedException();
        }

        public string specification()
        {
            return $"caja de cambio: {QuantityGearCase}, cantidad de ruedas: {QuantityWheel} , {base.Information()}";
        }
    }
}
