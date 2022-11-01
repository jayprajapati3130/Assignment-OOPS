using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        interface IPolygon
        {
            void CalculateArea(int a, int b);
        }
        interface IColor
        {
            void GetColor();
        }
        class Rectangle : IPolygon,IColor
        {
            public void CalculateArea(int a, int b)
            {
                int area = a * b;
                Console.WriteLine("Area of Rectangle: " + area);
            }
            public void GetColor()
            {

                Console.WriteLine("Red Rectangle");

            }
        }
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.CalculateArea(100, 200);
            r1.GetColor();
            Console.ReadLine();
        }
    }
}
