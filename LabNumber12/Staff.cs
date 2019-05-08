using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber12
{
    class Staff : Person
    {
        private string school;
        private double pay;

        private string School
        {
            get
            {
                return school;
            }
            set
            {
                school = value;
            }
        }

        private double Pay
        {
            get
            {
                return pay;
            }
            set
            {
                pay = value;
            }
        }

        public Staff(): base() { }

        public Staff(string name, string address, string school, double pay):base(name, address)
        {
            this.school = school;
            this.pay = pay;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nSchool: {school}\nPay: {pay: 0.00}";
        }
    }
}
