using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    class Calculator
    {
        public void add()
        {
            Console.WriteLine("implement Add Function");
        }
        public void sub()
        {
            Console.WriteLine("implement Sub Function");

        }
    }
    class AdvanceCal : Calculator
    {
        public void area()
        {
            Console.WriteLine("implement Area Function");

        }
    }
    class ScientificCal : AdvanceCal
    {
        public void sin()
        {
            Console.WriteLine("implement Sin Function");
        }
        public void cos()
        {
            Console.WriteLine("implement Cos Function");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ScientificCal cal = new ScientificCal();
            cal.add();
            cal.sub();
            cal.area();
            cal.cos();
            cal.sin();

        }
    }
}
