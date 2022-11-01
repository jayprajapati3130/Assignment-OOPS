using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    class Calculator
    {
        public void Add()
        {
            Console.WriteLine("implement Add Function");
        }
        public void Sub()
        {
            Console.WriteLine("implement Sub Function");

        }
    }
    class AdvanceCal : Calculator
    {
        public void Area()
        {
            Console.WriteLine("implement Area Function");

        }
    }
    class ScientificCal : AdvanceCal
    {
        public void Sin()
        {
            Console.WriteLine("implement Sin Function");
        }
        public void Cos()
        {
            Console.WriteLine("implement Cos Function");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ScientificCal cal = new ScientificCal();
            cal.Add();
            cal.Sub();
            cal.Area();
            cal.Cos();
            cal.Sin();
            Console.ReadLine();
        }
    }
}
