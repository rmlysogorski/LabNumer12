using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber12
{
    class Student : Person
    {
        private string program;
        private int year;
        private double fee;

        private string Program
        {
            get
            {
                return program;
            }
            set
            {
                program = value;
            }
        }

        private int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        
        private double Fee
        {
            get
            {
                return fee;
            }
            set
            {
                fee = value;
            }
        }

        public Student() : base() { }

        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            this.program = program;
            this.year = year;
            this.fee = fee;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nProgram: {program}\nYear: {year}\nFee: {fee: 0.00}";
        }
    }
}
