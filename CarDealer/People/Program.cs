using People.Class;
using System;

namespace People
{
    class Program
    {
        static void Main(string[] args)
        {
            User a0 = new Employee(0, "Brian", "nada",10);
            User a3 = new Client(0, "Brian", 7);
            Client a1 = new Client(1, "Brian", 76405500);
            Employee b1 = new Employee(1, "Dante", "gerente",150);
            Client a2 = new Client(2, "Vergil", 76405501);
            Employee b2 = new Employee(2, "Brian", "empleado",54);
            User[] t = { a0, a1, b1, a2, b2, a3 };
            foreach (var item in t)
            {
                Console.WriteLine(item.Salary());
            }
            foreach (var item in t)
            {
                Console.WriteLine(item.GetType());
            }
        }
    }
}
