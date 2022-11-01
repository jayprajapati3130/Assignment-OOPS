using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritance
{
    class Employee
    {
        public void Salary()
        {
            Console.WriteLine("salay = 23000");

        }
    }
    class Programmer : Employee
    {
        public void Bonus()
        {
            Console.WriteLine("Bonus = 5000");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Programmer programmer = new Programmer();
            programmer.Salary();
            programmer.Bonus();
            Console.ReadLine();

        }
    }
}
