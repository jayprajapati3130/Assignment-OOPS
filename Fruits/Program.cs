using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruits
{   
    interface IFruit
    {
        void name();
        void color();    
    }
    class Mango : IFruit
    {
        public void name()
        {
            Console.WriteLine("Mango");
        }
        public void color()
        {
            Console.WriteLine("and the color is Yellow");
        }
    }
    class Apple : IFruit
    {
        public void name()
        {
            Console.WriteLine("Apple");
        }
        public void color()
        {
            Console.WriteLine("and the color is Red");
        }
    }
    class Grapes : IFruit
    {
        public void name()
        {
            Console.WriteLine("Grapes");
        }
        public void color()
        {
            Console.WriteLine("and the color is Green");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mango mango = new Mango();
            mango.name();
            mango.color();

            Apple apple = new Apple();
            apple.name();
            apple.color();

            Grapes grapes = new Grapes();
            grapes.name();
            grapes.color();


        }
    }
}
