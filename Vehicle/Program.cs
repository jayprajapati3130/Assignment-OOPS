using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    abstract class Vehicle
    {
        public abstract void Start();
        public abstract void Stop();
        public abstract void Type();
    }
    class Bike : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("bike Start using Kick");
        }
        public override void Stop()
        {
            Console.WriteLine("bike Stop when break pressed");
        }
        public override void Type()
        {
            Console.WriteLine("Petrol type\n");
        }
    }
    class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car Start Using cell");
        }
        public override void Stop()
        {
            Console.WriteLine("Car Stop when break pressed");
        }
        public override void Type()
        {
            Console.WriteLine("Petrol & diesel type\n");
        }
    }
    class ElectricCar : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car Start Using cell and Key");
        }
        public override void Stop()
        {
            Console.WriteLine("Car Stop when break pressed");
        }
        public override void Type()
        {
            Console.WriteLine("Electric\n");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bike bike = new Bike();
            bike.Start();
            bike.Stop();
            bike.Type();

            Car car = new Car();
            car.Start();
            car.Stop();
            car.Type();

            ElectricCar electricCar = new ElectricCar();
            electricCar.Start();
            electricCar.Stop();
            electricCar.Type();
            Console.ReadLine();

        }
    }
}
