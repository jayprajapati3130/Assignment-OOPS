using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruits
{   
    interface IFruit
    {
        void Name();
        void Color();    
    }
    class Mango : IFruit
    {
        public void Name()
        {
            Console.WriteLine("Mango");
        }
        public void Color()
        {
            Console.WriteLine("and the color is Yellow");
        }
    }
    class Apple : IFruit
    {
        public void Name()
        {
            Console.WriteLine("Apple");
        }
        public void Color()
        {
            Console.WriteLine("and the color is Red");
        }
    }
    class Grapes : IFruit
    {
        public void Name()
        {
            Console.WriteLine("Grapes");
        }
        public void Color()
        {
            Console.WriteLine("and the color is Green");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mango mango = new Mango();
            mango.Name();
            mango.Color();

            Apple apple = new Apple();
            apple.Name();
            apple.Color();

            Grapes grapes = new Grapes();
            grapes.Name();
            grapes.Color();

            Console.ReadLine();
        }
    }
}
