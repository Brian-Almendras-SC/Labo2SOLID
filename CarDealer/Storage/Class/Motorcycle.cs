using System;
using System.Collections.Generic;
using System.Text;
using Storage.Interface;

namespace Storage.Class
{
    public class Motorcycle : Vehicle, IMotor
    {
        public int QuantityWheel;
        public string TypeMotor;    
        public int QuantityGearBox;
        public Motorcycle  (int QuantityGearbox, string Typemotor, Vehicle vehicle)
            : base(vehicle.GetId(), vehicle.Name, vehicle.Brand, vehicle.Price, vehicle.Model)
        {
            QuantityWheel = 2;
            TypeMotor = Typemotor;
            QuantityGearBox = QuantityGearbox;
        }
        public override string Information()
        {
            return $"{base.Information()}, cuenta con un motor{TypeMotor} de {QuantityGearBox} velocidades";
        }

        public override string specification()
        {
            return $"caja de cambio: {QuantityGearBox}, tipo de motor: {TypeMotor},cantidad de ruedas: {QuantityWheel} , {base.Information()}";
        }

        public string AboutMotor()
        {
            return $"El tipo de motor es{TypeMotor} que cuenta con una caja de {QuantityGearBox}";
        }
    }
}
