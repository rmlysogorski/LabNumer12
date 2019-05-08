using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber12
{
    class Person
    {
        private string name;
        private string address;

        private string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private string Address {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public Person() { }

        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        
        public override string ToString()
        {
            return $"Name: {name}\nAddress: {address}";
        }
    }
}
