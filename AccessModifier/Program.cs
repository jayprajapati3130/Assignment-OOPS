using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    class Accessmodifier
    {
        public void PublicMethod()
        {
            Console.WriteLine("This is Public method in Accessmodifier which is Access by all other class without inheritance");
        }
        private void PrivateMethod()
        {
            Console.WriteLine("this is Private method it is only Access by its own class");
        }
        protected void ProtectedMethod()
        {
            Console.WriteLine("this is Protected Method which is Access by own class and their child class");
        }
        void DefaultMethod()
        {
            Console.WriteLine("this is Default Method");
        }

       


    }
    internal class Program : Accessmodifier
    {
        static void Main(string[] args)
        {
            Accessmodifier accessmodifier = new Accessmodifier();
            Program program = new Program();
            //public method is Access by Program class 
            accessmodifier.PublicMethod();
            program.PublicMethod();

            //accessmodifier.privateMethod();  "we can not access private method in this class"
            
            //protected Method is Access by Program class using Inheritance
            program.ProtectedMethod();

            //program.defaultMethod(); "we can not access default method in this class"
            Console.ReadLine();
        }
    }
}
