using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintData
{
    class OverloadingDemo
    {
        public void PrintData(String name)
        {
            Console.WriteLine(name);
        }
        public void PrintData(String name1,string name2)
        {
            Console.WriteLine(name1 + name2);
        }
        public void PrintData(String name1, string name2,String email,String city)
        {
            Console.WriteLine(name1 + name2 + city + email);
        }

    }
    class PrintData
    {
        static void Main(string[] args)
        {
            String firstName, lastName,city,email;
            double number;
            Console.WriteLine("Enter Your FirstName");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter Your LastName");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter Your City");
            city = Console.ReadLine();
            Console.WriteLine("Enter Your Mobile No");
            number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Your Email");
            email = Console.ReadLine();
        
            OverloadingDemo demo = new OverloadingDemo();

            Console.WriteLine("press 1 for only name \npress 2 for Full name \npress 3 for entire Detail");
            int choice=Convert.ToInt32(Console.ReadLine());
            if(choice==1)
            {
                demo.PrintData(firstName);
            }
            if(choice==2)
            {
                demo.PrintData(firstName + " " +lastName);
            }
            if(choice==3)
            {
                demo.PrintData(firstName + " " + lastName + " "+email+ " " + city);
            }


            Console.ReadLine();
        }
    }
}
