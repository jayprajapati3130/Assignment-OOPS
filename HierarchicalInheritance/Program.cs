using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    class Rbi
    {
        public void credit()
        {
            Console.WriteLine("add Money in Bank Account");
        }
        public void debit()
        {
            Console.WriteLine("Money paid out from Bank Account");
        }
    }
    class Icici : Rbi
    {
        public void checkBal()
        {
            Console.WriteLine("we can check balance ");
        }
    }
    class Bob : Rbi
    {
        public void creditCard()
        {
            Console.WriteLine("BOB implement credit card feature");
        }
    }
    class Hdfc : Rbi
    {
        public void netBancking()
        {
            Console.WriteLine("HDFC implement NetBanking Feature");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Icici icici = new Icici();
            icici.credit();
            icici.checkBal();

            Hdfc hdfc = new Hdfc();
            hdfc.credit();
            hdfc.netBancking();
        }
    }
}
