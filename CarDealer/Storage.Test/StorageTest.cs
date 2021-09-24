using Storage.Class;
using NUnit.Framework;

namespace Storage.Test
{
    public class StorageTest
    {
        private int _idCar;
        private Automobile _autoTest;
        private Vehicle _vehicleTest;
        private Vehicle _motoTest;
        private string _resultTest;
        private string _varAux;
        [SetUp]
        public void Setup()
        {
            _idCar = 0;
            _autoTest = new Automobile(6, "V8", new Vehicle(_idCar, "lykan", "W-Motors", 1000000, "Deportivo"));
            _idCar++;
            _vehicleTest = new Vehicle(2, "lykan", "W-Motors", 1000000, "Deportivo");
            _idCar++;
            _motoTest = new Automobile(6, "V8", new Vehicle(_idCar, "lykan", "W-Motors", 1000000, "Deportivo"));
        }

        [Test]
        public void SpecificationOfMotorcicle()
        {
            _resultTest = "caja de cambio: 6, tipo de motor: V8,cantidad de ruedas: 4 ,ID: 0, Nombre: lykan, Marca: W-Motors, Precio: 1000000, Modelo: Deportivo";
            _varAux = _motoTest.specification();
            Assert.AreEqual(_resultTest, _autoTest.specification());
        }
        [Test]
        public void VehicleInformation()
        {
            _resultTest = "ID: 2, Nombre: lykan, Marca: W-Motors, Precio: 1000000, Modelo: Deportivo";
            _varAux = _vehicleTest.specification();
            Assert.AreEqual(_resultTest, _varAux);
        }
        [Test]
        public void TypeVehicle()
        {
            _resultTest = "Automobile";
            _varAux = _autoTest.TypeOfVehicle();
            Assert.AreEqual(_resultTest, _varAux);
        }
    }
}