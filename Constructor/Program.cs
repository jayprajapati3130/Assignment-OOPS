using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Addition
    {
         public Addition()
        {
            Console.WriteLine("Enter two Number");
            int no1=Convert.ToInt32(Console.ReadLine());
            int no2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("default constructor called");
            Console.WriteLine(no1 + no2);
        }
        public Addition(int no1,int no2)
        {
            Console.WriteLine("parameterized constructor called");
            Console.WriteLine(no1 + no2);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Addition add = new Addition();
            Addition addition = new Addition(12,15);

        }
    }
}
