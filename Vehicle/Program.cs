using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    abstract class Vehicle
    {
        public abstract void start();
        public abstract void stop();
        public abstract void type();
    }
    class Bike : Vehicle
    {
        public override void start()
        {
            Console.WriteLine("bike Start using Kick");
        }
        public override void stop()
        {
            Console.WriteLine("bike Stop when break pressed");
        }
        public override void type()
        {
            Console.WriteLine("Petrol type\n");
        }
    }
    class Car : Vehicle
    {
        public override void start()
        {
            Console.WriteLine("Car Start Using cell");
        }
        public override void stop()
        {
            Console.WriteLine("Car Stop when break pressed");
        }
        public override void type()
        {
            Console.WriteLine("Petrol & diesel type\n");
        }
    }
    class ElectricCar : Vehicle
    {
        public override void start()
        {
            Console.WriteLine("Car Start Using cell and Key");
        }
        public override void stop()
        {
            Console.WriteLine("Car Stop when break pressed");
        }
        public override void type()
        {
            Console.WriteLine("Electric\n");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bike bike = new Bike();
            bike.start();
            bike.stop();
            bike.type();

            Car car = new Car();
            car.start();
            car.stop();
            car.type();

            ElectricCar electricCar = new ElectricCar();
            electricCar.start();
            electricCar.stop();
            electricCar.type();


        }
    }
}
