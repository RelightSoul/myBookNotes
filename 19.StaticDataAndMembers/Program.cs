using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.StaticDataAndMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Static Data *****");

            SavingsAccount s1 = new SavingsAccount(50);
            Console.WriteLine("Interest Rate: {0}", SavingsAccount.currInterestRate);
            SavingsAccount.SetNewRate(0.08);
            SavingsAccount s2 = new SavingsAccount(100);
            SavingsAccount.InterestRate = 0.11;
            Console.WriteLine("Interest Rate: {0}", SavingsAccount.currInterestRate);
           
            Console.ReadLine();
        }
    }
}
