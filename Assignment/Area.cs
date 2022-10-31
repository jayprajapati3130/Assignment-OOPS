using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    abstract class Shape
    {
        public const double pi = 3.14;
        public abstract double CalArea(int side1);
    }
    class AreaCirle : Shape
    {
        public override double CalArea(int side1)
        {
            return pi*side1*side1;
        }
    }

    class AreaSquare : Shape
    {
        public override double CalArea(int side1)
        {
            return side1*side1;
        }
    }

    class AreaRectangle
    {
        public  double CalArea(int side1, int side2)
        {
            return (side1 * side2);
        }
    }
    internal class Area
    {
        public static void Main()
        {
            int choice,side1,side2;
            Console.WriteLine("press 1 for Circle");
            Console.WriteLine("press 2 for Square");
            Console.WriteLine("press 3 for Reactangle");
            choice = Convert.ToInt32(Console.ReadLine());

            if(choice == 1)
            {
                Console.WriteLine("Enter Radius:");
                side1 = Convert.ToInt32((Console.ReadLine()));
                AreaCirle cirle = new AreaCirle();
                Console.WriteLine("Area of Circle is : {0}", cirle.CalArea(side1));

            }
            if(choice == 2)
            {
                Console.WriteLine("Enter Side of Square:");
                side1 = Convert.ToInt32((Console.ReadLine()));
                AreaSquare square = new AreaSquare();
                Console.WriteLine("Area of Circle is : {0} ", square.CalArea(side1));
            }
            if(choice == 3)
            {
                Console.WriteLine("Enter the Length:");
                side1= Convert.ToInt32((Console.ReadLine()));
                Console.WriteLine("Enter the Breadth:");
                side2 = Convert.ToInt32((Console.ReadLine()));
                AreaRectangle rectangle = new AreaRectangle();
                Console.WriteLine("Area of rectangle : {0}", rectangle.CalArea(side1, side2));

            }

        }
    }
}
