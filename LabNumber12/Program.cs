using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber12
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Rich", "The Moon");
            Student s = new Student("Spongebob", "A Pineapple Under the Sea", "C# .NET", 2001, 9875.00);
            Staff st = new Staff("Jack Sparrow", "The Seven Seas", "BOOTcamp", 1000000.00);

            Console.WriteLine(p.ToString());
            Console.WriteLine();
            Console.WriteLine(s.ToString());
            Console.WriteLine();
            Console.WriteLine(st.ToString());
        }
    }
}
