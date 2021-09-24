using System;
using System.Collections.Generic;
using System.Text;

namespace People.Class
{
    public class Employee :User
    {
        private string _job;
        private long _salary;
        public Employee(long id, string name, string job,long salary)
            : base(id, name)
        {
            _salary = salary;
            _job = job;
        }

        public long GetSalary()
        {
            return _salary;
        }

        public override string Credential()
        {
            return $"{base.Credential()} y su cargo es:{_job}";
        }

        public override string Salary()
        {
            long AuxSalary = _salary * 500;
            return $"EL salario del empleado es {AuxSalary}";
        }
    }

}
