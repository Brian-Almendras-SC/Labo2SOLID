using System;
using System.Collections.Generic;
using System.Text;

namespace People.Class
{
    public abstract class User
    {
        private long _id;
        private string _name;

        public User(long id,string name)
        {
            _id = id;
            _name = name;
        }

        public virtual string Credential()
        {
            return $"Nombre{_name}";
        }

        public virtual string Salary() 
        {
            throw new NotImplementedException();
        }
    }
}
