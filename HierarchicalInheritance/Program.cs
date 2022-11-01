using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    class Rbi
    {
        public void Credit()
        {
            Console.WriteLine("add Money in Bank Account");
        }
        public void Debit()
        {
            Console.WriteLine("Money paid out from Bank Account");
        }
    }
    class Icici : Rbi
    {
        public void CheckBal()
        {
            Console.WriteLine("we can check balance ");
        }
    }
    class Bob : Rbi
    {
        public void CreditCard()
        {
            Console.WriteLine("BOB implement credit card feature");
        }
    }
    class Hdfc : Rbi
    {
        public void NetBancking()
        {
            Console.WriteLine("HDFC implement NetBanking Feature");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Icici icici = new Icici();
            icici.Credit();
            icici.CheckBal();

            Hdfc hdfc = new Hdfc();
            hdfc.Credit();
            hdfc.NetBancking();
            Console.ReadLine();
        }
    }
}
