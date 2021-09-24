using System;
using System.Collections.Generic;
using System.Text;

namespace Storage.Class
{
    public class Airplane:Vehicle
    {
        public int QuantityWheel;
        public string TypeMotor;
        public int QuantityTurbine;

        public Airplane(int Quantityturbine, string Typemotor, Vehicle vehicle)
            : base(vehicle.GetId(), vehicle.Name, vehicle.Brand, vehicle.Price, vehicle.Model)
        {
            QuantityWheel = 2;
            TypeMotor = Typemotor;
            QuantityTurbine = Quantityturbine;
        }
        public new string Information()
        {
            return $"{base.Information()}, cuenta con un motor{TypeMotor} y con {QuantityTurbine} turbinas";
        }

        public new string specification()
        {
            return $"{base.specification()}, Cantidad de turbinas: {QuantityTurbine}, tipo de motor: {TypeMotor}";
        }
    }
}
