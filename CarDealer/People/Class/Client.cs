using System;
using System.Collections.Generic;
using System.Text;

namespace People.Class
{
    public class Client:User
    {
        private long _number;
        public Client(long id,string name,long number)
            :base(id,name)
        {
            _number = number;
        }

        public override string Credential()
        {
            return $"{base.Credential()} y su numbero telefonico es:{_number}";
        }

        public override string Salary()
        {
            return "Es un cliente no tiene salario";
        }
    }
}
