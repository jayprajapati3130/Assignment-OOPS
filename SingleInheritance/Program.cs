using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritance
{
    class Employee
    {
        public void salary()
        {
            Console.WriteLine("salay = 23000");

        }
    }
    class Programmer : Employee
    {
        public void bonus()
        {
            Console.WriteLine("Bonus = 5000");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Programmer programmer = new Programmer();
            programmer.salary();
            programmer.bonus();

        }
    }
}
