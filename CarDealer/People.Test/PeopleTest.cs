using NUnit.Framework;
using People.Class;

namespace People.Test
{
    public class PeopleTest
    {
        User a0 ;
        User a3;
        Client a1 ;
        Employee b1;
        Client a2 ;
        Employee b2 ;
        User[] t;
        [SetUp]
        public void Setup()
        {
            a0 = new Employee(0, "Brian", "nada", 10);
            a3 = new Client(0, "Brian", 7);
            a1 = new Client(1, "Brian", 76405500);
            b1 = new Employee(1, "Dante", "gerente", 150);
            a2 = new Client(2, "Vergil", 76405501);
            b2 = new Employee(2, "Brian", "empleado", 54);
            t = new User[]{ a0, a1, b1, a2, b2, a3 };
        }

        [Test]
        public void PolymorphismExample()
        {  
            Assert.AreEqual("EL salario del empleado es 5000", a0.Salary());
            Assert.AreEqual("Es un cliente no tiene salario", a3.Salary());
        }
        [Test] 
    }
}