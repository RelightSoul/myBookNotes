using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.StaticDataAndMembers
{
    internal class SavingsAccount
    {   
        // Данный уровня экземпляра
        public double currBalance;
        // статический элемент данных
        public static double currInterestRate;

        public SavingsAccount(double balance) => currBalance = balance;
        
        //статический конструктор. Выполняется только один раз, может быть только один на класс,
        //не принимает значения, система автоматически выполняет его при создании первого элемента
        static SavingsAccount()                       
        {
            Console.WriteLine("In static ctor");
            currInterestRate = 0.04;
        }

        public static void SetNewRate (double newRate) => currInterestRate = newRate; 
        
        public static double GetInterestRate ()
            {return currInterestRate;}
        
        public static double InterestRate
        {
            get => currInterestRate;
            set => currInterestRate = value;
        }
    }
}
